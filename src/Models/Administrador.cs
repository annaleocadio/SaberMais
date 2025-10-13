using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SaberMais.Models
{
    [Table("Administradores")]
    public class Administrador
    {
        [Key]
        public int Id { get; set; }

        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }

        // 🔹 Identifica se é o super administrador
        public bool IsSuperAdmin { get; set; } = false;
    }
}

