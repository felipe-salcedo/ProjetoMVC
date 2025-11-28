using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MVCAutoPecas.Migrations
{
    /// <inheritdoc />
    public partial class SeedClientes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Clientes",
                columns: new[] { "Id", "Cpf", "Endereco", "Nome", "Telefone" },
                values: new object[,]
                {
                    { 1, "111.111.111-11", "Rua das Peças, 100", "Oficina do João", "(15) 99111-1111" },
                    { 2, "222.222.222-22", "Av. Brasil, 500", "Maria Mecânica", "(15) 99222-2222" },
                    { 3, "333.333.333-33", "Rua XV de Novembro, 20", "Auto Center Sorocaba", "(15) 3233-3333" },
                    { 4, "444.444.444-44", "Rodovia Castelo Branco, Km 80", "Transportadora Veloz", "(11) 99444-4444" },
                    { 5, "555.555.555-55", "Bairro Campolim, 10", "José da Silva", "(15) 99555-5555" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Clientes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Clientes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Clientes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Clientes",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Clientes",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
