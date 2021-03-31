using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AfiliadosTest.Models
{
    public class Afiliados
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Inserte un nombre adecuado")]
        [MaxLength(120, ErrorMessage = "El campo {0} debe tener una longitud máxima de {1} caracteres")]
        [DisplayName("Nombres")]
        public string Nombres { get; set; }

        [Required(ErrorMessage = "Inserte un apellido adecuado")]
        [MaxLength(120, ErrorMessage = "El campo {0} debe tener una longitud máxima de {1} caracteres")]
        [DisplayName("Apellidos")]
        public string Apellidos { get; set; }

        [DisplayName("Fecha de Nacimiento")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime FechaNacimiento { get; set; }

        public bool Sexo { get; set; }

        [Required(ErrorMessage = "Inserte una Cédula")]
        public int Cedula { get; set; }

        [DisplayName("Numero del Seguro Social")]
        public int SeguridadSocial { get; set; }

        [Required(ErrorMessage = "Escoja una fecha")]
        [DisplayName("Fecha de Registro")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? FechaRegistro { get; set; }

        [DisplayName("Monto Consumido")]
        public decimal MontoConsumido { get; set; }

        [Required]
        [DisplayName("Planes")]
        public int? PlanesID { get; set; }

        [Required]
        [DisplayName("Estatus")]
        public int? EstatusID { get; set; }

        

        public virtual Planes Planes { get; set; }
        public virtual Estatus Estatus { get; set; }
    }
}