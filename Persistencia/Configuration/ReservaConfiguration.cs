using Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Configuration;
public class ReservaConfiguration : IEntityTypeConfiguration<Reserva>
{
    public void Configure(EntityTypeBuilder<Reserva> builder)
    {
       
        builder.ToTable("Reservas");

            builder.Property(p => p.Id)
            .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
            .HasColumnName("Id_Reserva")
            .HasColumnType("int")
            .IsRequired();

            builder.Property(p => p.Id_Client)
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

            builder.Property(p => p.Fecha_Reserva)
            .HasColumnName("Fecha_Reserva")
            .HasColumnType("date")
            .IsRequired();

            builder.Property(p => p.Fecha_Fin)
            .HasColumnName("Fecha_Fin")
            .HasColumnType("date")
            .IsRequired();



            builder.Property(p => p.Estado)
            .HasColumnName("Estado")
            .HasColumnType("varchar")
            .HasMaxLength(200)
            .IsRequired();


             builder.HasOne(u => u.Cliente)
            .WithMany(a => a.Reservas)
            .HasForeignKey(u => u.Id_Client)
            .IsRequired();

             builder.HasOne(u => u.Automovil)
            .WithMany(a => a.Reservas)
            .HasForeignKey(u => u.Id_Automovil)
            .IsRequired();
    }
}