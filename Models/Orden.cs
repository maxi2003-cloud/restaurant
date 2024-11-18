using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Restaurante.Models
{
    public class Orden
    {
        public int OrdenId { get; set; }
        [ForeignKey("Mesa")]
        public int MesaId { get; set; }
        public Mesa Mesa { get; set; }

        [ForeignKey("Plato")]
        public int PlatoId { get; set; }
        public Plato Plato { get; set; }
        [Display(Name = "Cantidad")]
        public int cantidad { get; set; }
    }
}
