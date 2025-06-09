using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CrudMVC.Models
{
    public class Produto
    {
        [Key]
        public int ProdutoId { get; set; }

        [Required]
        public string Nome { get; set; }

        [Required]
        public decimal Preco { get; set; }

        public string Descricao { get; set; }

        // Propriedade de chave estrangeira 
        [ForeignKey("Categoria")]
        public int CategoriaId { get; set; }

        public Categoria Categoria { get; set; }
    }
}
