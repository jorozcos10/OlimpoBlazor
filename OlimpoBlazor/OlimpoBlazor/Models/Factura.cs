namespace OlimpoBlazor.Models
{
    public class Factura
    {
        public int FacturaID { get; set; }

        // Relación con Usuario
        public int UsuarioID { get; set; }
        public Usuario Usuario { get; set; }

        public DateTime Fecha { get; set; }
        public decimal Monto { get; set; }
    }
}
