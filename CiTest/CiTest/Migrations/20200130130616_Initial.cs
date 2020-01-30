using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CiTest.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Contracts",
                columns: table => new
                {
                    ContractCode = table.Column<string>(nullable: false),
                    PhaseOfContractField = table.Column<int>(nullable: false),
                    OriginalAmount = table.Column<decimal>(nullable: false),
                    OriginalAmountCurrency = table.Column<string>(nullable: true),
                    InstallmentAmountField = table.Column<int>(nullable: false),
                    CurrentBalance = table.Column<decimal>(nullable: false),
                    CurrentBalanceCurrency = table.Column<int>(nullable: false),
                    OverdueBalance = table.Column<decimal>(nullable: false),
                    OverdueBalanceCurrency = table.Column<int>(nullable: false),
                    DateOfLastPaymentField = table.Column<DateTime>(nullable: false),
                    NextPaymentDateField = table.Column<DateTime>(nullable: false),
                    DateAccountOpenedField = table.Column<DateTime>(nullable: false),
                    RealEndDateField = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contracts", x => x.ContractCode);
                });

            migrationBuilder.CreateTable(
                name: "Individuals",
                columns: table => new
                {
                    CustomerCodeField = table.Column<string>(nullable: false),
                    FirstNameField = table.Column<string>(nullable: true),
                    LastNameField = table.Column<string>(nullable: true),
                    GenderField = table.Column<int>(nullable: false),
                    DateOfBirthField = table.Column<DateTime>(nullable: false),
                    ContractCode = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Individuals", x => x.CustomerCodeField);
                    table.ForeignKey(
                        name: "FK_Individuals_Contracts_ContractCode",
                        column: x => x.ContractCode,
                        principalTable: "Contracts",
                        principalColumn: "ContractCode",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Individuals_ContractCode",
                table: "Individuals",
                column: "ContractCode");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Individuals");

            migrationBuilder.DropTable(
                name: "Contracts");
        }
    }
}
