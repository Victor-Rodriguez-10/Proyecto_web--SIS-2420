using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Venta_de_vehiculos_hyundai_bolivia.Migrations
{
    /// <inheritdoc />
    public partial class SegundaMigracion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Password",
                table: "Usuarios",
                newName: "NombreCompleto");

            migrationBuilder.AddColumn<decimal>(
                name: "Total",
                table: "Ventas",
                type: "TEXT",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "CostoVehiculo",
                table: "Vehiculos",
                type: "TEXT",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<string>(
                name: "Descripsion",
                table: "Vehiculos",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UrlFoto",
                table: "Vehiculos",
                type: "TEXT",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Total",
                table: "Ventas");

            migrationBuilder.DropColumn(
                name: "CostoVehiculo",
                table: "Vehiculos");

            migrationBuilder.DropColumn(
                name: "Descripsion",
                table: "Vehiculos");

            migrationBuilder.DropColumn(
                name: "UrlFoto",
                table: "Vehiculos");

            migrationBuilder.RenameColumn(
                name: "NombreCompleto",
                table: "Usuarios",
                newName: "Password");
        }
    }
}
