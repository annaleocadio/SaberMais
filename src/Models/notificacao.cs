namespace SaberMais.Models
{
    public class Notificacao
    {
        public int Id { get; set; }
        public string Mensagem { get; set; }
        public DateTime DataCriacao { get; set; }
        public bool Lida { get; set; }
        public int? CursoId { get; set; }
        public string TipoNotificacao { get; set; } // "NovoCurso" ou "AtualizacaoCurso"
    }
}