using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class alterlocationcurrency : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CurrencyId",
                table: "Deposit",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Deposit_CurrencyId",
                table: "Deposit",
                column: "CurrencyId");

            migrationBuilder.AddForeignKey(
                name: "FK_Deposit_Currency_CurrencyId",
                table: "Deposit",
                column: "CurrencyId",
                principalTable: "Currency",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Deposit_Currency_CurrencyId",
                table: "Deposit");

            migrationBuilder.DropIndex(
                name: "IX_Deposit_CurrencyId",
                table: "Deposit");

            migrationBuilder.DropColumn(
                name: "CurrencyId",
                table: "Deposit");
        }
    }
}
