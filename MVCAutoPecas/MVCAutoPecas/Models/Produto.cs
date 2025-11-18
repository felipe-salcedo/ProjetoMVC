using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCAutoPecas.Models
{
    public class Produto
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Nome { get; set; }

        [StringLength(500)]
        public string? Descricao { get; set; }

        [StringLength(200)]
        public string? ImagemUrl { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal Preco { get; set; }

        public int Estoque { get; set; }

        public string? CodigoFabricante { get; set; }

        public int CategoriaId { get; set; }
        public Categoria? Categoria { get; set; }

        public ICollection<PedidoItem> PedidoItens { get; set; } = new List<PedidoItem>();
    }
}