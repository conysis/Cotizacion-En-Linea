using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace CotizLicitWeb.Areas.Identity.Data
{
    // Add profile data for application users by adding properties to the CotizLicitWebUser class
    public class CotizLicitWebUser : IdentityUser

    {
        [PersonalData]
        [Column(TypeName ="nvarchar(25)")]
        public string DocId { get; set; }

        [PersonalData]
        [Column(TypeName = "nvarchar(100)")]
        public string Nombre { get; set; }

        [PersonalData]
        [Column(TypeName = "nvarchar(100)")]
        public string Apellido1 { get; set; }

        [PersonalData]
        [Column(TypeName = "nvarchar(100)")]
        public string Apellido2 { get; set; }

        [PersonalData]
        public int IdProveedor { get; set; }
    }
}
