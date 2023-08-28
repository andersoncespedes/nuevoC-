using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities;

public class Producto : BaseEntity
{
    public string ? NombreProducto { get; set; }	
    public double ? Precio { get; set; }
    public int ? Cantidad { get; set; } 
    public string ? CodigoProducto { get; set; }
    public int ? IdTipoProductFk { get; set; }
    public TipoProducto ? TipoProducto { get; set; }
}
