using Microsoft.AspNetCore.Mvc;
using SaberMais.Data;
using SaberMais.Models;
using System;
using System.IO;
using System.Threading.Tasks;

namespace SaberMais.Controllers
{
    public class CursoController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;

        public CursoController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }

        [HttpGet]
        public IActionResult Criar()
        {
            var model = new CursoViewModel
            {
                Presencial = false
            };
            return View(model);
        }

        [HttpPost]
        [RequestSizeLimit(50_000_000)]
        public async Task<IActionResult> Criar(CursoViewModel model)
        {
            if (!ModelState.IsValid)
                return View(model);

            if (model.Presencial)
            {
                if (string.IsNullOrWhiteSpace(model.Cep) ||
                    string.IsNullOrWhiteSpace(model.Logradouro) ||
                    string.IsNullOrWhiteSpace(model.Numero))
                {
                    ModelState.AddModelError("", "Preencha o endereço completo para cursos presenciais.");
                    return View(model);
                }
            }

            var curso = new Curso
            {
                Titulo = model.Titulo,
                Descricao = model.Descricao,
                Valor = model.Valor,
                Presencial = model.Presencial,
                Cep = model.Cep,
                Logradouro = model.Logradouro,
                Numero = model.Numero,
                Complemento = model.Complemento,
                Bairro = model.Bairro,
                Uf = model.Uf,
                CreatedAt = DateTime.UtcNow
            };

            var uploadRoot = Path.Combine(_env.WebRootPath, "uploads");
            if (!Directory.Exists(uploadRoot))
                Directory.CreateDirectory(uploadRoot);

            if (model.Imagem != null && model.Imagem.Length > 0)
            {
                var ext = Path.GetExtension(model.Imagem.FileName);
                var fileName = $"img_{Guid.NewGuid():N}{ext}";
                var filePath = Path.Combine(uploadRoot, fileName);
                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    await model.Imagem.CopyToAsync(stream);
                }
                curso.ImagemPath = $"/uploads/{fileName}";
            }

            if (model.Arquivo != null && model.Arquivo.Length > 0)
            {
                var ext = Path.GetExtension(model.Arquivo.FileName);
                var fileName = $"curso_{Guid.NewGuid():N}{ext}";
                var filePath = Path.Combine(uploadRoot, fileName);
                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    await model.Arquivo.CopyToAsync(stream);
                }
                curso.ArquivoPath = $"/uploads/{fileName}";
            }

            _context.Cursos.Add(curso);
            await _context.SaveChangesAsync();

            TempData["Sucesso"] = "Curso cadastrado com sucesso!";
            return RedirectToAction("Criar");
        }
    }
}
