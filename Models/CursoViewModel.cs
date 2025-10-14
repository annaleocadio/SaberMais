using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;

namespace SaberMais.Models
{
    public class CursoViewModel
    {
        [Required(ErrorMessage = "O título do curso é obrigatório.")]
        [StringLength(100, ErrorMessage = "O título deve ter no máximo 100 caracteres.")]
        public string Titulo { get; set; }

        [Display(Name = "Descrição do Curso")]
        [StringLength(1000, ErrorMessage = "A descrição deve ter no máximo 1000 caracteres.")]
        public string? Descricao { get; set; }

        [Required(ErrorMessage = "Informe o valor do curso.")]
        [Display(Name = "Valor (R$)")]
        [Range(0, 999999, ErrorMessage = "Informe um valor válido.")]
        public decimal Valor { get; set; }

        [Display(Name = "Presencial")]
        public bool Presencial { get; set; }

        // 🔹 Endereço (apenas obrigatório se o curso for presencial)
        [Display(Name = "CEP")]
        public string? Cep { get; set; }

        [Display(Name = "Logradouro")]
        public string? Logradouro { get; set; }

        [Display(Name = "Número")]
        public string? Numero { get; set; }

        [Display(Name = "Complemento")]
        public string? Complemento { get; set; }

        [Display(Name = "Bairro")]
        public string? Bairro { get; set; }

        [Display(Name = "UF")]
        [StringLength(2, ErrorMessage = "A UF deve ter 2 caracteres.")]
        public string? Uf { get; set; }

        // 🔹 Uploads
        [Display(Name = "Imagem de Divulgação")]
        public IFormFile? Imagem { get; set; }

        [Display(Name = "Arquivo do Curso")]
        public IFormFile? Arquivo { get; set; }
    }
}
