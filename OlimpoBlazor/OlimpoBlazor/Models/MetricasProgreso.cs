namespace OlimpoBlazor.Models
{
    public class MetricasProgreso
    {
        public int MetricaID { get; set; }

        // Relación con Usuario
        public int UsuarioID { get; set; }
        public Usuario Usuario { get; set; }

        public DateTime FechaRegistro { get; set; }
        public decimal? Pecho { get; set; }
        public decimal? Biceps { get; set; }
        public decimal? Triceps { get; set; }
        public decimal? Piernas { get; set; }
    }
}
