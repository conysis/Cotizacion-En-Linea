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

        [Column(TypeName = "nvarchar(9)")]
        [Required(ErrorMessage = "Este campo es obligatorio")]
        [DisplayName("Expediente Nº")]
        [MaxLength(9, ErrorMessage = "Máximo 9 caracteres")]
        public string Expediente { get; set; }

        [Column(TypeName = "nvarchar(10)")]
        [Required(ErrorMessage = "Este campo es obligatorio")]
        [DisplayName("Fecha Creación")]
        [MaxLength(10, ErrorMessage = "Máximo 10 caracteres")]
        public string FecCreacion { get; set; }

        [Column(TypeName = "nvarchar(10)")]
        [Required(ErrorMessage = "Este campo es obligatorio")]
        [DisplayName("Fecha Apertura")]
        [MaxLength(10, ErrorMessage = "Máximo 10 caracteres")]
        public string FecApertura { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio")]
        [DisplayName("Id Proveedor")]
        public int IdProveedor { get; set; }
    }
}
