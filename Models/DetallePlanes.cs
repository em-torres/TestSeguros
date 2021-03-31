using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AfiliadosTest.Models
{
    [Table("Detalle_Planes")]
    public class DetallePlanes
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PlanesID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int AfiliadosID { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Cedula { get; set; }
        public string MontoConsumido { get; set; }
        public string AfiliadosEstatusEstado { get; set; }


        public virtual Afiliados Afiliados { get; set; }
        public virtual Planes Planes { get; set; }
        public virtual Estatus Estatus { get; set; }
    }
}