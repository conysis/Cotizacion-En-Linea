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
    public class LinsxLicitsController : ControllerBase
    {
        private readonly LicitacionContext _context;

        public LinsxLicitsController(LicitacionContext context)
        {
            _context = context;
        }

        // GET: api/LinsxLicits
        [HttpGet]
        public async Task<ActionResult<IEnumerable<LinsxLicit>>> GetLinsxLicit()
        {
            return await _context.LinsxLicit.ToListAsync();
        }

        // GET: api/LinsxLicits/5
        [HttpGet("{id}")]
        public async Task<ActionResult<LinsxLicit>> GetLinsxLicit(int id)
        {
            var linsxLicit = await _context.LinsxLicit.FindAsync(id);

            if (linsxLicit == null)
            {
                return NotFound();
            }

            return linsxLicit;
        }

        // PUT: api/LinsxLicits/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutLinsxLicit(int id, LinsxLicit linsxLicit)
        {
            if (id != linsxLicit.Id)
            {
                return BadRequest();
            }

            _context.Entry(linsxLicit).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LinsxLicitExists(id))
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

        // POST: api/LinsxLicits
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<LinsxLicit>> PostLinsxLicit(LinsxLicit linsxLicit)
        {
            _context.LinsxLicit.Add(linsxLicit);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetLinsxLicit", new { id = linsxLicit.Id }, linsxLicit);
        }

        // DELETE: api/LinsxLicits/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteLinsxLicit(int id)
        {
            var linsxLicit = await _context.LinsxLicit.FindAsync(id);
            if (linsxLicit == null)
            {
                return NotFound();
            }

            _context.LinsxLicit.Remove(linsxLicit);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool LinsxLicitExists(int id)
        {
            return _context.LinsxLicit.Any(e => e.Id == id);
        }
    }
}
