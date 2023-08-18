using Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Configuration;
public class RegistroDevolucionConfiguration : IEntityTypeConfiguration<RegistroDevolucion>
{
    public void Configure(EntityTypeBuilder<RegistroDevolucion> builder)
    {
       
        builder.ToTable("RegistrosDevolucion");

            builder.Property(p => p.Id)
            .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
            .HasColumnName("Id_RegDev")
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


            builder.Property(p => p.Fecha_Devolucion)
            .HasColumnName("Fecha_Devolucion")
            .HasColumnType("date")
            .IsRequired();

            builder.Property(p => p.Monto_Adicional)
            .HasColumnName("monto_Adicional")
            .HasColumnType("decimal")
            .IsRequired();

             builder.Property(p => p.Kilometraje_Devuelto)
            .HasColumnName("Kilometrajedevuelto")
            .HasColumnType("int")
            .IsRequired();


            builder.Property(p => p.Devolucion_Combustible)
            .HasColumnName("CombustibleDevuelto")
            .HasColumnType("decimal")
            .IsRequired();




             builder.HasOne(u => u.Alquiler)
            .WithMany(a => a.RegistroDevoluciones)
            .HasForeignKey(u => u.Id_Alquiler)
            .IsRequired();

             builder.HasOne(u => u.Empleado)
            .WithMany(a => a.RegistroDevoluciones)
            .HasForeignKey(u => u.Id_Empleado)
            .IsRequired();
    }
}