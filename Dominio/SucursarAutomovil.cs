namespace Dominio;

    public class SucursarAutomovil : baseEntity
    {
        public Sucursal ?Sucursal { get; set; }
        public int IdAutomovil { get; set; }
        public Automovil ?Automovil { get; set; }
        public int Id_Cantidad_Disponible { get; set; }
        
    }
