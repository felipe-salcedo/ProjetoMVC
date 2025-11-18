using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVCAutoPecas.Data;
using MVCAutoPecas.Models.ViewModels;

namespace MVCAutoPecas.Controllers
{
    public class ProdutosController : Controller
    {
        private readonly AppDbContext _context;

        public ProdutosController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var categorias = await _context.Categorias.ToListAsync();
            var produtos = await _context.Produtos.ToListAsync();

            var model = categorias
                .Select(c => new CategoriaComProdutos
                {
                    Categoria = c,
                    Produtos = produtos.Where(p => p.CategoriaId == c.Id).ToList()
                })
                .ToList();

            return View(model);
        }
    }
}