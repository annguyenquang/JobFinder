using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JobFinder.Migrations
{
    /// <inheritdoc />
    public partial class MakePasswordFixed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("9127e8f9-a91c-4dca-8008-3cb7a8dcfb22"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 30, 23, 43, 4, 223, DateTimeKind.Local).AddTicks(7546), new DateTime(2024, 10, 30, 23, 43, 4, 223, DateTimeKind.Local).AddTicks(7553), new DateTime(2024, 10, 30, 23, 43, 4, 223, DateTimeKind.Local).AddTicks(7554) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("c3d3aa6b-ac70-4aa9-a8c2-88b3e0581d87"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 30, 23, 43, 4, 223, DateTimeKind.Local).AddTicks(7505), new DateTime(2024, 10, 30, 23, 43, 4, 223, DateTimeKind.Local).AddTicks(7538), new DateTime(2024, 10, 30, 23, 43, 4, 223, DateTimeKind.Local).AddTicks(7539) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("ca01ec6a-8d39-4e00-ab98-6c3f9a2e0b1e"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 30, 23, 43, 4, 223, DateTimeKind.Local).AddTicks(7571), new DateTime(2024, 10, 30, 23, 43, 4, 223, DateTimeKind.Local).AddTicks(7577), new DateTime(2024, 10, 30, 23, 43, 4, 223, DateTimeKind.Local).AddTicks(7578) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("def969c3-e7ad-4f71-9907-2c0d594d3ecb"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 28, 23, 43, 4, 223, DateTimeKind.Local).AddTicks(7558), new DateTime(2024, 10, 30, 23, 43, 4, 223, DateTimeKind.Local).AddTicks(7567), new DateTime(2024, 10, 30, 23, 43, 4, 223, DateTimeKind.Local).AddTicks(7568) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("9127e8f9-a91c-4dca-8008-3cb7a8dcfb22"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 30, 23, 32, 11, 311, DateTimeKind.Local).AddTicks(181), new DateTime(2024, 10, 30, 23, 32, 11, 311, DateTimeKind.Local).AddTicks(191), new DateTime(2024, 10, 30, 23, 32, 11, 311, DateTimeKind.Local).AddTicks(192) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("c3d3aa6b-ac70-4aa9-a8c2-88b3e0581d87"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 30, 23, 32, 11, 311, DateTimeKind.Local).AddTicks(146), new DateTime(2024, 10, 30, 23, 32, 11, 311, DateTimeKind.Local).AddTicks(175), new DateTime(2024, 10, 30, 23, 32, 11, 311, DateTimeKind.Local).AddTicks(176) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("ca01ec6a-8d39-4e00-ab98-6c3f9a2e0b1e"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 30, 23, 32, 11, 311, DateTimeKind.Local).AddTicks(226), new DateTime(2024, 10, 30, 23, 32, 11, 311, DateTimeKind.Local).AddTicks(231), new DateTime(2024, 10, 30, 23, 32, 11, 311, DateTimeKind.Local).AddTicks(231) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("def969c3-e7ad-4f71-9907-2c0d594d3ecb"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 28, 23, 32, 11, 311, DateTimeKind.Local).AddTicks(195), new DateTime(2024, 10, 30, 23, 32, 11, 311, DateTimeKind.Local).AddTicks(199), new DateTime(2024, 10, 30, 23, 32, 11, 311, DateTimeKind.Local).AddTicks(200) });
        }
    }
}
