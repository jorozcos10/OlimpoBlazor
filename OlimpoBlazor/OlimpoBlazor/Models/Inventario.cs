namespace OlimpoBlazor.Models
{
    public class Inventario
    {
        public int ItemID { get; set; } // Clave primaria
        public string NombreItem { get; set; }
        public int VidaUtilMeses { get; set; }
        public DateTime UltimoMantenimiento { get; set; }
    }
}
