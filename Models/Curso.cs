using System;
using System.ComponentModel.DataAnnotations;

namespace SaberMais.Models
{
    public class Curso
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Título")]
        public string Titulo { get; set; }

        [Display(Name = "Descrição")]
        public string Descricao { get; set; }

        [Display(Name = "Valor (R$)")]
        public decimal Valor { get; set; }

        [Display(Name = "Presencial")]
        public bool Presencial { get; set; }

        // Endereço (só preenchido se Presencial == true)
        [Display(Name = "CEP")]
        public string Cep { get; set; }

        [Display(Name = "Logradouro")]
        public string Logradouro { get; set; }

        [Display(Name = "Número")]
        public string Numero { get; set; }

        [Display(Name = "Complemento")]
        public string Complemento { get; set; }

        [Display(Name = "Bairro")]
        public string Bairro { get; set; }

        [Display(Name = "UF")]
        public string Uf { get; set; }

        // Arquivos (caminhos para wwwroot/uploads)
        [Display(Name = "Imagem de divulgação")]
        public string ImagemPath { get; set; }

        [Display(Name = "Arquivo do curso (ex: PDF, ZIP)")]
        public string ArquivoPath { get; set; }

        [Display(Name = "Criado em")]
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}

