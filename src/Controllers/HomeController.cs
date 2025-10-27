using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using SaberMais.Models;
using SaberMais.Data;
using System.Linq;

namespace SaberMais.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly AppDbContext _context;

        public HomeController(ILogger<HomeController> logger, AppDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            var cursos = _context.Cursos.ToList();
            return View(cursos);
        }

        public IActionResult Detalhes(int id)
        {
            var curso = _context.Cursos.FirstOrDefault(c => c.Id == id);

            if (curso == null)
            {
                return NotFound();
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