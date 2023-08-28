using AutoMapper;
using API.Dto;
using Core.Entities;
namespace API.Profiles;

public class MappingProfiles : Profile
{
    public MappingProfiles(){
        CreateMap<Persona,PersonaDto>().ReverseMap();
        CreateMap<Producto,ProductoDto>().ReverseMap();
        CreateMap<TipoPersona,TipoPersonaDto>().ReverseMap();
        CreateMap<TipoProducto,TipoProductoDto>().ReverseMap();
    }
}
