namespace OlimpoBlazor.Models
{
    public class Clase
    {
        public int ClaseID { get; set; }
        public string NombreClase { get; set; }
        public string Horario { get; set; }
        public int Cupo { get; set; }

        // Navegación a Reservas
        public ICollection<Reserva> Reservas { get; set; }
    }
}
