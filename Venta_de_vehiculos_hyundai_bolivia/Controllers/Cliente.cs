using System.ComponentModel.DataAnnotations;

namespace Venta_de_vehiculos_hyundai_bolivia.Controllers
{
    public class Cliente
    {
        [Key]
        public int Id { get; set; }
        public string? Nombre { get; set; }
        public int Celular { get; set; }
        public int Ci { get; set; }
        public string? Direccion { get; set; }

        public virtual List<Venta>? Ventas { get; set; }
    }
}
