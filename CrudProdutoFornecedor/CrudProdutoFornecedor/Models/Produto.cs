using System.ComponentModel.DataAnnotations.Schema;

namespace CrudProdutoFornecedor.Models;

public class Produto
{
    public int ProdutoId { get; set; }
    public string Nome { get; set; } = string.Empty;

    [Column(TypeName = "numeric(10,2)")]
    public decimal Preco { get; set; }

    public int FornecedorId { get; set; }
    public Fornecedor? Fornecedor { get; set; }
}