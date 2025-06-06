namespace TrabalhoAv1.Models
{
    public class Estado
    {
        public int EstadoId { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string Sigla { get; set; } = string.Empty;

        public ICollection<Estado>? Estados { get; set; }
    }
}
