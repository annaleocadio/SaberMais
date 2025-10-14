using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SaberMais.Data;
using SaberMais.Models;
using System.Linq;
using System.Security.Claims;

namespace SaberMais.Controllers
{
    public class UsuarioController : Controller
    {
        private readonly AppDbContext _context;

        public UsuarioController(AppDbContext context)
        {
            _context = context;
        }

        // GET: /Usuario/Cadastro
        [HttpGet]
        public IActionResult Cadastro()
        {
            return View();
        }

        // POST: /Usuario/Cadastro
        [HttpPost]
        public IActionResult Cadastro(Usuario usuario)
        {
            if (ModelState.IsValid)
            {
                _context.Usuarios.Add(usuario);
                _context.SaveChanges();
                return RedirectToAction("Login");
            }

            return View(usuario);
        }

        // GET: /Usuario/Login
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        // POST: /Usuario/Login
        [HttpPost]
        public IActionResult Login(string email, string senha)
        {
            // 🔹 Verifica se é um usuário comum
            var usuario = _context.Usuarios
                .FirstOrDefault(u => u.Email == email && u.Senha == senha);

            // 🔹 Verifica se é um administrador
            var administrador = _context.Administradores
                .FirstOrDefault(a => a.Email == email && a.Senha == senha);

            // Nenhum encontrado
            if (usuario == null && administrador == null)
            {
                ViewBag.Erro = "Usuário ou senha incorretos.";
                return View();
            }

            // 🔹 Se for administrador
            if (administrador != null)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, administrador.Nome),
                    new Claim(ClaimTypes.Email, administrador.Email),
                    new Claim(ClaimTypes.Role, "Administrador")
                };

                var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                var authProperties = new AuthenticationProperties
                {
                    IsPersistent = true
                };

                HttpContext.SignInAsync(
                    CookieAuthenticationDefaults.AuthenticationScheme,
                    new ClaimsPrincipal(claimsIdentity),
                    authProperties
                );

                return RedirectToAction("Index", "Perfil");
            }

            // 🔹 Se for usuário comum
            var userClaims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, usuario.NomeCompleto),
                new Claim(ClaimTypes.Email, usuario.Email),
                new Claim(ClaimTypes.Role, "Usuario")
            };

            var userIdentity = new ClaimsIdentity(userClaims, CookieAuthenticationDefaults.AuthenticationScheme);
            var userAuthProperties = new AuthenticationProperties
            {
                IsPersistent = true
            };

            HttpContext.SignInAsync(
                CookieAuthenticationDefaults.AuthenticationScheme,
                new ClaimsPrincipal(userIdentity),
                userAuthProperties
            );

            return RedirectToAction("Index", "Perfil");
        }

        // POST: /Usuario/Logout
        [HttpPost]
        public IActionResult Logout()
        {
            HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Login", "Usuario");
        }

        // ✅ GET: Esqueceu Senha
        [HttpGet]
        public IActionResult EsqueceuSenha()
        {
            return View();
        }

        // ✅ POST: Esqueceu Senha
        [HttpPost]
        public async Task<IActionResult> EsqueceuSenha(string email)
        {
            if (string.IsNullOrEmpty(email))
            {
                TempData["Erro"] = "Por favor, informe seu email.";
                return View();
            }

            var usuario = await _context.Usuarios.FirstOrDefaultAsync(u => u.Email == email);

            if (usuario == null)
            {
                TempData["Sucesso"] = "Se o email estiver cadastrado, você receberá as instruções.";
                return RedirectToAction("Login");
            }

            usuario.TokenRedefinicao = Guid.NewGuid().ToString();
            usuario.TokenValidade = DateTime.Now.AddHours(1);

            await _context.SaveChangesAsync();

            TempData["Sucesso"] = "Instruções enviadas! Use o link para redefinir sua senha.";
            TempData["Token"] = usuario.TokenRedefinicao;

            return RedirectToAction("RedefinirSenha", new { token = usuario.TokenRedefinicao, email = email });
        }

        // ✅ GET: Redefinir Senha
        [HttpGet]
        public async Task<IActionResult> RedefinirSenha(string token, string email)
        {
            if (string.IsNullOrEmpty(token) || string.IsNullOrEmpty(email))
            {
                TempData["Erro"] = "Link inválido.";
                return RedirectToAction("Login");
            }

            var usuario = await _context.Usuarios
                .FirstOrDefaultAsync(u => u.Email == email && u.TokenRedefinicao == token);

            if (usuario == null || usuario.TokenValidade == null || usuario.TokenValidade < DateTime.Now)
            {
                TempData["Erro"] = "Link expirado ou inválido.";
                return RedirectToAction("Login");
            }

            var model = new RedefinirSenhaViewModel
            {
                Token = token,
                Email = email
            };

            return View(model);
        }

        // ✅ POST: Redefinir Senha
        [HttpPost]
        public async Task<IActionResult> RedefinirSenha(RedefinirSenhaViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var usuario = await _context.Usuarios
                .FirstOrDefaultAsync(u => u.Email == model.Email && u.TokenRedefinicao == model.Token);

            if (usuario == null || usuario.TokenValidade == null || usuario.TokenValidade < DateTime.Now)
            {
                TempData["Erro"] = "Link expirado ou inválido.";
                return RedirectToAction("Login");
            }

            usuario.Senha = model.NovaSenha;
            usuario.TokenRedefinicao = null;
            usuario.TokenValidade = null;

            await _context.SaveChangesAsync();

            TempData["Sucesso"] = "Senha redefinida com sucesso! Faça login.";
            return RedirectToAction("Login");
        }
    }
}