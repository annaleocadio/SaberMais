using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SaberMais.Models
{
    [Table("Avaliacoes")]
    public class Avaliacao
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Avaliador")]
        public int UsuarioAvaliadorId { get; set; }

        [Required]
        [Display(Name = "Usuário Avaliado")]
        public int UsuarioAvaliadoId { get; set; }

        [Required]
        [Range(1, 5, ErrorMessage = "A nota deve estar entre 1 e 5")]
        [Display(Name = "Nota")]
        public int Nota { get; set; }

        [Display(Name = "Comentário")]
        [MaxLength(1000)]
        public string Comentario { get; set; }

        [Display(Name = "Data da Avaliação")]
        public DateTime DataAvaliacao { get; set; } = DateTime.Now;

        // Navegação
        [ForeignKey("UsuarioAvaliadorId")]
        public virtual Usuario UsuarioAvaliador { get; set; }

        [ForeignKey("UsuarioAvaliadoId")]
        public virtual Usuario UsuarioAvaliado { get; set; }
    }
}