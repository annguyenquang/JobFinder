﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JobFinder.Migrations
{
    /// <inheritdoc />
    public partial class MakeCoverLetterAndPhoneNumberNullable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "JobApplications",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "CoverLetter",
                table: "JobApplications",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("17e0cd7e-5887-44e2-bf2a-cd1b1f631f76"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 4, 13, 17, 21, 42, 828, DateTimeKind.Local).AddTicks(8095), new DateTime(2024, 11, 13, 17, 21, 42, 828, DateTimeKind.Local).AddTicks(8099), new DateTime(2024, 11, 13, 17, 21, 42, 828, DateTimeKind.Local).AddTicks(8100) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("1b9a3a57-5a94-4cc3-9af1-0380d074dd65"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 13, 17, 21, 42, 828, DateTimeKind.Local).AddTicks(8120), new DateTime(2024, 11, 13, 17, 21, 42, 828, DateTimeKind.Local).AddTicks(8125), new DateTime(2024, 11, 13, 17, 21, 42, 828, DateTimeKind.Local).AddTicks(8126) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("1c8a7d6b-2d7f-4c2b-a9c5-8b3e9f6f2d8b"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 13, 17, 21, 42, 828, DateTimeKind.Local).AddTicks(8067), new DateTime(2024, 11, 13, 17, 21, 42, 828, DateTimeKind.Local).AddTicks(8072), new DateTime(2024, 11, 13, 17, 21, 42, 828, DateTimeKind.Local).AddTicks(8072) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("1d41e60a-ffb5-4039-b4b6-3e25e68d0f2c"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 21, 42, 828, DateTimeKind.Local).AddTicks(8106), new DateTime(2024, 11, 13, 17, 21, 42, 828, DateTimeKind.Local).AddTicks(8111), new DateTime(2024, 11, 13, 17, 21, 42, 828, DateTimeKind.Local).AddTicks(8111) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("22aadfc7-6022-4f15-ac49-13fa33f8afbe"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 13, 17, 21, 42, 828, DateTimeKind.Local).AddTicks(7961), new DateTime(2024, 11, 13, 17, 21, 42, 828, DateTimeKind.Local).AddTicks(7965), new DateTime(2024, 11, 13, 17, 21, 42, 828, DateTimeKind.Local).AddTicks(7966) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("3d6b9f9b-6f2d-4b4a-b4c7-2c8b5f4e1b4e"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 13, 17, 21, 42, 828, DateTimeKind.Local).AddTicks(8045), new DateTime(2024, 11, 13, 17, 21, 42, 828, DateTimeKind.Local).AddTicks(8049), new DateTime(2024, 11, 13, 17, 21, 42, 828, DateTimeKind.Local).AddTicks(8050) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("3d8db2d5-5020-497e-917b-500a1f663c60"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 4, 13, 17, 21, 42, 828, DateTimeKind.Local).AddTicks(8180), new DateTime(2024, 11, 13, 17, 21, 42, 828, DateTimeKind.Local).AddTicks(8186), new DateTime(2024, 11, 13, 17, 21, 42, 828, DateTimeKind.Local).AddTicks(8187) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("4b3dff90-4d8a-4cbb-a3e8-6c7e5a4d3c4a"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 13, 17, 21, 42, 828, DateTimeKind.Local).AddTicks(8052), new DateTime(2024, 11, 13, 17, 21, 42, 828, DateTimeKind.Local).AddTicks(8056), new DateTime(2024, 11, 13, 17, 21, 42, 828, DateTimeKind.Local).AddTicks(8057) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("4c695d62-51f0-4070-a625-c030208dffb7"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 13, 17, 21, 42, 828, DateTimeKind.Local).AddTicks(7884), new DateTime(2024, 11, 13, 17, 21, 42, 828, DateTimeKind.Local).AddTicks(7909), new DateTime(2024, 11, 13, 17, 21, 42, 828, DateTimeKind.Local).AddTicks(7910) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("5540bd1d-b228-410e-8fbf-0842aeda7cb1"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 13, 17, 21, 42, 828, DateTimeKind.Local).AddTicks(7914), new DateTime(2024, 11, 13, 17, 21, 42, 828, DateTimeKind.Local).AddTicks(7919), new DateTime(2024, 11, 13, 17, 21, 42, 828, DateTimeKind.Local).AddTicks(7920) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("571827fa-78f4-4192-ad3b-06bb014309c2"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 13, 17, 21, 42, 828, DateTimeKind.Local).AddTicks(7923), new DateTime(2024, 11, 13, 17, 21, 42, 828, DateTimeKind.Local).AddTicks(7928), new DateTime(2024, 11, 13, 17, 21, 42, 828, DateTimeKind.Local).AddTicks(7928) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("5f9c2d8f-a7f2-45a4-8e4a-90b8f7a03b3e"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 13, 17, 21, 42, 828, DateTimeKind.Local).AddTicks(8031), new DateTime(2024, 11, 13, 17, 21, 42, 828, DateTimeKind.Local).AddTicks(8035), new DateTime(2024, 11, 13, 17, 21, 42, 828, DateTimeKind.Local).AddTicks(8036) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("6f0e2a6f-54d7-493c-bcb4-8f5eeb2fba1b"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 13, 17, 21, 42, 828, DateTimeKind.Local).AddTicks(8173), new DateTime(2024, 11, 13, 17, 21, 42, 828, DateTimeKind.Local).AddTicks(8177), new DateTime(2024, 11, 13, 17, 21, 42, 828, DateTimeKind.Local).AddTicks(8178) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("7c7616f2-3c2c-4c5f-9f40-470e78a847c7"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 13, 17, 21, 42, 828, DateTimeKind.Local).AddTicks(8189), new DateTime(2024, 11, 13, 17, 21, 42, 828, DateTimeKind.Local).AddTicks(8193), new DateTime(2024, 11, 13, 17, 21, 42, 828, DateTimeKind.Local).AddTicks(8194) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("82cfed84-d067-4d70-bef9-f08b0636a6b0"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 13, 17, 21, 42, 828, DateTimeKind.Local).AddTicks(8128), new DateTime(2024, 11, 13, 17, 21, 42, 828, DateTimeKind.Local).AddTicks(8132), new DateTime(2024, 11, 13, 17, 21, 42, 828, DateTimeKind.Local).AddTicks(8132) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("8845c741-6b0f-4f95-b179-3d007ba28a41"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 13, 17, 21, 42, 828, DateTimeKind.Local).AddTicks(7993), new DateTime(2024, 11, 13, 17, 21, 42, 828, DateTimeKind.Local).AddTicks(7998), new DateTime(2024, 11, 13, 17, 21, 42, 828, DateTimeKind.Local).AddTicks(7998) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("8c78bbac-4a5e-49ab-aafb-5a6c3f0c4b5d"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 6, 13, 17, 21, 42, 828, DateTimeKind.Local).AddTicks(8038), new DateTime(2024, 11, 13, 17, 21, 42, 828, DateTimeKind.Local).AddTicks(8043), new DateTime(2024, 11, 13, 17, 21, 42, 828, DateTimeKind.Local).AddTicks(8043) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("8f31d3d0-dc53-45d6-bccd-fd2d15dacb77"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 13, 17, 21, 42, 828, DateTimeKind.Local).AddTicks(8002), new DateTime(2024, 11, 13, 17, 21, 42, 828, DateTimeKind.Local).AddTicks(8006), new DateTime(2024, 11, 13, 17, 21, 42, 828, DateTimeKind.Local).AddTicks(8007) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("9127e8f9-a91c-4dca-8008-3cb7a8dcfb22"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 13, 17, 21, 42, 828, DateTimeKind.Local).AddTicks(7947), new DateTime(2024, 11, 13, 17, 21, 42, 828, DateTimeKind.Local).AddTicks(7952), new DateTime(2024, 11, 13, 17, 21, 42, 828, DateTimeKind.Local).AddTicks(7952) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("a6b3ec6a-1d44-4b00-aa18-7d3f1a2e2f6d"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 13, 17, 21, 42, 828, DateTimeKind.Local).AddTicks(8016), new DateTime(2024, 11, 13, 17, 21, 42, 828, DateTimeKind.Local).AddTicks(8020), new DateTime(2024, 11, 13, 17, 21, 42, 828, DateTimeKind.Local).AddTicks(8021) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("af7bcf34-a92d-4b2b-9937-3e6b7f4f2c6d"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 13, 17, 21, 42, 828, DateTimeKind.Local).AddTicks(8060), new DateTime(2024, 11, 13, 17, 21, 42, 828, DateTimeKind.Local).AddTicks(8064), new DateTime(2024, 11, 13, 17, 21, 42, 828, DateTimeKind.Local).AddTicks(8065) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("b3f9d8c7-a1f4-4e3d-b7c2-7e3f9a4f1c5d"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 4, 13, 17, 21, 42, 828, DateTimeKind.Local).AddTicks(8074), new DateTime(2024, 11, 13, 17, 21, 42, 828, DateTimeKind.Local).AddTicks(8078), new DateTime(2024, 11, 13, 17, 21, 42, 828, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("c0a173ff-5be0-4bc9-877b-8d632eeb6da6"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 13, 17, 21, 42, 828, DateTimeKind.Local).AddTicks(8196), new DateTime(2024, 11, 13, 17, 21, 42, 828, DateTimeKind.Local).AddTicks(8200), new DateTime(2024, 11, 13, 17, 21, 42, 828, DateTimeKind.Local).AddTicks(8200) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("c3d3aa6b-ac70-4aa9-a8c2-88b3e0581d87"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 13, 17, 21, 42, 828, DateTimeKind.Local).AddTicks(7938), new DateTime(2024, 11, 13, 17, 21, 42, 828, DateTimeKind.Local).AddTicks(7943), new DateTime(2024, 11, 13, 17, 21, 42, 828, DateTimeKind.Local).AddTicks(7943) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("c3e8ff99-9f1a-4e4e-aaa4-4d1c8e5e3b5a"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 21, 42, 828, DateTimeKind.Local).AddTicks(8023), new DateTime(2024, 11, 13, 17, 21, 42, 828, DateTimeKind.Local).AddTicks(8028), new DateTime(2024, 11, 13, 17, 21, 42, 828, DateTimeKind.Local).AddTicks(8029) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("c8e2c78e-f68e-4c7e-a22f-5c81b4b5a8b0"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 21, 42, 828, DateTimeKind.Local).AddTicks(8166), new DateTime(2024, 11, 13, 17, 21, 42, 828, DateTimeKind.Local).AddTicks(8171), new DateTime(2024, 11, 13, 17, 21, 42, 828, DateTimeKind.Local).AddTicks(8171) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("ca01ec6a-8d39-4e00-ab98-6c3f9a2e0b1e"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 13, 17, 21, 42, 828, DateTimeKind.Local).AddTicks(7931), new DateTime(2024, 11, 13, 17, 21, 42, 828, DateTimeKind.Local).AddTicks(7935), new DateTime(2024, 11, 13, 17, 21, 42, 828, DateTimeKind.Local).AddTicks(7936) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("d0d69bba-c6c0-4e1e-b8a1-9b4b44e69b93"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 13, 17, 21, 42, 828, DateTimeKind.Local).AddTicks(8113), new DateTime(2024, 11, 13, 17, 21, 42, 828, DateTimeKind.Local).AddTicks(8117), new DateTime(2024, 11, 13, 17, 21, 42, 828, DateTimeKind.Local).AddTicks(8118) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("dd6b2a14-0f8b-41a8-ae5d-53de0a92d764"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 13, 17, 21, 42, 828, DateTimeKind.Local).AddTicks(8081), new DateTime(2024, 11, 13, 17, 21, 42, 828, DateTimeKind.Local).AddTicks(8085), new DateTime(2024, 11, 13, 17, 21, 42, 828, DateTimeKind.Local).AddTicks(8086) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("def969c3-e7ad-4f71-9907-2c0d594d3ecb"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 13, 17, 21, 42, 828, DateTimeKind.Local).AddTicks(7955), new DateTime(2024, 11, 13, 17, 21, 42, 828, DateTimeKind.Local).AddTicks(7959), new DateTime(2024, 11, 13, 17, 21, 42, 828, DateTimeKind.Local).AddTicks(7959) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("df024b07-216f-41d7-b79b-25eb8f28762d"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 4, 13, 17, 21, 42, 828, DateTimeKind.Local).AddTicks(8159), new DateTime(2024, 11, 13, 17, 21, 42, 828, DateTimeKind.Local).AddTicks(8164), new DateTime(2024, 11, 13, 17, 21, 42, 828, DateTimeKind.Local).AddTicks(8164) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("f07a1be4-bd6d-4c2d-9537-303e0c7a5dcf"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 13, 17, 21, 42, 828, DateTimeKind.Local).AddTicks(8088), new DateTime(2024, 11, 13, 17, 21, 42, 828, DateTimeKind.Local).AddTicks(8093), new DateTime(2024, 11, 13, 17, 21, 42, 828, DateTimeKind.Local).AddTicks(8093) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("fa01ec6a-8d39-4e00-ab98-6c3f9a2e0b1f"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 4, 13, 17, 21, 42, 828, DateTimeKind.Local).AddTicks(8009), new DateTime(2024, 11, 13, 17, 21, 42, 828, DateTimeKind.Local).AddTicks(8013), new DateTime(2024, 11, 13, 17, 21, 42, 828, DateTimeKind.Local).AddTicks(8014) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "JobApplications",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CoverLetter",
                table: "JobApplications",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("17e0cd7e-5887-44e2-bf2a-cd1b1f631f76"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 4, 13, 17, 17, 27, 46, DateTimeKind.Local).AddTicks(2167), new DateTime(2024, 11, 13, 17, 17, 27, 46, DateTimeKind.Local).AddTicks(2171), new DateTime(2024, 11, 13, 17, 17, 27, 46, DateTimeKind.Local).AddTicks(2172) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("1b9a3a57-5a94-4cc3-9af1-0380d074dd65"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 13, 17, 17, 27, 46, DateTimeKind.Local).AddTicks(2188), new DateTime(2024, 11, 13, 17, 17, 27, 46, DateTimeKind.Local).AddTicks(2192), new DateTime(2024, 11, 13, 17, 17, 27, 46, DateTimeKind.Local).AddTicks(2193) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("1c8a7d6b-2d7f-4c2b-a9c5-8b3e9f6f2d8b"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 13, 17, 17, 27, 46, DateTimeKind.Local).AddTicks(2140), new DateTime(2024, 11, 13, 17, 17, 27, 46, DateTimeKind.Local).AddTicks(2144), new DateTime(2024, 11, 13, 17, 17, 27, 46, DateTimeKind.Local).AddTicks(2144) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("1d41e60a-ffb5-4039-b4b6-3e25e68d0f2c"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 17, 27, 46, DateTimeKind.Local).AddTicks(2174), new DateTime(2024, 11, 13, 17, 17, 27, 46, DateTimeKind.Local).AddTicks(2178), new DateTime(2024, 11, 13, 17, 17, 27, 46, DateTimeKind.Local).AddTicks(2179) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("22aadfc7-6022-4f15-ac49-13fa33f8afbe"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 13, 17, 17, 27, 46, DateTimeKind.Local).AddTicks(2016), new DateTime(2024, 11, 13, 17, 17, 27, 46, DateTimeKind.Local).AddTicks(2020), new DateTime(2024, 11, 13, 17, 17, 27, 46, DateTimeKind.Local).AddTicks(2020) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("3d6b9f9b-6f2d-4b4a-b4c7-2c8b5f4e1b4e"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 13, 17, 17, 27, 46, DateTimeKind.Local).AddTicks(2116), new DateTime(2024, 11, 13, 17, 17, 27, 46, DateTimeKind.Local).AddTicks(2121), new DateTime(2024, 11, 13, 17, 17, 27, 46, DateTimeKind.Local).AddTicks(2122) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("3d8db2d5-5020-497e-917b-500a1f663c60"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 4, 13, 17, 17, 27, 46, DateTimeKind.Local).AddTicks(2252), new DateTime(2024, 11, 13, 17, 17, 27, 46, DateTimeKind.Local).AddTicks(2257), new DateTime(2024, 11, 13, 17, 17, 27, 46, DateTimeKind.Local).AddTicks(2257) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("4b3dff90-4d8a-4cbb-a3e8-6c7e5a4d3c4a"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 13, 17, 17, 27, 46, DateTimeKind.Local).AddTicks(2124), new DateTime(2024, 11, 13, 17, 17, 27, 46, DateTimeKind.Local).AddTicks(2129), new DateTime(2024, 11, 13, 17, 17, 27, 46, DateTimeKind.Local).AddTicks(2129) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("4c695d62-51f0-4070-a625-c030208dffb7"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 13, 17, 17, 27, 46, DateTimeKind.Local).AddTicks(1935), new DateTime(2024, 11, 13, 17, 17, 27, 46, DateTimeKind.Local).AddTicks(1961), new DateTime(2024, 11, 13, 17, 17, 27, 46, DateTimeKind.Local).AddTicks(1961) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("5540bd1d-b228-410e-8fbf-0842aeda7cb1"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 13, 17, 17, 27, 46, DateTimeKind.Local).AddTicks(1969), new DateTime(2024, 11, 13, 17, 17, 27, 46, DateTimeKind.Local).AddTicks(1975), new DateTime(2024, 11, 13, 17, 17, 27, 46, DateTimeKind.Local).AddTicks(1975) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("571827fa-78f4-4192-ad3b-06bb014309c2"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 13, 17, 17, 27, 46, DateTimeKind.Local).AddTicks(1978), new DateTime(2024, 11, 13, 17, 17, 27, 46, DateTimeKind.Local).AddTicks(1983), new DateTime(2024, 11, 13, 17, 17, 27, 46, DateTimeKind.Local).AddTicks(1983) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("5f9c2d8f-a7f2-45a4-8e4a-90b8f7a03b3e"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 13, 17, 17, 27, 46, DateTimeKind.Local).AddTicks(2102), new DateTime(2024, 11, 13, 17, 17, 27, 46, DateTimeKind.Local).AddTicks(2106), new DateTime(2024, 11, 13, 17, 17, 27, 46, DateTimeKind.Local).AddTicks(2107) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("6f0e2a6f-54d7-493c-bcb4-8f5eeb2fba1b"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 13, 17, 17, 27, 46, DateTimeKind.Local).AddTicks(2244), new DateTime(2024, 11, 13, 17, 17, 27, 46, DateTimeKind.Local).AddTicks(2249), new DateTime(2024, 11, 13, 17, 17, 27, 46, DateTimeKind.Local).AddTicks(2250) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("7c7616f2-3c2c-4c5f-9f40-470e78a847c7"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 13, 17, 17, 27, 46, DateTimeKind.Local).AddTicks(2259), new DateTime(2024, 11, 13, 17, 17, 27, 46, DateTimeKind.Local).AddTicks(2264), new DateTime(2024, 11, 13, 17, 17, 27, 46, DateTimeKind.Local).AddTicks(2264) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("82cfed84-d067-4d70-bef9-f08b0636a6b0"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 13, 17, 17, 27, 46, DateTimeKind.Local).AddTicks(2195), new DateTime(2024, 11, 13, 17, 17, 27, 46, DateTimeKind.Local).AddTicks(2201), new DateTime(2024, 11, 13, 17, 17, 27, 46, DateTimeKind.Local).AddTicks(2201) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("8845c741-6b0f-4f95-b179-3d007ba28a41"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 13, 17, 17, 27, 46, DateTimeKind.Local).AddTicks(2022), new DateTime(2024, 11, 13, 17, 17, 27, 46, DateTimeKind.Local).AddTicks(2026), new DateTime(2024, 11, 13, 17, 17, 27, 46, DateTimeKind.Local).AddTicks(2027) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("8c78bbac-4a5e-49ab-aafb-5a6c3f0c4b5d"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 6, 13, 17, 17, 27, 46, DateTimeKind.Local).AddTicks(2109), new DateTime(2024, 11, 13, 17, 17, 27, 46, DateTimeKind.Local).AddTicks(2113), new DateTime(2024, 11, 13, 17, 17, 27, 46, DateTimeKind.Local).AddTicks(2114) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("8f31d3d0-dc53-45d6-bccd-fd2d15dacb77"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 13, 17, 17, 27, 46, DateTimeKind.Local).AddTicks(2072), new DateTime(2024, 11, 13, 17, 17, 27, 46, DateTimeKind.Local).AddTicks(2077), new DateTime(2024, 11, 13, 17, 17, 27, 46, DateTimeKind.Local).AddTicks(2078) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("9127e8f9-a91c-4dca-8008-3cb7a8dcfb22"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 13, 17, 17, 27, 46, DateTimeKind.Local).AddTicks(2002), new DateTime(2024, 11, 13, 17, 17, 27, 46, DateTimeKind.Local).AddTicks(2006), new DateTime(2024, 11, 13, 17, 17, 27, 46, DateTimeKind.Local).AddTicks(2007) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("a6b3ec6a-1d44-4b00-aa18-7d3f1a2e2f6d"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 13, 17, 17, 27, 46, DateTimeKind.Local).AddTicks(2087), new DateTime(2024, 11, 13, 17, 17, 27, 46, DateTimeKind.Local).AddTicks(2091), new DateTime(2024, 11, 13, 17, 17, 27, 46, DateTimeKind.Local).AddTicks(2092) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("af7bcf34-a92d-4b2b-9937-3e6b7f4f2c6d"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 13, 17, 17, 27, 46, DateTimeKind.Local).AddTicks(2133), new DateTime(2024, 11, 13, 17, 17, 27, 46, DateTimeKind.Local).AddTicks(2137), new DateTime(2024, 11, 13, 17, 17, 27, 46, DateTimeKind.Local).AddTicks(2138) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("b3f9d8c7-a1f4-4e3d-b7c2-7e3f9a4f1c5d"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 4, 13, 17, 17, 27, 46, DateTimeKind.Local).AddTicks(2146), new DateTime(2024, 11, 13, 17, 17, 27, 46, DateTimeKind.Local).AddTicks(2150), new DateTime(2024, 11, 13, 17, 17, 27, 46, DateTimeKind.Local).AddTicks(2151) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("c0a173ff-5be0-4bc9-877b-8d632eeb6da6"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 13, 17, 17, 27, 46, DateTimeKind.Local).AddTicks(2266), new DateTime(2024, 11, 13, 17, 17, 27, 46, DateTimeKind.Local).AddTicks(2270), new DateTime(2024, 11, 13, 17, 17, 27, 46, DateTimeKind.Local).AddTicks(2271) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("c3d3aa6b-ac70-4aa9-a8c2-88b3e0581d87"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 13, 17, 17, 27, 46, DateTimeKind.Local).AddTicks(1993), new DateTime(2024, 11, 13, 17, 17, 27, 46, DateTimeKind.Local).AddTicks(1997), new DateTime(2024, 11, 13, 17, 17, 27, 46, DateTimeKind.Local).AddTicks(1998) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("c3e8ff99-9f1a-4e4e-aaa4-4d1c8e5e3b5a"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 17, 27, 46, DateTimeKind.Local).AddTicks(2094), new DateTime(2024, 11, 13, 17, 17, 27, 46, DateTimeKind.Local).AddTicks(2099), new DateTime(2024, 11, 13, 17, 17, 27, 46, DateTimeKind.Local).AddTicks(2099) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("c8e2c78e-f68e-4c7e-a22f-5c81b4b5a8b0"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 17, 27, 46, DateTimeKind.Local).AddTicks(2236), new DateTime(2024, 11, 13, 17, 17, 27, 46, DateTimeKind.Local).AddTicks(2242), new DateTime(2024, 11, 13, 17, 17, 27, 46, DateTimeKind.Local).AddTicks(2242) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("ca01ec6a-8d39-4e00-ab98-6c3f9a2e0b1e"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 13, 17, 17, 27, 46, DateTimeKind.Local).AddTicks(1986), new DateTime(2024, 11, 13, 17, 17, 27, 46, DateTimeKind.Local).AddTicks(1990), new DateTime(2024, 11, 13, 17, 17, 27, 46, DateTimeKind.Local).AddTicks(1990) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("d0d69bba-c6c0-4e1e-b8a1-9b4b44e69b93"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 13, 17, 17, 27, 46, DateTimeKind.Local).AddTicks(2181), new DateTime(2024, 11, 13, 17, 17, 27, 46, DateTimeKind.Local).AddTicks(2186), new DateTime(2024, 11, 13, 17, 17, 27, 46, DateTimeKind.Local).AddTicks(2186) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("dd6b2a14-0f8b-41a8-ae5d-53de0a92d764"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 13, 17, 17, 27, 46, DateTimeKind.Local).AddTicks(2153), new DateTime(2024, 11, 13, 17, 17, 27, 46, DateTimeKind.Local).AddTicks(2157), new DateTime(2024, 11, 13, 17, 17, 27, 46, DateTimeKind.Local).AddTicks(2157) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("def969c3-e7ad-4f71-9907-2c0d594d3ecb"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 13, 17, 17, 27, 46, DateTimeKind.Local).AddTicks(2009), new DateTime(2024, 11, 13, 17, 17, 27, 46, DateTimeKind.Local).AddTicks(2013), new DateTime(2024, 11, 13, 17, 17, 27, 46, DateTimeKind.Local).AddTicks(2014) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("df024b07-216f-41d7-b79b-25eb8f28762d"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 4, 13, 17, 17, 27, 46, DateTimeKind.Local).AddTicks(2204), new DateTime(2024, 11, 13, 17, 17, 27, 46, DateTimeKind.Local).AddTicks(2209), new DateTime(2024, 11, 13, 17, 17, 27, 46, DateTimeKind.Local).AddTicks(2209) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("f07a1be4-bd6d-4c2d-9537-303e0c7a5dcf"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 13, 17, 17, 27, 46, DateTimeKind.Local).AddTicks(2160), new DateTime(2024, 11, 13, 17, 17, 27, 46, DateTimeKind.Local).AddTicks(2165), new DateTime(2024, 11, 13, 17, 17, 27, 46, DateTimeKind.Local).AddTicks(2165) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("fa01ec6a-8d39-4e00-ab98-6c3f9a2e0b1f"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 4, 13, 17, 17, 27, 46, DateTimeKind.Local).AddTicks(2080), new DateTime(2024, 11, 13, 17, 17, 27, 46, DateTimeKind.Local).AddTicks(2084), new DateTime(2024, 11, 13, 17, 17, 27, 46, DateTimeKind.Local).AddTicks(2085) });
        }
    }
}
