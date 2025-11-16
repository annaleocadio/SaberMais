using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SaberMais.Models
{
    [Table("Mensagens")]
    public class Mensagem
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Remetente")]
        public int RemetenteId { get; set; }

        [Required]
        [Display(Name = "Destinatário")]
        public int DestinatarioId { get; set; }

        [Required]
        [Display(Name = "Assunto")]
        [MaxLength(200)]
        public string Assunto { get; set; }

        [Required]
        [Display(Name = "Conteúdo")]
        [MaxLength(2000)]
        public string Conteudo { get; set; }

        [Display(Name = "Data de Envio")]
        public DateTime DataEnvio { get; set; } = DateTime.Now;

        [Display(Name = "Lida")]
        public bool Lida { get; set; } = false;

        // Navegação
        [ForeignKey("RemetenteId")]
        public virtual Usuario Remetente { get; set; }

        [ForeignKey("DestinatarioId")]
        public virtual Usuario Destinatario { get; set; }
    }
}