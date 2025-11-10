using System.ComponentModel.DataAnnotations;

namespace MVCAutoPecas.Models
{
    public class Categoria
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Nome { get; set; }

        public ICollection<Produto> Produtos { get; set; } = new List<Produto>();
    }
}