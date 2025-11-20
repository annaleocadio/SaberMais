using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using SaberMais.Data;
using SaberMais.Models;
using SaberMais.Services;
using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Security.Claims;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace SaberMais.Controllers
{
    public class CursoController : Controller
    {
        private readonly AppDbContext _context;
        private readonly INotificacaoService _notificacaoService;
        private readonly IWebHostEnvironment _env;

        public CursoController(AppDbContext context, IWebHostEnvironment env, INotificacaoService notificacaoService)
        {
            _context = context;
            _env = env;
            _notificacaoService = notificacaoService;
        }

        [HttpGet]
        [Authorize]
        public IActionResult Criar()
        {
            var model = new CursoViewModel
            {
                Presencial = false
            };
            return View(model);
        }

        [HttpPost]
        [Authorize]
        [RequestSizeLimit(50_000_000)]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Criar(CursoViewModel model)
        {
            // ✅ Validação do ModelState (verifica Data Annotations)
            if (!ModelState.IsValid)
                return View(model);

            var emailLogado = User.FindFirstValue(ClaimTypes.Email);
            var usuarioLogado = _context.Usuarios.FirstOrDefault(u => u.Email == emailLogado);

            if (usuarioLogado == null)
            {
                TempData["Erro"] = "Você precisa estar logado para criar um curso.";
                return RedirectToAction("Login", "Usuario");
            }

            // ✅ Validação do endereço se for presencial
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
                Cpf = model.Cpf,  // ✅ ADICIONADO CPF
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
                CreatedAt = DateTime.UtcNow,
                UsuarioId = usuarioLogado.Id,
                Recomendado = model.Recomendado,
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

            _notificacaoService.CriarNotificacao(
                $"Novo curso disponível: {curso.Titulo}",
                curso.Id,
                "NovoCurso"
            );

            TempData["Sucesso"] = "Curso cadastrado com sucesso!";
            return RedirectToAction("Criar");
        }


        [HttpGet]
        [Authorize]
        public async Task<IActionResult> Editar(int id)
        {
            var curso = await _context.Cursos.FindAsync(id);
            if (curso == null)
                return NotFound();

            var model = new CursoViewModel
            {
                Id = curso.Id,  // ✅ ADICIONADO ID
                Cpf = curso.Cpf,  // ✅ ADICIONADO CPF
                Titulo = curso.Titulo,
                Descricao = curso.Descricao,
                Valor = curso.Valor,
                Presencial = curso.Presencial,
                Cep = curso.Cep,
                Logradouro = curso.Logradouro,
                Numero = curso.Numero,
                Complemento = curso.Complemento,
                Bairro = curso.Bairro,
                Uf = curso.Uf,
                Recomendado = curso.Recomendado,
            };

            return View(model);
        }

        [HttpPost]
        [Authorize]
        [ValidateAntiForgeryToken]
        [RequestSizeLimit(50_000_000)]
        public async Task<IActionResult> Editar(int id, CursoViewModel model)
        {
            // ✅ Validação do ModelState (verifica Data Annotations)
            if (!ModelState.IsValid)
                return View(model);

            var curso = await _context.Cursos.FindAsync(id);
            if (curso == null)
                return NotFound();

            // ✅ Validação do endereço se for presencial
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

            curso.Cpf = model.Cpf;  // ✅ ADICIONADO CPF
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
            curso.Recomendado = model.Recomendado;

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

            await _context.SaveChangesAsync();

            TempData["Sucesso"] = "Curso atualizado com sucesso!";
            return RedirectToAction("Index", "Home");
        }
    }
}