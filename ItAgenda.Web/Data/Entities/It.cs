using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ItAgenda.Web.Data.Entities
{
    public class It
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

        [Required]
        [Display(Name = "Email")]
        [MaxLength(100, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        public string Email { get; set; }

        [Required]
        [Display(Name = "Celular")]
        [MaxLength(9, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        public string Celular { get; set; }

        public Empresa Empresa { get; set; }

        public Sistema Sistema { get; set; }

    }
}
