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
  public class UsersController : ControllerBase
  {
    private readonly AlibabaContext _context;

    public UsersController(AlibabaContext context)
    {
      _context = context;
    }

    // GET: api/Users
    [HttpGet]
    public async Task<ActionResult<IEnumerable<User>>> GetTodoItems()
    {
      return await _context.User.ToListAsync();
    }

    // GET: api/Users/5
    [HttpGet("{id}")]
    public async Task<ActionResult<User>> GetUser(long id)
    {
      var user = (await _context.User.Where(a => a.Id == id).Include(s => s.Hotel).FirstOrDefaultAsync());

      if (user == null)
      {
        return NotFound();
      }

      return Ok(user);
    }

    // PUT: api/Users/5
    // To protect from overposting attacks, enable the specific properties you want to bind to, for
    // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
    [HttpPut("{id}")]
    public async Task<IActionResult> PutUser(long id, User user)
    {
      if (id != user.Id)
      {
        return BadRequest();
      }

      _context.Entry(user).State = EntityState.Modified;

      try
      {
        await _context.SaveChangesAsync();
      }
      catch (DbUpdateConcurrencyException)
      {
        if (!UserExists(id))
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

    [HttpPost("Login")]
    public async Task<ActionResult<User>> PostLogin(login login)
    {
      var a = await _context.User.Where(e => (e.Mobile == login.username || e.Email == login.username) && e.Password == login.password).FirstOrDefaultAsync();
      if (a == null)
      {
        return NotFound();
      }

      return a;
    }

    // POST: api/Users
    // To protect from overposting attacks, enable the specific properties you want to bind to, for
    // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
    [HttpPost]
    public async Task<ActionResult<User>> PostUser(User user)
    {
      _context.User.Add(user);
      await _context.SaveChangesAsync();

      return CreatedAtAction("GetUser", new { id = user.Id }, user);
    }

    // DELETE: api/Users/5
    [HttpDelete("{id}")]
    public async Task<ActionResult<User>> DeleteUser(long id)
    {
      var user = await _context.User.FindAsync(id);
      if (user == null)
      {
        return NotFound();
      }

      _context.User.Remove(user);
      await _context.SaveChangesAsync();

      return user;
    }

    private bool UserExists(long id)
    {
      return _context.User.Any(e => e.Id == id);
    }
  }
}
