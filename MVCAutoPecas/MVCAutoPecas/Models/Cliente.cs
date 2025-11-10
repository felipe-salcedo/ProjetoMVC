using System.ComponentModel.DataAnnotations;

namespace MVCAutoPecas.Models
{
    public class Cliente
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Nome { get; set; }

        [StringLength(14)]
        public string? Cpf { get; set; }

        [StringLength(20)]
        public string? Telefone { get; set; }
        
        public string? Endereco { get; set; }

        public ICollection<Pedido> Pedidos { get; set; } = new List<Pedido>();
    }
}