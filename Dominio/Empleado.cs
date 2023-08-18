
using iText.IO.Source;

namespace Dominio;

    public class Empleado : baseEntity
    {
       public ICollection<RegistroDevolucion> ? RegistroDevoluciones { get; set; }
       public ICollection<RegistroEntrega> ? RegistroEntregas { get; set; }

        public string? Nombre { get; set; }
        public string ?Apellido { get; set; }
        public string ? Dni { get; set; }
        public string ? Direccion { get; set; }
        public string ? Telefono { get; set; }
        public string ? Cargo { get; set; }

    }
