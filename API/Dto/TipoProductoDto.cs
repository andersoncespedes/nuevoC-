namespace API.Dto;

public class TipoProductoDto : BaseEntityDto
{
    public string ? Descripcion { get; set; }
    public ICollection<ProductoDto> ? Productos { get; set; }        
}
