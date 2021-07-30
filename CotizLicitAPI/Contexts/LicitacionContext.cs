using CotizLicitAPI.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CotizLicitAPI.Contexts
{
    public class LicitacionContext : DbContext
    {
        public LicitacionContext(DbContextOptions<LicitacionContext> options):base(options)
        {
            
        }
        public DbSet<Licitacion> Licitacions { get; set; }
        public DbSet<CotizLicitAPI.Models.Cotizacion> Cotizacion { get; set; }
        public DbSet<CotizLicitAPI.Models.Proveedor> Proveedor { get; set; }
        public DbSet<CotizLicitAPI.Models.Usuario> Usuario { get; set; }
        public DbSet<CotizLicitAPI.Models.LinsxCotiz> LinsxCotiz { get; set; }
        public DbSet<CotizLicitAPI.Models.LinsxLicit> LinsxLicit { get; set; }
    }
}
