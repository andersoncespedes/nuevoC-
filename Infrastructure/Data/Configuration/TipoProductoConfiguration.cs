using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Core.Entities;

namespace Infrastructure.Data.Configuration;

public class TipoProductoConfiguration : IEntityTypeConfiguration<TipoProducto>
{
    public void Configure(EntityTypeBuilder<TipoProducto> builder){
        builder.ToTable("tipo_producto");
        builder.Property(e => e.Descripcion)
        .IsRequired()
        .HasMaxLength(20);
    }
}
