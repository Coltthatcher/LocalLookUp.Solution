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

    // GET api/animals
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Town>>> Get()
    {
      return await _db.Towns.ToListAsync();
    }

    // POST api/animals
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
  }
}


