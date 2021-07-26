using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CotizLicitAPI.Models
{
    public class Licitacion
    {
        [Key]
        public int Id { get; set; }

        [Column(TypeName = "nvarchar(9)")]
        [Required]
        public string Expediente { get; set; }

        [Column(TypeName = "nvarchar(10)")]
        public string FecCreacion { get; set; }

        [Column(TypeName = "nvarchar(10)")]
        public string FecApertura { get; set; }

        public int IdProveedor { get; set; }
    }
}
