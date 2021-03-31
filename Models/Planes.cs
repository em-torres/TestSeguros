using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AfiliadosTest.Models
{
    public class Planes
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Inserte un plan adecuado")]
        [MaxLength(120, ErrorMessage = "El campo {0} debe tener una longitud máxima de {1} caracteres")]
        public string Plan { get; set; }
        
        [DisplayName("Monto de Cobertura")]
        public decimal MontoCobertura { get; set; }

        [Required(ErrorMessage = "Elija una fecha")]
        [DisplayName("Fecha de Registro")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? FechaRegistro { get; set; }

        [Required]
        public int? EstatusID { get; set; }

        public virtual Estatus Estatus { get; set; }

        public virtual ICollection<Afiliados> AfiliadosPlan { get; set; }
    }
}