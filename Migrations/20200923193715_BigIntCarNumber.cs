using Microsoft.EntityFrameworkCore.Migrations;

namespace CardApp.Migrations
{
    public partial class BigIntCarNumber : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<long>(
                name: "CardNumber",
                table: "Cards",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldMaxLength: 16);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "CardNumber",
                table: "Cards",
                type: "int",
                maxLength: 16,
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint");
        }
    }
}
