using Microsoft.AspNetCore.Mvc;
using SaberMais.Data;
using SaberMais.Models;

namespace SaberMais.Features.Pesquisa
{
    public class PesquisaController : Controller
    {
        private readonly AppDbContext _context;

        public PesquisaController(AppDbContext context)
        {
            _context = context;
        }

        // /Pesquisa?termo=xxx
        [HttpGet]
        public IActionResult Index(string? termo)
        {
            var viewModel = new PesquisaViewModel
            {
                Termo = termo
            };

            // Se não digitou nada, não pesquisa
            if (!string.IsNullOrWhiteSpace(termo))
            {
                // 🔹 AJUSTAR AQUI os nomes das propriedades conforme seu modelo Curso
                var query = _context.Cursos.AsQueryable();

                termo = termo.Trim();

                query = query.Where(c =>
                    (c.Titulo != null && c.Titulo.Contains(termo)) ||
                    (c.Descricao != null && c.Descricao.Contains(termo)));

                viewModel.Resultados = query
                    .Select(c => new ResultadoCursoViewModel
                    {
                        Id = c.Id,
                        Titulo = c.Titulo,
                        Descricao = c.Descricao
                    })
                    .ToList();
            }

            return View(viewModel);
        }
    }
}
