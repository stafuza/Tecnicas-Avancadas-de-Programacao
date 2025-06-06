namespace TrabalhoAv1.Models
{
    public class Cliente
    {
        public int ClienteId { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string Sexo { get; set; } = string.Empty;
        public string Idade { get; set; } = string.Empty;
        public DateOnly DataNasc { get; set; }

        public int CidadeId { get; set; }
        public Cidade? Cidade { get; set; }
    }  
}
