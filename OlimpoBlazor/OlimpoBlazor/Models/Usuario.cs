namespace OlimpoBlazor.Models
{
    public class Usuario
    {
        public int UsuarioID { get; set; }
        public string Rol { get; set; }
        public string Nombre { get; set; }
        public string Email { get; set; }
        public string Contraseña { get; set; }
        public DateTime FechaRegistro { get; set; }

        // Navegación a Reservas
        public ICollection<Reserva> Reservas { get; set; }
    }
}
