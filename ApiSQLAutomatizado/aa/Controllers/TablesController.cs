using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using aa.Models;

namespace aa.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TablesController : ControllerBase
    {
        private readonly TesteDbContext _context;

        public TablesController(TesteDbContext context)
        {
            _context = context;
        }

        // GET: api/Tables
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Table>>> GetTable()
        {
            return await _context.Table.ToListAsync();
        }

        // GET: api/Tables/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Table>> GetTable(int id)
        {
            var table = await _context.Table.FindAsync(id);

            if (table == null)
            {
                return NotFound();
            }

            return table;
        }

        // PUT: api/Tables/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTable(int id, Table table)
        {
            if (id != table.Id)
            {
                return BadRequest();
            }

            _context.Entry(table).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TableExists(id))
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

        // POST: api/Tables
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Table>> PostTable(Table table)
        {
            _context.Table.Add(table);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TableExists(table.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTable", new { id = table.Id }, table);
        }

        // DELETE: api/Tables/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Table>> DeleteTable(int id)
        {
            var table = await _context.Table.FindAsync(id);
            if (table == null)
            {
                return NotFound();
            }

            _context.Table.Remove(table);
            await _context.SaveChangesAsync();

            return table;
        }

        private bool TableExists(int id)
        {
            return _context.Table.Any(e => e.Id == id);
        }
    }
}
