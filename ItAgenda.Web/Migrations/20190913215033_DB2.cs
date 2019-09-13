using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ItAgenda.Web.Migrations
{
    public partial class DB2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Empleados_Departamentos_DeptarmentoId",
                table: "Empleados");

            migrationBuilder.RenameColumn(
                name: "DeptarmentoId",
                table: "Empleados",
                newName: "DepartamentoId");

            migrationBuilder.RenameIndex(
                name: "IX_Empleados_DeptarmentoId",
                table: "Empleados",
                newName: "IX_Empleados_DepartamentoId");

            migrationBuilder.CreateTable(
                name: "TipoPrioridades",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<int>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoPrioridades", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TipoRequerimientos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoRequerimientos", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Empleados_Departamentos_DepartamentoId",
                table: "Empleados",
                column: "DepartamentoId",
                principalTable: "Departamentos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Empleados_Departamentos_DepartamentoId",
                table: "Empleados");

            migrationBuilder.DropTable(
                name: "TipoPrioridades");

            migrationBuilder.DropTable(
                name: "TipoRequerimientos");

            migrationBuilder.RenameColumn(
                name: "DepartamentoId",
                table: "Empleados",
                newName: "DeptarmentoId");

            migrationBuilder.RenameIndex(
                name: "IX_Empleados_DepartamentoId",
                table: "Empleados",
                newName: "IX_Empleados_DeptarmentoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Empleados_Departamentos_DeptarmentoId",
                table: "Empleados",
                column: "DeptarmentoId",
                principalTable: "Departamentos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
