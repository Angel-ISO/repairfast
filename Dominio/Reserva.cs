namespace Dominio;

    public class Reserva : baseEntity
    {
        public int Id_Client { get; set;}
        public Cliente? Cliente { get; set;}
        public int Id_Automovil { get; set;}
        public Automovil? Automovil { get; set;}
        public DateTime Fecha_Reserva { get; set;}
        public DateTime Fecha_Inicio { get; set;}
        public DateTime Fecha_Fin { get; set;}
        public string ? Estado { get; set; }



    }
