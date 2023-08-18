

namespace Dominio;

    public class RegistroEntrega : baseEntity
    {
        public int Id_Alquiler { get; set; }
        public Alquiler? Alquiler { get; set;}
        public int Id_Empleado { get; set; }
        public Empleado? Empleado { get; set; }
        public DateTime Fecha_Entrega { get; set; }
        public double Combustible_Entregado { get; set; }
        public int Kilometraje_Entregado  { get; set;}
    }
