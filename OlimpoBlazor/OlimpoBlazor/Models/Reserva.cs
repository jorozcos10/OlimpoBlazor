namespace OlimpoBlazor.Models
{
    public class Reserva
    {
        public int ReservaID { get; set; }

        // Relación con Usuario
        public int UsuarioID { get; set; }
        public Usuario Usuario { get; set; }

        // Relación con Clase
        public int ClaseID { get; set; }
        public Clase Clase { get; set; }

        public DateTime FechaReserva { get; set; }
    }
}
