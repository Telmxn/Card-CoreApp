using Microsoft.EntityFrameworkCore.Migrations;

namespace CardApp.Migrations
{
    public partial class CarNumberAdedCard : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CardNumber",
                table: "Cards",
                maxLength: 16,
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CardNumber",
                table: "Cards");
        }
    }
}
