using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SaberMais.Models
{
    public class Usuario
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Nome Completo")]
        public string NomeCompleto { get; set; }

        [Required]
        [Display(Name = "Tipo de Pessoa")]
        public string TipoPessoa { get; set; } // Física ou Jurídica

        [Required]
        [Display(Name = "CPF ou CNPJ")]
        [StringLength(18)]
        public string Documento { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Data de Nascimento")]
        public DateTime DataNascimento { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Senha { get; set; }

        [NotMapped]
        [DataType(DataType.Password)]
        [Compare("Senha", ErrorMessage = "As senhas não coincidem.")]
        [Display(Name = "Confirmar Senha")]
        public string ConfirmarSenha { get; set; }

        // Foto padrão quando usuário ainda não enviou imagem
        [Display(Name = "Foto de Perfil")]
        [Column(TypeName = "nvarchar(255)")]
        public string FotoPerfil { get; set; } = "default-user.png";
    }
}
