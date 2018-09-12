using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class adduserwallet : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserWallet",
                table: "Deposit",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserWallet",
                table: "Deposit");
        }
    }
}
