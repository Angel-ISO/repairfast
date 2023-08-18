using Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Configuration;
public class EmpleadoConfiguration : IEntityTypeConfiguration<Empleado>
{
    public void Configure(EntityTypeBuilder<Empleado> builder)
    {
       
        builder.ToTable("Empleado");

            builder.Property(p => p.Id)
            .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
            .HasColumnName("Id_Empleado")
            .HasColumnType("int")
            .IsRequired();

         
            builder.Property(p => p.Nombre)
            .HasColumnName("nombre")
            .HasColumnType("varchar")
            .HasMaxLength(200)
            .IsRequired();

             builder.Property(p => p.Apellido)
            .HasColumnName("apellido")
            .HasColumnType("varchar")
            .HasMaxLength(200)
            .IsRequired();

             builder.Property(p => p.Dni)
            .HasColumnName("dni")
            .HasColumnType("varchar")
            .HasMaxLength(200)
            .IsRequired();


            builder.Property(p => p.Direccion)
            .HasColumnName("Dirrecion")
            .HasColumnType("varchar")
            .HasMaxLength(200)
            .IsRequired();


             builder.Property(p => p.Telefono)
            .HasColumnName("telefono")
            .HasColumnType("varchar")
            .HasMaxLength(200)
            .IsRequired();



             builder.Property(p => p.Cargo)
            .HasColumnName("cargo")
            .HasColumnType("varchar")
            .HasMaxLength(200)
            .IsRequired();

            
          
    }
}