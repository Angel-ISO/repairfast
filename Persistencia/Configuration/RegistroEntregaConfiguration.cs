using Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Configuration;
public class RegistroEntregaConfiguration : IEntityTypeConfiguration<RegistroEntrega>
{
    public void Configure(EntityTypeBuilder<RegistroEntrega> builder)
    {
       
        builder.ToTable("RegistrosEntrega");

            builder.Property(p => p.Id)
            .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
            .HasColumnName("Id_RegEntrega")
            .HasColumnType("int")
            .IsRequired();

            builder.Property(p => p.Id_Empleado)
            .HasColumnName("Id_Empleado")
            .HasColumnType("int")
            .IsRequired();

            builder.Property(p => p.Id_Alquiler)
            .HasColumnName("Id_Alquiler")
            .HasColumnType("int")
            .IsRequired();


            builder.Property(p => p.Fecha_Entrega)
            .HasColumnName("Fecha_Entrega")
            .HasColumnType("date")
            .IsRequired();

             builder.Property(p => p.Kilometraje_Entregado)
            .HasColumnName("Kilometrajentregado")
            .HasColumnType("int")
            .IsRequired();


            builder.Property(p => p.Combustible_Entregado)
            .HasColumnName("Combustibleentregado")
            .HasColumnType("decimal")
            .IsRequired();

             builder.HasOne(u => u.Alquiler)
            .WithMany(a => a.RegistroEntregas)
            .HasForeignKey(u => u.Id_Alquiler)
            .IsRequired();

             builder.HasOne(u => u.Empleado)
            .WithMany(a => a.RegistroEntregas)
            .HasForeignKey(u => u.Id_Empleado)
            .IsRequired();
    }
}