
namespace Dominio;
    public class Alquiler : baseEntity
    {
        public ICollection<RegistroDevolucion> ? RegistroDevoluciones { get; set; }
        public ICollection<RegistroEntrega> ? RegistroEntregas { get; set; }
        public int Id_Cliente { get; set; }
        public Cliente ?cliente { get; set; }
        public int Id_Automovil { get; set; }
        public Automovil? Automovil { get; set; }
        public DateTime Fecha_Inicio { get; set;}
        public DateTime Fecha_Fin { get; set;}
        public double Precio_Total { get; set; }
        public string? Estado { get; set; }


    }
