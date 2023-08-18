using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistencia.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Automovil",
                columns: table => new
                {
                    Id_Automovil = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    marca = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    modelo = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    año = table.Column<int>(type: "int", nullable: false),
                    tipo = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    capacidad = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    preciodiario = table.Column<decimal>(type: "decimal(38,17)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Automovil", x => x.Id_Automovil);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Cliente",
                columns: table => new
                {
                    Id_Cliente = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    nombre = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    apellido = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    dni = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Dirrecion = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    telefono = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Email = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cliente", x => x.Id_Cliente);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Empleado",
                columns: table => new
                {
                    Id_Empleado = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    nombre = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    apellido = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    dni = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Dirrecion = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    telefono = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    cargo = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empleado", x => x.Id_Empleado);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "sucursales",
                columns: table => new
                {
                    Id_Sucursal = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    nombre = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Dirreccion = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Telefono = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sucursales", x => x.Id_Sucursal);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Alquiler",
                columns: table => new
                {
                    Id_Alquiler = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Id_Cliente = table.Column<int>(type: "int", nullable: false),
                    Id_Automovil = table.Column<int>(type: "int", nullable: false),
                    Fecha_Inicio = table.Column<DateTime>(type: "date", nullable: false),
                    Fecha_Fin = table.Column<DateTime>(type: "date", nullable: false),
                    Precio_Total = table.Column<decimal>(type: "decimal(38,17)", nullable: false),
                    Estado = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Alquiler", x => x.Id_Alquiler);
                    table.ForeignKey(
                        name: "FK_Alquiler_Automovil_Id_Automovil",
                        column: x => x.Id_Automovil,
                        principalTable: "Automovil",
                        principalColumn: "Id_Automovil",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Alquiler_Cliente_Id_Cliente",
                        column: x => x.Id_Cliente,
                        principalTable: "Cliente",
                        principalColumn: "Id_Cliente",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Reservas",
                columns: table => new
                {
                    Id_Reserva = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Id_Cliente = table.Column<int>(type: "int", nullable: false),
                    Id_Automovil = table.Column<int>(type: "int", nullable: false),
                    Fecha_Reserva = table.Column<DateTime>(type: "date", nullable: false),
                    Fecha_Inicio = table.Column<DateTime>(type: "date", nullable: false),
                    Fecha_Fin = table.Column<DateTime>(type: "date", nullable: false),
                    Estado = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservas", x => x.Id_Reserva);
                    table.ForeignKey(
                        name: "FK_Reservas_Automovil_Id_Automovil",
                        column: x => x.Id_Automovil,
                        principalTable: "Automovil",
                        principalColumn: "Id_Automovil",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Reservas_Cliente_Id_Cliente",
                        column: x => x.Id_Cliente,
                        principalTable: "Cliente",
                        principalColumn: "Id_Cliente",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "SucursalAutomovil",
                columns: table => new
                {
                    Id_Sucursales = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Id_Automovil = table.Column<int>(type: "int", nullable: false),
                    id_CantidadDisponible = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SucursalAutomovil", x => x.Id_Sucursales);
                    table.ForeignKey(
                        name: "FK_SucursalAutomovil_Automovil_Id_Automovil",
                        column: x => x.Id_Automovil,
                        principalTable: "Automovil",
                        principalColumn: "Id_Automovil",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SucursalAutomovil_sucursales_Id_Sucursales",
                        column: x => x.Id_Sucursales,
                        principalTable: "sucursales",
                        principalColumn: "Id_Sucursal",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "RegistrosDevolucion",
                columns: table => new
                {
                    Id_RegDev = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Id_Alquiler = table.Column<int>(type: "int", nullable: false),
                    Id_Empleado = table.Column<int>(type: "int", nullable: false),
                    Fecha_Devolucion = table.Column<DateTime>(type: "date", nullable: false),
                    CombustibleDevuelto = table.Column<decimal>(type: "decimal(38,17)", nullable: false),
                    Kilometrajedevuelto = table.Column<int>(type: "int", nullable: false),
                    monto_Adicional = table.Column<decimal>(type: "decimal(38,17)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RegistrosDevolucion", x => x.Id_RegDev);
                    table.ForeignKey(
                        name: "FK_RegistrosDevolucion_Alquiler_Id_Alquiler",
                        column: x => x.Id_Alquiler,
                        principalTable: "Alquiler",
                        principalColumn: "Id_Alquiler",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RegistrosDevolucion_Empleado_Id_Empleado",
                        column: x => x.Id_Empleado,
                        principalTable: "Empleado",
                        principalColumn: "Id_Empleado",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "RegistrosEntrega",
                columns: table => new
                {
                    Id_RegEntrega = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Id_Alquiler = table.Column<int>(type: "int", nullable: false),
                    Id_Empleado = table.Column<int>(type: "int", nullable: false),
                    Fecha_Entrega = table.Column<DateTime>(type: "date", nullable: false),
                    Combustibleentregado = table.Column<decimal>(type: "decimal(38,17)", nullable: false),
                    Kilometrajentregado = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RegistrosEntrega", x => x.Id_RegEntrega);
                    table.ForeignKey(
                        name: "FK_RegistrosEntrega_Alquiler_Id_Alquiler",
                        column: x => x.Id_Alquiler,
                        principalTable: "Alquiler",
                        principalColumn: "Id_Alquiler",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RegistrosEntrega_Empleado_Id_Empleado",
                        column: x => x.Id_Empleado,
                        principalTable: "Empleado",
                        principalColumn: "Id_Empleado",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Alquiler_Id_Automovil",
                table: "Alquiler",
                column: "Id_Automovil");

            migrationBuilder.CreateIndex(
                name: "IX_Alquiler_Id_Cliente",
                table: "Alquiler",
                column: "Id_Cliente");

            migrationBuilder.CreateIndex(
                name: "IX_RegistrosDevolucion_Id_Alquiler",
                table: "RegistrosDevolucion",
                column: "Id_Alquiler");

            migrationBuilder.CreateIndex(
                name: "IX_RegistrosDevolucion_Id_Empleado",
                table: "RegistrosDevolucion",
                column: "Id_Empleado");

            migrationBuilder.CreateIndex(
                name: "IX_RegistrosEntrega_Id_Alquiler",
                table: "RegistrosEntrega",
                column: "Id_Alquiler");

            migrationBuilder.CreateIndex(
                name: "IX_RegistrosEntrega_Id_Empleado",
                table: "RegistrosEntrega",
                column: "Id_Empleado");

            migrationBuilder.CreateIndex(
                name: "IX_Reservas_Id_Automovil",
                table: "Reservas",
                column: "Id_Automovil");

            migrationBuilder.CreateIndex(
                name: "IX_Reservas_Id_Cliente",
                table: "Reservas",
                column: "Id_Cliente");

            migrationBuilder.CreateIndex(
                name: "IX_SucursalAutomovil_Id_Automovil",
                table: "SucursalAutomovil",
                column: "Id_Automovil");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RegistrosDevolucion");

            migrationBuilder.DropTable(
                name: "RegistrosEntrega");

            migrationBuilder.DropTable(
                name: "Reservas");

            migrationBuilder.DropTable(
                name: "SucursalAutomovil");

            migrationBuilder.DropTable(
                name: "Alquiler");

            migrationBuilder.DropTable(
                name: "Empleado");

            migrationBuilder.DropTable(
                name: "sucursales");

            migrationBuilder.DropTable(
                name: "Automovil");

            migrationBuilder.DropTable(
                name: "Cliente");
        }
    }
}
