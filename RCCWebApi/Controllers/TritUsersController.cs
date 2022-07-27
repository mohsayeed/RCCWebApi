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
    public class TritUsersController : ControllerBase
    {
        private readonly rasdbContext _context;

        public TritUsersController(rasdbContext context)
        {
            _context = context;
        }


        // GET: api/TritUsers/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TritUser>> GetTritUser(int id)
        {
          if (_context.TritUsers == null)
          {
              return NotFound();
          }
            var tritUser = await _context.TritUsers.FindAsync(id);

            if (tritUser == null)
            {
                return NotFound();
            }
            return StatusCode(StatusCodes.Status200OK, new { userName = tritUser.UserName});
        }

        // PUT: api/TritUsers/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
       

        private bool TritUserExists(int id)
        {
            return (_context.TritUsers?.Any(e => e.UserId == id)).GetValueOrDefault();
        }
    }
}
