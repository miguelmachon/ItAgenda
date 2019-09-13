using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ItAgenda.Web.Migrations
{
    public partial class DB3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Requerimentos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FechaCreacion = table.Column<DateTime>(nullable: false),
                    FechaAprobacion = table.Column<DateTime>(nullable: false),
                    EmpleadoId = table.Column<int>(nullable: true),
                    TipoPrioridadId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Requerimentos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Requerimentos_Empleados_EmpleadoId",
                        column: x => x.EmpleadoId,
                        principalTable: "Empleados",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Requerimentos_TipoPrioridades_TipoPrioridadId",
                        column: x => x.TipoPrioridadId,
                        principalTable: "TipoPrioridades",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RequerimientoDetalles",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Detalle = table.Column<int>(maxLength: 50, nullable: false),
                    RequerimentoId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RequerimientoDetalles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RequerimientoDetalles_Requerimentos_RequerimentoId",
                        column: x => x.RequerimentoId,
                        principalTable: "Requerimentos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Requerimentos_EmpleadoId",
                table: "Requerimentos",
                column: "EmpleadoId");

            migrationBuilder.CreateIndex(
                name: "IX_Requerimentos_TipoPrioridadId",
                table: "Requerimentos",
                column: "TipoPrioridadId");

            migrationBuilder.CreateIndex(
                name: "IX_RequerimientoDetalles_RequerimentoId",
                table: "RequerimientoDetalles",
                column: "RequerimentoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RequerimientoDetalles");

            migrationBuilder.DropTable(
                name: "Requerimentos");
        }
    }
}
