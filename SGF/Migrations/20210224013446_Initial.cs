using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SGF.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DCExpenseType",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DCExpenseType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ShippingCompany",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CompanyName = table.Column<string>(nullable: true),
                    ContactName = table.Column<string>(nullable: true),
                    Telephone = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShippingCompany", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "State",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Uf = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_State", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DryCargo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Value = table.Column<double>(nullable: false),
                    TotalKM = table.Column<double>(nullable: false),
                    Material = table.Column<string>(nullable: true),
                    DepartureDate = table.Column<DateTime>(nullable: false),
                    ArrivalDate = table.Column<DateTime>(nullable: false),
                    ShippingCompanyId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DryCargo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DryCargo_ShippingCompany_ShippingCompanyId",
                        column: x => x.ShippingCompanyId,
                        principalTable: "ShippingCompany",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "City",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    IdEstado = table.Column<int>(nullable: false),
                    DryCargoId = table.Column<int>(nullable: true),
                    ShippingCompanyId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_City", x => x.Id);
                    table.ForeignKey(
                        name: "FK_City_DryCargo_DryCargoId",
                        column: x => x.DryCargoId,
                        principalTable: "DryCargo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_City_ShippingCompany_ShippingCompanyId",
                        column: x => x.ShippingCompanyId,
                        principalTable: "ShippingCompany",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DCExpense",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Value = table.Column<double>(nullable: false),
                    TypeId = table.Column<int>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Date = table.Column<DateTime>(nullable: false),
                    PayedByDriver = table.Column<bool>(nullable: false),
                    DryCargoId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DCExpense", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DCExpense_DryCargo_DryCargoId",
                        column: x => x.DryCargoId,
                        principalTable: "DryCargo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DCExpense_DCExpenseType_TypeId",
                        column: x => x.TypeId,
                        principalTable: "DCExpenseType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_City_DryCargoId",
                table: "City",
                column: "DryCargoId");

            migrationBuilder.CreateIndex(
                name: "IX_City_ShippingCompanyId",
                table: "City",
                column: "ShippingCompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_DCExpense_DryCargoId",
                table: "DCExpense",
                column: "DryCargoId");

            migrationBuilder.CreateIndex(
                name: "IX_DCExpense_TypeId",
                table: "DCExpense",
                column: "TypeId");

            migrationBuilder.CreateIndex(
                name: "IX_DryCargo_ShippingCompanyId",
                table: "DryCargo",
                column: "ShippingCompanyId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "City");

            migrationBuilder.DropTable(
                name: "DCExpense");

            migrationBuilder.DropTable(
                name: "State");

            migrationBuilder.DropTable(
                name: "DryCargo");

            migrationBuilder.DropTable(
                name: "DCExpenseType");

            migrationBuilder.DropTable(
                name: "ShippingCompany");
        }
    }
}
