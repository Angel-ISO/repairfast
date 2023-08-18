using Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Configuration;
public class SucursalAutomovilConfiguration : IEntityTypeConfiguration<SucursarAutomovil>
{
    public void Configure(EntityTypeBuilder<SucursarAutomovil> builder)
    {
       
        builder.ToTable("SucursalAutomovil");

            builder.Property(p => p.Id)
            .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
            .HasColumnName("Id_Sucursales")
            .HasColumnType("int")
            .IsRequired();


            builder.Property(p => p.IdAutomovil)
            .HasColumnName("Id_Automovil")
            .HasColumnType("int")
            .IsRequired();


            builder.Property(p => p.Id_Cantidad_Disponible)
            .HasColumnName("id_CantidadDisponible")
            .HasColumnType("int")
            .IsRequired();


             builder.HasOne(u => u.Sucursal)
            .WithMany(a => a.SucursarAutomoviles)
            .HasForeignKey(u => u.Id)
            .IsRequired();

             builder.HasOne(u => u.Automovil)
            .WithMany(a => a.SucursarAutomoviles)
            .HasForeignKey(u => u.IdAutomovil)
            .IsRequired();
    }
}