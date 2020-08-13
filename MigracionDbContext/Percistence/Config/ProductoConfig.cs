using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MigracionDbContext.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MigracionDbContext.Percistence.Config
{
    public class ProductoConfig
    {
       
            public ProductoConfig(EntityTypeBuilder<Producto> entityBuilder)
            {
                entityBuilder.Property(x => x.Marca).IsRequired().HasMaxLength(50);
                entityBuilder.Property(x => x.Descripcion).IsRequired().HasMaxLength(100);
                entityBuilder.Property(x => x.Presentacion).IsRequired().HasMaxLength(30);


                entityBuilder.HasData(
                    new Producto
                    {
                        ProductoId = 001,
                        Marca = "Farma",
                        Descripcion = "Tableatas 20",
                        Presentacion = "Tabletas"
                    }
                );
            }
        
    }
}
