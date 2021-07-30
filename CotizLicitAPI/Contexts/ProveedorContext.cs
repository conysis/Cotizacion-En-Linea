using CotizLicitAPI.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CotizLicitAPI.Contexts
{
    public class ProveedorContext : DbContext
    {
        public ProveedorContext(DbContextOptions<ProveedorContext> options) : base(options)
        {

        }
        public DbSet<Proveedor> Proveedors { get; set; }
    }
}
