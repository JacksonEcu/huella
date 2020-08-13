using Microsoft.EntityFrameworkCore;
using MigracionDbContext.Clases;
using MigracionDbContext.Percistence.Config;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MigracionDbContext.Percistence
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
           : base(options)
        {

        }


        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Factura> Facturas { get; set; }
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Proveedor> Proveedores { get; set; }





        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            new ClienteConfig(builder.Entity<Cliente>());
            new FacturaConfig(builder.Entity<Factura>());
            new ProductoConfig(builder.Entity<Producto>());
            new ProveedorConfig(builder.Entity<Proveedor>());

        }

    }
}
