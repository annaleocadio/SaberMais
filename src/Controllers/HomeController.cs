using System.Diagnostics;
using SaberMais.Services;
using Microsoft.AspNetCore.Mvc;
using SaberMais.Models;
using SaberMais.Data;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace SaberMais.Controllers
{
    public class HomeController : BaseController
    {
        private readonly ILogger<HomeController> _logger;
        private readonly AppDbContext _context;

        public HomeController(ILogger<HomeController> logger, AppDbContext context, INotificacaoService notificacaoService)
            : base(notificacaoService)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            var recomendados = _context.Cursos
                .Where(c => c.Recomendado == true)
                .Take(4)
                .ToList();

            var cursos = _context.Cursos.ToList();

            ViewBag.Recomendados = recomendados;

            return View(cursos);
        }

        public IActionResult Detalhes(int id)
        {
            var curso = _context.Cursos
                .Include(c => c.Usuario)
                .FirstOrDefault(c => c.Id == id);

            if (curso == null)
            {
                return NotFound();
            }

            if (curso.Usuario != null)
            {
                var avaliacoes = _context.Avaliacoes
                    .Where(a => a.UsuarioAvaliadoId == curso.UsuarioId)
                    .ToList();
                ViewBag.AvaliacoesCriador = avaliacoes;
            }

            return View(curso);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}