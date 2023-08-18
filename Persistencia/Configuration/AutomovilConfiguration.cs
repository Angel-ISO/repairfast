using Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Configuration;
public class AutomovilConfiguration : IEntityTypeConfiguration<Automovil>
{
    public void Configure(EntityTypeBuilder<Automovil> builder)
    {
       
        builder.ToTable("Automovil");

            builder.Property(p => p.Id)
            .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
            .HasColumnName("Id_Automovil")
            .HasColumnType("int")
            .IsRequired();

         
            builder.Property(p => p.Marca)
            .HasColumnName("marca")
            .HasColumnType("varchar")
            .HasMaxLength(200)
            .IsRequired();

             builder.Property(p => p.Modelo)
            .HasColumnName("modelo")
            .HasColumnType("varchar")
            .HasMaxLength(200)
            .IsRequired();

             builder.Property(p => p.Año)
            .HasColumnName("año")
            .HasColumnType("int")
            .IsRequired();

            builder.Property(p => p.Tipo)
            .HasColumnName("tipo")
            .HasColumnType("varchar")
            .HasMaxLength(20);


            builder.Property(p => p.Capacidad)
            .HasColumnName("capacidad")
            .HasColumnType("varchar")
            .HasMaxLength(200)
            .IsRequired();

            builder.Property(p => p.Precio_Diario)
            .HasColumnName("preciodiario")
            .HasColumnType("decimal")
            .IsRequired();
    }
}