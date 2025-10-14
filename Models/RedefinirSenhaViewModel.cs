using System.ComponentModel.DataAnnotations;

namespace SaberMais.Models
{
    public class RedefinirSenhaViewModel
    {
        [Required(ErrorMessage = "O token é obrigatório")]
        public string Token { get; set; }

        [Required(ErrorMessage = "O email é obrigatório")]
        [EmailAddress(ErrorMessage = "Email inválido")]
        public string Email { get; set; }

        [Required(ErrorMessage = "A nova senha é obrigatória")]
        [StringLength(100, MinimumLength = 6, ErrorMessage = "A senha deve ter no mínimo 6 caracteres")]
        [DataType(DataType.Password)]
        [Display(Name = "Nova Senha")]
        public string NovaSenha { get; set; }

        [Required(ErrorMessage = "Confirme a nova senha")]
        [DataType(DataType.Password)]
        [Compare("NovaSenha", ErrorMessage = "As senhas não coincidem")]
        [Display(Name = "Confirmar Nova Senha")]
        public string ConfirmarNovaSenha { get; set; }
    }
}
