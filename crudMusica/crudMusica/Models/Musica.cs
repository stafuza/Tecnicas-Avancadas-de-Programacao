using System.ComponentModel.DataAnnotations;

namespace CrudMVC.Models
{
    public class Produto
    {
        [Key]
        public int MusicaId { get; set; }

        [Required]

        public string Nome { get; set; }

        [Required]
        public string Album { get; set; }

        [Required]
        public string Artista { get; set; }

        public string Feat { get; set; }
    }
}