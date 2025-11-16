using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SaberMais.Data;
using SaberMais.Models;
using SaberMais.Services;
using System.Linq;
using System.Security.Claims;

namespace SaberMais.Controllers
{
    [Authorize]
    public class AvaliacaoController : BaseController
    {
        private readonly AppDbContext _context;

        public AvaliacaoController(AppDbContext context, INotificacaoService notificacaoService)
            : base(notificacaoService)
        {
            _context = context;
        }

        // GET: Exibe o perfil de um usuário com suas avaliações
        public IActionResult VerPerfil(int id)
        {
            var usuario = _context.Usuarios.Find(id);
            if (usuario == null)
                return NotFound();

            var avaliacoes = _context.Avaliacoes
                .Include(a => a.UsuarioAvaliador)
                .Where(a => a.UsuarioAvaliadoId == id)
                .OrderByDescending(a => a.DataAvaliacao)
                .ToList();

            var mediaNotas = avaliacoes.Any() ? avaliacoes.Average(a => a.Nota) : 0;

            ViewBag.Usuario = usuario;
            ViewBag.Avaliacoes = avaliacoes;
            ViewBag.MediaNotas = mediaNotas;
            ViewBag.TotalAvaliacoes = avaliacoes.Count;

            return View();
        }

        // GET: Formulário para avaliar um usuário
        [HttpGet]
        public IActionResult Avaliar(int usuarioId)
        {
            var emailLogado = User.FindFirstValue(ClaimTypes.Email);
            var usuarioLogado = _context.Usuarios.FirstOrDefault(u => u.Email == emailLogado);

            if (usuarioLogado == null)
            {
                TempData["Erro"] = "Você precisa estar logado para avaliar.";
                return RedirectToAction("Login", "Usuario");
            }

            if (usuarioLogado.Id == usuarioId)
            {
                TempData["Erro"] = "Você não pode avaliar a si mesmo!";
                return RedirectToAction("VerPerfil", new { id = usuarioId });
            }

            // Verifica se já avaliou este usuário
            var jaAvaliou = _context.Avaliacoes
                .Any(a => a.UsuarioAvaliadorId == usuarioLogado.Id && a.UsuarioAvaliadoId == usuarioId);

            if (jaAvaliou)
            {
                TempData["Erro"] = "Você já avaliou este usuário!";
                return RedirectToAction("VerPerfil", new { id = usuarioId });
            }

            var usuarioAvaliado = _context.Usuarios.Find(usuarioId);
            if (usuarioAvaliado == null)
                return NotFound();

            ViewBag.UsuarioAvaliado = usuarioAvaliado;
            return View();
        }

        // POST: Salva a avaliação
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Avaliar(int usuarioId, int nota, string comentario)
        {
            var emailLogado = User.FindFirstValue(ClaimTypes.Email);
            var usuarioLogado = _context.Usuarios.FirstOrDefault(u => u.Email == emailLogado);

            if (usuarioLogado == null)
                return RedirectToAction("Login", "Usuario");

            var avaliacao = new Avaliacao
            {
                UsuarioAvaliadorId = usuarioLogado.Id,
                UsuarioAvaliadoId = usuarioId,
                Nota = nota,
                Comentario = comentario,
                DataAvaliacao = DateTime.Now
            };

            _context.Avaliacoes.Add(avaliacao);
            _context.SaveChanges();

            TempData["Sucesso"] = "Avaliação enviada com sucesso!";
            return RedirectToAction("VerPerfil", new { id = usuarioId });
        }

        // POST: Excluir avaliação (só o avaliador pode excluir)
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Excluir(int id)
        {
            var emailLogado = User.FindFirstValue(ClaimTypes.Email);
            var usuarioLogado = _context.Usuarios.FirstOrDefault(u => u.Email == emailLogado);

            var avaliacao = _context.Avaliacoes.Find(id);
            if (avaliacao == null)
                return NotFound();

            // Verifica se é o dono da avaliação
            if (avaliacao.UsuarioAvaliadorId != usuarioLogado.Id)
            {
                TempData["Erro"] = "Você não pode excluir esta avaliação!";
                return RedirectToAction("VerPerfil", new { id = avaliacao.UsuarioAvaliadoId });
            }

            _context.Avaliacoes.Remove(avaliacao);
            _context.SaveChanges();

            TempData["Sucesso"] = "Avaliação excluída com sucesso!";
            return RedirectToAction("VerPerfil", new { id = avaliacao.UsuarioAvaliadoId });
        }
    }
}