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
  [Route("[controller]")]
  [ApiController]
  public class HotelsController : ControllerBase
  {
    private readonly AlibabaContext _context;

    public HotelsController(AlibabaContext context)
    {
      _context = context;
    }

    // GET: api/Hotels
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Hotel>>> GetHotel()
    {
      return await _context.Hotel.Include(s => s.Room).Include(s => s.Pic).Include(s => s.Feature).ToListAsync();
    }

    // GET: api/Hotels/5
    [HttpGet("{id}")]
    public async Task<ActionResult<Hotel>> GetHotel(long id)
    {
      var hotel = await _context.Hotel.Include(s=>s.Room).Include(s=>s.Pic).Include(s=> s.Feature).FirstOrDefaultAsync(s=>s.Id==id);

      if (hotel == null)
      {
        return NotFound();
      }

      return hotel;
    }

    [HttpGet("Search")]
    public async Task<ActionResult<List<Hotel>>> SearchHotel([FromQuery]Search search)
    {
      var hotels = await _context.Hotel.Include(s => s.Room).Include(s => s.Pic).Include(s => s.Feature).Where(a =>
      (string.IsNullOrEmpty(search.City) ? true : a.City == search.City) &&
      (string.IsNullOrEmpty(search.Date) ? true : true) &&
      ((search.Adult == 0) ? true : a.Room.Any(r => r.Adult >= search.Adult)) &&
      ((search.Kid == 0) ? true : a.Room.Any(r => r.Kid >= search.Kid))
      ).ToListAsync();

      if (hotels == null)
      {
        return NotFound();
      }

      return hotels;
    }

    // PUT: api/Hotels/5
    // To protect from overposting attacks, enable the specific properties you want to bind to, for
    // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
    [HttpPut("{id}")]
    public async Task<IActionResult> PutHotel(long id, Hotel hotel)
    {
      if (id != hotel.Id)
      {
        return BadRequest();
      }

      _context.Entry(hotel).State = EntityState.Modified;

      try
      {
        await _context.SaveChangesAsync();
      }
      catch (DbUpdateConcurrencyException)
      {
        if (!HotelExists(id))
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

    // POST: api/Hotels
    // To protect from overposting attacks, enable the specific properties you want to bind to, for
    // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
    [HttpPost]
    public async Task<ActionResult<Hotel>> PostHotel(Hotel hotel)
    {
      _context.Hotel.Add(hotel);
      await _context.SaveChangesAsync();

      return CreatedAtAction("GetHotel", new { id = hotel.Id }, hotel);
    }

    // DELETE: api/Hotels/5
    [HttpDelete("{id}")]
    public async Task<ActionResult<Hotel>> DeleteHotel(long id)
    {
      var hotel = await _context.Hotel.FindAsync(id);
      if (hotel == null)
      {
        return NotFound();
      }

      _context.Hotel.Remove(hotel);
      await _context.SaveChangesAsync();

      return hotel;
    }

    private bool HotelExists(long id)
    {
      return _context.Hotel.Any(e => e.Id == id);
    }
  }
}
