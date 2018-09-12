using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class AddCurrencyInBank : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CurrencyId",
                table: "Bank",
                nullable: true,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Bank_CurrencyId",
                table: "Bank",
                column: "CurrencyId");

            migrationBuilder.AddForeignKey(
                name: "FK_Bank_Currency_CurrencyId",
                table: "Bank",
                column: "CurrencyId",
                principalTable: "Currency",
                principalColumn: "Id"
                /*onDelete: ReferentialAction.Cascade*/);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bank_Currency_CurrencyId",
                table: "Bank");

            migrationBuilder.DropIndex(
                name: "IX_Bank_CurrencyId",
                table: "Bank");

            migrationBuilder.DropColumn(
                name: "CurrencyId",
                table: "Bank");
        }
    }
}
