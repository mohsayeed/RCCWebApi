using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RCCWebApi.Models;

namespace RCCWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TritOrdersController : ControllerBase
    {
        private readonly rasdbContext _context;

        public TritOrdersController(rasdbContext context)
        {
            _context = context;
        }

        // GET: api/TritOrders
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TritOrder>>> GetTritOrders()
        {
          if (_context.TritOrders == null)
          {
              return NotFound();
          }
            return await _context.TritOrders.ToListAsync();
        }

        // GET: api/TritOrders/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TritOrder>> GetTritOrder(int id)
        {
          if (_context.TritOrders == null)
          {
              return NotFound();
          }
            var tritOrder = await _context.TritOrders.FindAsync(id);

            if (tritOrder == null)
            {
                return NotFound();
            }

            return tritOrder;
        }

        // PUT: api/TritOrders/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTritOrder(int id, TritOrder tritOrder)
        {
            if (id != tritOrder.OrderId)
            {
                return BadRequest();
            }

            _context.Entry(tritOrder).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TritOrderExists(id))
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

        // POST: api/TritOrders
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<TritOrder>> PostTritOrder(TritOrder tritOrder)
        {
          if (_context.TritOrders == null)
          {
              return Problem("Entity set 'rasdbContext.TritOrders'  is null.");
          }
            _context.TritOrders.Add(tritOrder);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTritOrder", new { id = tritOrder.OrderId }, tritOrder);
        }

        // DELETE: api/TritOrders/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTritOrder(int id)
        {
            if (_context.TritOrders == null)
            {
                return NotFound();
            }
            var tritOrder = await _context.TritOrders.FindAsync(id);
            if (tritOrder == null)
            {
                return NotFound();
            }

            _context.TritOrders.Remove(tritOrder);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TritOrderExists(int id)
        {
            return (_context.TritOrders?.Any(e => e.OrderId == id)).GetValueOrDefault();
        }
    }
}
