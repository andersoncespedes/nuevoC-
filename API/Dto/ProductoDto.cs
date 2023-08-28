namespace API.Dto;
public class ProductoDto : BaseEntityDto
{
    public string ? NombreProducto { get; set; }	
    public double ? Precio { get; set; }
    public int ? Cantidad { get; set; } 
    public string ? CodigoProducto { get; set; }
    public int ? IdTipoProductFk { get; set; }
    public TipoProductoDto ? TipoProducto { get; set; }
}
