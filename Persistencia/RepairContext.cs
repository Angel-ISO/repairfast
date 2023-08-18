using System.Reflection;
using Microsoft.EntityFrameworkCore;
using Dominio;


namespace Persistencia;
public class RepairContext : DbContext {
    public RepairContext(DbContextOptions<RepairContext> options) : base(options) { 

    }
public DbSet<Alquiler> ?Alquilers { get; set; }
      public DbSet<Automovil> ?Automoviles { get; set; }
      public DbSet<Cliente> ?Clientes { get; set; }
      public DbSet<Empleado> ?Empleados { get; set; }
      public DbSet<RegistroEntrega> ?RegistroEntregas { get; set; }
      public DbSet<RegistroDevolucion> ?RegistroDevoluciones { get; set; }
      public DbSet<Reserva> ?Reservas { get; set; }
      public DbSet<Sucursal> ?Sucursales { get; set; }
      public DbSet<SucursarAutomovil> ?SucursarAutomoviles { get; set; }
        

       protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }

}