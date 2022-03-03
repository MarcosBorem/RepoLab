using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ApiPostgreSql.Models;
using System.Security.Claims;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Text;

namespace ApiPostgreSql.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoguinsController : ControllerBase
    {
        private readonly ApiPostgreSqlContext _context;

        public LoguinsController(ApiPostgreSqlContext context)
        {
            _context = context;
        }

        // GET: api/Loguins
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Loguin>>> GetLoguins()
        {
            return await _context.Loguins.ToListAsync();
        }

        // GET: api/Loguins/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Loguin>> GetLoguin(int id)
        {
            var loguin = await _context.Loguins.FindAsync(id);

            if (loguin == null)
            {
                return NotFound();
            }

            return loguin;
        }

        // PUT: api/Loguins/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutLoguin(int id, Loguin loguin)
        {
            if (id != loguin.Id)
            {
                return BadRequest();
            }

            _context.Entry(loguin).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LoguinExists(id))
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

        // POST: api/Loguins
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Loguin>> PostLoguin(Loguin loguin)
        {
            _context.Loguins.Add(loguin);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (LoguinExists(loguin.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetLoguin", new { id = loguin.Id }, loguin);
        }

     

        // DELETE: api/Loguins/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteLoguin(int id)
        {
            var loguin = await _context.Loguins.FindAsync(id);
            if (loguin == null)
            {
                return NotFound();
            }

            _context.Loguins.Remove(loguin);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool LoguinExists(int id)
        {
            return _context.Loguins.Any(e => e.Id == id);
        }
    }
}
