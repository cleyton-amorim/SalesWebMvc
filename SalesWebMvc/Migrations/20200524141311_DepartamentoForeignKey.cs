using Microsoft.EntityFrameworkCore.Migrations;

namespace SalesWebMvc.Migrations
{
    public partial class DepartamentoForeignKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vendedor_Departamento_DepartId",
                table: "Vendedor");

            migrationBuilder.DropIndex(
                name: "IX_Vendedor_DepartId",
                table: "Vendedor");

            migrationBuilder.DropColumn(
                name: "DepartId",
                table: "Vendedor");

            migrationBuilder.AddColumn<int>(
                name: "DepartamentoId",
                table: "Vendedor",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Vendedor_DepartamentoId",
                table: "Vendedor",
                column: "DepartamentoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Vendedor_Departamento_DepartamentoId",
                table: "Vendedor",
                column: "DepartamentoId",
                principalTable: "Departamento",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vendedor_Departamento_DepartamentoId",
                table: "Vendedor");

            migrationBuilder.DropIndex(
                name: "IX_Vendedor_DepartamentoId",
                table: "Vendedor");

            migrationBuilder.DropColumn(
                name: "DepartamentoId",
                table: "Vendedor");

            migrationBuilder.AddColumn<int>(
                name: "DepartId",
                table: "Vendedor",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Vendedor_DepartId",
                table: "Vendedor",
                column: "DepartId");

            migrationBuilder.AddForeignKey(
                name: "FK_Vendedor_Departamento_DepartId",
                table: "Vendedor",
                column: "DepartId",
                principalTable: "Departamento",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
