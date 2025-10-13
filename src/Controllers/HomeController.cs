using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using SaberMais.Models;
using SaberMais.Data; // ? importa o contexto do banco
using System.Linq;   // ? necessário para usar .ToList()

namespace SaberMais.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly AppDbContext _context; // ? adiciona o banco

        public HomeController(ILogger<HomeController> logger, AppDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        // ? Página inicial que lista os cursos
        public IActionResult Index()
        {
            var cursos = _context.Cursos.ToList();
            return View(cursos);
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
