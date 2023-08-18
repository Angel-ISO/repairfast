using System.Security.Cryptography.X509Certificates;

namespace Dominio;

    public class Sucursal : baseEntity
    {
        public ICollection<SucursarAutomovil> ? SucursarAutomoviles { get; set; }
        public string ? Nombre { get; set; }
        public string? Direccion { get; set; }
        public string? Telefono { get; set; }
    }
