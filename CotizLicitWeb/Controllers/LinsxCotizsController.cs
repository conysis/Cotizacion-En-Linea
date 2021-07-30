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
    public class LinsxCotizsController : Controller
    {
        private readonly LicitacionContext _context;

        public LinsxCotizsController(LicitacionContext context)
        {
            _context = context;
        }

        // GET: LinsxCotizs
        public async Task<IActionResult> Index()
        {
            return View(await _context.LinsxCotiz.ToListAsync());
        }

        // GET: LinsxCotizs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var linsxCotiz = await _context.LinsxCotiz
                .FirstOrDefaultAsync(m => m.Id == id);
            if (linsxCotiz == null)
            {
                return NotFound();
            }

            return View(linsxCotiz);
        }

        // GET: LinsxCotizs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: LinsxCotizs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Precio,Cantidad")] LinsxCotiz linsxCotiz)
        {
            if (ModelState.IsValid)
            {
                _context.Add(linsxCotiz);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(linsxCotiz);
        }

        // GET: LinsxCotizs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var linsxCotiz = await _context.LinsxCotiz.FindAsync(id);
            if (linsxCotiz == null)
            {
                return NotFound();
            }
            return View(linsxCotiz);
        }

        // POST: LinsxCotizs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Precio,Cantidad")] LinsxCotiz linsxCotiz)
        {
            if (id != linsxCotiz.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(linsxCotiz);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LinsxCotizExists(linsxCotiz.Id))
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
            return View(linsxCotiz);
        }

        // GET: LinsxCotizs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var linsxCotiz = await _context.LinsxCotiz
                .FirstOrDefaultAsync(m => m.Id == id);
            if (linsxCotiz == null)
            {
                return NotFound();
            }

            return View(linsxCotiz);
        }

        // POST: LinsxCotizs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var linsxCotiz = await _context.LinsxCotiz.FindAsync(id);
            _context.LinsxCotiz.Remove(linsxCotiz);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LinsxCotizExists(int id)
        {
            return _context.LinsxCotiz.Any(e => e.Id == id);
        }
    }
}
