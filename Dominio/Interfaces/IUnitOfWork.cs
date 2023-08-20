namespace Dominio.Interfaces;
public interface IUnitOfWork
{
    IAlquilerRepository Alquileres {get;}     
    IAutomovilRepository Automoviles {get;}     
    IClienteRepository Clientes {get;}     
    IEmpleadoRepository Empleados {get;}     
    IRegistroEntregaRepository RegistroEntregas {get;}     
    IRegistroDevolucionRepository RegistroDevoluciones {get;}     
    IReservaRepository Reservas {get;}     
    ISucursalRepository Sucursales {get;}     
    ISucursarAutomovilRepository SucursalAutomoviles {get;}     
   
    Task<int> SaveAsync();
}
