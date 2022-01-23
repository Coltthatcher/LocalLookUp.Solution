using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using LocalLookUp.Models;
using Microsoft.EntityFrameworkCore;

namespace LocalLookUp.Controllers
{
[Route("api/[controller]")]
  [ApiController]
  public class TownsController : ControllerBase
  {
    private readonly LocalLookUpContext _db;

    public TownsController(LocalLookUpContext db)
    {
      _db = db;
    }

    // GET api/towns
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Town>>> Get(string restaurant, string shop)
    {
      var query = _db.Towns.AsQueryable();

      if (restaurant != null)
      {
        query = query.Where(entry => entry.Restaurant == restaurant);
      }
      if (shop != null)
      {
        query = query.Where(entry => entry.Shop == shop);
      }      

      return await query.ToListAsync();
    }

    // POST api/towns
    [HttpPost]
    public async Task<ActionResult<Town>> Post(Town town)
    {
      _db.Towns.Add(town);
      await _db.SaveChangesAsync();

      return CreatedAtAction(nameof(GetTown), new { id = town.TownId }, town);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Town>> GetTown(int id)
    {
      var town = await _db.Towns.FindAsync(id);

      if (town == null)
      {
          return NotFound();
      }

      return town;
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Put(int id, Town town)
    {
      if (id != town.TownId)
      {
        return BadRequest();
      }

      _db.Entry(town).State = EntityState.Modified;

      try
      {
        await _db.SaveChangesAsync();
      }
      catch (DbUpdateConcurrencyException)
      {
        if (!TownExists(id))
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

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteTown(int id)
    {
      var town = await _db.Towns.FindAsync(id);
      if (town == null)
      {
        return NotFound();
      }

      _db.Towns.Remove(town);
      await _db.SaveChangesAsync();

      return NoContent();
    }

    private bool TownExists(int id)
      {
        return _db.Towns.Any(e => e.TownId == id);
      }
  }
}


