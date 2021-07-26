using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CotizLicitWeb.Models
{
    public class LicitacionContext : DbContext
    {
        public LicitacionContext(DbContextOptions<LicitacionContext> options):base(options)
        {
            
        }
        public DbSet<Licitacion> Licitacions { get; set; }
    }
}
