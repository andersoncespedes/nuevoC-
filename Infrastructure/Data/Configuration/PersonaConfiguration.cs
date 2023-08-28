using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace Infrastructure.Data.Configuration;
public class PersonaConfiguration : IEntityTypeConfiguration<Persona>
{
    public void Configure(EntityTypeBuilder<Persona> Builder){
        Builder.ToTable("persona");
        Builder.Property(e => e.Nombre)
        .IsRequired()
        .HasMaxLength(20);

        Builder.Property(e => e.Apellido)
        .IsRequired()
        .HasMaxLength(20);
        
        Builder.Property(e => e.Correo)
        .IsRequired()
        .HasMaxLength(20);
        Builder.HasIndex(e => e.Cedula).IsUnique();
    }
}
