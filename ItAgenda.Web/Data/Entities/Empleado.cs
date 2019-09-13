using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ItAgenda.Web.Data.Entities
{
    public class Empleado
    {

        public int Id { get; set; }

        [Required]
        [Display(Name = "Nombre")]
        [MaxLength(50, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        public string Nombre { get; set; }

        [Required]
        [Display(Name = "Apellido")]
        [MaxLength(50, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        public string Apellido { get; set; }


        public Departamento  Departamento { get; set; }

        public ICollection<Requerimento> Requerimentos { get; set; }


    }
}
