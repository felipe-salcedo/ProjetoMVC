using System.ComponentModel.DataAnnotations;

namespace MVCAutoPecas.Models
{
    public class Fornecedor
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Nome { get; set; }

        [StringLength(18)]
        public string? Cnpj { get; set; }

        [StringLength(20)]
        public string? Telefone { get; set; }

        public ICollection<Produto> Produtos { get; set; } = new List<Produto>();
    }
}