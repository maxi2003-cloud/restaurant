namespace Restaurante.Models
{
    public class Plato
    {
        public int PlatoId { get; set; }
        public required string Nombre_Plato { get; set; }
        public required string Observacion { get; set; }
        public float Precio { get; set; }
    }
}