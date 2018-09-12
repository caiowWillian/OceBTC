using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class DASDADAS : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
        //    migrationBuilder.AddColumn<int>(
        //        name: "CurrencyId",
        //        table: "Wallet",
        //        nullable: false,
        //        defaultValue: 0);

        //    migrationBuilder.CreateIndex(
        //        name: "IX_Wallet_CurrencyId",
        //        table: "Wallet",
        //        column: "CurrencyId");

        //    migrationBuilder.AddForeignKey(
        //        name: "FK_Wallet_Currency_CurrencyId",
        //        table: "Wallet",
        //        column: "CurrencyId",
        //        principalTable: "Currency",
        //        principalColumn: "Id",
        //        onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropForeignKey(
            //    name: "FK_Wallet_Currency_CurrencyId",
            //    table: "Wallet");

            //migrationBuilder.DropIndex(
            //    name: "IX_Wallet_CurrencyId",
            //    table: "Wallet");

            //migrationBuilder.DropColumn(
            //    name: "CurrencyId",
            //    table: "Wallet");
        }
    }
}
