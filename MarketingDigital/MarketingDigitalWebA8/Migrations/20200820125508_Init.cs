using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MarketingDigitalWebA8.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EmpresaCliente",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INT", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "VARCHAR(50)", nullable: false),
                    LastName = table.Column<string>(type: "VARCHAR(50)", nullable: false),
                    Email = table.Column<string>(type: "VARCHAR(50)", nullable: false),
                    Password = table.Column<string>(type: "VARCHAR(100)", nullable: false),
                    Company = table.Column<string>(type: "VARCHAR(50)", nullable: true),
                    Phone = table.Column<string>(type: "VARCHAR(50)", nullable: true),
                    Status = table.Column<bool>(type: "BIT", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "DATETIME", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmpresaCliente", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmpresaCliente");
        }
    }
}
