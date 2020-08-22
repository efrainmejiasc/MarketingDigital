using Microsoft.EntityFrameworkCore.Migrations;

namespace MarketingDigitalWebA8.Migrations
{
    public partial class joselelu : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_EmpresaCliente_Email",
                table: "EmpresaCliente",
                column: "Email",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_EmpresaCliente_Email",
                table: "EmpresaCliente");
        }
    }
}
