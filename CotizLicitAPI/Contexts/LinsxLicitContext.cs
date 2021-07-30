using CotizLicitAPI.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CotizLicitAPI.Contexts
{
    public class LinsxLicitContext : DbContext
    {
        public LinsxLicitContext(DbContextOptions<LinsxLicitContext> options) : base(options)
        {

        }
        public DbSet<LinsxLicit> Lineas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<LinsxLicit>(eb =>
            {
                eb.Property(b => b.Precio).HasColumnType("decimal(10,2)");
            });
        }
    }
}
