using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ItAgenda.Web.Data.Entities
{
    public class Empresa
    {

        public int Id { get; set; }

        [Required]
        [Display(Name = "Nombre")]
        [MaxLength(100, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        public string Nombre { get; set; }

        [Required]
        [Display(Name = "Razon Social")]
        [MaxLength(100, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        public string RazonSocial { get; set; }

        [Required]
        [Display(Name = "NIT")]
        [MaxLength(15, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        public string Nit { get; set; }

        [Required]
        [Display(Name = "NRC")]
        [MaxLength(20, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        public string Nrc { get; set; }

        [Required]
        [Display(Name = "Telefono")]
        [MaxLength(9, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        public string Telefono { get; set; }

        [Required]
        [Display(Name = "Direccion")]
        [MaxLength(100, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        public string Direccion { get; set; }


        [Required]
        [Display(Name = "Email")]
        [DataType(DataType.EmailAddress)]
        [MaxLength(100, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        public int Email { get; set; }


        public ICollection<It> Its { get; set; }






    }
}
