using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PrestamApp.Persistence.Migrations
{
    public partial class SeedDataBase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "Payments",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UrlFile",
                table: "Loans",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UrlFile",
                table: "Contacts",
                maxLength: 50,
                nullable: true);

            migrationBuilder.CreateTable(
                name: "TimeFrames",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Description = table.Column<string>(nullable: true),
                    CountDay = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TimeFrames", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Payments",
                columns: new[] { "PaymentID", "CapitalAmount", "Code", "CreatedBy", "CreatedDate", "Date", "InterestAmount", "LateFee", "ModifiedBy", "ModifiedDate", "PendigBalance", "TotalBalance" },
                values: new object[,]
                {
                    { 1, 1538.46m, "P-001", null, null, new DateTime(2018, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 461.54m, 0.00m, null, null, 0.00m, 2000.00m },
                    { 29, 105.77m, "P-029", null, null, new DateTime(2018, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 69.23m, 0.00m, null, null, 125.00m, 175.00m },
                    { 30, 4466.67m, "P-030", null, null, new DateTime(2018, 5, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1563.33m, 0.00m, null, null, 0.00m, 6030.00m },
                    { 31, 4466.67m, "P-031", null, null, new DateTime(2018, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1563.33m, 0.00m, null, null, 0.00m, 6030.00m },
                    { 32, 4466.67m, "P-032", null, null, new DateTime(2018, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1563.33m, 0.00m, null, null, 0.00m, 6030.00m },
                    { 33, 4466.67m, "P-033", null, null, new DateTime(2018, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 1563.33m, 0.00m, null, null, 0.00m, 6030.00m },
                    { 34, 4466.67m, "P-034", null, null, new DateTime(2018, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1563.33m, 0.00m, null, null, 0.00m, 6030.00m },
                    { 35, 4466.67m, "P-035", null, null, new DateTime(2018, 6, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 1563.33m, 0.00m, null, null, 0.00m, 6030.00m },
                    { 36, 3790.00m, "P-036", null, null, new DateTime(2018, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 1563.33m, 0.00m, null, null, 1120.00m, 4910.00m },
                    { 37, 384.62m, "P-037", null, null, new DateTime(2018, 12, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 115.38m, 0.00m, null, null, 0.00m, 500.00m },
                    { 38, 1000.00m, "P-038", null, null, new DateTime(2018, 12, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 350.00m, 0.00m, null, null, 0.00m, 1350.00m },
                    { 39, 1000.00m, "P-039", null, null, new DateTime(2018, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 400.00m, 0.00m, null, null, 0.00m, 1400.00m },
                    { 40, 1000.00m, "P-040", null, null, new DateTime(2018, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 400.00m, 0.00m, null, null, 0.00m, 1400.00m },
                    { 41, 1000.00m, "P-041", null, null, new DateTime(2018, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 400.00m, 0.00m, null, null, 0.00m, 1400.00m },
                    { 42, 1000.00m, "P-042", null, null, new DateTime(2018, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 400.00m, 0.00m, null, null, 0.00m, 1400.00m },
                    { 43, 1000.00m, "P-043", null, null, new DateTime(2018, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 400.00m, 0.00m, null, null, 0.00m, 1400.00m },
                    { 44, 1000.00m, "P-044", null, null, new DateTime(2018, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 400.00m, 0.00m, null, null, 0.00m, 1400.00m },
                    { 45, 1000.00m, "P-045", null, null, new DateTime(2018, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 400.00m, 0.00m, null, null, 0.00m, 1400.00m },
                    { 46, 1000.00m, "P-046", null, null, new DateTime(2018, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 400.00m, 0.00m, null, null, 0.00m, 1400.00m },
                    { 47, 384.62m, "P-047", null, null, new DateTime(2018, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 115.38m, 0.00m, null, null, 0.00m, 500m },
                    { 48, 384.62m, "P-048", null, null, new DateTime(2018, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 115.38m, 0.00m, null, null, 0.00m, 500m },
                    { 49, 384.62m, "P-049", null, null, new DateTime(2018, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 115.38m, 0.00m, null, null, 0.00m, 500m },
                    { 27, 230.77m, "P-027", null, null, new DateTime(2018, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 69.23m, 0.00m, null, null, 0.00m, 300.00m },
                    { 26, 230.77m, "P-026", null, null, new DateTime(2018, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 69.23m, 0.00m, null, null, 0.00m, 300.00m },
                    { 28, 230.77m, "P-028", null, null, new DateTime(2018, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 69.23m, 0.00m, null, null, 0.00m, 300.00m },
                    { 24, 230.77m, "P-024", null, null, new DateTime(2017, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 69.23m, 0.00m, null, null, 0.00m, 300.00m },
                    { 2, 1538.46m, "P-002", null, null, new DateTime(2018, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 461.54m, 0.00m, null, null, 0.00m, 2000.00m },
                    { 3, 1538.46m, "P-003", null, null, new DateTime(2018, 12, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 461.54m, 0.00m, null, null, 0.00m, 2000.00m },
                    { 4, 1538.46m, "P-004", null, null, new DateTime(2018, 12, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 461.54m, 0.00m, null, null, 0.00m, 2000.00m },
                    { 5, 666.67m, "P-005", null, null, new DateTime(2018, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 233.33m, 0.00m, null, null, 0.00m, 900.00m },
                    { 6, 666.67m, "P-006", null, null, new DateTime(2018, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 233.33m, 0.00m, null, null, 0.00m, 900.00m },
                    { 7, 666.67m, "P-007", null, null, new DateTime(2018, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 233.33m, 0.00m, null, null, 0.00m, 900.00m },
                    { 8, 666.67m, "P-008", null, null, new DateTime(2018, 12, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 233.33m, 0.00m, null, null, 0.00m, 900.00m },
                    { 9, 666.67m, "P-009", null, null, new DateTime(2018, 12, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 233.33m, 0.00m, null, null, 0.00m, 900.00m },
                    { 10, 666.67m, "P-010", null, null, new DateTime(2018, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 233.33m, 0.00m, null, null, 0.00m, 900.00m },
                    { 25, 230.77m, "P-025", null, null, new DateTime(2017, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 69.23m, 0.00m, null, null, 0.00m, 300.00m },
                    { 12, 666.67m, "P-012", null, null, new DateTime(2018, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 233.33m, 0.00m, null, null, 0.00m, 900.00m },
                    { 11, 666.67m, "P-011", null, null, new DateTime(2018, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 233.33m, 0.00m, null, null, 0.00m, 900.00m },
                    { 14, 666.67m, "P-014", null, null, new DateTime(2018, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 233.33m, 0.00m, null, null, 0.00m, 900.00m },
                    { 23, 769.23m, "P-023", null, null, new DateTime(2017, 9, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 230.77m, 0.00m, null, null, 0.00m, 1000.00m },
                    { 13, 666.67m, "P-013", null, null, new DateTime(2018, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 233.33m, 0.00m, null, null, 0.00m, 900.00m },
                    { 21, 769.23m, "P-021", null, null, new DateTime(2017, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 230.77m, 0.00m, null, null, 0.00m, 1000.00m },
                    { 20, 769.23m, "P-020", null, null, new DateTime(2017, 8, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 230.77m, 0.00m, null, null, 0.00m, 1000.00m },
                    { 22, 769.23m, "P-022", null, null, new DateTime(2017, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 230.77m, 0.00m, null, null, 0.00m, 1000.00m },
                    { 18, 769.23m, "P-018", null, null, new DateTime(2017, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 230.77m, 0.00m, null, null, 0.00m, 1000.00m },
                    { 17, 769.23m, "P-017", null, null, new DateTime(2017, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 230.77m, 0.00m, null, null, 0.00m, 1000.00m },
                    { 16, 666.67m, "P-016", null, null, new DateTime(2018, 12, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 233.33m, 0.00m, null, null, 0.00m, 900.00m },
                    { 15, 666.67m, "P-015", null, null, new DateTime(2018, 12, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 233.33m, 0.00m, null, null, 0.00m, 900.00m },
                    { 19, 769.23m, "P-019", null, null, new DateTime(2017, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 230.77m, 0.00m, null, null, 0.00m, 1000.00m }
                });

            migrationBuilder.InsertData(
                table: "TimeFrames",
                columns: new[] { "Id", "CountDay", "Description" },
                values: new object[,]
                {
                    { 5, 30, "Mensual" },
                    { 1, 1, "Diario" },
                    { 2, 2, "Interdiario" },
                    { 3, 7, "Semanal" },
                    { 4, 14, "Quincenal" },
                    { 6, 365, "Anual" }
                });

            migrationBuilder.InsertData(
                table: "Loans",
                columns: new[] { "LoanID", "Code", "ContactID", "CreatedBy", "CreatedDate", "EndDate", "Interest", "InterestRate", "IsActive", "LoanAmount", "LoanDate", "ModifiedBy", "ModifiedDate", "NumberOfDue", "NumeroCuotasPagadas", "SimpleInterest", "TimeFrameID", "TotalBalance", "TotalCapitalAmount", "UpToDate", "UrlFile" },
                values: new object[,]
                {
                    { 1, "L-001", 1, null, null, new DateTime(2019, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6000.00m, 2.50m, true, 20000.00m, new DateTime(2018, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 13, 4, true, 3, 18000.00m, 13846.16m, false, null },
                    { 2, "L-002", 2, null, null, new DateTime(2019, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 3500.00m, 2.50m, true, 10000.00m, new DateTime(2018, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 15, 5, true, 3, 9000.00m, 6666.65m, false, null },
                    { 3, "L-003", 3, null, null, new DateTime(2019, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 3500.00m, 2.50m, true, 10000.00m, new DateTime(2018, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 15, 7, true, 3, 7200.00m, 5333.31m, false, null },
                    { 4, "L-004", 4, null, null, new DateTime(2017, 10, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 3000.00m, 2.50m, true, 10000.00m, new DateTime(2017, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 13, 7, true, 3, 6298.00m, 4913.39m, false, null },
                    { 5, "L-005", 5, null, null, new DateTime(2017, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 600.00m, 2.50m, true, 2000.00m, new DateTime(2017, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 13, 0, true, 3, 2600.00m, 2000.00m, false, null },
                    { 6, "L-006", 5, null, null, new DateTime(2018, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 900.00m, 2.50m, true, 3000.00m, new DateTime(2017, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 13, 5, true, 3, 2225.00m, 1740.38m, false, null },
                    { 7, "L-007", 6, null, null, new DateTime(2018, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 23450.00m, 2.50m, true, 67000.00m, new DateTime(2018, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 15, 6, true, 3, 49360.00m, 36853.31m, false, null },
                    { 8, "L-008", 7, null, null, new DateTime(2019, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 1500.00m, 2.50m, true, 5000.00m, new DateTime(2018, 12, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 13, 1, true, 3, 6000.00m, 4615.38m, false, null },
                    { 9, "L-009", 8, null, null, new DateTime(2019, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 5250.00m, 2.50m, true, 15000.00m, new DateTime(2018, 12, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 15, 1, true, 3, 18900.00m, 14000.00m, false, null },
                    { 10, "L-010", 9, null, null, new DateTime(2019, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 8000.00m, 2.50m, true, 20000.00m, new DateTime(2018, 10, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 20, 8, true, 3, 16800.00m, 12000.00m, false, null },
                    { 11, "L-011", 9, null, null, new DateTime(2019, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 7000.00m, 2.50m, true, 20000.00m, new DateTime(2018, 12, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 15, 0, true, 3, 27000.00m, 20000.00m, false, null },
                    { 12, "L-012", 10, null, null, new DateTime(2019, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 1500.00m, 2.50m, true, 5000.00m, new DateTime(2018, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 13, 3, true, 3, 4000.00m, 3846.14m, false, null }
                });

            migrationBuilder.InsertData(
                table: "Dues",
                columns: new[] { "DueID", "AdvancePayment", "CapitalAmount", "CreatedBy", "CreatedDate", "Date", "DueIsPaidOff", "DueNumber", "InterestAmount", "LateFee", "LoanID", "ModifiedBy", "ModifiedDate", "PaymentAmount", "PendingBalance" },
                values: new object[,]
                {
                    { 1, null, 0.00m, null, null, new DateTime(2018, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 1, 0.00m, 0.00m, 1, null, null, 0.00m, 0.00m },
                    { 112, null, 384.62m, null, null, new DateTime(2019, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 13, 115.38m, 0.00m, 8, null, null, 500.00m, 0.00m },
                    { 113, null, 0.00m, null, null, new DateTime(2018, 12, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 1, 0.00m, 0.00m, 9, null, null, 0.00m, 0.00m },
                    { 114, null, 1000.00m, null, null, new DateTime(2018, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 2, 350.00m, 0.00m, 9, null, null, 1350.00m, 0.00m },
                    { 115, null, 1000.00m, null, null, new DateTime(2019, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 3, 350.00m, 0.00m, 9, null, null, 1350.00m, 0.00m },
                    { 116, null, 1000.00m, null, null, new DateTime(2019, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 4, 350.00m, 0.00m, 9, null, null, 1350.00m, 0.00m },
                    { 117, null, 1000.00m, null, null, new DateTime(2019, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 5, 350.00m, 0.00m, 9, null, null, 1350.00m, 0.00m },
                    { 118, null, 1000.00m, null, null, new DateTime(2019, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 6, 350.00m, 0.00m, 9, null, null, 1350.00m, 0.00m },
                    { 119, null, 1000.00m, null, null, new DateTime(2019, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 7, 350.00m, 0.00m, 9, null, null, 1350.00m, 0.00m },
                    { 111, null, 384.62m, null, null, new DateTime(2019, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 12, 115.38m, 0.00m, 8, null, null, 500.00m, 0.00m },
                    { 120, null, 1000.00m, null, null, new DateTime(2019, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 8, 350.00m, 0.00m, 9, null, null, 1350.00m, 0.00m },
                    { 122, null, 1000.00m, null, null, new DateTime(2019, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 10, 350.00m, 0.00m, 9, null, null, 1350.00m, 0.00m },
                    { 123, null, 1000.00m, null, null, new DateTime(2019, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 11, 350.00m, 0.00m, 9, null, null, 1350.00m, 0.00m },
                    { 124, null, 1000.00m, null, null, new DateTime(2019, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 12, 350.00m, 0.00m, 9, null, null, 1350.00m, 0.00m },
                    { 125, null, 1000.00m, null, null, new DateTime(2019, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 13, 350.00m, 0.00m, 9, null, null, 1350.00m, 0.00m },
                    { 126, null, 1000.00m, null, null, new DateTime(2019, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 14, 350.00m, 0.00m, 9, null, null, 1350.00m, 0.00m },
                    { 127, null, 1000.00m, null, null, new DateTime(2019, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 15, 350.00m, 0.00m, 9, null, null, 1350.00m, 0.00m },
                    { 128, null, 0.00m, null, null, new DateTime(2018, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 1, 0.00m, 0.00m, 10, null, null, 0.00m, 0.00m },
                    { 129, null, 0.00m, null, null, new DateTime(2018, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 2, 0.00m, 0.00m, 10, null, null, 0.00m, 0.00m },
                    { 121, null, 1000.00m, null, null, new DateTime(2019, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 9, 350.00m, 0.00m, 9, null, null, 1350.00m, 0.00m },
                    { 130, null, 0.00m, null, null, new DateTime(2018, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 3, 0.00m, 0.00m, 10, null, null, 0.00m, 0.00m },
                    { 110, null, 384.62m, null, null, new DateTime(2019, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 11, 115.38m, 0.00m, 8, null, null, 500.00m, 0.00m },
                    { 108, null, 384.62m, null, null, new DateTime(2019, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 9, 115.38m, 0.00m, 8, null, null, 500.00m, 0.00m },
                    { 90, null, 1120.00m, null, null, new DateTime(2018, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 7, 0.00m, 0.00m, 7, null, null, 4910.00m, 1120.00m },
                    { 91, null, 4466.67m, null, null, new DateTime(2018, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 8, 1563.33m, 0.00m, 7, null, null, 6030.00m, 0.00m },
                    { 92, null, 4466.67m, null, null, new DateTime(2018, 7, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 9, 1563.33m, 0.00m, 7, null, null, 6030.00m, 0.00m },
                    { 93, null, 4466.67m, null, null, new DateTime(2018, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 10, 1563.33m, 0.00m, 7, null, null, 6030.00m, 0.00m },
                    { 94, null, 4466.67m, null, null, new DateTime(2018, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 11, 1563.33m, 0.00m, 7, null, null, 6030.00m, 0.00m },
                    { 95, null, 4466.67m, null, null, new DateTime(2018, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 11, 1563.33m, 0.00m, 7, null, null, 6030.00m, 0.00m },
                    { 96, null, 4466.67m, null, null, new DateTime(2018, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 12, 1563.33m, 0.00m, 7, null, null, 6030.00m, 0.00m },
                    { 97, null, 4466.67m, null, null, new DateTime(2018, 8, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 13, 1563.33m, 0.00m, 7, null, null, 6030.00m, 0.00m },
                    { 109, null, 384.62m, null, null, new DateTime(2019, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 10, 115.38m, 0.00m, 8, null, null, 500.00m, 0.00m },
                    { 98, null, 4466.67m, null, null, new DateTime(2018, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 14, 1563.33m, 0.00m, 7, null, null, 6030.00m, 0.00m },
                    { 100, null, 0.00m, null, null, new DateTime(2018, 12, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 1, 0.00m, 0.00m, 8, null, null, 0.00m, 0.00m },
                    { 101, null, 384.62m, null, null, new DateTime(2018, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 2, 115.38m, 0.00m, 8, null, null, 500.00m, 0.00m },
                    { 102, null, 384.62m, null, null, new DateTime(2019, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 3, 115.38m, 0.00m, 8, null, null, 500.00m, 0.00m },
                    { 103, null, 384.62m, null, null, new DateTime(2019, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 4, 115.38m, 0.00m, 8, null, null, 500.00m, 0.00m },
                    { 104, null, 384.62m, null, null, new DateTime(2019, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 5, 115.38m, 0.00m, 8, null, null, 500.00m, 0.00m },
                    { 105, null, 384.62m, null, null, new DateTime(2019, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 6, 115.38m, 0.00m, 8, null, null, 500.00m, 0.00m },
                    { 106, null, 384.62m, null, null, new DateTime(2019, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 7, 115.38m, 0.00m, 8, null, null, 500.00m, 0.00m },
                    { 107, null, 384.62m, null, null, new DateTime(2019, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 8, 115.38m, 0.00m, 8, null, null, 500.00m, 0.00m },
                    { 99, null, 4466.67m, null, null, new DateTime(2018, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 15, 1563.33m, 0.00m, 7, null, null, 6030.00m, 0.00m },
                    { 89, null, 0.00m, null, null, new DateTime(2018, 6, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 6, 0.00m, 0.00m, 7, null, null, 0.00m, 0.00m },
                    { 131, null, 0.00m, null, null, new DateTime(2018, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 4, 0.00m, 0.00m, 10, null, null, 0.00m, 0.00m },
                    { 133, null, 0.00m, null, null, new DateTime(2018, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 6, 0.00m, 0.00m, 10, null, null, 0.00m, 0.00m },
                    { 156, null, 1333.33m, null, null, new DateTime(2019, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 9, 466.67m, 0.00m, 11, null, null, 1800.00m, 0.00m },
                    { 157, null, 1333.33m, null, null, new DateTime(2019, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 10, 466.67m, 0.00m, 11, null, null, 1800.00m, 0.00m },
                    { 158, null, 1333.33m, null, null, new DateTime(2019, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 11, 466.67m, 0.00m, 11, null, null, 1800.00m, 0.00m },
                    { 159, null, 1333.33m, null, null, new DateTime(2019, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 12, 466.67m, 0.00m, 11, null, null, 1800.00m, 0.00m },
                    { 160, null, 1333.33m, null, null, new DateTime(2019, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 13, 466.67m, 0.00m, 11, null, null, 1800.00m, 0.00m },
                    { 161, null, 1333.33m, null, null, new DateTime(2019, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 14, 466.67m, 0.00m, 11, null, null, 1800.00m, 0.00m },
                    { 162, null, 1333.33m, null, null, new DateTime(2019, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 15, 466.67m, 0.00m, 11, null, null, 1800.00m, 0.00m },
                    { 163, null, 0.00m, null, null, new DateTime(2018, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 1, 0.00m, 0.00m, 12, null, null, 0.00m, 0.00m },
                    { 155, null, 1333.33m, null, null, new DateTime(2019, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 8, 466.67m, 0.00m, 11, null, null, 1800.00m, 0.00m },
                    { 164, null, 0.00m, null, null, new DateTime(2018, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 2, 0.00m, 0.00m, 12, null, null, 0.00m, 0.00m },
                    { 166, null, 384.62m, null, null, new DateTime(2018, 12, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 4, 115.38m, 0.00m, 12, null, null, 500.00m, 0.00m },
                    { 167, null, 384.62m, null, null, new DateTime(2018, 12, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 5, 115.38m, 0.00m, 12, null, null, 500.00m, 0.00m },
                    { 168, null, 384.62m, null, null, new DateTime(2019, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 6, 115.38m, 0.00m, 12, null, null, 500.00m, 0.00m },
                    { 169, null, 384.62m, null, null, new DateTime(2019, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 7, 115.38m, 0.00m, 12, null, null, 500.00m, 0.00m },
                    { 170, null, 384.62m, null, null, new DateTime(2019, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 8, 115.38m, 0.00m, 12, null, null, 500.00m, 0.00m },
                    { 171, null, 384.62m, null, null, new DateTime(2019, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 9, 115.38m, 0.00m, 12, null, null, 500.00m, 0.00m },
                    { 172, null, 384.62m, null, null, new DateTime(2019, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 10, 115.38m, 0.00m, 12, null, null, 500.00m, 0.00m },
                    { 173, null, 384.62m, null, null, new DateTime(2019, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 11, 115.38m, 0.00m, 12, null, null, 500.00m, 0.00m },
                    { 165, null, 0.00m, null, null, new DateTime(2018, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 3, 0.00m, 0.00m, 12, null, null, 0.00m, 0.00m },
                    { 132, null, 0.00m, null, null, new DateTime(2018, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 5, 0.00m, 0.00m, 10, null, null, 0.00m, 0.00m },
                    { 154, null, 1333.33m, null, null, new DateTime(2019, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 7, 466.67m, 0.00m, 11, null, null, 1800.00m, 0.00m },
                    { 152, null, 1333.33m, null, null, new DateTime(2019, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 5, 466.67m, 0.00m, 11, null, null, 1800.00m, 0.00m },
                    { 134, null, 0.00m, null, null, new DateTime(2018, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 7, 0.00m, 0.00m, 10, null, null, 0.00m, 0.00m },
                    { 135, null, 0.00m, null, null, new DateTime(2018, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 8, 0.00m, 0.00m, 10, null, null, 0.00m, 0.00m },
                    { 136, null, 1000.00m, null, null, new DateTime(2018, 12, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 9, 400.00m, 0.00m, 10, null, null, 1400.00m, 0.00m },
                    { 137, null, 1000.00m, null, null, new DateTime(2018, 12, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 10, 400.00m, 0.00m, 10, null, null, 1400.00m, 0.00m },
                    { 138, null, 1000.00m, null, null, new DateTime(2019, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 11, 400.00m, 0.00m, 10, null, null, 1400.00m, 0.00m },
                    { 139, null, 1000.00m, null, null, new DateTime(2019, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 12, 400.00m, 0.00m, 10, null, null, 1400.00m, 0.00m },
                    { 140, null, 1000.00m, null, null, new DateTime(2019, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 13, 400.00m, 0.00m, 10, null, null, 1400.00m, 0.00m },
                    { 141, null, 1000.00m, null, null, new DateTime(2019, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 14, 400.00m, 0.00m, 10, null, null, 1400.00m, 0.00m },
                    { 153, null, 1333.33m, null, null, new DateTime(2019, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 6, 466.67m, 0.00m, 11, null, null, 1800.00m, 0.00m },
                    { 142, null, 1000.00m, null, null, new DateTime(2019, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 15, 400.00m, 0.00m, 10, null, null, 1400.00m, 0.00m },
                    { 144, null, 1000.00m, null, null, new DateTime(2019, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 17, 400.00m, 0.00m, 10, null, null, 1400.00m, 0.00m },
                    { 145, null, 1000.00m, null, null, new DateTime(2019, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 18, 400.00m, 0.00m, 10, null, null, 1400.00m, 0.00m },
                    { 146, null, 1000.00m, null, null, new DateTime(2019, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 19, 400.00m, 0.00m, 10, null, null, 1400.00m, 0.00m },
                    { 147, null, 1000.00m, null, null, new DateTime(2019, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 20, 400.00m, 0.00m, 10, null, null, 1400.00m, 0.00m },
                    { 148, null, 1333.33m, null, null, new DateTime(2018, 12, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 1, 466.67m, 0.00m, 11, null, null, 1800.00m, 0.00m },
                    { 149, null, 1333.33m, null, null, new DateTime(2019, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 2, 466.67m, 0.00m, 11, null, null, 1800.00m, 0.00m },
                    { 150, null, 1333.33m, null, null, new DateTime(2019, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 3, 466.67m, 0.00m, 11, null, null, 1800.00m, 0.00m },
                    { 151, null, 1333.33m, null, null, new DateTime(2019, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 4, 466.67m, 0.00m, 11, null, null, 1800.00m, 0.00m },
                    { 143, null, 1000.00m, null, null, new DateTime(2019, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 16, 400.00m, 0.00m, 10, null, null, 1400.00m, 0.00m },
                    { 174, null, 384.62m, null, null, new DateTime(2019, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 12, 115.38m, 0.00m, 12, null, null, 500.00m, 0.00m },
                    { 88, null, 0.00m, null, null, new DateTime(2018, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 5, 0.00m, 0.00m, 7, null, null, 0.00m, 0.00m },
                    { 86, null, 0.00m, null, null, new DateTime(2018, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 3, 0.00m, 0.00m, 7, null, null, 0.00m, 0.00m },
                    { 24, null, 666.67m, null, null, new DateTime(2019, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 11, 233.33m, 0.00m, 2, null, null, 900.00m, 0.00m },
                    { 25, null, 666.67m, null, null, new DateTime(2019, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 12, 233.33m, 0.00m, 2, null, null, 900.00m, 0.00m },
                    { 26, null, 666.67m, null, null, new DateTime(2019, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 13, 233.33m, 0.00m, 2, null, null, 900.00m, 0.00m },
                    { 27, null, 666.67m, null, null, new DateTime(2019, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 14, 233.33m, 0.00m, 2, null, null, 900.00m, 0.00m },
                    { 28, null, 666.67m, null, null, new DateTime(2019, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 15, 233.33m, 0.00m, 2, null, null, 900.00m, 0.00m },
                    { 29, null, 0.00m, null, null, new DateTime(2018, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 1, 0.00m, 0.00m, 3, null, null, 0.00m, 0.00m },
                    { 30, null, 0.00m, null, null, new DateTime(2018, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 2, 0.00m, 0.00m, 3, null, null, 0.00m, 0.00m },
                    { 31, null, 0.00m, null, null, new DateTime(2018, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 3, 0.00m, 0.00m, 3, null, null, 0.00m, 0.00m },
                    { 23, null, 666.67m, null, null, new DateTime(2019, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 10, 233.33m, 0.00m, 2, null, null, 900.00m, 0.00m },
                    { 32, null, 0.00m, null, null, new DateTime(2018, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 4, 0.00m, 0.00m, 3, null, null, 0.00m, 0.00m },
                    { 34, null, 0.00m, null, null, new DateTime(2018, 12, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 6, 0.00m, 0.00m, 3, null, null, 0.00m, 0.00m },
                    { 35, null, 0.00m, null, null, new DateTime(2018, 12, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 7, 0.00m, 0.00m, 3, null, null, 0.00m, 0.00m },
                    { 36, null, 666.67m, null, null, new DateTime(2019, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 8, 233.33m, 0.00m, 3, null, null, 900.00m, 0.00m },
                    { 37, null, 666.67m, null, null, new DateTime(2019, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 9, 233.33m, 0.00m, 3, null, null, 900.00m, 0.00m },
                    { 38, null, 666.67m, null, null, new DateTime(2019, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 10, 233.33m, 0.00m, 3, null, null, 900.00m, 0.00m },
                    { 39, null, 666.67m, null, null, new DateTime(2019, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 11, 233.33m, 0.00m, 3, null, null, 900.00m, 0.00m },
                    { 40, null, 666.67m, null, null, new DateTime(2019, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 12, 233.33m, 0.00m, 3, null, null, 900.00m, 0.00m },
                    { 41, null, 666.67m, null, null, new DateTime(2019, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 13, 233.33m, 0.00m, 3, null, null, 900.00m, 0.00m },
                    { 33, null, 0.00m, null, null, new DateTime(2018, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 5, 0.00m, 0.00m, 3, null, null, 0.00m, 0.00m },
                    { 42, null, 666.67m, null, null, new DateTime(2019, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 14, 233.33m, 0.00m, 3, null, null, 900.00m, 0.00m },
                    { 22, null, 666.67m, null, null, new DateTime(2019, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 9, 233.33m, 0.00m, 2, null, null, 900.00m, 0.00m },
                    { 20, null, 666.67m, null, null, new DateTime(2019, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 7, 233.33m, 0.00m, 2, null, null, 900.00m, 0.00m },
                    { 2, null, 0.00m, null, null, new DateTime(2018, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 2, 0.00m, 0.00m, 1, null, null, 0.00m, 0.00m },
                    { 3, null, 0.00m, null, null, new DateTime(2018, 12, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 3, 0.00m, 0.00m, 1, null, null, 0.00m, 0.00m },
                    { 4, null, 0.00m, null, null, new DateTime(2018, 12, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 4, 0.00m, 0m, 1, null, null, 0.00m, 0.00m },
                    { 5, null, 1538.46m, null, null, new DateTime(2019, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 5, 461.54m, 0.00m, 1, null, null, 2000.00m, 0.00m },
                    { 6, null, 1538.46m, null, null, new DateTime(2019, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 6, 461.54m, 0.00m, 1, null, null, 2000.00m, 0.00m },
                    { 7, null, 1538.46m, null, null, new DateTime(2019, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 7, 461.54m, 0.00m, 1, null, null, 2000.00m, 0.00m },
                    { 8, null, 1538.46m, null, null, new DateTime(2019, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 8, 461.54m, 0.00m, 1, null, null, 2000.00m, 0.00m },
                    { 9, null, 1538.46m, null, null, new DateTime(2019, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 9, 461.54m, 0.00m, 1, null, null, 2000.00m, 0.00m },
                    { 21, null, 666.67m, null, null, new DateTime(2019, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 8, 233.33m, 0.00m, 2, null, null, 900.00m, 0.00m },
                    { 10, null, 1538.46m, null, null, new DateTime(2019, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 10, 461.54m, 0.00m, 1, null, null, 2000.00m, 0.00m },
                    { 12, null, 1538.46m, null, null, new DateTime(2019, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 12, 461.54m, 0.00m, 1, null, null, 2000.00m, 0.00m },
                    { 13, null, 1538.46m, null, null, new DateTime(2019, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 13, 461.54m, 0.00m, 1, null, null, 2000.00m, 0.00m },
                    { 14, null, 0.00m, null, null, new DateTime(2018, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 1, 0.00m, 0.00m, 2, null, null, 0.00m, 0.00m },
                    { 15, null, 0.00m, null, null, new DateTime(2018, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 2, 0.00m, 0.00m, 2, null, null, 0.00m, 0.00m },
                    { 16, null, 0.00m, null, null, new DateTime(2018, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 3, 0.00m, 0.00m, 2, null, null, 0.00m, 0.00m },
                    { 17, null, 0.00m, null, null, new DateTime(2018, 12, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 4, 0.00m, 0.00m, 2, null, null, 0.00m, 0.00m },
                    { 18, null, 0.00m, null, null, new DateTime(2018, 12, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 5, 0.00m, 0.00m, 2, null, null, 0.00m, 0.00m },
                    { 19, null, 666.67m, null, null, new DateTime(2019, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 6, 233.33m, 0.00m, 2, null, null, 900.00m, 0.00m },
                    { 11, null, 1538.46m, null, null, new DateTime(2019, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 11, 461.54m, 0.00m, 1, null, null, 2000.00m, 0.00m },
                    { 87, null, 0.00m, null, null, new DateTime(2018, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 4, 0.00m, 0.00m, 7, null, null, 0.00m, 0.00m },
                    { 43, null, 666.67m, null, null, new DateTime(2019, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 15, 233.33m, 0.00m, 3, null, null, 900.00m, 0.00m },
                    { 45, null, 0.00m, null, null, new DateTime(2017, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 2, 0.00m, 0.00m, 4, null, null, 0.00m, 0.00m },
                    { 68, null, 153.85m, null, null, new DateTime(2017, 11, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 11, 46.15m, 0.00m, 5, null, null, 200.00m, 0.00m },
                    { 69, null, 153.85m, null, null, new DateTime(2017, 12, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 12, 46.15m, 0.00m, 5, null, null, 200.00m, 0.00m },
                    { 70, null, 153.85m, null, null, new DateTime(2017, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 13, 46.15m, 0.00m, 5, null, null, 200.00m, 0.00m },
                    { 71, null, 0.00m, null, null, new DateTime(2017, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 1, 0.00m, 0.00m, 6, null, null, 0.00m, 0.00m },
                    { 72, null, 0.00m, null, null, new DateTime(2017, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 2, 0.00m, 0.00m, 6, null, null, 0.00m, 0.00m },
                    { 73, null, 0.00m, null, null, new DateTime(2018, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 3, 0.00m, 0.00m, 6, null, null, 0.00m, 0.00m }
                });

            migrationBuilder.InsertData(
                table: "Dues",
                columns: new[] { "DueID", "AdvancePayment", "CapitalAmount", "CreatedBy", "CreatedDate", "Date", "DueIsPaidOff", "DueNumber", "InterestAmount", "LateFee", "LoanID", "ModifiedBy", "ModifiedDate", "PaymentAmount", "PendingBalance" },
                values: new object[,]
                {
                    { 74, null, 0.00m, null, null, new DateTime(2018, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 4, 0.00m, 0.00m, 6, null, null, 0.00m, 0.00m },
                    { 75, null, 0.00m, null, null, new DateTime(2018, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 5, 0.00m, 0.00m, 6, null, null, 0.00m, 0.00m },
                    { 67, null, 153.85m, null, null, new DateTime(2017, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 10, 46.15m, 0.00m, 5, null, null, 200.00m, 0.00m },
                    { 76, null, 125.00m, null, null, new DateTime(2018, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 6, 0.00m, 0.00m, 6, null, null, 175.00m, 125.00m },
                    { 78, null, 230.77m, null, null, new DateTime(2018, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 8, 69.23m, 0.00m, 6, null, null, 300.00m, 0.00m },
                    { 79, null, 230.77m, null, null, new DateTime(2018, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 9, 69.23m, 0.00m, 6, null, null, 300.00m, 0.00m },
                    { 80, null, 230.77m, null, null, new DateTime(2018, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 10, 69.23m, 0.00m, 6, null, null, 300.00m, 0.00m },
                    { 81, null, 230.77m, null, null, new DateTime(2018, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 11, 69.23m, 0.00m, 6, null, null, 300.00m, 0.00m },
                    { 82, null, 230.77m, null, null, new DateTime(2018, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 12, 69.23m, 0.00m, 6, null, null, 300.00m, 0.00m },
                    { 83, null, 230.77m, null, null, new DateTime(2018, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 13, 69.23m, 0.00m, 6, null, null, 300.00m, 0.00m },
                    { 84, null, 0.00m, null, null, new DateTime(2018, 5, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 1, 0.00m, 0.00m, 7, null, null, 0.00m, 0.00m },
                    { 85, null, 0.00m, null, null, new DateTime(2018, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 2, 0.00m, 0.00m, 7, null, null, 0.00m, 0.00m },
                    { 77, null, 230.77m, null, null, new DateTime(2018, 1, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 7, 69.23m, 0.00m, 6, null, null, 300.00m, 0.00m },
                    { 44, null, 0.00m, null, null, new DateTime(2017, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 1, 0.00m, 0.00m, 4, null, null, 0.00m, 0.00m },
                    { 66, null, 153.85m, null, null, new DateTime(2017, 11, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 9, 46.15m, 0.00m, 5, null, null, 200.00m, 0.00m },
                    { 64, null, 153.85m, null, null, new DateTime(2017, 10, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 7, 46.15m, 0.00m, 5, null, null, 200.00m, 0.00m },
                    { 46, null, 0.00m, null, null, new DateTime(2017, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 3, 0.00m, 0.00m, 4, null, null, 0.00m, 0.00m },
                    { 47, null, 0.00m, null, null, new DateTime(2017, 8, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 4, 0.00m, 0.00m, 4, null, null, 0.00m, 0.00m },
                    { 48, null, 0.00m, null, null, new DateTime(2017, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 5, 0.00m, 0.00m, 4, null, null, 0.00m, 0.00m },
                    { 49, null, 0.00m, null, null, new DateTime(2017, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 6, 0.00m, 0.00m, 4, null, null, 0.00m, 0.00m },
                    { 50, null, 0.00m, null, null, new DateTime(2017, 9, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 7, 0.00m, 0.00m, 4, null, null, 0.00m, 0.00m },
                    { 51, null, 769.23m, null, null, new DateTime(2017, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 8, 230.77m, 0.00m, 4, null, null, 1000.00m, 0.00m },
                    { 52, null, 769.23m, null, null, new DateTime(2017, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 9, 230.77m, 0.00m, 4, null, null, 1000.00m, 0.00m },
                    { 53, null, 769.23m, null, null, new DateTime(2017, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 10, 230.77m, 0.00m, 4, null, null, 1000.00m, 0.00m },
                    { 65, null, 153.85m, null, null, new DateTime(2017, 11, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 8, 46.15m, 0.00m, 5, null, null, 200.00m, 0.00m },
                    { 54, null, 769.23m, null, null, new DateTime(2017, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 11, 230.77m, 0.00m, 4, null, null, 1000.00m, 0.00m },
                    { 56, null, 769.23m, null, null, new DateTime(2017, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 12, 230.77m, 0.00m, 4, null, null, 1000.00m, 0.00m },
                    { 57, null, 769.23m, null, null, new DateTime(2017, 10, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 13, 230.77m, 0.00m, 4, null, null, 1000.00m, 0.00m },
                    { 58, null, 153.85m, null, null, new DateTime(2017, 9, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 1, 46.15m, 0.00m, 5, null, null, 200.00m, 0.00m },
                    { 59, null, 153.85m, null, null, new DateTime(2017, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 2, 46.15m, 0.00m, 5, null, null, 200.00m, 0.00m },
                    { 60, null, 153.85m, null, null, new DateTime(2017, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 3, 46.15m, 0.00m, 5, null, null, 200.00m, 0.00m },
                    { 61, null, 153.85m, null, null, new DateTime(2017, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 4, 46.15m, 0.00m, 5, null, null, 200.00m, 0.00m },
                    { 62, null, 153.85m, null, null, new DateTime(2017, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 5, 46.15m, 0.00m, 5, null, null, 200.00m, 0.00m },
                    { 63, null, 153.85m, null, null, new DateTime(2017, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 6, 46.15m, 0.00m, 5, null, null, 200.00m, 0.00m },
                    { 55, null, 769.23m, null, null, new DateTime(2017, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 11, 230.77m, 0.00m, 4, null, null, 1000.00m, 0.00m },
                    { 175, null, 384.62m, null, null, new DateTime(2019, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 13, 115.38m, 0.00m, 12, null, null, 500.00m, 0.00m }
                });

            migrationBuilder.InsertData(
                table: "DuesPayments",
                columns: new[] { "DueID", "PaymentID" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 74, 27 },
                    { 75, 28 },
                    { 76, 29 },
                    { 84, 30 },
                    { 85, 31 },
                    { 86, 32 },
                    { 87, 33 },
                    { 88, 34 },
                    { 89, 35 },
                    { 90, 36 },
                    { 100, 37 },
                    { 113, 38 },
                    { 128, 39 },
                    { 129, 40 },
                    { 130, 41 },
                    { 131, 42 },
                    { 132, 43 },
                    { 133, 44 },
                    { 134, 45 },
                    { 135, 46 },
                    { 163, 47 },
                    { 73, 26 },
                    { 164, 48 },
                    { 72, 25 },
                    { 50, 23 },
                    { 2, 2 },
                    { 3, 3 },
                    { 4, 4 },
                    { 14, 5 },
                    { 15, 6 },
                    { 16, 7 },
                    { 17, 8 },
                    { 18, 9 },
                    { 29, 10 },
                    { 30, 11 },
                    { 31, 12 },
                    { 32, 13 },
                    { 33, 14 },
                    { 34, 15 },
                    { 35, 16 },
                    { 44, 17 },
                    { 45, 18 },
                    { 46, 19 },
                    { 47, 20 },
                    { 48, 21 },
                    { 49, 22 },
                    { 71, 24 },
                    { 165, 49 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Loans_TimeFrameID",
                table: "Loans",
                column: "TimeFrameID");

            migrationBuilder.AddForeignKey(
                name: "FK_Loans_TimeFrames_TimeFrameID",
                table: "Loans",
                column: "TimeFrameID",
                principalTable: "TimeFrames",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Loans_TimeFrames_TimeFrameID",
                table: "Loans");

            migrationBuilder.DropTable(
                name: "TimeFrames");

            migrationBuilder.DropIndex(
                name: "IX_Loans_TimeFrameID",
                table: "Loans");

            migrationBuilder.DeleteData(
                table: "Dues",
                keyColumn: "DueID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Dues",
                keyColumn: "DueID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Dues",
                keyColumn: "DueID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Dues",
                keyColumn: "DueID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Dues",
                keyColumn: "DueID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Dues",
                keyColumn: "DueID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Dues",
                keyColumn: "DueID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Dues",
                keyColumn: "DueID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Dues",
                keyColumn: "DueID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Dues",
                keyColumn: "DueID",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Dues",
                keyColumn: "DueID",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Dues",
                keyColumn: "DueID",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Dues",
                keyColumn: "DueID",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Dues",
                keyColumn: "DueID",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Dues",
                keyColumn: "DueID",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Dues",
                keyColumn: "DueID",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Dues",
                keyColumn: "DueID",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Dues",
                keyColumn: "DueID",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Dues",
                keyColumn: "DueID",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Dues",
                keyColumn: "DueID",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Dues",
                keyColumn: "DueID",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Dues",
                keyColumn: "DueID",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Dues",
                keyColumn: "DueID",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Dues",
                keyColumn: "DueID",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Dues",
                keyColumn: "DueID",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Dues",
                keyColumn: "DueID",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Dues",
                keyColumn: "DueID",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Dues",
                keyColumn: "DueID",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Dues",
                keyColumn: "DueID",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Dues",
                keyColumn: "DueID",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Dues",
                keyColumn: "DueID",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Dues",
                keyColumn: "DueID",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Dues",
                keyColumn: "DueID",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Dues",
                keyColumn: "DueID",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Dues",
                keyColumn: "DueID",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Dues",
                keyColumn: "DueID",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Dues",
                keyColumn: "DueID",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Dues",
                keyColumn: "DueID",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Dues",
                keyColumn: "DueID",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Dues",
                keyColumn: "DueID",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Dues",
                keyColumn: "DueID",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Dues",
                keyColumn: "DueID",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Dues",
                keyColumn: "DueID",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Dues",
                keyColumn: "DueID",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Dues",
                keyColumn: "DueID",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Dues",
                keyColumn: "DueID",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Dues",
                keyColumn: "DueID",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Dues",
                keyColumn: "DueID",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Dues",
                keyColumn: "DueID",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Dues",
                keyColumn: "DueID",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Dues",
                keyColumn: "DueID",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Dues",
                keyColumn: "DueID",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Dues",
                keyColumn: "DueID",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Dues",
                keyColumn: "DueID",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Dues",
                keyColumn: "DueID",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Dues",
                keyColumn: "DueID",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Dues",
                keyColumn: "DueID",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Dues",
                keyColumn: "DueID",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Dues",
                keyColumn: "DueID",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Dues",
                keyColumn: "DueID",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Dues",
                keyColumn: "DueID",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Dues",
                keyColumn: "DueID",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Dues",
                keyColumn: "DueID",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Dues",
                keyColumn: "DueID",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Dues",
                keyColumn: "DueID",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Dues",
                keyColumn: "DueID",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Dues",
                keyColumn: "DueID",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Dues",
                keyColumn: "DueID",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Dues",
                keyColumn: "DueID",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Dues",
                keyColumn: "DueID",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Dues",
                keyColumn: "DueID",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Dues",
                keyColumn: "DueID",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Dues",
                keyColumn: "DueID",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Dues",
                keyColumn: "DueID",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Dues",
                keyColumn: "DueID",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Dues",
                keyColumn: "DueID",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Dues",
                keyColumn: "DueID",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Dues",
                keyColumn: "DueID",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Dues",
                keyColumn: "DueID",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Dues",
                keyColumn: "DueID",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Dues",
                keyColumn: "DueID",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Dues",
                keyColumn: "DueID",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "Dues",
                keyColumn: "DueID",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "Dues",
                keyColumn: "DueID",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "Dues",
                keyColumn: "DueID",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "Dues",
                keyColumn: "DueID",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "Dues",
                keyColumn: "DueID",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "Dues",
                keyColumn: "DueID",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "Dues",
                keyColumn: "DueID",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "Dues",
                keyColumn: "DueID",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "Dues",
                keyColumn: "DueID",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "Dues",
                keyColumn: "DueID",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "Dues",
                keyColumn: "DueID",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "Dues",
                keyColumn: "DueID",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "Dues",
                keyColumn: "DueID",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "Dues",
                keyColumn: "DueID",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "Dues",
                keyColumn: "DueID",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "Dues",
                keyColumn: "DueID",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "Dues",
                keyColumn: "DueID",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "Dues",
                keyColumn: "DueID",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "Dues",
                keyColumn: "DueID",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "Dues",
                keyColumn: "DueID",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "Dues",
                keyColumn: "DueID",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "Dues",
                keyColumn: "DueID",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "Dues",
                keyColumn: "DueID",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "Dues",
                keyColumn: "DueID",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "Dues",
                keyColumn: "DueID",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "Dues",
                keyColumn: "DueID",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "Dues",
                keyColumn: "DueID",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "Dues",
                keyColumn: "DueID",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "Dues",
                keyColumn: "DueID",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "Dues",
                keyColumn: "DueID",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "Dues",
                keyColumn: "DueID",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "Dues",
                keyColumn: "DueID",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "Dues",
                keyColumn: "DueID",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "Dues",
                keyColumn: "DueID",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "Dues",
                keyColumn: "DueID",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "Dues",
                keyColumn: "DueID",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "Dues",
                keyColumn: "DueID",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "Dues",
                keyColumn: "DueID",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "Dues",
                keyColumn: "DueID",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "Dues",
                keyColumn: "DueID",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "Dues",
                keyColumn: "DueID",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "Dues",
                keyColumn: "DueID",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "Dues",
                keyColumn: "DueID",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "Dues",
                keyColumn: "DueID",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "DuesPayments",
                keyColumns: new[] { "DueID", "PaymentID" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "DuesPayments",
                keyColumns: new[] { "DueID", "PaymentID" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "DuesPayments",
                keyColumns: new[] { "DueID", "PaymentID" },
                keyValues: new object[] { 3, 3 });

            migrationBuilder.DeleteData(
                table: "DuesPayments",
                keyColumns: new[] { "DueID", "PaymentID" },
                keyValues: new object[] { 4, 4 });

            migrationBuilder.DeleteData(
                table: "DuesPayments",
                keyColumns: new[] { "DueID", "PaymentID" },
                keyValues: new object[] { 14, 5 });

            migrationBuilder.DeleteData(
                table: "DuesPayments",
                keyColumns: new[] { "DueID", "PaymentID" },
                keyValues: new object[] { 15, 6 });

            migrationBuilder.DeleteData(
                table: "DuesPayments",
                keyColumns: new[] { "DueID", "PaymentID" },
                keyValues: new object[] { 16, 7 });

            migrationBuilder.DeleteData(
                table: "DuesPayments",
                keyColumns: new[] { "DueID", "PaymentID" },
                keyValues: new object[] { 17, 8 });

            migrationBuilder.DeleteData(
                table: "DuesPayments",
                keyColumns: new[] { "DueID", "PaymentID" },
                keyValues: new object[] { 18, 9 });

            migrationBuilder.DeleteData(
                table: "DuesPayments",
                keyColumns: new[] { "DueID", "PaymentID" },
                keyValues: new object[] { 29, 10 });

            migrationBuilder.DeleteData(
                table: "DuesPayments",
                keyColumns: new[] { "DueID", "PaymentID" },
                keyValues: new object[] { 30, 11 });

            migrationBuilder.DeleteData(
                table: "DuesPayments",
                keyColumns: new[] { "DueID", "PaymentID" },
                keyValues: new object[] { 31, 12 });

            migrationBuilder.DeleteData(
                table: "DuesPayments",
                keyColumns: new[] { "DueID", "PaymentID" },
                keyValues: new object[] { 32, 13 });

            migrationBuilder.DeleteData(
                table: "DuesPayments",
                keyColumns: new[] { "DueID", "PaymentID" },
                keyValues: new object[] { 33, 14 });

            migrationBuilder.DeleteData(
                table: "DuesPayments",
                keyColumns: new[] { "DueID", "PaymentID" },
                keyValues: new object[] { 34, 15 });

            migrationBuilder.DeleteData(
                table: "DuesPayments",
                keyColumns: new[] { "DueID", "PaymentID" },
                keyValues: new object[] { 35, 16 });

            migrationBuilder.DeleteData(
                table: "DuesPayments",
                keyColumns: new[] { "DueID", "PaymentID" },
                keyValues: new object[] { 44, 17 });

            migrationBuilder.DeleteData(
                table: "DuesPayments",
                keyColumns: new[] { "DueID", "PaymentID" },
                keyValues: new object[] { 45, 18 });

            migrationBuilder.DeleteData(
                table: "DuesPayments",
                keyColumns: new[] { "DueID", "PaymentID" },
                keyValues: new object[] { 46, 19 });

            migrationBuilder.DeleteData(
                table: "DuesPayments",
                keyColumns: new[] { "DueID", "PaymentID" },
                keyValues: new object[] { 47, 20 });

            migrationBuilder.DeleteData(
                table: "DuesPayments",
                keyColumns: new[] { "DueID", "PaymentID" },
                keyValues: new object[] { 48, 21 });

            migrationBuilder.DeleteData(
                table: "DuesPayments",
                keyColumns: new[] { "DueID", "PaymentID" },
                keyValues: new object[] { 49, 22 });

            migrationBuilder.DeleteData(
                table: "DuesPayments",
                keyColumns: new[] { "DueID", "PaymentID" },
                keyValues: new object[] { 50, 23 });

            migrationBuilder.DeleteData(
                table: "DuesPayments",
                keyColumns: new[] { "DueID", "PaymentID" },
                keyValues: new object[] { 71, 24 });

            migrationBuilder.DeleteData(
                table: "DuesPayments",
                keyColumns: new[] { "DueID", "PaymentID" },
                keyValues: new object[] { 72, 25 });

            migrationBuilder.DeleteData(
                table: "DuesPayments",
                keyColumns: new[] { "DueID", "PaymentID" },
                keyValues: new object[] { 73, 26 });

            migrationBuilder.DeleteData(
                table: "DuesPayments",
                keyColumns: new[] { "DueID", "PaymentID" },
                keyValues: new object[] { 74, 27 });

            migrationBuilder.DeleteData(
                table: "DuesPayments",
                keyColumns: new[] { "DueID", "PaymentID" },
                keyValues: new object[] { 75, 28 });

            migrationBuilder.DeleteData(
                table: "DuesPayments",
                keyColumns: new[] { "DueID", "PaymentID" },
                keyValues: new object[] { 76, 29 });

            migrationBuilder.DeleteData(
                table: "DuesPayments",
                keyColumns: new[] { "DueID", "PaymentID" },
                keyValues: new object[] { 84, 30 });

            migrationBuilder.DeleteData(
                table: "DuesPayments",
                keyColumns: new[] { "DueID", "PaymentID" },
                keyValues: new object[] { 85, 31 });

            migrationBuilder.DeleteData(
                table: "DuesPayments",
                keyColumns: new[] { "DueID", "PaymentID" },
                keyValues: new object[] { 86, 32 });

            migrationBuilder.DeleteData(
                table: "DuesPayments",
                keyColumns: new[] { "DueID", "PaymentID" },
                keyValues: new object[] { 87, 33 });

            migrationBuilder.DeleteData(
                table: "DuesPayments",
                keyColumns: new[] { "DueID", "PaymentID" },
                keyValues: new object[] { 88, 34 });

            migrationBuilder.DeleteData(
                table: "DuesPayments",
                keyColumns: new[] { "DueID", "PaymentID" },
                keyValues: new object[] { 89, 35 });

            migrationBuilder.DeleteData(
                table: "DuesPayments",
                keyColumns: new[] { "DueID", "PaymentID" },
                keyValues: new object[] { 90, 36 });

            migrationBuilder.DeleteData(
                table: "DuesPayments",
                keyColumns: new[] { "DueID", "PaymentID" },
                keyValues: new object[] { 100, 37 });

            migrationBuilder.DeleteData(
                table: "DuesPayments",
                keyColumns: new[] { "DueID", "PaymentID" },
                keyValues: new object[] { 113, 38 });

            migrationBuilder.DeleteData(
                table: "DuesPayments",
                keyColumns: new[] { "DueID", "PaymentID" },
                keyValues: new object[] { 128, 39 });

            migrationBuilder.DeleteData(
                table: "DuesPayments",
                keyColumns: new[] { "DueID", "PaymentID" },
                keyValues: new object[] { 129, 40 });

            migrationBuilder.DeleteData(
                table: "DuesPayments",
                keyColumns: new[] { "DueID", "PaymentID" },
                keyValues: new object[] { 130, 41 });

            migrationBuilder.DeleteData(
                table: "DuesPayments",
                keyColumns: new[] { "DueID", "PaymentID" },
                keyValues: new object[] { 131, 42 });

            migrationBuilder.DeleteData(
                table: "DuesPayments",
                keyColumns: new[] { "DueID", "PaymentID" },
                keyValues: new object[] { 132, 43 });

            migrationBuilder.DeleteData(
                table: "DuesPayments",
                keyColumns: new[] { "DueID", "PaymentID" },
                keyValues: new object[] { 133, 44 });

            migrationBuilder.DeleteData(
                table: "DuesPayments",
                keyColumns: new[] { "DueID", "PaymentID" },
                keyValues: new object[] { 134, 45 });

            migrationBuilder.DeleteData(
                table: "DuesPayments",
                keyColumns: new[] { "DueID", "PaymentID" },
                keyValues: new object[] { 135, 46 });

            migrationBuilder.DeleteData(
                table: "DuesPayments",
                keyColumns: new[] { "DueID", "PaymentID" },
                keyValues: new object[] { 163, 47 });

            migrationBuilder.DeleteData(
                table: "DuesPayments",
                keyColumns: new[] { "DueID", "PaymentID" },
                keyValues: new object[] { 164, 48 });

            migrationBuilder.DeleteData(
                table: "DuesPayments",
                keyColumns: new[] { "DueID", "PaymentID" },
                keyValues: new object[] { 165, 49 });

            migrationBuilder.DeleteData(
                table: "Dues",
                keyColumn: "DueID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Dues",
                keyColumn: "DueID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Dues",
                keyColumn: "DueID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Dues",
                keyColumn: "DueID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Dues",
                keyColumn: "DueID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Dues",
                keyColumn: "DueID",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Dues",
                keyColumn: "DueID",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Dues",
                keyColumn: "DueID",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Dues",
                keyColumn: "DueID",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Dues",
                keyColumn: "DueID",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Dues",
                keyColumn: "DueID",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Dues",
                keyColumn: "DueID",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Dues",
                keyColumn: "DueID",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Dues",
                keyColumn: "DueID",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Dues",
                keyColumn: "DueID",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Dues",
                keyColumn: "DueID",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Dues",
                keyColumn: "DueID",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Dues",
                keyColumn: "DueID",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Dues",
                keyColumn: "DueID",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Dues",
                keyColumn: "DueID",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Dues",
                keyColumn: "DueID",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Dues",
                keyColumn: "DueID",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Dues",
                keyColumn: "DueID",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Dues",
                keyColumn: "DueID",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Dues",
                keyColumn: "DueID",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Dues",
                keyColumn: "DueID",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Dues",
                keyColumn: "DueID",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Dues",
                keyColumn: "DueID",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Dues",
                keyColumn: "DueID",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Dues",
                keyColumn: "DueID",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Dues",
                keyColumn: "DueID",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Dues",
                keyColumn: "DueID",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Dues",
                keyColumn: "DueID",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Dues",
                keyColumn: "DueID",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Dues",
                keyColumn: "DueID",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Dues",
                keyColumn: "DueID",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Dues",
                keyColumn: "DueID",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Dues",
                keyColumn: "DueID",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Dues",
                keyColumn: "DueID",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "Dues",
                keyColumn: "DueID",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "Dues",
                keyColumn: "DueID",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "Dues",
                keyColumn: "DueID",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "Dues",
                keyColumn: "DueID",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "Dues",
                keyColumn: "DueID",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "Dues",
                keyColumn: "DueID",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "Dues",
                keyColumn: "DueID",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "Dues",
                keyColumn: "DueID",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "Dues",
                keyColumn: "DueID",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "Dues",
                keyColumn: "DueID",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "LoanID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "LoanID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "PaymentID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "PaymentID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "PaymentID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "PaymentID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "PaymentID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "PaymentID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "PaymentID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "PaymentID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "PaymentID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "PaymentID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "PaymentID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "PaymentID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "PaymentID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "PaymentID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "PaymentID",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "PaymentID",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "PaymentID",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "PaymentID",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "PaymentID",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "PaymentID",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "PaymentID",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "PaymentID",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "PaymentID",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "PaymentID",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "PaymentID",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "PaymentID",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "PaymentID",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "PaymentID",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "PaymentID",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "PaymentID",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "PaymentID",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "PaymentID",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "PaymentID",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "PaymentID",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "PaymentID",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "PaymentID",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "PaymentID",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "PaymentID",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "PaymentID",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "PaymentID",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "PaymentID",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "PaymentID",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "PaymentID",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "PaymentID",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "PaymentID",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "PaymentID",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "PaymentID",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "PaymentID",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "PaymentID",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "LoanID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "LoanID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "LoanID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "LoanID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "LoanID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "LoanID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "LoanID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "LoanID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "LoanID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "LoanID",
                keyValue: 12);

            migrationBuilder.DropColumn(
                name: "Code",
                table: "Payments");

            migrationBuilder.DropColumn(
                name: "UrlFile",
                table: "Loans");

            migrationBuilder.DropColumn(
                name: "UrlFile",
                table: "Contacts");
        }
    }
}
