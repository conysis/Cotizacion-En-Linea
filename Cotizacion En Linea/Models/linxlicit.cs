//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cotizacion_En_Linea.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class linxlicit
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public linxlicit()
        {
            this.linxcotiz = new HashSet<linxcotiz>();
        }
    
        public int id { get; set; }
        public int codigo { get; set; }
        public int cantidad { get; set; }
        public string detalle { get; set; }
        public int unidadMedida { get; set; }
        public int idLicitacion { get; set; }
    
        public virtual licitaciones licitaciones { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<linxcotiz> linxcotiz { get; set; }
    }
}