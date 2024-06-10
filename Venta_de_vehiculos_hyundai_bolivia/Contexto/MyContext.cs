using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Venta_de_vehiculos_hyundai_bolivia.Controllers;

namespace Venta_de_vehiculos_hyundai_bolivia.Contexto
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Venta> Ventas { get; set; }
        public DbSet<Vehiculos> Vehiculos { get; set; }
    }
}
