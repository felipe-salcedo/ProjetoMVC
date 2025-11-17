using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using MVCAutoPecas.Models;
using MVCAutoPecas.Models.ViewModels;
using MVCAutoPecas.Data;

namespace MVCAutoPecas.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly AppDbContext _context;

        public HomeController(ILogger<HomeController> logger, AppDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var categorias = await _context.Categorias
                .Include(c => c.Produtos)
                .OrderBy(c => c.Nome)
                .ToListAsync();

            var model = categorias.Select(c => new CategoriaComProdutos
            {
                Categoria = c,
                Produtos = c.Produtos?.OrderBy(p => p.Nome).ToList() ?? new List<Produto>()
            }).ToList();

            return View(model);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}