namespace Dominio;

    public class Automovil : baseEntity
    {
         public ICollection<SucursarAutomovil> ? SucursarAutomoviles { get; set; }
        
       public ICollection<Reserva> ? Reservas { get; set; }
        public ICollection<Alquiler> ? Alquileres { get; set; }
        public string ?Marca { get; set;}
        public string ? Modelo { get; set;}
        public int ? Año { get; set;}
        public string ? Tipo { get; set;}
        public string ? Capacidad { get; set;}
        public double Precio_Diario { get; set;}
    }
