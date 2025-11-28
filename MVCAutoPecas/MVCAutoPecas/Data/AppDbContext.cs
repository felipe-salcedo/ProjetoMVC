using Microsoft.EntityFrameworkCore;
using MVCAutoPecas.Models;

namespace MVCAutoPecas.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<PedidoItem> PedidoItens { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Cliente>().HasData(
                new Cliente { Id = 1, Nome = "Oficina do João", Cpf = "111.111.111-11", Telefone = "(15) 99111-1111", Endereco = "Rua das Peças, 100" },
                new Cliente { Id = 2, Nome = "Maria Mecânica", Cpf = "222.222.222-22", Telefone = "(15) 99222-2222", Endereco = "Av. Brasil, 500" },
                new Cliente { Id = 3, Nome = "Auto Center Sorocaba", Cpf = "333.333.333-33", Telefone = "(15) 3233-3333", Endereco = "Rua XV de Novembro, 20" },
                new Cliente { Id = 4, Nome = "Transportadora Veloz", Cpf = "444.444.444-44", Telefone = "(11) 99444-4444", Endereco = "Rodovia Castelo Branco, Km 80" },
                new Cliente { Id = 5, Nome = "José da Silva", Cpf = "555.555.555-55", Telefone = "(15) 99555-5555", Endereco = "Bairro Campolim, 10" }
            );
        }
    }
}