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
    public class PicsController : ControllerBase
    {
        private readonly AlibabaContext _context;

        public PicsController(AlibabaContext context)
        {
            _context = context;
        }

        // GET: api/Pics
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Pic>>> GetPic()
        {
            return await _context.Pic.ToListAsync();
        }

        // GET: api/Pics/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Pic>> GetPic(long id)
        {
            var pic = await _context.Pic.FindAsync(id);

            if (pic == null)
            {
                return NotFound();
            }

            return pic;
        }

        // PUT: api/Pics/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPic(long id, Pic pic)
        {
            if (id != pic.Id)
            {
                return BadRequest();
            }

            _context.Entry(pic).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PicExists(id))
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

        // POST: api/Pics
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Pic>> PostPic(Pic pic)
        {
            _context.Pic.Add(pic);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPic", new { id = pic.Id }, pic);
        }

        // DELETE: api/Pics/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Pic>> DeletePic(long id)
        {
            var pic = await _context.Pic.FindAsync(id);
            if (pic == null)
            {
                return NotFound();
            }

            _context.Pic.Remove(pic);
            await _context.SaveChangesAsync();

            return pic;
        }

        private bool PicExists(long id)
        {
            return _context.Pic.Any(e => e.Id == id);
        }
    }
}
