using System.ComponentModel.DataAnnotations;

namespace Restaurante.Models
{
    public class Plato
    {
        public int PlatoId { get; set; }
        [Display(Name = "Nombre del Plato")]
        public required string Nombre_Plato { get; set; }
        [Display(Name = "Observación")]
        public required string Observacion { get; set; }
        public float Precio { get; set; }
    }
}