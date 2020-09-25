using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using NetTopologySuite.Geometries;

namespace PrestamApp.Persistence.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AddressData",
                columns: table => new
                {
                    AddressDataID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Description = table.Column<string>(maxLength: 100, nullable: true),
                    ParentId = table.Column<int>(nullable: true),
                    LevelId = table.Column<int>(nullable: false),
                    Coordinate = table.Column<Geometry>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AddressData", x => x.AddressDataID);
                });

            migrationBuilder.CreateTable(
                name: "AddressTypes",
                columns: table => new
                {
                    AddressTypeID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Description = table.Column<string>(maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AddressTypes", x => x.AddressTypeID);
                });

            migrationBuilder.CreateTable(
                name: "Collectors",
                columns: table => new
                {
                    CollectorID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserID = table.Column<int>(nullable: false),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    Address = table.Column<string>(maxLength: 70, nullable: false),
                    PhoneNumber1 = table.Column<string>(nullable: false),
                    PhoneNumber2 = table.Column<string>(nullable: true),
                    Email = table.Column<string>(maxLength: 255, nullable: false),
                    CreatedBy = table.Column<string>(maxLength: 50, nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: true),
                    ModifiedBy = table.Column<string>(maxLength: 50, nullable: true),
                    ModifiedDate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Collectors", x => x.CollectorID);
                });

            migrationBuilder.CreateTable(
                name: "Payments",
                columns: table => new
                {
                    PaymentID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Date = table.Column<DateTime>(nullable: false),
                    CapitalAmount = table.Column<decimal>(nullable: false),
                    InterestAmount = table.Column<decimal>(nullable: false),
                    LateFee = table.Column<decimal>(nullable: false),
                    PendigBalance = table.Column<decimal>(nullable: false),
                    TotalBalance = table.Column<decimal>(nullable: false),
                    CreatedBy = table.Column<string>(maxLength: 50, nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: true),
                    ModifiedBy = table.Column<string>(maxLength: 50, nullable: true),
                    ModifiedDate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payments", x => x.PaymentID);
                });

            migrationBuilder.CreateTable(
                name: "RelationShipTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RelationShipTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Zones",
                columns: table => new
                {
                    ZoneID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Description = table.Column<string>(maxLength: 50, nullable: false),
                    CreatedBy = table.Column<string>(maxLength: 50, nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: true),
                    ModifiedBy = table.Column<string>(maxLength: 50, nullable: true),
                    ModifiedDate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Zones", x => x.ZoneID);
                });

            migrationBuilder.CreateTable(
                name: "Address",
                columns: table => new
                {
                    AddressId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Refference = table.Column<string>(maxLength: 30, nullable: true),
                    Street = table.Column<string>(maxLength: 40, nullable: true),
                    Location = table.Column<Geometry>(nullable: true),
                    AddressTypeId = table.Column<int>(nullable: false),
                    AddressDataId = table.Column<int>(nullable: true),
                    CreatedBy = table.Column<string>(maxLength: 50, nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: true),
                    ModifiedBy = table.Column<string>(maxLength: 50, nullable: true),
                    ModifiedDate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Address", x => x.AddressId);
                    table.ForeignKey(
                        name: "FK_Address_AddressData_AddressDataId",
                        column: x => x.AddressDataId,
                        principalTable: "AddressData",
                        principalColumn: "AddressDataID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Address_AddressTypes_AddressTypeId",
                        column: x => x.AddressTypeId,
                        principalTable: "AddressTypes",
                        principalColumn: "AddressTypeID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ZoneCollectors",
                columns: table => new
                {
                    ZoneId = table.Column<int>(nullable: false),
                    CollectorId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ZoneCollectors", x => new { x.CollectorId, x.ZoneId });
                    table.ForeignKey(
                        name: "FK_ZoneCollectors_Collectors_CollectorId",
                        column: x => x.CollectorId,
                        principalTable: "Collectors",
                        principalColumn: "CollectorID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ZoneCollectors_Zones_ZoneId",
                        column: x => x.ZoneId,
                        principalTable: "Zones",
                        principalColumn: "ZoneID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Contacts",
                columns: table => new
                {
                    ContactId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ContactNumber = table.Column<string>(maxLength: 10, nullable: true, defaultValue: "C-000"),
                    IdentificationNumber = table.Column<string>(maxLength: 13, nullable: true),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    LastName = table.Column<string>(maxLength: 50, nullable: false),
                    Email = table.Column<string>(maxLength: 50, nullable: true),
                    Gender = table.Column<bool>(nullable: false),
                    AddressId = table.Column<int>(nullable: false),
                    PhoneNumberOne = table.Column<string>(maxLength: 20, nullable: false),
                    PhoneNumberTwo = table.Column<string>(maxLength: 50, nullable: true),
                    ZoneId = table.Column<int>(nullable: false),
                    CreatedBy = table.Column<string>(maxLength: 50, nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: true),
                    ModifiedBy = table.Column<string>(maxLength: 50, nullable: true),
                    ModifiedDate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacts", x => x.ContactId);
                    table.ForeignKey(
                        name: "FK_Contacts_Address_AddressId",
                        column: x => x.AddressId,
                        principalTable: "Address",
                        principalColumn: "AddressId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Contacts_Zones_ZoneId",
                        column: x => x.ZoneId,
                        principalTable: "Zones",
                        principalColumn: "ZoneID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Loans",
                columns: table => new
                {
                    LoanID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ContactID = table.Column<int>(nullable: false),
                    TimeFrameID = table.Column<int>(nullable: false),
                    LoanAmount = table.Column<decimal>(nullable: false),
                    SimpleInterest = table.Column<bool>(nullable: false),
                    InterestRate = table.Column<decimal>(nullable: false),
                    Interest = table.Column<decimal>(nullable: false),
                    LoanDate = table.Column<DateTime>(nullable: false),
                    EndDate = table.Column<DateTime>(nullable: false),
                    NumberOfDue = table.Column<int>(nullable: false),
                    TotalBalance = table.Column<decimal>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    UpToDate = table.Column<bool>(nullable: false),
                    Code = table.Column<string>(maxLength: 10, nullable: false),
                    NumeroCuotasPagadas = table.Column<int>(nullable: true),
                    TotalCapitalAmount = table.Column<decimal>(nullable: false),
                    CreatedBy = table.Column<string>(maxLength: 50, nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: true),
                    ModifiedBy = table.Column<string>(maxLength: 50, nullable: true),
                    ModifiedDate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Loans", x => x.LoanID);
                    table.ForeignKey(
                        name: "FK_Loans_Contacts_ContactID",
                        column: x => x.ContactID,
                        principalTable: "Contacts",
                        principalColumn: "ContactId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PersonalRefferences",
                columns: table => new
                {
                    PersonalRefferenceId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    ContactId = table.Column<int>(nullable: false),
                    RelationShipTypeId = table.Column<int>(nullable: false),
                    Address = table.Column<string>(maxLength: 256, nullable: true),
                    Location = table.Column<Geometry>(nullable: true),
                    PhoneNumberOne = table.Column<string>(nullable: true),
                    PhoneNumberTwo = table.Column<string>(nullable: true),
                    CreatedBy = table.Column<string>(maxLength: 50, nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: true),
                    ModifiedBy = table.Column<string>(maxLength: 50, nullable: true),
                    ModifiedDate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonalRefferences", x => x.PersonalRefferenceId);
                    table.ForeignKey(
                        name: "FK_PersonalRefferences_Contacts_ContactId",
                        column: x => x.ContactId,
                        principalTable: "Contacts",
                        principalColumn: "ContactId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PersonalRefferences_RelationShipTypes_RelationShipTypeId",
                        column: x => x.RelationShipTypeId,
                        principalTable: "RelationShipTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Dues",
                columns: table => new
                {
                    DueID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    LoanID = table.Column<int>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    InterestAmount = table.Column<decimal>(nullable: false),
                    CapitalAmount = table.Column<decimal>(nullable: false),
                    LateFee = table.Column<decimal>(nullable: false),
                    PendingBalance = table.Column<decimal>(nullable: false),
                    PaymentAmount = table.Column<decimal>(nullable: false),
                    AdvancePayment = table.Column<decimal>(nullable: true),
                    DueNumber = table.Column<int>(nullable: false),
                    DueIsPaidOff = table.Column<bool>(nullable: false),
                    CreatedBy = table.Column<string>(maxLength: 50, nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: true),
                    ModifiedBy = table.Column<string>(maxLength: 50, nullable: true),
                    ModifiedDate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dues", x => x.DueID);
                    table.ForeignKey(
                        name: "FK_Dues_Loans_LoanID",
                        column: x => x.LoanID,
                        principalTable: "Loans",
                        principalColumn: "LoanID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DuesPayments",
                columns: table => new
                {
                    DueID = table.Column<int>(nullable: false),
                    PaymentID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DuesPayments", x => new { x.DueID, x.PaymentID });
                    table.ForeignKey(
                        name: "FK_DuesPayments_Dues_DueID",
                        column: x => x.DueID,
                        principalTable: "Dues",
                        principalColumn: "DueID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DuesPayments_Payments_PaymentID",
                        column: x => x.PaymentID,
                        principalTable: "Payments",
                        principalColumn: "PaymentID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AddressTypes",
                columns: new[] { "AddressTypeID", "Description" },
                values: new object[,]
                {
                    { 1, "Casa" },
                    { 2, "Oficina" },
                    { 3, "Otros" }
                });

            migrationBuilder.InsertData(
                table: "Collectors",
                columns: new[] { "CollectorID", "Address", "CreatedBy", "CreatedDate", "Email", "ModifiedBy", "ModifiedDate", "Name", "PhoneNumber1", "PhoneNumber2", "UserID" },
                values: new object[,]
                {
                    { 1, "Maimón, Bonao, Calle Principal No. 5", null, null, "Francis@test.com", null, null, "Francis", "8095555555", null, 2 },
                    { 2, "Hacienda Estrella No. 5", null, null, "Ruddy@test.com", null, null, "Ruddy", "8095555555", null, 3 }
                });

            migrationBuilder.InsertData(
                table: "RelationShipTypes",
                columns: new[] { "Id", "Description" },
                values: new object[,]
                {
                    { 1, "Familiar" },
                    { 2, "Vecino" },
                    { 3, "Comapañero de Trabajo" },
                    { 4, "Comapañero de Estudio" }
                });

            migrationBuilder.InsertData(
                table: "Zones",
                columns: new[] { "ZoneID", "CreatedBy", "CreatedDate", "Description", "ModifiedBy", "ModifiedDate" },
                values: new object[,]
                {
                    { 1, null, null, "Pradera Verde", null, null },
                    { 2, null, null, "Intec", null, null }
                });

            migrationBuilder.InsertData(
                table: "Address",
                columns: new[] { "AddressId", "AddressDataId", "AddressTypeId", "CreatedBy", "CreatedDate", "Location", "ModifiedBy", "ModifiedDate", "Refference", "Street" },
                values: new object[,]
                {
                    { 1, null, 1, null, null, null, null, null, null, "El Tamarindo" },
                    { 2, null, 1, null, null, null, null, null, "Villa Tropical", "El Tamarindo" },
                    { 3, null, 1, null, null, null, null, null, null, "El Tamarindo" },
                    { 4, null, 1, null, null, null, null, null, null, "El Tamarindo, Calle La Ciencia No. 2" },
                    { 5, null, 1, null, null, null, null, null, null, "El Tamarindo" },
                    { 6, null, 1, null, null, null, null, null, null, "El Tamarindo" },
                    { 7, null, 1, null, null, null, null, null, null, "El Tamarindo" },
                    { 8, null, 1, null, null, null, null, null, null, "El Tamarindo" },
                    { 9, null, 1, null, null, null, null, null, null, "El Tamarindo" },
                    { 10, null, 1, null, null, null, null, null, "La Gallera", "El Tamarindo" }
                });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "ContactId", "AddressId", "ContactNumber", "CreatedBy", "CreatedDate", "Email", "Gender", "IdentificationNumber", "LastName", "ModifiedBy", "ModifiedDate", "Name", "PhoneNumberOne", "PhoneNumberTwo", "ZoneId" },
                values: new object[,]
                {
                    { 1, 1, "C-001", null, null, null, false, "001-0349060-3", "Cuevas Cabrera", null, null, "Alba", "829-592-2920", null, 2 },
                    { 2, 2, "C-002", null, null, null, false, "223-0005438-2", "Zapata", null, null, "Mery Elizabeth", "555-555-5555", null, 1 },
                    { 3, 3, "C-003", null, null, null, true, "076-0010914-9", "Nova Florian", null, null, "Erasmo", "809-509-1947", null, 1 },
                    { 4, 4, "C-004", null, null, null, false, "024-0016983-4", "Hernandez", null, null, "Adela", "829-260-2377", null, 1 },
                    { 5, 5, "C-005", null, null, null, true, "402-2321927-6", "Aguas Vivas", null, null, "Janser Michael", "555-555-5555", null, 1 },
                    { 6, 6, "C-006", null, null, null, true, "013-0023998-3", "Rodríguez", null, null, "Rikelvin Alberto", "849-252-2039", null, 2 },
                    { 7, 7, "C-007", null, null, null, true, "108-0001178-4", "Mora Montero", null, null, "Castulo", "829-905-9263", null, 1 },
                    { 8, 8, "C-008", null, null, null, true, "001-1419722-1", "Ferjuste", null, null, "Daniel", "555-555-5555", null, 2 },
                    { 9, 9, "C-009", null, null, null, true, "001-1527870-7", "Montero Montero", null, null, "Franklin", "829-298-4775", null, 1 },
                    { 10, 10, "C-010", null, null, null, true, "001-0229497-2", "Casamora Montero", null, null, "Nestor", "809-861-9080", null, 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Address_AddressDataId",
                table: "Address",
                column: "AddressDataId");

            migrationBuilder.CreateIndex(
                name: "IX_Address_AddressTypeId",
                table: "Address",
                column: "AddressTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Contacts_AddressId",
                table: "Contacts",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_Contacts_ZoneId",
                table: "Contacts",
                column: "ZoneId");

            migrationBuilder.CreateIndex(
                name: "IX_Dues_LoanID",
                table: "Dues",
                column: "LoanID");

            migrationBuilder.CreateIndex(
                name: "IX_DuesPayments_PaymentID",
                table: "DuesPayments",
                column: "PaymentID");

            migrationBuilder.CreateIndex(
                name: "IX_Loans_ContactID",
                table: "Loans",
                column: "ContactID");

            migrationBuilder.CreateIndex(
                name: "IX_PersonalRefferences_ContactId",
                table: "PersonalRefferences",
                column: "ContactId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonalRefferences_RelationShipTypeId",
                table: "PersonalRefferences",
                column: "RelationShipTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_ZoneCollectors_ZoneId",
                table: "ZoneCollectors",
                column: "ZoneId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DuesPayments");

            migrationBuilder.DropTable(
                name: "PersonalRefferences");

            migrationBuilder.DropTable(
                name: "ZoneCollectors");

            migrationBuilder.DropTable(
                name: "Dues");

            migrationBuilder.DropTable(
                name: "Payments");

            migrationBuilder.DropTable(
                name: "RelationShipTypes");

            migrationBuilder.DropTable(
                name: "Collectors");

            migrationBuilder.DropTable(
                name: "Loans");

            migrationBuilder.DropTable(
                name: "Contacts");

            migrationBuilder.DropTable(
                name: "Address");

            migrationBuilder.DropTable(
                name: "Zones");

            migrationBuilder.DropTable(
                name: "AddressData");

            migrationBuilder.DropTable(
                name: "AddressTypes");
        }
    }
}
