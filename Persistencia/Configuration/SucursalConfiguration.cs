using Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Configuration;
public class SucursalConfiguration : IEntityTypeConfiguration<Sucursal>
{
    public void Configure(EntityTypeBuilder<Sucursal> builder)
    {
       
        builder.ToTable("sucursales");

            builder.Property(p => p.Id)
            .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
            .HasColumnName("Id_Sucursal")
            .HasColumnType("int")
            .IsRequired();

           

    

            builder.Property(p => p.Nombre)
            .HasColumnName("nombre")
            .HasColumnType("varchar")
            .HasMaxLength(200)
            .IsRequired();


            builder.Property(p => p.Direccion)
            .HasColumnName("Dirreccion")
            .HasColumnType("varchar")
            .HasMaxLength(200)
            .IsRequired();

            builder.Property(p => p.Telefono)
            .HasColumnName("Telefono")
            .HasColumnType("varchar")
            .HasMaxLength(200)
            .IsRequired();



    }
}