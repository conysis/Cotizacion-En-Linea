using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CotizLicitAPI.Models;

namespace CotizLicitAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LicitacionsController : ControllerBase
    {
        private readonly LicitacionContext _context;

        public LicitacionsController(LicitacionContext context)
        {
            _context = context;
        }

        // GET: api/Licitacions
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Licitacion>>> GetLicitacions()
        {
            return await _context.Licitacions.ToListAsync();
        }

        // GET: api/Licitacions/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Licitacion>> GetLicitacion(int id)
        {
            var licitacion = await _context.Licitacions.FindAsync(id);

            if (licitacion == null)
            {
                return NotFound();
            }

            return licitacion;
        }

        // PUT: api/Licitacions/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutLicitacion(int id, Licitacion licitacion)
        {
            if (id != licitacion.Id)
            {
                return BadRequest();
            }

            _context.Entry(licitacion).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LicitacionExists(id))
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

        // POST: api/Licitacions
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Licitacion>> PostLicitacion(Licitacion licitacion)
        {
            _context.Licitacions.Add(licitacion);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetLicitacion", new { id = licitacion.Id }, licitacion);
        }

        // DELETE: api/Licitacions/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteLicitacion(int id)
        {
            var licitacion = await _context.Licitacions.FindAsync(id);
            if (licitacion == null)
            {
                return NotFound();
            }

            _context.Licitacions.Remove(licitacion);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool LicitacionExists(int id)
        {
            return _context.Licitacions.Any(e => e.Id == id);
        }
    }
}
