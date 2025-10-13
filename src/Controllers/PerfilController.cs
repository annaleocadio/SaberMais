using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SaberMais.Data;
using SaberMais.Models;
using System.Linq;
using System.Security.Claims;

namespace SaberMais.Controllers
{
    [Authorize]
    public class PerfilController : Controller
    {
        private readonly AppDbContext _context;

        public PerfilController(AppDbContext context)
        {
            _context = context;
        }

        // ============================================================
        // EXIBE O PERFIL DO USUÁRIO OU ADMINISTRADOR
        // ============================================================
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

                // Painel principal (visível a todos admins)
                ViewBag.Usuarios = _context.Usuarios.ToList();
                ViewBag.Cursos = _context.Cursos.ToList();

                // Lista de administradores (apenas pro super admin)
                if (administrador.IsSuperAdmin)
                {
                    ViewBag.Administradores = _context.Administradores.ToList();
                }
            }
            else if (usuario != null)
            {
                ViewBag.Tipo = "Usuario";
                ViewBag.Nome = usuario.NomeCompleto;
            }

            return View();
        }

        // ============================================================
        // GERENCIAMENTO DE USUÁRIOS E CURSOS (QUALQUER ADMIN)
        // ============================================================

        [HttpPost]
        public IActionResult ApagarUsuario(int id)
        {
            var usuario = _context.Usuarios.Find(id);
            if (usuario != null)
            {
                _context.Usuarios.Remove(usuario);
                _context.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult BloquearUsuario(int id)
        {
            var usuario = _context.Usuarios.Find(id);
            if (usuario != null)
            {
                usuario.Senha = "BLOQUEADO";
                _context.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult ApagarCurso(int id)
        {
            var curso = _context.Cursos.Find(id);
            if (curso != null)
            {
                _context.Cursos.Remove(curso);
                _context.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        // GET: Editar curso
        [HttpGet]
        public IActionResult EditarCurso(int id)
        {
            var curso = _context.Cursos.FirstOrDefault(c => c.Id == id);
            if (curso == null)
            {
                return NotFound();
            }

            return View(curso);
        }

        // POST: Editar curso
        [HttpPost]
        public IActionResult EditarCurso(Curso curso)
        {
            if (ModelState.IsValid)
            {
                _context.Cursos.Update(curso);
                _context.SaveChanges();
                TempData["Sucesso"] = "Curso atualizado com sucesso!";
                return RedirectToAction("Index");
            }

            return View(curso);
        }


        // ============================================================
        // GERENCIAMENTO DE ADMINISTRADORES (SOMENTE SUPER ADMIN)
        // ============================================================

        //  Cadastrar novo administrador
        [HttpPost]
        public IActionResult CriarAdministrador(string nome, string email, string senha)
        {
            var emailLogado = User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.Email)?.Value;
            var logado = _context.Administradores.FirstOrDefault(a => a.Email == emailLogado);

            // bloqueia se não for o super admin
            if (logado == null || !logado.IsSuperAdmin)
            {
                return Unauthorized();
            }

            // evita duplicados
            if (_context.Administradores.Any(a => a.Email == email))
            {
                TempData["Erro"] = "Já existe um administrador com esse e-mail.";
                return RedirectToAction("Index");
            }

            var novo = new Administrador
            {
                Nome = nome,
                Email = email,
                Senha = senha,
                IsSuperAdmin = false
            };

            _context.Administradores.Add(novo);
            _context.SaveChanges();

            TempData["Sucesso"] = "Novo administrador criado com sucesso!";
            return RedirectToAction("Index");
        }

        //  Excluir administrador (exceto o super admin)
        [HttpPost]
        public IActionResult ExcluirAdministrador(int id)
        {
            var emailLogado = User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.Email)?.Value;
            var logado = _context.Administradores.FirstOrDefault(a => a.Email == emailLogado);

            if (logado == null || !logado.IsSuperAdmin)
            {
                return Unauthorized();
            }

            var admin = _context.Administradores.Find(id);
            if (admin != null && !admin.IsSuperAdmin)
            {
                _context.Administradores.Remove(admin);
                _context.SaveChanges();
            }

            return RedirectToAction("Index");
        }

        //  Bloquear administrador (exceto o super admin)
        [HttpPost]
        public IActionResult BloquearAdministrador(int id)
        {
            var emailLogado = User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.Email)?.Value;
            var logado = _context.Administradores.FirstOrDefault(a => a.Email == emailLogado);

            if (logado == null || !logado.IsSuperAdmin)
            {
                return Unauthorized();
            }

            var admin = _context.Administradores.Find(id);
            if (admin != null && !admin.IsSuperAdmin)
            {
                admin.Senha = "BLOQUEADO";
                _context.SaveChanges();
            }

            return RedirectToAction("Index");
        }
    }
}
