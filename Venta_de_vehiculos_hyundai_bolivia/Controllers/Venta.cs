using System.ComponentModel.DataAnnotations;

namespace Venta_de_vehiculos_hyundai_bolivia.Controllers
{
    public class Venta
    {
        [Key]
        public int Id { get; set; }
        public DateOnly Fecha { get; set; }
        public int Num_recibo { get; set; }

        //claves foraneas
        public int UsuarioId { get; set; }
        public int ClienteId { get; set; }
        public int VehiculoId { get; set; }
        public decimal Total { get; set; }

        public virtual Usuario? Usuario { get; set; }
        public virtual Cliente? Cliente { get; set; }
        public virtual Vehiculos? Vehiculos { get; set; }
    }
}
