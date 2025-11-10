using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCAutoPecas.Models
{
    public class Pedido
    {
        public int Id { get; set; }

        public DateTime DataPedido { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal ValorTotal { get; set; }

        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }
        public int FuncionarioId { get; set; }
        public ICollection<PedidoItem> PedidoItens { get; set; } = new List<PedidoItem>();
    }
}