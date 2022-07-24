using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RCCWebApi.DTO.MobileLogin;
using RCCWebApi.Models;

namespace RCCWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TritMobileLoginsController : ControllerBase
    {
        private readonly rasdbContext _context;
        private readonly IMapper mapper;

        public TritMobileLoginsController(rasdbContext context , IMapper mapper )
        {
            _context = context;
            this.mapper = mapper;
        }

        // GET: api/TritMobileLogins
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ReadOnlyMobileLoginDto>>> GetTritMobileLogins()
        {
          if (_context.TritMobileLogins == null)
          {
              return NotFound();
          }
            var TritMobileLogins =  await _context.TritMobileLogins.ToListAsync();
            var ReadOnlyMobileLoginDto = mapper.Map < IEnumerable < ReadOnlyMobileLoginDto >> (TritMobileLogins);
            return Ok(ReadOnlyMobileLoginDto);
        }

        // GET: api/TritMobileLogins/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TritMobileLogin>> GetTritMobileLogin(int id)
        {
          if (_context.TritMobileLogins == null)
          {
              return NotFound();
          }
            var tritMobileLogin = await _context.TritMobileLogins.FindAsync(id);

            if (tritMobileLogin == null)
            {
                return NotFound();
            }

            return tritMobileLogin;
        }

        //GET : api/TritMobileLogins/details?username=1&password=sayeed
        [HttpGet("details")]
        public async Task<ActionResult<ReadOnlyMobileLoginDto>> GetTritMobileLoginAuthenticate(string UserName, string Password)
        {
            if (_context.TritMobileLogins == null)
            {
                return NotFound();
            }
            var tritMobileLogin = await _context.TritMobileLogins.Where(x => x.UserName == UserName && x.Password == Password).FirstOrDefaultAsync();

            if (tritMobileLogin == null)
            {
                return StatusCode(StatusCodes.Status401Unauthorized, new { message = "Invalid username or password" });
            }
            var ReadOnlytritMobileLogin = mapper.Map<ReadOnlyMobileLoginDto>(tritMobileLogin);
            return ReadOnlytritMobileLogin;
        }


       // PUT: api/TritMobileLogins/5
         //To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTritMobileLogin(int id, UpdatePassword tritMobileLogin)
        {
            if (id != tritMobileLogin.MobileLoginId)
            {
                return BadRequest();
            }
            var tritMobileLoginReset = mapper.Map<TritMobileLogin>(tritMobileLogin);
            _context.Entry(tritMobileLoginReset).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TritMobileLoginExists(id))
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

        // POST: api/TritMobileLogins
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<TritMobileLogin>> PostTritMobileLogin(TritMobileLogin tritMobileLogin)
        {
          if (_context.TritMobileLogins == null)
          {
              return Problem("Entity set 'rasdbContext.TritMobileLogins'  is null.");
          }
            _context.TritMobileLogins.Add(tritMobileLogin);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTritMobileLogin", new { id = tritMobileLogin.MobileLoginId }, tritMobileLogin);
        }

        // DELETE: api/TritMobileLogins/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTritMobileLogin(int id)
        {
            if (_context.TritMobileLogins == null)
            {
                return NotFound();
            }
            var tritMobileLogin = await _context.TritMobileLogins.FindAsync(id);
            if (tritMobileLogin == null)
            {
                return NotFound();
            }

            _context.TritMobileLogins.Remove(tritMobileLogin);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TritMobileLoginExists(int id)
        {
            return (_context.TritMobileLogins?.Any(e => e.MobileLoginId == id)).GetValueOrDefault();
        }
    }
}
