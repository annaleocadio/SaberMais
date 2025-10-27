using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SaberMais.Data;
using SaberMais.Models;
using System;
using System.IO;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace SaberMais.Controllers
{
    [Authorize]
    public class PerfilController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;

        public PerfilController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }

        public IActionResult Index()
        {
            var email = User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.Email)?.Value;
            if (string.IsNullOrEmpty(email))
            {
                ViewBag.Nome = "Desconhecido";
                ViewBag.Tipo = "Desconhecido";
                return View();
            }

            var administrador = _context.Administradores.FirstOrDefault(a => a.Email == email);
            var usuario = _context.Usuarios.FirstOrDefault(u => u.Email == email);

            if (administrador != null)
            {
                ViewBag.Tipo = "Administrador";
                ViewBag.Nome = administrador.Nome;
                ViewBag.IsSuperAdmin = administrador.IsSuperAdmin;
                ViewBag.Usuarios = _context.Usuarios.ToList();
                ViewBag.Cursos = _context.Cursos.ToList();

                if (administrador.IsSuperAdmin)
                    ViewBag.Administradores = _context.Administradores.ToList();
            }
            else if (usuario != null)
            {
                ViewBag.Tipo = "Usuario";
                ViewBag.Nome = usuario.NomeCompleto;
                ViewBag.Usuario = usuario;
            }

            return View();
        }

        [HttpGet]
        public IActionResult Editar()
        {
            var email = User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.Email)?.Value;
            if (string.IsNullOrEmpty(email))
                return RedirectToAction("Login", "Usuario");

            var usuario = _context.Usuarios.FirstOrDefault(u => u.Email == email);
            if (usuario == null)
                return NotFound();

            return View(usuario);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Editar(Usuario model, IFormFile Foto)
        {
            var emailLogado = User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.Email)?.Value;
            if (string.IsNullOrEmpty(emailLogado))
                return RedirectToAction("Login", "Usuario");

            var usuario = _context.Usuarios.FirstOrDefault(u => u.Email == emailLogado);
            if (usuario == null)
                return NotFound();

            usuario.NomeCompleto = model.NomeCompleto;

            if (Foto != null && Foto.Length > 0)
            {
                var allowedExt = new[] { ".jpg", ".jpeg", ".png", ".gif", ".webp" };
                var ext = Path.GetExtension(Foto.FileName).ToLowerInvariant();

                if (!allowedExt.Contains(ext))
                {
                    TempData["Erro"] = "Tipo de imagem não permitido. Utilize JPG, PNG ou GIF.";
                    return View(usuario);
                }

                if (Foto.Length > 2 * 1024 * 1024)
                {
                    TempData["Erro"] = "A imagem deve ter até 2 MB.";
                    return View(usuario);
                }

                var uploads = Path.Combine(_env.WebRootPath, "uploads");
                if (!Directory.Exists(uploads))
                    Directory.CreateDirectory(uploads);

                if (!string.IsNullOrEmpty(usuario.FotoPerfil) && usuario.FotoPerfil != "default-user.png")
                {
                    try
                    {
                        var fotoAntiga = Path.Combine(uploads, usuario.FotoPerfil);
                        if (System.IO.File.Exists(fotoAntiga))
                            System.IO.File.Delete(fotoAntiga);
                    }
                    catch { }
                }

                var fileName = Guid.NewGuid().ToString("N") + ext;
                var filePath = Path.Combine(uploads, fileName);

                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    await Foto.CopyToAsync(stream);
                }

                usuario.FotoPerfil = fileName;
            }

            try
            {
                _context.Usuarios.Update(usuario);
                await _context.SaveChangesAsync();

                TempData["Sucesso"] = "Perfil atualizado com sucesso!";
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                TempData["Erro"] = "Erro ao salvar: " + ex.Message;
                return View(usuario);
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ExcluirConta()
        {
            var emailLogado = User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.Email)?.Value;
            if (string.IsNullOrEmpty(emailLogado))
                return RedirectToAction("Login", "Usuario");

            var usuario = _context.Usuarios.FirstOrDefault(u => u.Email == emailLogado);
            if (usuario != null)
            {
                if (!string.IsNullOrEmpty(usuario.FotoPerfil))
                {
                    var uploads = Path.Combine(_env.WebRootPath, "uploads");
                    var path = Path.Combine(uploads, usuario.FotoPerfil);
                    try { if (System.IO.File.Exists(path)) System.IO.File.Delete(path); } catch { }
                }

                _context.Usuarios.Remove(usuario);
                await _context.SaveChangesAsync();
            }

            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            TempData["Sucesso"] = "Conta excluída com sucesso.";
            return RedirectToAction("Index", "Home");
        }

        [HttpPost]
        public async Task<IActionResult> ApagarUsuario(int id)
        {
            var usuario = _context.Usuarios.Find(id);
            if (usuario != null)
            {
                _context.Usuarios.Remove(usuario);
                await _context.SaveChangesAsync();
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> BloquearUsuario(int id)
        {
            var usuario = _context.Usuarios.Find(id);
            if (usuario != null)
            {
                usuario.Senha = "BLOQUEADO";
                await _context.SaveChangesAsync();
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> ApagarCurso(int id)
        {
            var curso = _context.Cursos.Find(id);
            if (curso != null)
            {
                _context.Cursos.Remove(curso);
                await _context.SaveChangesAsync();
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> CriarAdministrador(string nome, string email, string senha)
        {
            var emailLogado = User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.Email)?.Value;
            var logado = _context.Administradores.FirstOrDefault(a => a.Email == emailLogado);
            if (logado == null || !logado.IsSuperAdmin) return Unauthorized();

            if (_context.Administradores.Any(a => a.Email == email))
            {
                TempData["Erro"] = "Já existe um administrador com esse e-mail.";
                return RedirectToAction("Index");
            }

            var novo = new Administrador { Nome = nome, Email = email, Senha = senha, IsSuperAdmin = false };
            _context.Administradores.Add(novo);
            await _context.SaveChangesAsync();

            TempData["Sucesso"] = "Novo administrador criado com sucesso!";
            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> ExcluirAdministrador(int id)
        {
            var emailLogado = User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.Email)?.Value;
            var logado = _context.Administradores.FirstOrDefault(a => a.Email == emailLogado);
            if (logado == null || !logado.IsSuperAdmin) return Unauthorized();

            var admin = _context.Administradores.Find(id);
            if (admin != null && !admin.IsSuperAdmin)
            {
                _context.Administradores.Remove(admin);
                await _context.SaveChangesAsync();
            }

            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> BloquearAdministrador(int id)
        {
            var emailLogado = User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.Email)?.Value;
            var logado = _context.Administradores.FirstOrDefault(a => a.Email == emailLogado);
            if (logado == null || !logado.IsSuperAdmin) return Unauthorized();

            var admin = _context.Administradores.Find(id);
            if (admin != null && !admin.IsSuperAdmin)
            {
                admin.Senha = "BLOQUEADO";
                await _context.SaveChangesAsync();
            }

            return RedirectToAction("Index");
        }
    }
}