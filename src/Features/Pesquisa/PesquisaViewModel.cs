namespace SaberMais.Features.Pesquisa
{
    public class PesquisaViewModel
    {
        public string? Termo { get; set; }

        // Aqui vão os resultados da pesquisa (por enquanto só uma lista simples)
        public List<ResultadoCursoViewModel> Resultados { get; set; } = new();
    }

    public class ResultadoCursoViewModel
    {
        public int Id { get; set; }
        public string Titulo { get; set; } = string.Empty;
        public string? Descricao { get; set; }
    }
}
