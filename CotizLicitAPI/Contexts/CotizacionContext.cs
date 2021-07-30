using CotizLicitAPI.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CotizLicitAPI.Contexts
{
    public class CotizacionContext : DbContext
    {
        public CotizacionContext(DbContextOptions<CotizacionContext> options):base(options)
        {

        }
        public DbSet<Cotizacion> Cotizacions { get; set; }
    }
}
