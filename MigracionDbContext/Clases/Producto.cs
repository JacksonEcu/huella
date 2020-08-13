using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MigracionDbContext.Clases
{
    public class Producto
    {
        public int ProductoId { get; set; }
        public string Marca { get; set; }
        public string Descripcion { get; set; }
        public string Presentacion { get; set; }


    }
}
