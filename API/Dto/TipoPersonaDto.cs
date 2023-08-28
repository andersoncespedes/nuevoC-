namespace API.Dto;

public class TipoPersonaDto : BaseEntityDto
{
    public string ?  Descripcion { get; set; }
    public ICollection<PersonaDto> ?  Personas { get; set; }
}
