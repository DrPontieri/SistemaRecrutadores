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
    public class TipoTecnologiasController : ControllerBase
    {
        private readonly SistemaDbContext _context;

        public TipoTecnologiasController(SistemaDbContext context)
        {
            _context = context;
        }

        // GET: api/TipoTecnologias
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TipoTecnologia>>> GetTipoTecnologias()
        {
          if (_context.TipoTecnologias == null)
          {
              return NotFound();
          }
            return await _context.TipoTecnologias.ToListAsync();
        }

        // GET: api/TipoTecnologias/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TipoTecnologia>> GetTipoTecnologia(int id)
        {
          if (_context.TipoTecnologias == null)
          {
              return NotFound();
          }
            var tipoTecnologia = await _context.TipoTecnologias.FindAsync(id);

            if (tipoTecnologia == null)
            {
                return NotFound();
            }

            return tipoTecnologia;
        }

        // PUT: api/TipoTecnologias/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTipoTecnologia(int id, TipoTecnologia tipoTecnologia)
        {
            if (id != tipoTecnologia.Id)
            {
                return BadRequest();
            }

            _context.Entry(tipoTecnologia).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TipoTecnologiaExists(id))
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

        // POST: api/TipoTecnologias
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<TipoTecnologia>> PostTipoTecnologia(TipoTecnologia tipoTecnologia)
        {
          if (_context.TipoTecnologias == null)
          {
              return Problem("Entity set 'SistemaDbContext.TipoTecnologias'  is null.");
          }
            _context.TipoTecnologias.Add(tipoTecnologia);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTipoTecnologia", new { id = tipoTecnologia.Id }, tipoTecnologia);
        }

        // DELETE: api/TipoTecnologias/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTipoTecnologia(int id)
        {
            if (_context.TipoTecnologias == null)
            {
                return NotFound();
            }
            var tipoTecnologia = await _context.TipoTecnologias.FindAsync(id);
            if (tipoTecnologia == null)
            {
                return NotFound();
            }

            _context.TipoTecnologias.Remove(tipoTecnologia);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TipoTecnologiaExists(int id)
        {
            return (_context.TipoTecnologias?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
