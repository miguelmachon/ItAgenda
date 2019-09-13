using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ItAgenda.Web.Data.Entities
{
    public class RequerimientoDetalle
    {

        public int Id { get; set; }

        [Required]
        [Display(Name = "Detalle Requerimiento")]
        [MaxLength(50, ErrorMessage = "The {0} field can not have more than {1} characters.")]

        public int Detalle { get; set; }

        public Requerimento Requerimento { get; set; }


    }
}
