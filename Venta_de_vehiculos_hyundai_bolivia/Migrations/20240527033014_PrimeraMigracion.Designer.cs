﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Venta_de_vehiculos_hyundai_bolivia.Contexto;

#nullable disable

namespace Venta_de_vehiculos_hyundai_bolivia.Migrations
{
    [DbContext(typeof(MyContext))]
    [Migration("20240527033014_PrimeraMigracion")]
    partial class PrimeraMigracion
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.5");

            modelBuilder.Entity("Venta_de_vehiculos_hyundai_bolivia.Controllers.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Celular")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Ci")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Direccion")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nombre")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("Venta_de_vehiculos_hyundai_bolivia.Controllers.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<string>("Password")
                        .HasColumnType("TEXT");

                    b.Property<int>("Rol")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("Venta_de_vehiculos_hyundai_bolivia.Controllers.Vehiculos", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Matricula")
                        .HasColumnType("TEXT");

                    b.Property<string>("Modelo")
                        .HasColumnType("TEXT");

                    b.Property<int>("Stock")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Vehiculos");
                });

            modelBuilder.Entity("Venta_de_vehiculos_hyundai_bolivia.Controllers.Venta", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("ClienteId")
                        .HasColumnType("INTEGER");

                    b.Property<DateOnly>("Fecha")
                        .HasColumnType("TEXT");

                    b.Property<int>("Num_recibo")
                        .HasColumnType("INTEGER");

                    b.Property<int>("UsuarioId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("VehiculoId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("VehiculosId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("ClienteId");

                    b.HasIndex("UsuarioId");

                    b.HasIndex("VehiculosId");

                    b.ToTable("Ventas");
                });

            modelBuilder.Entity("Venta_de_vehiculos_hyundai_bolivia.Controllers.Venta", b =>
                {
                    b.HasOne("Venta_de_vehiculos_hyundai_bolivia.Controllers.Cliente", "Cliente")
                        .WithMany("Ventas")
                        .HasForeignKey("ClienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Venta_de_vehiculos_hyundai_bolivia.Controllers.Usuario", "Usuario")
                        .WithMany("Ventas")
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Venta_de_vehiculos_hyundai_bolivia.Controllers.Vehiculos", "Vehiculos")
                        .WithMany()
                        .HasForeignKey("VehiculosId");

                    b.Navigation("Cliente");

                    b.Navigation("Usuario");

                    b.Navigation("Vehiculos");
                });

            modelBuilder.Entity("Venta_de_vehiculos_hyundai_bolivia.Controllers.Cliente", b =>
                {
                    b.Navigation("Ventas");
                });

            modelBuilder.Entity("Venta_de_vehiculos_hyundai_bolivia.Controllers.Usuario", b =>
                {
                    b.Navigation("Ventas");
                });
#pragma warning restore 612, 618
        }
    }
}
