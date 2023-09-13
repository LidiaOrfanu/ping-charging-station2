using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Server.Api.Models;

namespace Server.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChargingStations : ControllerBase
    {
        private readonly DbContext _context;

        public ChargingStations(DbContext context)
        {
            _context = context;
        }

        // GET: api/ChargingStations
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ChargingStation>>> GetChargingStation()
        {
          if (_context.ChargingStations == null)
          {
              return NotFound();
          }
            return await _context.ChargingStations.ToListAsync();
        }

        // GET: api/ChargingStations/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ChargingStation>> GetChargingStation(int id)
        {
          if (_context.ChargingStations == null)
          {
              return NotFound();
          }
            var chargingStation = await _context.ChargingStations.FindAsync(id);

            if (chargingStation == null)
            {
                return NotFound();
            }

            return chargingStation;
        }

        // PUT: api/ChargingStations/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutChargingStation(int id, ChargingStation chargingStation)
        {
            if (id != chargingStation.StationId)
            {
                return BadRequest();
            }

            _context.Entry(chargingStation).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ChargingStationExists(id))
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

        // POST: api/ChargingStations
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ChargingStation>> PostChargingStation(ChargingStation chargingStation)
        {
          if (_context.ChargingStations == null)
          {
              return Problem("Entity set 'DbContext.ChargingStation'  is null.");
          }
            _context.ChargingStations.Add(chargingStation);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetChargingStation", new { id = chargingStation.StationId }, chargingStation);
        }

        // DELETE: api/ChargingStations/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteChargingStation(int id)
        {
            if (_context.ChargingStations == null)
            {
                return NotFound();
            }
            var chargingStation = await _context.ChargingStations.FindAsync(id);
            if (chargingStation == null)
            {
                return NotFound();
            }

            _context.ChargingStations.Remove(chargingStation);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ChargingStationExists(int id)
        {
            return (_context.ChargingStations?.Any(e => e.StationId == id)).GetValueOrDefault();
        }
    }
}
