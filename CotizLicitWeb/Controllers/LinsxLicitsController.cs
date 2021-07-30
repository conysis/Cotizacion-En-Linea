using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CotizLicitAPI.Contexts;
using CotizLicitAPI.Models;

namespace CotizLicitWeb.Controllers
{
    public class LinsxLicitsController : Controller
    {
        private readonly LicitacionContext _context;

        public LinsxLicitsController(LicitacionContext context)
        {
            _context = context;
        }

        // GET: LinsxLicits
        public async Task<IActionResult> Index()
        {
            return View(await _context.LinsxLicit.ToListAsync());
        }

        // GET: LinsxLicits/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var linsxLicit = await _context.LinsxLicit
                .FirstOrDefaultAsync(m => m.Id == id);
            if (linsxLicit == null)
            {
                return NotFound();
            }

            return View(linsxLicit);
        }

        // GET: LinsxLicits/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: LinsxLicits/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Detalle,UnidadMedida,Precio,Cantidad")] LinsxLicit linsxLicit)
        {
            if (ModelState.IsValid)
            {
                _context.Add(linsxLicit);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(linsxLicit);
        }

        // GET: LinsxLicits/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var linsxLicit = await _context.LinsxLicit.FindAsync(id);
            if (linsxLicit == null)
            {
                return NotFound();
            }
            return View(linsxLicit);
        }

        // POST: LinsxLicits/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Detalle,UnidadMedida,Precio,Cantidad")] LinsxLicit linsxLicit)
        {
            if (id != linsxLicit.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(linsxLicit);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LinsxLicitExists(linsxLicit.Id))
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
            return View(linsxLicit);
        }

        // GET: LinsxLicits/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var linsxLicit = await _context.LinsxLicit
                .FirstOrDefaultAsync(m => m.Id == id);
            if (linsxLicit == null)
            {
                return NotFound();
            }

            return View(linsxLicit);
        }

        // POST: LinsxLicits/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var linsxLicit = await _context.LinsxLicit.FindAsync(id);
            _context.LinsxLicit.Remove(linsxLicit);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LinsxLicitExists(int id)
        {
            return _context.LinsxLicit.Any(e => e.Id == id);
        }
    }
}
