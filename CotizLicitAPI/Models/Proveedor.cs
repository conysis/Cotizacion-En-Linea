using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CotizLicitAPI.Models
{
    public class Proveedor
    {
        [Key]
        public int Id { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        [Required]
        public string Nombre { get; set; }

        [Required]
        public DateTime FecCreacion { get; set; }

        [Required]
        public DateTime FecApertura { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        [Required]
        public string RazonSocial { get; set; }

        public List<Licitacion> Licitaciones { get; set; }

        public List<Usuario> Usuarios { get; set; }

    }
}
