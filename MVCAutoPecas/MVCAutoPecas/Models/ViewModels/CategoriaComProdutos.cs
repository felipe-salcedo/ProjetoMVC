namespace MVCAutoPecas.Models.ViewModels
{
    public class CategoriaComProdutos
    {
        public Categoria Categoria { get; set; }
        public List<Produto> Produtos { get; set; } = new List<Produto>();
    }
}