using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class AddDepositWalletCurrency : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropForeignKey(
            //    name: "FK_Deposit_Currency_CurrencyId",
            //    table: "Deposit");

            //migrationBuilder.DropForeignKey(
            //    name: "FK_Wallet_Currency_CurrencyId",
            //    table: "Wallet");

            //migrationBuilder.DropIndex(
            //    name: "IX_Wallet_CurrencyId",
            //    table: "Wallet");

            //migrationBuilder.DropIndex(
            //    name: "IX_Deposit_CurrencyId",
            //    table: "Deposit");

            //migrationBuilder.DropColumn(
            //    name: "CurrencyId",
            //    table: "Wallet");

            //migrationBuilder.DropColumn(
            //    name: "CurrencyId",
            //    table: "Deposit");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.AddColumn<int>(
            //    name: "CurrencyId",
            //    table: "Wallet",
            //    nullable: false,
            //    defaultValue: 0);

            //migrationBuilder.AddColumn<int>(
            //    name: "CurrencyId",
            //    table: "Deposit",
            //    nullable: false,
            //    defaultValue: 0);

            //migrationBuilder.CreateIndex(
            //    name: "IX_Wallet_CurrencyId",
            //    table: "Wallet",
            //    column: "CurrencyId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Deposit_CurrencyId",
            //    table: "Deposit",
            //    column: "CurrencyId");

            //migrationBuilder.AddForeignKey(
            //    name: "FK_Deposit_Currency_CurrencyId",
            //    table: "Deposit",
            //    column: "CurrencyId",
            //    principalTable: "Currency",
            //    principalColumn: "Id",
            //    onDelete: ReferentialAction.Cascade);

            //migrationBuilder.AddForeignKey(
            //    name: "FK_Wallet_Currency_CurrencyId",
            //    table: "Wallet",
            //    column: "CurrencyId",
            //    principalTable: "Currency",
            //    principalColumn: "Id",
            //    onDelete: ReferentialAction.Cascade);
        }
    }
}
