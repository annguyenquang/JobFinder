using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JobFinder.Migrations
{
    /// <inheritdoc />
    public partial class AddPositionApplicationTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("60dab990-4c0b-4381-a2bb-810df105a381"));

            migrationBuilder.CreateTable(
                name: "PositionApplications",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PositionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CVLink = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PositionApplications", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PositionApplications_Positions_PositionId",
                        column: x => x.PositionId,
                        principalTable: "Positions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PositionApplications_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "Email", "Password", "Phone", "Username" },
                values: new object[] { new Guid("d03e3439-6e60-429f-861e-2336eb6e4042"), "admin@gmail.com", "Admin", "0123456789", "Admin" });

            migrationBuilder.CreateIndex(
                name: "IX_PositionApplications_PositionId",
                table: "PositionApplications",
                column: "PositionId");

            migrationBuilder.CreateIndex(
                name: "IX_PositionApplications_UserId",
                table: "PositionApplications",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PositionApplications");

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("d03e3439-6e60-429f-861e-2336eb6e4042"));

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "Email", "Password", "Phone", "Username" },
                values: new object[] { new Guid("60dab990-4c0b-4381-a2bb-810df105a381"), "admin@gmail.com", "Admin", "0123456789", "Admin" });
        }
    }
}
