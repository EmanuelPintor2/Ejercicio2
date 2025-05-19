using System.ComponentModel.DataAnnotations;

namespace PracticoMVC.Models
{
    public class Producto
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio")]
        public string Nombre { get; set; } = null!;


        [Range(0.01, 1000000, ErrorMessage = "El precio debe ser mayor que cero")]
        [Required(ErrorMessage = "El precio es obligatorio")]
        public decimal Precio { get; set; }
    }
}
