using System.ComponentModel.DataAnnotations;

namespace Venta_de_vehiculos_hyundai_bolivia.Controllers
{
    public class Vehiculos
    {
        [Key]
        public int Id { get; set; }
        public string? Matricula { get; set; }
        public string? Modelo { get; set; }
        public int Stock { get; set; }
    }
}
