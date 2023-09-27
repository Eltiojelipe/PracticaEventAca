using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventosAca.Share.Entities
{
    public class ProgramaEvento
    {
        public int Id { get; set; }
        public int EventoAcademicoId { get; set; }
        public DateTime Fecha { get; set; }
        public string HoraInicio { get; set; }
        public string HoraFin { get; set; }
        public string NombreSesion { get; set; }
        public string Descripcion { get; set; }
        public string Nombreponente { get; set; }
        public string AfiliacionInstitucional { get; set; }


    }


}
