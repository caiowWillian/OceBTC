using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class DepositAllowNull : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Deposit_Bank_BankId",
                table: "Deposit");

            migrationBuilder.DropForeignKey(
                name: "FK_Deposit_Wallet_WalletId",
                table: "Deposit");

            migrationBuilder.AlterColumn<int>(
                name: "WalletId",
                table: "Deposit",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "BankId",
                table: "Deposit",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Deposit_Bank_BankId",
                table: "Deposit",
                column: "BankId",
                principalTable: "Bank",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Deposit_Wallet_WalletId",
                table: "Deposit",
                column: "WalletId",
                principalTable: "Wallet",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Deposit_Bank_BankId",
                table: "Deposit");

            migrationBuilder.DropForeignKey(
                name: "FK_Deposit_Wallet_WalletId",
                table: "Deposit");

            migrationBuilder.AlterColumn<int>(
                name: "WalletId",
                table: "Deposit",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "BankId",
                table: "Deposit",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Deposit_Bank_BankId",
                table: "Deposit",
                column: "BankId",
                principalTable: "Bank",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Deposit_Wallet_WalletId",
                table: "Deposit",
                column: "WalletId",
                principalTable: "Wallet",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
