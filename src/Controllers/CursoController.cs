using Microsoft.AspNetCore.Mvc;
using SaberMais.Data;
using SaberMais.Models;
using SaberMais.Services;
using System;
using System.IO;
using System.Threading.Tasks;

namespace SaberMais.Controllers
{
    public class CursoController : Controller
    {
        private readonly AppDbContext _context;
        private readonly INotificacaoService _notificacaoService;
        private readonly IWebHostEnvironment _env;

        public CursoController(AppDbContext context, IWebHostEnvironment env, INotificacaoService notificacaoService)
        {
            _context = context;                     // ✅ corrigido (só uma vez)
            _env = env;
            _notificacaoService = notificacaoService;
        }

        // ===================== CRIAR =====================

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
        [ValidateAntiForgeryToken]
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

            // Imagem
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

            // Arquivo principal do curso
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

            // Criar notificação
            _notificacaoService.CriarNotificacao(
                $"Novo curso disponível: {curso.Titulo}",
                curso.Id,
                "NovoCurso"
            );

            TempData["Sucesso"] = "Curso cadastrado com sucesso!";
            return RedirectToAction("Criar");
        }

        // ===================== EDITAR =====================

        // GET: /Curso/Editar/3
        [HttpGet]
        public async Task<IActionResult> Editar(int id)
        {
            var curso = await _context.Cursos.FindAsync(id);
            if (curso == null)
                return NotFound();

            var model = new CursoViewModel
            {
                Titulo = curso.Titulo,
                Descricao = curso.Descricao,
                Valor = curso.Valor,
                Presencial = curso.Presencial,
                Cep = curso.Cep,
                Logradouro = curso.Logradouro,
                Numero = curso.Numero,
                Complemento = curso.Complemento,
                Bairro = curso.Bairro,
                Uf = curso.Uf
                // Se o seu CursoViewModel tiver campos para mostrar paths,
                // dá pra preencher aqui também.
            };

            return View(model); // vai procurar Views/Curso/Editar.cshtml
        }

        // POST: /Curso/Editar/3
        [HttpPost]
        [ValidateAntiForgeryToken]
        [RequestSizeLimit(50_000_000)]
        public async Task<IActionResult> Editar(int id, CursoViewModel model)
        {
            if (!ModelState.IsValid)
                return View(model);

            var curso = await _context.Cursos.FindAsync(id);
            if (curso == null)
                return NotFound();

            // Validação de endereço se for presencial
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

            // Atualiza dados básicos
            curso.Titulo = model.Titulo;
            curso.Descricao = model.Descricao;
            curso.Valor = model.Valor;
            curso.Presencial = model.Presencial;
            curso.Cep = model.Cep;
            curso.Logradouro = model.Logradouro;
            curso.Numero = model.Numero;
            curso.Complemento = model.Complemento;
            curso.Bairro = model.Bairro;
            curso.Uf = model.Uf;

            var uploadRoot = Path.Combine(_env.WebRootPath, "uploads");
            if (!Directory.Exists(uploadRoot))
                Directory.CreateDirectory(uploadRoot);

            // Se o usuário enviar nova imagem, substitui
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

            // Se enviar novo arquivo do curso, substitui
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

            await _context.SaveChangesAsync();

            TempData["Sucesso"] = "Curso atualizado com sucesso!";
            // Redireciona pra alguma página segura que já existe
            return RedirectToAction("Index", "Home");
        }
    }
}
