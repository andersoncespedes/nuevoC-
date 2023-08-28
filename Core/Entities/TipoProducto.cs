using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities;

public class TipoProducto : BaseEntity
{
    public string ? Descripcion { get; set; }
    public ICollection<Producto> ? Productos { get; set; }
}
