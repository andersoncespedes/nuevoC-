using System.Reflection;
using Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data;

public class BodegaContext : DbContext
{
    public BodegaContext(DbContextOptions<BodegaContext> options) : base(options){

    }
    public DbSet<Persona> Personas { get; set; }
    public DbSet<Producto> Productos { get; set; }
    public DbSet<TipoPersona> TipoPersonas { get; set;}
    public DbSet<TipoProducto> TipoProductos { get; set;}
    protected override void OnModelCreating(ModelBuilder modelBuilder){
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        modelBuilder.Entity<TipoProducto>()
        .HasMany<Producto>(e => e.Productos)
        .WithOne(e => e.TipoProducto)
        .HasForeignKey(e => e.IdTipoProductFk);
    }
}
