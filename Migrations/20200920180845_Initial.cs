using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CardApp.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cards",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CardHolder = table.Column<string>(maxLength: 255, nullable: false),
                    ExpDate = table.Column<DateTime>(nullable: false),
                    Balance = table.Column<int>(nullable: false),
                    CVC = table.Column<int>(maxLength: 4, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cards", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cards");
        }
    }
}
