using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventosAca.Share.Entities
{
    public class Participantes
    {

        public int Id { get; set; }

        [Display(Name = "Participantes")]
        [MaxLength(80, ErrorMessage = "El campo {0} debe contener solo 80 caracteres")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public string? Name { get; set; }



    }
}
