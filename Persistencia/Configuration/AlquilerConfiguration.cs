using Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Configuration;
public class AreaConfiguration : IEntityTypeConfiguration<Alquiler>
{
    public void Configure(EntityTypeBuilder<Alquiler> builder)
    {
       
        builder.ToTable("Alquiler");

            builder.Property(p => p.Id)
            .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
            .HasColumnName("Id_Alquiler")
            .HasColumnType("int")
            .IsRequired();

            builder.Property(p => p.Id_Cliente)
            .HasColumnName("Id_Cliente")
            .HasColumnType("int")
            .IsRequired();

            builder.Property(p => p.Id_Automovil)
            .HasColumnName("Id_Automovil")
            .HasColumnType("int")
            .IsRequired();


            builder.Property(p => p.Fecha_Inicio)
            .HasColumnName("Fecha_Inicio")
            .HasColumnType("date")
            .IsRequired();

            builder.Property(p => p.Fecha_Fin)
            .HasColumnName("Fecha_Fin")
            .HasColumnType("date")
            .IsRequired();


            builder.Property(p => p.Precio_Total)
            .HasColumnName("Precio_Total")
            .HasColumnType("decimal")
            .IsRequired();


            builder.Property(p => p.Estado)
            .HasColumnName("Estado")
            .HasColumnType("varchar")
            .HasMaxLength(200)
            .IsRequired();


             builder.HasOne(u => u.cliente)
            .WithMany(a => a.Alquileres)
            .HasForeignKey(u => u.Id_Cliente)
            .IsRequired();

             builder.HasOne(u => u.Automovil)
            .WithMany(a => a.Alquileres)
            .HasForeignKey(u => u.Id_Automovil)
            .IsRequired();
    }
}