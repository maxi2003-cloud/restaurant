using System.ComponentModel.DataAnnotations;

namespace Restaurante.Models
{
    public class Mesa
    {
        public int MesaId { get; set; }
        [Display(Name = "Número de Mesa")]
        public int NumeroMesa { get; set; }
        public int Capacidad { get; set; }
        public string Estado { get; set; }

    }
}
