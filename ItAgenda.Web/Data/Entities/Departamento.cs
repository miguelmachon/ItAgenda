using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ItAgenda.Web.Data.Entities
{
    public class Departamento
    {

        public int Id { get; set; }

        [Display(Name = "Nombre Departamento")]
        [MaxLength(50, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]

        public string Nombre { get; set; }


        public ICollection<Empleado> Empleados { get; set; }

    }
}
