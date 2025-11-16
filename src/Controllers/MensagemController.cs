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
    public class MensagemController : BaseController
    {
        private readonly AppDbContext _context;

        public MensagemController(AppDbContext context, INotificacaoService notificacaoService)
            : base(notificacaoService)
        {
            _context = context;
        }

        // GET: Caixa de entrada
        public IActionResult Index()
        {
            var emailLogado = User.FindFirstValue(ClaimTypes.Email);
            var usuarioLogado = _context.Usuarios.FirstOrDefault(u => u.Email == emailLogado);

            if (usuarioLogado == null)
                return RedirectToAction("Login", "Usuario");

            var mensagensRecebidas = _context.Mensagens
                .Include(m => m.Remetente)
                .Where(m => m.DestinatarioId == usuarioLogado.Id)
                .OrderByDescending(m => m.DataEnvio)
                .ToList();

            var mensagensEnviadas = _context.Mensagens
                .Include(m => m.Destinatario)
                .Where(m => m.RemetenteId == usuarioLogado.Id)
                .OrderByDescending(m => m.DataEnvio)
                .ToList();

            ViewBag.MensagensRecebidas = mensagensRecebidas;
            ViewBag.MensagensEnviadas = mensagensEnviadas;
            ViewBag.NaoLidas = mensagensRecebidas.Count(m => !m.Lida);

            return View();
        }

        // GET: Ler mensagem
        public IActionResult Ler(int id)
        {
            var emailLogado = User.FindFirstValue(ClaimTypes.Email);
            var usuarioLogado = _context.Usuarios.FirstOrDefault(u => u.Email == emailLogado);

            var mensagem = _context.Mensagens
                .Include(m => m.Remetente)
                .Include(m => m.Destinatario)
                .FirstOrDefault(m => m.Id == id);

            if (mensagem == null)
                return NotFound();

            // Verifica se o usuário tem permissão para ler
            if (mensagem.DestinatarioId != usuarioLogado.Id && mensagem.RemetenteId != usuarioLogado.Id)
            {
                TempData["Erro"] = "Você não tem permissão para ler esta mensagem!";
                return RedirectToAction("Index");
            }

            // Marca como lida se for o destinatário
            if (mensagem.DestinatarioId == usuarioLogado.Id && !mensagem.Lida)
            {
                mensagem.Lida = true;
                _context.SaveChanges();
            }

            return View(mensagem);
        }

        // GET: Formulário para nova mensagem
        [HttpGet]
        public IActionResult Enviar(int? destinatarioId)
        {
            var usuarios = _context.Usuarios
                .Where(u => u.Email != User.FindFirstValue(ClaimTypes.Email))
                .OrderBy(u => u.NomeCompleto)
                .ToList();

            ViewBag.Usuarios = usuarios;
            ViewBag.DestinatarioId = destinatarioId;

            return View();
        }

        // POST: Enviar mensagem
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Enviar(int destinatarioId, string assunto, string conteudo)
        {
            var emailLogado = User.FindFirstValue(ClaimTypes.Email);
            var usuarioLogado = _context.Usuarios.FirstOrDefault(u => u.Email == emailLogado);

            if (usuarioLogado == null)
                return RedirectToAction("Login", "Usuario");

            if (string.IsNullOrWhiteSpace(assunto) || string.IsNullOrWhiteSpace(conteudo))
            {
                TempData["Erro"] = "Assunto e conteúdo são obrigatórios!";
                return RedirectToAction("Enviar", new { destinatarioId });
            }

            var mensagem = new Mensagem
            {
                RemetenteId = usuarioLogado.Id,
                DestinatarioId = destinatarioId,
                Assunto = assunto,
                Conteudo = conteudo,
                DataEnvio = DateTime.Now,
                Lida = false
            };

            _context.Mensagens.Add(mensagem);
            _context.SaveChanges();

            TempData["Sucesso"] = "Mensagem enviada com sucesso!";
            return RedirectToAction("Index");
        }

        // POST: Excluir mensagem
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Excluir(int id)
        {
            var emailLogado = User.FindFirstValue(ClaimTypes.Email);
            var usuarioLogado = _context.Usuarios.FirstOrDefault(u => u.Email == emailLogado);

            var mensagem = _context.Mensagens.Find(id);
            if (mensagem == null)
                return NotFound();

            // Só pode excluir se for destinatário ou remetente
            if (mensagem.DestinatarioId != usuarioLogado.Id && mensagem.RemetenteId != usuarioLogado.Id)
            {
                TempData["Erro"] = "Você não pode excluir esta mensagem!";
                return RedirectToAction("Index");
            }

            _context.Mensagens.Remove(mensagem);
            _context.SaveChanges();

            TempData["Sucesso"] = "Mensagem excluída com sucesso!";
            return RedirectToAction("Index");
        }

        // POST: Marcar como lida
        [HttpPost]
        public IActionResult MarcarLida(int id)
        {
            var mensagem = _context.Mensagens.Find(id);
            if (mensagem != null)
            {
                mensagem.Lida = true;
                _context.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}