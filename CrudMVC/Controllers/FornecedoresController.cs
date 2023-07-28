using CrudMVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CrudMVC.Controllers
{
    public class FornecedoresController : Controller
    {
        private readonly Context _context;

        public FornecedoresController(Context context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.Fornecedores.ToListAsync());
        }

        [HttpGet]
        public IActionResult NovoFornecedor()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> NovoFornecedor(Fornecedor fornecedor)
        {
            await _context.Fornecedores.AddAsync(fornecedor);

            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public async Task<IActionResult> AtualizarFornecedor(int fornecedorId)
        {
            Fornecedor fornecedor = await _context.Fornecedores.FindAsync(fornecedorId);

            return View(fornecedor);
        }

        [HttpPost]
        public async Task<IActionResult> AtualizarFornecedor(Fornecedor fornecedor)
        {
            _context.Fornecedores.Update(fornecedor);

            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        public async Task<IActionResult> ExcluirFornecedor(int fornecedorId)
        {
            Fornecedor fornecedor = await _context.Fornecedores.FindAsync(fornecedorId);
            _context.Fornecedores.Remove(fornecedor);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
