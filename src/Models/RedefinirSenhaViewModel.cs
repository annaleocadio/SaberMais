using System.ComponentModel.DataAnnotations;

namespace SaberMais.Models
{
    public class RedefinirSenhaViewModel
    {
        [Required(ErrorMessage = "Informe o e-mail")]
        [EmailAddress(ErrorMessage = "E-mail inválido")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Informe a nova senha")]
        [DataType(DataType.Password)]
        public string NovaSenha { get; set; }

        [Required(ErrorMessage = "Confirme a nova senha")]
        [DataType(DataType.Password)]
        [Compare("NovaSenha", ErrorMessage = "As senhas não coincidem")]
        public string ConfirmarSenha { get; set; }
    }
}
