using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class AddDescribe : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Describe",
                table: "Wallet",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Describe",
                table: "User",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Describe",
                table: "Deposit",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Describe",
                table: "Currency",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Describe",
                table: "Bank",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Describe",
                table: "Wallet");

            migrationBuilder.DropColumn(
                name: "Describe",
                table: "User");

            migrationBuilder.DropColumn(
                name: "Describe",
                table: "Deposit");

            migrationBuilder.DropColumn(
                name: "Describe",
                table: "Currency");

            migrationBuilder.DropColumn(
                name: "Describe",
                table: "Bank");
        }
    }
}
