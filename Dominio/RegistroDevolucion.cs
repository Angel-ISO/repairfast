
namespace Dominio;

    public class RegistroDevolucion : baseEntity
    {
        public int Id_Alquiler { get; set; }
        public Alquiler? Alquiler { get; set; }
        public int Id_Empleado { get; set; }
        public Empleado ? Empleado { get; set; }
        public DateTime Fecha_Devolucion { get; set; }
        public double Devolucion_Combustible { get; set; }
        public int Kilometraje_Devuelto { get; set; }
        public double Monto_Adicional { get; set; }

    }
