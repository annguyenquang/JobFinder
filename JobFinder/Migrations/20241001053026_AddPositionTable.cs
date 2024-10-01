using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JobFinder.Migrations
{
    /// <inheritdoc />
    public partial class AddPositionTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("5980ede0-69fd-40db-9334-64d852f4d5bc"));

            migrationBuilder.CreateTable(
                name: "Positions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Salary = table.Column<double>(type: "float", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CloseDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FirmId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Positions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Positions_Firms_FirmId",
                        column: x => x.FirmId,
                        principalTable: "Firms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "Email", "Password", "Phone", "Username" },
                values: new object[] { new Guid("60dab990-4c0b-4381-a2bb-810df105a381"), "admin@gmail.com", "Admin", "0123456789", "Admin" });

            migrationBuilder.CreateIndex(
                name: "IX_Positions_FirmId",
                table: "Positions",
                column: "FirmId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Positions");

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("60dab990-4c0b-4381-a2bb-810df105a381"));

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "Email", "Password", "Phone", "Username" },
                values: new object[] { new Guid("5980ede0-69fd-40db-9334-64d852f4d5bc"), "admin@gmail.com", "Admin", "0123456789", "Admin" });
        }
    }
}
