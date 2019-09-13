using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ItAgenda.Web.Data.Entities
{
    public class Requerimento
    {

        public int Id { get; set; }


        [Display(Name = "Fecha Creacion")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd HH:mm}", ApplyFormatInEditMode = true)]
        public DateTime FechaCreacion { get; set; }

        [Display(Name = "Fecha Creacion")]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd HH:mm}")]
        public DateTime FechaCreacionToLocal => FechaCreacion.ToLocalTime();

        [Display(Name = "Fecha Aprobacion")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd HH:mm}", ApplyFormatInEditMode = true)]
        public DateTime  FechaAprobacion { get; set; }

        [Display(Name = "Fecha Aprobacion")]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd HH:mm}")]
        public DateTime FechaAprobacionToLocal => FechaAprobacion.ToLocalTime();

        public Empleado Empleado  { get; set; }

        public TipoPrioridad TipoPrioridad { get; set; }
        public ICollection<RequerimientoDetalle> RequerimientoDetalles { get; set; }



    }
}
