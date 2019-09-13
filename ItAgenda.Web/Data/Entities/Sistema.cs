using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ItAgenda.Web.Data.Entities
{
    public class Sistema
    {

        public int Id { get; set; }

        [Required]
        [Display(Name = "")]
        [MaxLength(50, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        public string Nombre { get; set; }


        public ICollection<It> Its { get; set; }


    }
}
