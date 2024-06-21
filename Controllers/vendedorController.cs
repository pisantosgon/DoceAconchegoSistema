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
    public class vendedorController : Controller
    {
        private readonly Contexto _context;

        public vendedorController(Contexto context)
        {
            _context = context;
        }

        // GET: vendedor
        public async Task<IActionResult> Index()
        {
              return _context.vendedor != null ? 
                          View(await _context.vendedor.ToListAsync()) :
                          Problem("Entity set 'Contexto.vendedor'  is null.");
        }

        // GET: vendedor/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.vendedor == null)
            {
                return NotFound();
            }

            var vendedor = await _context.vendedor
                .FirstOrDefaultAsync(m => m.vendedorId == id);
            if (vendedor == null)
            {
                return NotFound();
            }

            return View(vendedor);
        }

        // GET: vendedor/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: vendedor/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("vendedorId,Nomevendedor")] vendedor vendedor)
        {
            if (ModelState.IsValid)
            {
                _context.Add(vendedor);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(vendedor);
        }

        // GET: vendedor/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.vendedor == null)
            {
                return NotFound();
            }

            var vendedor = await _context.vendedor.FindAsync(id);
            if (vendedor == null)
            {
                return NotFound();
            }
            return View(vendedor);
        }

        // POST: vendedor/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("vendedorId,Nomevendedor")] vendedor vendedor)
        {
            if (id != vendedor.vendedorId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(vendedor);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!vendedorExists(vendedor.vendedorId))
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
            return View(vendedor);
        }

        // GET: vendedor/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.vendedor == null)
            {
                return NotFound();
            }

            var vendedor = await _context.vendedor
                .FirstOrDefaultAsync(m => m.vendedorId == id);
            if (vendedor == null)
            {
                return NotFound();
            }

            return View(vendedor);
        }

        // POST: vendedor/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.vendedor == null)
            {
                return Problem("Entity set 'Contexto.vendedor'  is null.");
            }
            var vendedor = await _context.vendedor.FindAsync(id);
            if (vendedor != null)
            {
                _context.vendedor.Remove(vendedor);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool vendedorExists(int id)
        {
          return (_context.vendedor?.Any(e => e.vendedorId == id)).GetValueOrDefault();
        }
    }
}
