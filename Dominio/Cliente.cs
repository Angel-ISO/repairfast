namespace Dominio;

    public class Cliente : baseEntity
    {
        public ICollection<Reserva> ? Reservas { get; set; }
        public ICollection<Alquiler> ? Alquileres { get; set; }
        public string ?Nombre { get; set; }
        public string ? Apellido { get; set; }
        public string ? Dni  { get; set; }
        public string ? Direccion { get; set; }
        public string ? Telefono { get; set; }
        public string? Email { get; set; }
    }
