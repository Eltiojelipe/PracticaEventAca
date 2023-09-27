using Microsoft.EntityFrameworkCore;
using EventosAca.Share.Entities;

namespace EventosAca.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }
        public DbSet<EventoAcademico> eventos { get; set; }
        public DbSet<Participantes> participante { get; set; }
        public DbSet<programaEvento> programaEventos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }

    }



