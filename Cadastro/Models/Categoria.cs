using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace CrudMVC.Models
{
    public class Categoria
    {
        [Key]
        public int CategoriaId { get; set; }

        [Required]
        public string Nome { get; set; }

        // Uma categoria pode ter muitos produtos 
        public List<Produto> Produtos { get; set; }
    }
}