using EventosAca.API.Data;
using EventosAca.Share.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EventosAca.API.Controllers
{
    [ApiController]
    [Route("/api/programa")]
    public class programEventosController : ControllerBase
    {
        private readonly DataContext _context;

        public programEventosController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult> Get()
        {
            return Ok(await _context.programaEventos.ToListAsync());
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult> Get(int id)
        {
            var programa = await _context.programaEventos.FirstOrDefaultAsync(c => c.Id == id);

            if (programa == null)
            {
                return NotFound();
            }

            return Ok(programa);
        }
        //insertar
        [HttpPost]
        public async Task<ActionResult> Post(ProgramaEvento programaEventos)
        {
            _context.programaEventos.Add(programaEventos);
            await _context.SaveChangesAsync();
            return Ok(programaEventos);
        }
        //actualizar
        [HttpPut]
        public async Task<ActionResult> Put(ProgramaEvento programaEventos)
        {
            _context.programaEventos.Update(programaEventos);
            await _context.SaveChangesAsync();
            return Ok(programaEventos);
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {
            var afectado = await _context.programaEventos.Where(c => c.Id == id).ExecuteDeleteAsync;

            if (afectado == 0)
            {
                return NotFound();
            }

            return NoContent();

        }
    }
}
