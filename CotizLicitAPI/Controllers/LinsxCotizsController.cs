using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CotizLicitAPI.Contexts;
using CotizLicitAPI.Models;

namespace CotizLicitAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LinsxCotizsController : ControllerBase
    {
        private readonly LicitacionContext _context;

        public LinsxCotizsController(LicitacionContext context)
        {
            _context = context;
        }

        // GET: api/LinsxCotizs
        [HttpGet]
        public async Task<ActionResult<IEnumerable<LinsxCotiz>>> GetLinsxCotiz()
        {
            return await _context.LinsxCotiz.ToListAsync();
        }

        // GET: api/LinsxCotizs/5
        [HttpGet("{id}")]
        public async Task<ActionResult<LinsxCotiz>> GetLinsxCotiz(int id)
        {
            var linsxCotiz = await _context.LinsxCotiz.FindAsync(id);

            if (linsxCotiz == null)
            {
                return NotFound();
            }

            return linsxCotiz;
        }

        // PUT: api/LinsxCotizs/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutLinsxCotiz(int id, LinsxCotiz linsxCotiz)
        {
            if (id != linsxCotiz.Id)
            {
                return BadRequest();
            }

            _context.Entry(linsxCotiz).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LinsxCotizExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/LinsxCotizs
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<LinsxCotiz>> PostLinsxCotiz(LinsxCotiz linsxCotiz)
        {
            _context.LinsxCotiz.Add(linsxCotiz);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetLinsxCotiz", new { id = linsxCotiz.Id }, linsxCotiz);
        }

        // DELETE: api/LinsxCotizs/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteLinsxCotiz(int id)
        {
            var linsxCotiz = await _context.LinsxCotiz.FindAsync(id);
            if (linsxCotiz == null)
            {
                return NotFound();
            }

            _context.LinsxCotiz.Remove(linsxCotiz);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool LinsxCotizExists(int id)
        {
            return _context.LinsxCotiz.Any(e => e.Id == id);
        }
    }
}
