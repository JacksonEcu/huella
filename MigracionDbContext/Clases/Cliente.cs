using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MigracionDbContext.Clases
{
    public class Cliente
    {
        public int ClienteId { get; set; }
        public string Nombre { get; set; }
        public string Telefono { get; set; }
    }
}
