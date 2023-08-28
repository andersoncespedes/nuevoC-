namespace API.Dto;
public class PersonaDto : BaseEntityDto
{
    public string ? Nombre { get; set; }
    public string ?  Apellido { get; set; }
    public int ? Cedula { get; set; }
    public DateTime ? FechaNacimiento { get; set; }
    public string ? Correo { get; set; }
    public int ? IdTipoPersonaFk { get; set; }
    public TipoPersonaDto ? TipoPersona { get; set; }
}
