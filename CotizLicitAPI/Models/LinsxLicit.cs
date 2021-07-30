using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CotizLicitAPI.Models
{
    public class LinsxLicit
    {
        public enum UnidadesMedida
        {
            Metro,
            Unidad,
            Litro
        }
        [Key]
        public int Id { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(150)")]
        public string Detalle { get; set; }

        public UnidadesMedida UnidadMedida { get; set; }

        [Required]
        [Column(TypeName = "decimal(10,2)")]
        public decimal Precio { get; set; }

        [Required]
        public int Cantidad { get; set; }

    }
}
