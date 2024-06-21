using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Doceaconchego.Models;

namespace Doceaconchego.Controllers
{
    public class ClientehasvendasController : Controller
    {
        private readonly Contexto _context;

        public ClientehasvendasController(Contexto context)
        {
            _context = context;
        }

        // GET: Clientehasvendas
        public async Task<IActionResult> Index()
        {
            var contexto = _context.Clientehasvendas.Include(c => c.Cliente).Include(c => c.Produto).Include(c => c.Venda);
            return View(await contexto.ToListAsync());
        }

        // GET: Clientehasvendas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Clientehasvendas == null)
            {
                return NotFound();
            }

            var clientehasvendas = await _context.Clientehasvendas
                .Include(c => c.Cliente)
                .Include(c => c.Produto)
                .Include(c => c.Venda)
                .FirstOrDefaultAsync(m => m.ClientehasvendasId == id);
            if (clientehasvendas == null)
            {
                return NotFound();
            }

            return View(clientehasvendas);
        }

        // GET: Clientehasvendas/Create
        public IActionResult Create()
        {
            ViewData["ClienteId"] = new SelectList(_context.Cliente, "ClienteId", "ClienteId");
            ViewData["ProdutoId"] = new SelectList(_context.Produto, "ProdutoId", "ProdutoId");
            ViewData["VendaId"] = new SelectList(_context.Venda, "VendaId", "VendaId");
            return View();
        }

        // POST: Clientehasvendas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ClientehasvendasId,ClienteId,VendaId,ProdutoId")] Clientehasvendas clientehasvendas)
        {
            if (ModelState.IsValid)
            {
                _context.Add(clientehasvendas);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ClienteId"] = new SelectList(_context.Cliente, "ClienteId", "ClienteId", clientehasvendas.ClienteId);
            ViewData["ProdutoId"] = new SelectList(_context.Produto, "ProdutoId", "ProdutoId", clientehasvendas.ProdutoId);
            ViewData["VendaId"] = new SelectList(_context.Venda, "VendaId", "VendaId", clientehasvendas.VendaId);
            return View(clientehasvendas);
        }

        // GET: Clientehasvendas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Clientehasvendas == null)
            {
                return NotFound();
            }

            var clientehasvendas = await _context.Clientehasvendas.FindAsync(id);
            if (clientehasvendas == null)
            {
                return NotFound();
            }
            ViewData["ClienteId"] = new SelectList(_context.Cliente, "ClienteId", "ClienteId", clientehasvendas.ClienteId);
            ViewData["ProdutoId"] = new SelectList(_context.Produto, "ProdutoId", "ProdutoId", clientehasvendas.ProdutoId);
            ViewData["VendaId"] = new SelectList(_context.Venda, "VendaId", "VendaId", clientehasvendas.VendaId);
            return View(clientehasvendas);
        }

        // POST: Clientehasvendas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ClientehasvendasId,ClienteId,VendaId,ProdutoId")] Clientehasvendas clientehasvendas)
        {
            if (id != clientehasvendas.ClientehasvendasId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(clientehasvendas);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ClientehasvendasExists(clientehasvendas.ClientehasvendasId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["ClienteId"] = new SelectList(_context.Cliente, "ClienteId", "ClienteId", clientehasvendas.ClienteId);
            ViewData["ProdutoId"] = new SelectList(_context.Produto, "ProdutoId", "ProdutoId", clientehasvendas.ProdutoId);
            ViewData["VendaId"] = new SelectList(_context.Venda, "VendaId", "VendaId", clientehasvendas.VendaId);
            return View(clientehasvendas);
        }

        // GET: Clientehasvendas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Clientehasvendas == null)
            {
                return NotFound();
            }

            var clientehasvendas = await _context.Clientehasvendas
                .Include(c => c.Cliente)
                .Include(c => c.Produto)
                .Include(c => c.Venda)
                .FirstOrDefaultAsync(m => m.ClientehasvendasId == id);
            if (clientehasvendas == null)
            {
                return NotFound();
            }

            return View(clientehasvendas);
        }

        // POST: Clientehasvendas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Clientehasvendas == null)
            {
                return Problem("Entity set 'Contexto.Clientehasvendas'  is null.");
            }
            var clientehasvendas = await _context.Clientehasvendas.FindAsync(id);
            if (clientehasvendas != null)
            {
                _context.Clientehasvendas.Remove(clientehasvendas);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ClientehasvendasExists(int id)
        {
          return (_context.Clientehasvendas?.Any(e => e.ClientehasvendasId == id)).GetValueOrDefault();
        }
    }
}
