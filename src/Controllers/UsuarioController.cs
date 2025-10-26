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
                TempData["MensagemSucesso"] = "Cadastro realizado com sucesso! Faça login para continuar.";
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
            var usuario = _context.Usuarios.FirstOrDefault(u => u.Email == email && u.Senha == senha);
            var administrador = _context.Administradores.FirstOrDefault(a => a.Email == email && a.Senha == senha);

            if (usuario == null && administrador == null)
            {
                ViewBag.Erro = "Usuário ou senha incorretos.";
                return View();
            }

            // Administrador
            if (administrador != null)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, administrador.Nome),
                    new Claim(ClaimTypes.Email, administrador.Email),
                    new Claim(ClaimTypes.Role, "Administrador")
                };

                var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                var authProperties = new AuthenticationProperties { IsPersistent = true };

                HttpContext.SignInAsync(
                    CookieAuthenticationDefaults.AuthenticationScheme,
                    new ClaimsPrincipal(claimsIdentity),
                    authProperties
                );

                return RedirectToAction("Index", "Perfil");
            }

            // Usuário comum
            var userClaims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, usuario.NomeCompleto),
                new Claim(ClaimTypes.Email, usuario.Email),
                new Claim(ClaimTypes.Role, "Usuario")
            };

            var userIdentity = new ClaimsIdentity(userClaims, CookieAuthenticationDefaults.AuthenticationScheme);
            var userAuthProperties = new AuthenticationProperties { IsPersistent = true };

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

        // GET: /Usuario/RedefinirSenha
        [HttpGet]
        public IActionResult RedefinirSenha()
        {
            return View();
        }

        // POST: /Usuario/RedefinirSenha
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult RedefinirSenha(RedefinirSenhaViewModel model)
        {
            if (!ModelState.IsValid)
                return View(model);

            var usuario = _context.Usuarios.FirstOrDefault(u => u.Email == model.Email);
            if (usuario == null)
            {
                TempData["MensagemErro"] = "E-mail não encontrado.";
                return View(model);
            }

            usuario.Senha = model.NovaSenha;
            _context.SaveChanges();

            TempData["MensagemSucesso"] = "Senha redefinida com sucesso! Faça login novamente.";
            return RedirectToAction("Login", "Usuario");
        }
    }
}

