using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Dominio.Entity;
using InfraEstrutura;

namespace SistemaRecrutadores.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TecnologiasController : ControllerBase
    {
        private readonly SistemaDbContext _context;

        public TecnologiasController(SistemaDbContext context)
        {
            _context = context;
        }

        // GET: api/Tecnologias
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Tecnologia>>> GetTecnologias()
        {
          if (_context.Tecnologias == null)
          {
              return NotFound();
          }
            return await _context.Tecnologias.ToListAsync();
        }

        // GET: api/Tecnologias/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Tecnologia>> GetTecnologia(int id)
        {
          if (_context.Tecnologias == null)
          {
              return NotFound();
          }
            var tecnologia = await _context.Tecnologias.FindAsync(id);

            if (tecnologia == null)
            {
                return NotFound();
            }

            return tecnologia;
        }

        // PUT: api/Tecnologias/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTecnologia(int id, Tecnologia tecnologia)
        {
            if (id != tecnologia.Id)
            {
                return BadRequest();
            }

            _context.Entry(tecnologia).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TecnologiaExists(id))
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

        // POST: api/Tecnologias
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Tecnologia>> PostTecnologia(Tecnologia tecnologia)
        {
          if (_context.Tecnologias == null)
          {
              return Problem("Entity set 'SistemaDbContext.Tecnologias'  is null.");
          }
            _context.Tecnologias.Add(tecnologia);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTecnologia", new { id = tecnologia.Id }, tecnologia);
        }

        // DELETE: api/Tecnologias/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTecnologia(int id)
        {
            if (_context.Tecnologias == null)
            {
                return NotFound();
            }
            var tecnologia = await _context.Tecnologias.FindAsync(id);
            if (tecnologia == null)
            {
                return NotFound();
            }

            _context.Tecnologias.Remove(tecnologia);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TecnologiaExists(int id)
        {
            return (_context.Tecnologias?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
