using CrudMVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CrudMVC.Controllers
{
    public class ClientesController : Controller
    {
        private readonly Context _context;

        public ClientesController(Context context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.Clientes.ToListAsync());
        }

        [HttpGet]
        public IActionResult NovoCliente()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> NovoCliente(Cliente cliente)
        {
            await _context.Clientes.AddAsync(cliente);

            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public async Task<IActionResult> AtualizarCliente(int clienteId)
        {
            Cliente cliente = await _context.Clientes.FindAsync(clienteId);

            return View(cliente);
        }

        [HttpPost]
        public async Task<IActionResult> AtualizarCliente(Cliente cliente)
        {
            _context.Clientes.Update(cliente);

            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        public async Task<IActionResult> ExcluirCliente(int clienteId)
        {
            Cliente cliente = await _context.Clientes.FindAsync(clienteId);
            _context.Clientes.Remove(cliente);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
