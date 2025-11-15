using SaberMais.Data;
using SaberMais.Models;
using Microsoft.EntityFrameworkCore;

namespace SaberMais.Services
{
    public interface INotificacaoService
    {
        void CriarNotificacao(string mensagem, int cursoId, string tipo);
        List<Notificacao> ObterNotificacoes();
        void MarcarComoLida(int notificacaoId);
        int ContarNaoLidas();
        void MarcarTodasComoLidas(); 
    }

    public class NotificacaoService : INotificacaoService
    {
        private readonly AppDbContext _context;

        public NotificacaoService(AppDbContext context)
        {
            _context = context;
        }

        public void CriarNotificacao(string mensagem, int cursoId, string tipo)
        {
            var notificacao = new Notificacao
            {
                Mensagem = mensagem,
                DataCriacao = DateTime.Now,
                Lida = false,
                CursoId = cursoId,
                TipoNotificacao = tipo
            };

            _context.Notificacoes.Add(notificacao);
            _context.SaveChanges();
        }

        public List<Notificacao> ObterNotificacoes()
        {
            return _context.Notificacoes
                .Where(n => !n.Lida)
                .OrderByDescending(n => n.DataCriacao)
                .Take(5)
                .ToList();
        }

        public void MarcarComoLida(int notificacaoId)
        {
            var notificacao = _context.Notificacoes.Find(notificacaoId);
            if (notificacao != null)
            {
                notificacao.Lida = true;
                _context.SaveChanges();
            }
        }

        public int ContarNaoLidas()
        {
            return _context.Notificacoes.Count(n => !n.Lida);
        }

        public void MarcarTodasComoLidas()
        {
            var notificacoes = _context.Notificacoes.Where(n => !n.Lida).ToList();
            foreach (var notificacao in notificacoes)
            {
                notificacao.Lida = true;
            }
            _context.SaveChanges();
        }
    }
}