using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities;

public class Persona : BaseEntity
{
    public string ? Nombre { get; set; }
    public string ?  Apellido { get; set; }
    public int ? Cedula { get; set; }
    public DateTime ? FechaNacimiento { get; set; }
    public string ? Correo { get; set; }
    public int ? IdTipoPersonaFk { get; set; }
    public TipoPersona ? TipoPersona { get; set; }
}
