using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ParqueaderoGrupoB.App.Persistencia.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "espacios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NumeroEspacio = table.Column<int>(type: "int", nullable: false),
                    Estado = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_espacios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "reportes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EspaciosDisponibles = table.Column<int>(type: "int", nullable: false),
                    RecervasDisponibles = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_reportes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "vehiculos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Marca = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Modelo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tamaño = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_vehiculos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "reservas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HoraIngreso = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HoraSalida = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EspacioId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_reservas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_reservas_espacios_EspacioId",
                        column: x => x.EspacioId,
                        principalTable: "espacios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "personas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telefono = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Direccion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaNacimiento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CrearGerenteId = table.Column<int>(type: "int", nullable: true),
                    CrearAuxiliarId = table.Column<int>(type: "int", nullable: true),
                    CrearClienteId = table.Column<int>(type: "int", nullable: true),
                    CrearVehiculoId = table.Column<int>(type: "int", nullable: true),
                    CrearReservaId = table.Column<int>(type: "int", nullable: true),
                    TipoVehiculo = table.Column<int>(type: "int", nullable: true),
                    CantidadVehiculos = table.Column<int>(type: "int", nullable: true),
                    ConsultarReservas = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConsultarEspacios = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_personas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_personas_personas_CrearAuxiliarId",
                        column: x => x.CrearAuxiliarId,
                        principalTable: "personas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_personas_personas_CrearClienteId",
                        column: x => x.CrearClienteId,
                        principalTable: "personas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_personas_personas_CrearGerenteId",
                        column: x => x.CrearGerenteId,
                        principalTable: "personas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_personas_reservas_CrearReservaId",
                        column: x => x.CrearReservaId,
                        principalTable: "reservas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_personas_vehiculos_CrearVehiculoId",
                        column: x => x.CrearVehiculoId,
                        principalTable: "vehiculos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_personas_CrearAuxiliarId",
                table: "personas",
                column: "CrearAuxiliarId");

            migrationBuilder.CreateIndex(
                name: "IX_personas_CrearClienteId",
                table: "personas",
                column: "CrearClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_personas_CrearGerenteId",
                table: "personas",
                column: "CrearGerenteId");

            migrationBuilder.CreateIndex(
                name: "IX_personas_CrearReservaId",
                table: "personas",
                column: "CrearReservaId");

            migrationBuilder.CreateIndex(
                name: "IX_personas_CrearVehiculoId",
                table: "personas",
                column: "CrearVehiculoId");

            migrationBuilder.CreateIndex(
                name: "IX_reservas_EspacioId",
                table: "reservas",
                column: "EspacioId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "personas");

            migrationBuilder.DropTable(
                name: "reportes");

            migrationBuilder.DropTable(
                name: "reservas");

            migrationBuilder.DropTable(
                name: "vehiculos");

            migrationBuilder.DropTable(
                name: "espacios");
        }
    }
}
