using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RCCWebApi.DTO.DailyRate;
using RCCWebApi.Models;

namespace RCCWebApi.Controllers
{
    [ApiController]
    public class TritDailyRatesController : ControllerBase
    {
        private readonly rasdbContext _context;
        private readonly IMapper mapper;

        public TritDailyRatesController(rasdbContext context, IMapper mapper)
        {
            _context = context;
            this.mapper = mapper;
        }

        // GET: api/TritDailyRates
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TritDailyRate>>> GetTritDailyRates()
        {
          if (_context.TritDailyRates == null)
          {
              return NotFound();
          }
            return await _context.TritDailyRates.ToListAsync();
        }

        //Get: api/TritDailyRates/GetLatestDailyRates
        [HttpGet("GetLatestDailyRates")]
        public async Task<ActionResult<ReadOnlyDailyRates>> GetLatestDailyRates()
        {
            if (_context.TritDailyRates == null)
            {
                return NotFound();
            }
            var result = await _context.TritDailyRates.OrderByDescending(c => c.DailyDate).FirstOrDefaultAsync();
            return mapper.Map<ReadOnlyDailyRates>(result);
        }

        // GET: api/TritDailyRates/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TritDailyRate>> GetTritDailyRate(int id)
        {
          if (_context.TritDailyRates == null)
          {
              return NotFound();
          }
            var tritDailyRate = await _context.TritDailyRates.FindAsync(id);

            if (tritDailyRate == null)
            {
                return NotFound();
            }

            return tritDailyRate;
        }

        // PUT: api/TritDailyRates/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTritDailyRate(int id, TritDailyRate tritDailyRate)
        {
            if (id != tritDailyRate.DailyRateId)
            {
                return BadRequest();
            }

            _context.Entry(tritDailyRate).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TritDailyRateExists(id))
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

        // POST: api/TritDailyRates
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<TritDailyRate>> PostTritDailyRate(TritDailyRate tritDailyRate)
        {
          if (_context.TritDailyRates == null)
          {
              return Problem("Entity set 'rasdbContext.TritDailyRates'  is null.");
          }
            _context.TritDailyRates.Add(tritDailyRate);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTritDailyRate", new { id = tritDailyRate.DailyRateId }, tritDailyRate);
        }

        // DELETE: api/TritDailyRates/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTritDailyRate(int id)
        {
            if (_context.TritDailyRates == null)
            {
                return NotFound();
            }
            var tritDailyRate = await _context.TritDailyRates.FindAsync(id);
            if (tritDailyRate == null)
            {
                return NotFound();
            }

            _context.TritDailyRates.Remove(tritDailyRate);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TritDailyRateExists(int id)
        {
            return (_context.TritDailyRates?.Any(e => e.DailyRateId == id)).GetValueOrDefault();
        }
    }
}
