using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using alibaba.Models;

namespace alibaba.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReservesController : ControllerBase
    {
        private readonly AlibabaContext _context;

        public ReservesController(AlibabaContext context)
        {
            _context = context;
        }

        // GET: api/Reserves
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Reserve>>> GetReserve()
        {
            return await _context.Reserve.ToListAsync();
        }

        // GET: api/Reserves/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Reserve>> GetReserve(long id)
        {
            var reserve = await _context.Reserve.FindAsync(id);

            if (reserve == null)
            {
                return NotFound();
            }

            return reserve;
        }

        // PUT: api/Reserves/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutReserve(long id, Reserve reserve)
        {
            if (id != reserve.Id)
            {
                return BadRequest();
            }

            _context.Entry(reserve).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ReserveExists(id))
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

        // POST: api/Reserves
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Reserve>> PostReserve(Reserve reserve)
        {
            _context.Reserve.Add(reserve);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetReserve", new { id = reserve.Id }, reserve);
        }

        // DELETE: api/Reserves/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Reserve>> DeleteReserve(long id)
        {
            var reserve = await _context.Reserve.FindAsync(id);
            if (reserve == null)
            {
                return NotFound();
            }

            _context.Reserve.Remove(reserve);
            await _context.SaveChangesAsync();

            return reserve;
        }

        private bool ReserveExists(long id)
        {
            return _context.Reserve.Any(e => e.Id == id);
        }
    }
}
