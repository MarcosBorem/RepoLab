using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using MySql.Data.MySqlClient;
using Npgsql;
using WebApplication1.Models;


namespace WebApplication1.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]


    public class UsuariomysqlsController : ControllerBase
    {
        private readonly bancotesteContext _context;

        public UsuariomysqlsController(bancotesteContext context)
        {
            _context = context;
        }

        // GET: api/Usuariomysqls
        
        [HttpGet]
        
        public async Task<ActionResult<IEnumerable<Usuariomysql>>> GetUsuariomysqlsAsync()
        {
            return await _context.Usuariomysqls.ToListAsync();
        }

        // GET: api/Usuariomysqls/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Usuariomysql>> GetUsuariomysqlAsync(int id)
        {
            var usuariomysql = await _context.Usuariomysqls.FindAsync(id);

            if (usuariomysql == null)
            {
                return NotFound();
            }

            return usuariomysql;
        }

        // PUT: api/Usuariomysqls/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutUsuariomysqlAsync(int id, Usuariomysql usuariomysql)

        {
               
            if (id != usuariomysql.Id)
            {
                return BadRequest();
            }

            _context.Entry(usuariomysql).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UsuariomysqlExists(id))
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

        // POST: api/Usuariomysqls
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        
        public async Task<ActionResult<Usuariomysql>> PostUsuariomysqlAsync(Usuariomysql usuariomysql)
        {
            _context.Usuariomysqls.Add(usuariomysql);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetUsuariomysql", new { id = usuariomysql.Id }, usuariomysql);
        }

        // DELETE: api/Usuariomysqls/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUsuariomysqlAsync(int id)
        {
            var usuariomysql = await _context.Usuariomysqls.FindAsync(id);
            if (usuariomysql == null)
            {
                return NotFound();
            }

            _context.Usuariomysqls.Remove(usuariomysql);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool UsuariomysqlExists(int id)
        {
            return _context.Usuariomysqls.Any(e => e.Id == id);
        }
      
    }

    
}
