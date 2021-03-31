using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AfiliadosTest.Models
{
    public class Estatus
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Seleccione un Estado Correspondiente")]
        [DisplayName("Estatus")]
        public string Estado { get; set; }
    }
}