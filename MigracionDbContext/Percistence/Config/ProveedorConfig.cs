using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MigracionDbContext.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MigracionDbContext.Percistence.Config
{
    public class ProveedorConfig
    {
        public ProveedorConfig(EntityTypeBuilder<Proveedor> entityBuilder)
        {
            entityBuilder.Property(x => x.Nombre).IsRequired().HasMaxLength(50);
            entityBuilder.Property(x => x.Telefono).IsRequired().HasMaxLength(100);


            entityBuilder.HasData(
                new Proveedor
                {
                    ProveedorId = 001,
                    Nombre = "Milton Hunda"
                    
                }
            );
        }
    }
}
