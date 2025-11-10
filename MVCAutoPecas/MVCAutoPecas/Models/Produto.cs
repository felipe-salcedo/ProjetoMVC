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

        [Column(TypeName = "decimal(18,2)")] // Define a precisão no banco
        public decimal Preco { get; set; }

        public int Estoque { get; set; }

        public string? CodigoFabricante { get; set; }

        // --- Relacionamentos (Chaves Estrangeiras) ---

        // Chave estrangeira para Categoria
        public int CategoriaId { get; set; }
        public Categoria Categoria { get; set; }

        // Chave estrangeira para Fornecedor
        public int FornecedorId { get; set; }
        public Fornecedor Fornecedor { get; set; }

        // --- Relacionamentos (Many-to-Many) ---

        // Propriedade de navegação: Os pedidos que contêm este produto
        public ICollection<PedidoItem> PedidoItens { get; set; } = new List<PedidoItem>();
    }
}