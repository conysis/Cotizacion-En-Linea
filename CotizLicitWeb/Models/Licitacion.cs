using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;

namespace CotizLicitWeb.Models
{
    public class Licitacion
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio")]
        [DisplayName("Expediente Nº")]
        [MaxLength(9, ErrorMessage = "Máximo 9 caracteres")]
        public string Expediente { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio")]
        [DisplayName("Fecha Creación")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime FecCreacion { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio")]
        [DisplayName("Fecha Apertura")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime FecApertura { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio")]
        [DisplayName("Id Proveedor")]
        public int IdProveedor { get; set; }
    }
}
