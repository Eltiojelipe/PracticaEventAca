using EventosAca.API.Data;
using EventosAca.Share.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Data.SqlTypes;

namespace EventosAca.API.Controllers
{
    [ApiController]
    [Route("/api/eventos")]
    public class eventosController:ControllerBase
    {
        private readonly DataContext _context;

        public eventosController (DataContext context)
        {
            _context = context; 
        }

        [HttpGet]
        public async Task <ActionResult> Get()
        {
            return Ok(await _context.eventos.ToListAsync());
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult> Get(int id)
        {
            var eventos = await _context.eventos.FirstOrDefaultAsync(c=> c.Id == id);

            if(eventos == null)
            {
                return NotFound();
            }

            return Ok(eventos);
        }
        //insertar
        [HttpPost]
        public async Task<ActionResult> Post(EventoAcademico eventos)
        {
            _context.eventos.Add(eventos);
            await _context.SaveChangesAsync();  
            return Ok(eventos);
        }
        //actualizar
        [HttpPut]
        public async Task<ActionResult> Put(EventoAcademico eventos)
        {
            _context.eventos.Update(eventos);
            await _context.SaveChangesAsync();
            return Ok(eventos);
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {
            var afectado = await _context.eventos.Where(c => c.Id == id).ExecuteDeleteAsync;

            if (afectado == 0)
            {
                return NotFound();
            }

            return NoContent();
            
        }
    }
}
