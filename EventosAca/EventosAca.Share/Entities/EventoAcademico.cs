using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace EventosAca.Share.Entities
{
    public class EventoAcademico
    {

        public int Id { get; set; }

        [Display (Name= "Evento Academico")]
        [MaxLength (80, ErrorMessage = "El campo {0} debe contener solo 80 caracteres")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public string? Name { get; set; }

        public string? Description { get; set; }

        public int? AcademicoId { get; set; }

        public string fechaInicio { get; set; }

        public string fechaOut { get;set; }

        public string ubicacion { get; set; }   


    }
}
