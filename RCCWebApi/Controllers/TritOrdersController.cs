using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
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
        private readonly IMapper mapper;

        public TritOrdersController(rasdbContext context, IMapper mapper)
        {
            _context = context;
            this.mapper = mapper;
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
        [HttpGet("isOrderPresent")]
        public async Task<ActionResult> GetIsOrderPresent(int userid, DateTime date)
        {

            if (_context.TritOrders == null)
            {
                return NotFound();
            }
            var isOrderPresent = await _context.TritOrders.Where(x => x.UserId == userid && x.OrderDate == date).FirstOrDefaultAsync();

            if (isOrderPresent == null)
            {
                return StatusCode(StatusCodes.Status200OK, new { message = "Please Order Now !!" , isOrderPresent=false });
            }
            else
            {
                return StatusCode(StatusCodes.Status200OK, new { message = "Already Ordered",order = isOrderPresent , isOrderPresent=true });
            }
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
        [HttpPost("enterorder")]

        public async Task<IActionResult> PostNewUpdateOrder(int id, TritOrder tritOrder , DateTime date)
        {
            if (id != tritOrder.UserId)
            {
                return BadRequest();
            }

            TritOrder? tritOrder1 = await _context.TritOrders.Where(c => c.UserId == id && c.OrderDate == date).FirstOrDefaultAsync();
            var isOrderPresent = tritOrder1;
            if (isOrderPresent!=null)

            {
                isOrderPresent.OrderCages = tritOrder.OrderCages;
                isOrderPresent.OrderDate = tritOrder.OrderDate;
                isOrderPresent.UpdatedDt = tritOrder.UpdatedDt;
                isOrderPresent.UpdatedBy = tritOrder.UpdatedBy;
                _context.Entry(isOrderPresent).State = EntityState.Modified;

            }
            else
            {
                _context.TritOrders.Add(tritOrder);
                await _context.SaveChangesAsync();
                return CreatedAtAction("GetTritOrder", new { id = tritOrder.UserId }, tritOrder);

            }

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
