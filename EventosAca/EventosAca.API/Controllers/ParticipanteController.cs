using EventosAca.API.Data;
using EventosAca.Share.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EventosAca.API.Controllers
{
    [ApiController]
    [Route("/api/participante")]
    public class participanteController : ControllerBase
    {
        private readonly DataContext _context;

        public participanteController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult> Get()
        {
            return Ok(await _context.participante.ToListAsync());
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult> Get(int id)
        {
            var participante = await _context.participante.FirstOrDefaultAsync(c => c.Id == id);

            if (participante == null)
            {
                return NotFound();
            }

            return Ok(participante);
        }
        //insertar
        [HttpPost]
        public async Task<ActionResult> Post(Participantes participante)
        {
            _context.participante.Add(participante);
            await _context.SaveChangesAsync();
            return Ok(participante);
        }
        //actualizar
        [HttpPut]
        public async Task<ActionResult> Put(Participantes participante)
        {
            _context.participante.Update(participante);
            await _context.SaveChangesAsync();
            return Ok(participante);
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {

            if (afectado == 0)
            {
                return NotFound();
            }

            return NoContent();

        }
    }
}
