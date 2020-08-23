using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MarketingDigitalWebA8.Migrations
{
    public partial class applog2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AppLog",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INT", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "VARCHAR(70)", nullable: true),
                    Method = table.Column<string>(type: "VARCHAR(70)", nullable: true),
                    Exception = table.Column<string>(type: "VARCHAR(4000)", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "DATETIME", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppLog", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AppLog");
        }
    }
}
