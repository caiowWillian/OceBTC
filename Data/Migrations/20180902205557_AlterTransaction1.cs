using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class AlterTransaction1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "Value",
                table: "Transaction",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.CreateTable(
                name: "TransactionAlter",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CurrencyId = table.Column<int>(nullable: false),
                    Value = table.Column<double>(nullable: false),
                    Make = table.Column<bool>(nullable: false),
                    TransactionId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TransactionAlter", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TransactionAlter_Currency_CurrencyId",
                        column: x => x.CurrencyId,
                        principalTable: "Currency",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TransactionAlter_Transaction_TransactionId",
                        column: x => x.TransactionId,
                        principalTable: "Transaction",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TransactionAlter_CurrencyId",
                table: "TransactionAlter",
                column: "CurrencyId");

            migrationBuilder.CreateIndex(
                name: "IX_TransactionAlter_TransactionId",
                table: "TransactionAlter",
                column: "TransactionId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TransactionAlter");

            migrationBuilder.DropColumn(
                name: "Value",
                table: "Transaction");
        }
    }
}
