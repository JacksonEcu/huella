using LiteDB;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MigracionDbContext.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MigracionDbContext.Percistence.Config
{
    public class ClienteConfig
    {
        public ClienteConfig(EntityTypeBuilder<Cliente> entityBuilder)
        {
            entityBuilder.Property(x => x.Nombre).IsRequired().HasMaxLength(100);
            entityBuilder.Property(x => x.Telefono).IsRequired().HasMaxLength(50);


            entityBuilder.HasData(
                new Cliente
                {
                    ClienteId = 1,
                    Nombre = "Luis Chala",
                    Telefono = "099541515",
                }
            );
        }
    }
}
