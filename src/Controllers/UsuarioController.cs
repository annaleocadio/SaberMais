using Microsoft.AspNetCore.Mvc;
using SaberMais.Data;
using SaberMais.Models;
using System.Linq;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;

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
                    new Claim(ClaimTypes.Name, administrador.Nome), // nome do admin
                    new Claim(ClaimTypes.Email, administrador.Email),
                    new Claim(ClaimTypes.Role, "Administrador")
                };

                var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                var authProperties = new AuthenticationProperties
                {
                    IsPersistent = true // mantém login
                };

                HttpContext.SignInAsync(
                    CookieAuthenticationDefaults.AuthenticationScheme,
                    new ClaimsPrincipal(claimsIdentity),
                    authProperties
                );

                // ✅ Redireciona para a aba Perfil
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

            // ✅ Redireciona para a aba Perfil também
            return RedirectToAction("Index", "Perfil");
        }

        // POST: /Usuario/Logout
        [HttpPost]
        public IActionResult Logout()
        {
            HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Login", "Usuario");
        }
    }
}
