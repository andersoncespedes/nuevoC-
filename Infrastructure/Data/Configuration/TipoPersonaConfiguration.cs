using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Core.Entities;

namespace Infrastructure.Data.Configuration;

public class TipoPersonaConfiguration : IEntityTypeConfiguration<TipoPersona>
{
    public void Configure(EntityTypeBuilder<TipoPersona> builder){
        builder.ToTable("tipo_persona");
        builder.Property(e => e.Descripcion)
        .IsRequired()
        .HasMaxLength(20);
    }
}
