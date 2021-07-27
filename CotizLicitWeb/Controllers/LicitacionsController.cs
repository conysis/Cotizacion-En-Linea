using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CotizLicitWeb.Models;

namespace CotizLicitWeb.Controllers
{
    public class LicitacionsController : Controller
    {
        private readonly LicitacionContext _context;

        public LicitacionsController(LicitacionContext context)
        {
            _context = context;
        }

        // GET: Licitacions
        public async Task<IActionResult> Index()
        {
            return View(await _context.Licitacions.ToListAsync());
        }

        // GET: Licitacions/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var licitacion = await _context.Licitacions
                .FirstOrDefaultAsync(m => m.Id == id);
            if (licitacion == null)
            {
                return NotFound();
            }

            return View(licitacion);
        }

        // GET: Licitacions/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Licitacions/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Expediente,FecCreacion,FecApertura,IdProveedor")] Licitacion licitacion)
        {
            if (ModelState.IsValid)
            {
                _context.Add(licitacion);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(licitacion);
        }

        // GET: Licitacions/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var licitacion = await _context.Licitacions.FindAsync(id);
            if (licitacion == null)
            {
                return NotFound();
            }
            return View(licitacion);
        }

        // POST: Licitacions/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Expediente,FecCreacion,FecApertura,IdProveedor")] Licitacion licitacion)
        {
            if (id != licitacion.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(licitacion);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LicitacionExists(licitacion.Id))
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
            return View(licitacion);
        }

        // GET: Licitacions/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var licitacion = await _context.Licitacions
                .FirstOrDefaultAsync(m => m.Id == id);
            if (licitacion == null)
            {
                return NotFound();
            }

            return View(licitacion);
        }

        // POST: Licitacions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var licitacion = await _context.Licitacions.FindAsync(id);
            _context.Licitacions.Remove(licitacion);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LicitacionExists(int id)
        {
            return _context.Licitacions.Any(e => e.Id == id);
        }
    }
}
