using CotizLicitAPI.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CotizLicitAPI.Contexts
{
    public class LinsxCotizContext : DbContext
    {
        public LinsxCotizContext(DbContextOptions<LinsxCotizContext> options) : base(options)
        {

        }
        public DbSet<LinsxCotiz> Lineas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<LinsxLicit>(eb =>
            {
                eb.Property(b => b.Precio).HasColumnType("decimal(10,2)");
            });
        }

    }
}
