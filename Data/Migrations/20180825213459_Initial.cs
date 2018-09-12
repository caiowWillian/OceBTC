using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bank",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    InputDate = table.Column<DateTime>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: true),
                    Ativo = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bank", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Currency",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    InputDate = table.Column<DateTime>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: true),
                    Ativo = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Currency", x => x.Id);
                });

            //migrationBuilder.CreateTable(
            //    name: "ImgUser",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
            //        MimeType = table.Column<string>(nullable: true),
            //        FileName = table.Column<string>(nullable: true),
            //        FileContentBase64 = table.Column<string>(nullable: true),
            //        IdNews = table.Column<int>(nullable: false),
            //        Deletado = table.Column<bool>(nullable: false),
            //        DataCadastro = table.Column<DateTime>(nullable: false),
            //        DataAlteracao = table.Column<DateTime>(nullable: true),
            //        FileLenght = table.Column<long>(nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_ImgUser", x => x.Id);
            //    });

            migrationBuilder.CreateTable(
                name: "Wallet",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    InputDate = table.Column<DateTime>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: true),
                    Ativo = table.Column<bool>(nullable: false),
                    Guid = table.Column<string>(nullable: true),
                    CurrencyId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Wallet", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Wallet_Currency_CurrencyId",
                        column: x => x.CurrencyId,
                        principalTable: "Currency",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            //migrationBuilder.CreateTable(
            //    name: "User",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
            //        InputDate = table.Column<DateTime>(nullable: false),
            //        UpdateDate = table.Column<DateTime>(nullable: true),
            //        Ativo = table.Column<bool>(nullable: false),
            //        Name = table.Column<string>(nullable: false),
            //        Cep = table.Column<string>(nullable: false),
            //        Email = table.Column<string>(nullable: false),
            //        Pw = table.Column<string>(nullable: false),
            //        Cpf = table.Column<string>(nullable: false),
            //        Admin = table.Column<bool>(nullable: false),
            //        ImgUserId = table.Column<int>(nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_User", x => x.Id);
            //        table.ForeignKey(
            //            name: "FK_User_ImgUser_ImgUserId",
            //            column: x => x.ImgUserId,
            //            principalTable: "ImgUser",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Restrict);
            //    });

            migrationBuilder.CreateTable(
                name: "Deposit",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    InputDate = table.Column<DateTime>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: true),
                    Ativo = table.Column<bool>(nullable: false),
                    UserId = table.Column<int>(nullable: false),
                    Value = table.Column<double>(nullable: false),
                    WalletId = table.Column<int>(nullable: false),
                    BankId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Deposit", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Deposit_Bank_BankId",
                        column: x => x.BankId,
                        principalTable: "Bank",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Deposit_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Deposit_Wallet_WalletId",
                        column: x => x.WalletId,
                        principalTable: "Wallet",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Deposit_BankId",
                table: "Deposit",
                column: "BankId");

            migrationBuilder.CreateIndex(
                name: "IX_Deposit_UserId",
                table: "Deposit",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Deposit_WalletId",
                table: "Deposit",
                column: "WalletId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_User_ImgUserId",
            //    table: "User",
            //    column: "ImgUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Wallet_CurrencyId",
                table: "Wallet",
                column: "CurrencyId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropTable(
            //    name: "Deposit");

            //migrationBuilder.DropTable(
            //    name: "Bank");

            //migrationBuilder.DropTable(
            //    name: "User");

            //migrationBuilder.DropTable(
            //    name: "Wallet");

            //migrationBuilder.DropTable(
            //    name: "ImgUser");

            //migrationBuilder.DropTable(
            //    name: "Currency");
        }
    }
}
