using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace ItAgenda.Web.Data.Entities
{
    public class Usuario : IdentityUser
    {

        [Required]
        [Display(Name = "Nombre")]
        [MaxLength(50, ErrorMessage = "The {0} field can not have more than {1} characters.")]

        public string Nombre { get; set; }

        [Required]
        [Display(Name = "Apellido")]
        [MaxLength(50, ErrorMessage = "The {0} field can not have more than {1} characters.")]

        public string Apellido { get; set; }


    }
}
