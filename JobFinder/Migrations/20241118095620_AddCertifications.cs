﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JobFinder.Migrations
{
    /// <inheritdoc />
    public partial class AddCertifications : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Certifications",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("17e0cd7e-5887-44e2-bf2a-cd1b1f631f76"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 4, 18, 16, 56, 19, 843, DateTimeKind.Local).AddTicks(7684), new DateTime(2024, 11, 18, 16, 56, 19, 843, DateTimeKind.Local).AddTicks(7687), new DateTime(2024, 11, 18, 16, 56, 19, 843, DateTimeKind.Local).AddTicks(7688) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("1b9a3a57-5a94-4cc3-9af1-0380d074dd65"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 18, 16, 56, 19, 843, DateTimeKind.Local).AddTicks(7710), new DateTime(2024, 11, 18, 16, 56, 19, 843, DateTimeKind.Local).AddTicks(7715), new DateTime(2024, 11, 18, 16, 56, 19, 843, DateTimeKind.Local).AddTicks(7715) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("1c8a7d6b-2d7f-4c2b-a9c5-8b3e9f6f2d8b"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 18, 16, 56, 19, 843, DateTimeKind.Local).AddTicks(7606), new DateTime(2024, 11, 18, 16, 56, 19, 843, DateTimeKind.Local).AddTicks(7610), new DateTime(2024, 11, 18, 16, 56, 19, 843, DateTimeKind.Local).AddTicks(7610) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("1d41e60a-ffb5-4039-b4b6-3e25e68d0f2c"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 18, 16, 56, 19, 843, DateTimeKind.Local).AddTicks(7690), new DateTime(2024, 11, 18, 16, 56, 19, 843, DateTimeKind.Local).AddTicks(7696), new DateTime(2024, 11, 18, 16, 56, 19, 843, DateTimeKind.Local).AddTicks(7697) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("22aadfc7-6022-4f15-ac49-13fa33f8afbe"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 18, 16, 56, 19, 843, DateTimeKind.Local).AddTicks(7515), new DateTime(2024, 11, 18, 16, 56, 19, 843, DateTimeKind.Local).AddTicks(7520), new DateTime(2024, 11, 18, 16, 56, 19, 843, DateTimeKind.Local).AddTicks(7520) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("3d6b9f9b-6f2d-4b4a-b4c7-2c8b5f4e1b4e"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 18, 16, 56, 19, 843, DateTimeKind.Local).AddTicks(7583), new DateTime(2024, 11, 18, 16, 56, 19, 843, DateTimeKind.Local).AddTicks(7587), new DateTime(2024, 11, 18, 16, 56, 19, 843, DateTimeKind.Local).AddTicks(7588) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("3d8db2d5-5020-497e-917b-500a1f663c60"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 4, 18, 16, 56, 19, 843, DateTimeKind.Local).AddTicks(7747), new DateTime(2024, 11, 18, 16, 56, 19, 843, DateTimeKind.Local).AddTicks(7752), new DateTime(2024, 11, 18, 16, 56, 19, 843, DateTimeKind.Local).AddTicks(7752) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("4b3dff90-4d8a-4cbb-a3e8-6c7e5a4d3c4a"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 18, 16, 56, 19, 843, DateTimeKind.Local).AddTicks(7590), new DateTime(2024, 11, 18, 16, 56, 19, 843, DateTimeKind.Local).AddTicks(7595), new DateTime(2024, 11, 18, 16, 56, 19, 843, DateTimeKind.Local).AddTicks(7595) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("4c695d62-51f0-4070-a625-c030208dffb7"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 18, 16, 56, 19, 843, DateTimeKind.Local).AddTicks(7289), new DateTime(2024, 11, 18, 16, 56, 19, 843, DateTimeKind.Local).AddTicks(7407), new DateTime(2024, 11, 18, 16, 56, 19, 843, DateTimeKind.Local).AddTicks(7409) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("5540bd1d-b228-410e-8fbf-0842aeda7cb1"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 18, 16, 56, 19, 843, DateTimeKind.Local).AddTicks(7447), new DateTime(2024, 11, 18, 16, 56, 19, 843, DateTimeKind.Local).AddTicks(7455), new DateTime(2024, 11, 18, 16, 56, 19, 843, DateTimeKind.Local).AddTicks(7456) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("571827fa-78f4-4192-ad3b-06bb014309c2"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 18, 16, 56, 19, 843, DateTimeKind.Local).AddTicks(7462), new DateTime(2024, 11, 18, 16, 56, 19, 843, DateTimeKind.Local).AddTicks(7468), new DateTime(2024, 11, 18, 16, 56, 19, 843, DateTimeKind.Local).AddTicks(7469) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("5f9c2d8f-a7f2-45a4-8e4a-90b8f7a03b3e"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 18, 16, 56, 19, 843, DateTimeKind.Local).AddTicks(7568), new DateTime(2024, 11, 18, 16, 56, 19, 843, DateTimeKind.Local).AddTicks(7572), new DateTime(2024, 11, 18, 16, 56, 19, 843, DateTimeKind.Local).AddTicks(7573) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("6f0e2a6f-54d7-493c-bcb4-8f5eeb2fba1b"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 18, 16, 56, 19, 843, DateTimeKind.Local).AddTicks(7741), new DateTime(2024, 11, 18, 16, 56, 19, 843, DateTimeKind.Local).AddTicks(7745), new DateTime(2024, 11, 18, 16, 56, 19, 843, DateTimeKind.Local).AddTicks(7745) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("7c7616f2-3c2c-4c5f-9f40-470e78a847c7"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 18, 16, 56, 19, 843, DateTimeKind.Local).AddTicks(7754), new DateTime(2024, 11, 18, 16, 56, 19, 843, DateTimeKind.Local).AddTicks(7760), new DateTime(2024, 11, 18, 16, 56, 19, 843, DateTimeKind.Local).AddTicks(7761) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("82cfed84-d067-4d70-bef9-f08b0636a6b0"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 18, 16, 56, 19, 843, DateTimeKind.Local).AddTicks(7718), new DateTime(2024, 11, 18, 16, 56, 19, 843, DateTimeKind.Local).AddTicks(7722), new DateTime(2024, 11, 18, 16, 56, 19, 843, DateTimeKind.Local).AddTicks(7723) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("8845c741-6b0f-4f95-b179-3d007ba28a41"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 18, 16, 56, 19, 843, DateTimeKind.Local).AddTicks(7524), new DateTime(2024, 11, 18, 16, 56, 19, 843, DateTimeKind.Local).AddTicks(7529), new DateTime(2024, 11, 18, 16, 56, 19, 843, DateTimeKind.Local).AddTicks(7529) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("8c78bbac-4a5e-49ab-aafb-5a6c3f0c4b5d"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 6, 18, 16, 56, 19, 843, DateTimeKind.Local).AddTicks(7575), new DateTime(2024, 11, 18, 16, 56, 19, 843, DateTimeKind.Local).AddTicks(7580), new DateTime(2024, 11, 18, 16, 56, 19, 843, DateTimeKind.Local).AddTicks(7581) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("8f31d3d0-dc53-45d6-bccd-fd2d15dacb77"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 18, 16, 56, 19, 843, DateTimeKind.Local).AddTicks(7533), new DateTime(2024, 11, 18, 16, 56, 19, 843, DateTimeKind.Local).AddTicks(7542), new DateTime(2024, 11, 18, 16, 56, 19, 843, DateTimeKind.Local).AddTicks(7543) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("9127e8f9-a91c-4dca-8008-3cb7a8dcfb22"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 18, 16, 56, 19, 843, DateTimeKind.Local).AddTicks(7496), new DateTime(2024, 11, 18, 16, 56, 19, 843, DateTimeKind.Local).AddTicks(7501), new DateTime(2024, 11, 18, 16, 56, 19, 843, DateTimeKind.Local).AddTicks(7502) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("a6b3ec6a-1d44-4b00-aa18-7d3f1a2e2f6d"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 18, 16, 56, 19, 843, DateTimeKind.Local).AddTicks(7552), new DateTime(2024, 11, 18, 16, 56, 19, 843, DateTimeKind.Local).AddTicks(7557), new DateTime(2024, 11, 18, 16, 56, 19, 843, DateTimeKind.Local).AddTicks(7558) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("af7bcf34-a92d-4b2b-9937-3e6b7f4f2c6d"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 18, 16, 56, 19, 843, DateTimeKind.Local).AddTicks(7599), new DateTime(2024, 11, 18, 16, 56, 19, 843, DateTimeKind.Local).AddTicks(7603), new DateTime(2024, 11, 18, 16, 56, 19, 843, DateTimeKind.Local).AddTicks(7604) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("b3f9d8c7-a1f4-4e3d-b7c2-7e3f9a4f1c5d"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 4, 18, 16, 56, 19, 843, DateTimeKind.Local).AddTicks(7661), new DateTime(2024, 11, 18, 16, 56, 19, 843, DateTimeKind.Local).AddTicks(7666), new DateTime(2024, 11, 18, 16, 56, 19, 843, DateTimeKind.Local).AddTicks(7667) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("c0a173ff-5be0-4bc9-877b-8d632eeb6da6"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 18, 16, 56, 19, 843, DateTimeKind.Local).AddTicks(7764), new DateTime(2024, 11, 18, 16, 56, 19, 843, DateTimeKind.Local).AddTicks(7770), new DateTime(2024, 11, 18, 16, 56, 19, 843, DateTimeKind.Local).AddTicks(7770) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("c3d3aa6b-ac70-4aa9-a8c2-88b3e0581d87"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 18, 16, 56, 19, 843, DateTimeKind.Local).AddTicks(7482), new DateTime(2024, 11, 18, 16, 56, 19, 843, DateTimeKind.Local).AddTicks(7488), new DateTime(2024, 11, 18, 16, 56, 19, 843, DateTimeKind.Local).AddTicks(7488) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("c3e8ff99-9f1a-4e4e-aaa4-4d1c8e5e3b5a"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 18, 16, 56, 19, 843, DateTimeKind.Local).AddTicks(7561), new DateTime(2024, 11, 18, 16, 56, 19, 843, DateTimeKind.Local).AddTicks(7566), new DateTime(2024, 11, 18, 16, 56, 19, 843, DateTimeKind.Local).AddTicks(7566) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("c8e2c78e-f68e-4c7e-a22f-5c81b4b5a8b0"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 18, 16, 56, 19, 843, DateTimeKind.Local).AddTicks(7733), new DateTime(2024, 11, 18, 16, 56, 19, 843, DateTimeKind.Local).AddTicks(7738), new DateTime(2024, 11, 18, 16, 56, 19, 843, DateTimeKind.Local).AddTicks(7739) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("ca01ec6a-8d39-4e00-ab98-6c3f9a2e0b1e"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 18, 16, 56, 19, 843, DateTimeKind.Local).AddTicks(7473), new DateTime(2024, 11, 18, 16, 56, 19, 843, DateTimeKind.Local).AddTicks(7478), new DateTime(2024, 11, 18, 16, 56, 19, 843, DateTimeKind.Local).AddTicks(7479) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("d0d69bba-c6c0-4e1e-b8a1-9b4b44e69b93"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 18, 16, 56, 19, 843, DateTimeKind.Local).AddTicks(7699), new DateTime(2024, 11, 18, 16, 56, 19, 843, DateTimeKind.Local).AddTicks(7707), new DateTime(2024, 11, 18, 16, 56, 19, 843, DateTimeKind.Local).AddTicks(7707) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("dd6b2a14-0f8b-41a8-ae5d-53de0a92d764"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 18, 16, 56, 19, 843, DateTimeKind.Local).AddTicks(7669), new DateTime(2024, 11, 18, 16, 56, 19, 843, DateTimeKind.Local).AddTicks(7674), new DateTime(2024, 11, 18, 16, 56, 19, 843, DateTimeKind.Local).AddTicks(7674) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("def969c3-e7ad-4f71-9907-2c0d594d3ecb"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 18, 16, 56, 19, 843, DateTimeKind.Local).AddTicks(7505), new DateTime(2024, 11, 18, 16, 56, 19, 843, DateTimeKind.Local).AddTicks(7510), new DateTime(2024, 11, 18, 16, 56, 19, 843, DateTimeKind.Local).AddTicks(7511) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("df024b07-216f-41d7-b79b-25eb8f28762d"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 4, 18, 16, 56, 19, 843, DateTimeKind.Local).AddTicks(7726), new DateTime(2024, 11, 18, 16, 56, 19, 843, DateTimeKind.Local).AddTicks(7731), new DateTime(2024, 11, 18, 16, 56, 19, 843, DateTimeKind.Local).AddTicks(7731) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("f07a1be4-bd6d-4c2d-9537-303e0c7a5dcf"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 18, 16, 56, 19, 843, DateTimeKind.Local).AddTicks(7676), new DateTime(2024, 11, 18, 16, 56, 19, 843, DateTimeKind.Local).AddTicks(7681), new DateTime(2024, 11, 18, 16, 56, 19, 843, DateTimeKind.Local).AddTicks(7682) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("fa01ec6a-8d39-4e00-ab98-6c3f9a2e0b1f"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 4, 18, 16, 56, 19, 843, DateTimeKind.Local).AddTicks(7545), new DateTime(2024, 11, 18, 16, 56, 19, 843, DateTimeKind.Local).AddTicks(7550), new DateTime(2024, 11, 18, 16, 56, 19, 843, DateTimeKind.Local).AddTicks(7550) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0cc554c2-c577-4a89-8cc1-90724bcbb9fb"),
                column: "Certifications",
                value: "[]");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("789d82a4-e7ea-458b-aacd-039fc2f30fc4"),
                column: "Certifications",
                value: "[]");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Certifications",
                table: "Users");

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("17e0cd7e-5887-44e2-bf2a-cd1b1f631f76"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 4, 18, 15, 24, 34, 107, DateTimeKind.Local).AddTicks(7478), new DateTime(2024, 11, 18, 15, 24, 34, 107, DateTimeKind.Local).AddTicks(7485), new DateTime(2024, 11, 18, 15, 24, 34, 107, DateTimeKind.Local).AddTicks(7485) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("1b9a3a57-5a94-4cc3-9af1-0380d074dd65"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 18, 15, 24, 34, 107, DateTimeKind.Local).AddTicks(7500), new DateTime(2024, 11, 18, 15, 24, 34, 107, DateTimeKind.Local).AddTicks(7505), new DateTime(2024, 11, 18, 15, 24, 34, 107, DateTimeKind.Local).AddTicks(7506) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("1c8a7d6b-2d7f-4c2b-a9c5-8b3e9f6f2d8b"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 18, 15, 24, 34, 107, DateTimeKind.Local).AddTicks(7450), new DateTime(2024, 11, 18, 15, 24, 34, 107, DateTimeKind.Local).AddTicks(7454), new DateTime(2024, 11, 18, 15, 24, 34, 107, DateTimeKind.Local).AddTicks(7455) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("1d41e60a-ffb5-4039-b4b6-3e25e68d0f2c"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 18, 15, 24, 34, 107, DateTimeKind.Local).AddTicks(7487), new DateTime(2024, 11, 18, 15, 24, 34, 107, DateTimeKind.Local).AddTicks(7491), new DateTime(2024, 11, 18, 15, 24, 34, 107, DateTimeKind.Local).AddTicks(7492) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("22aadfc7-6022-4f15-ac49-13fa33f8afbe"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 18, 15, 24, 34, 107, DateTimeKind.Local).AddTicks(7332), new DateTime(2024, 11, 18, 15, 24, 34, 107, DateTimeKind.Local).AddTicks(7336), new DateTime(2024, 11, 18, 15, 24, 34, 107, DateTimeKind.Local).AddTicks(7337) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("3d6b9f9b-6f2d-4b4a-b4c7-2c8b5f4e1b4e"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 18, 15, 24, 34, 107, DateTimeKind.Local).AddTicks(7428), new DateTime(2024, 11, 18, 15, 24, 34, 107, DateTimeKind.Local).AddTicks(7432), new DateTime(2024, 11, 18, 15, 24, 34, 107, DateTimeKind.Local).AddTicks(7433) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("3d8db2d5-5020-497e-917b-500a1f663c60"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 4, 18, 15, 24, 34, 107, DateTimeKind.Local).AddTicks(7564), new DateTime(2024, 11, 18, 15, 24, 34, 107, DateTimeKind.Local).AddTicks(7568), new DateTime(2024, 11, 18, 15, 24, 34, 107, DateTimeKind.Local).AddTicks(7568) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("4b3dff90-4d8a-4cbb-a3e8-6c7e5a4d3c4a"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 18, 15, 24, 34, 107, DateTimeKind.Local).AddTicks(7435), new DateTime(2024, 11, 18, 15, 24, 34, 107, DateTimeKind.Local).AddTicks(7439), new DateTime(2024, 11, 18, 15, 24, 34, 107, DateTimeKind.Local).AddTicks(7440) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("4c695d62-51f0-4070-a625-c030208dffb7"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 18, 15, 24, 34, 107, DateTimeKind.Local).AddTicks(7252), new DateTime(2024, 11, 18, 15, 24, 34, 107, DateTimeKind.Local).AddTicks(7278), new DateTime(2024, 11, 18, 15, 24, 34, 107, DateTimeKind.Local).AddTicks(7278) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("5540bd1d-b228-410e-8fbf-0842aeda7cb1"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 18, 15, 24, 34, 107, DateTimeKind.Local).AddTicks(7283), new DateTime(2024, 11, 18, 15, 24, 34, 107, DateTimeKind.Local).AddTicks(7289), new DateTime(2024, 11, 18, 15, 24, 34, 107, DateTimeKind.Local).AddTicks(7290) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("571827fa-78f4-4192-ad3b-06bb014309c2"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 18, 15, 24, 34, 107, DateTimeKind.Local).AddTicks(7292), new DateTime(2024, 11, 18, 15, 24, 34, 107, DateTimeKind.Local).AddTicks(7298), new DateTime(2024, 11, 18, 15, 24, 34, 107, DateTimeKind.Local).AddTicks(7298) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("5f9c2d8f-a7f2-45a4-8e4a-90b8f7a03b3e"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 18, 15, 24, 34, 107, DateTimeKind.Local).AddTicks(7413), new DateTime(2024, 11, 18, 15, 24, 34, 107, DateTimeKind.Local).AddTicks(7418), new DateTime(2024, 11, 18, 15, 24, 34, 107, DateTimeKind.Local).AddTicks(7419) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("6f0e2a6f-54d7-493c-bcb4-8f5eeb2fba1b"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 18, 15, 24, 34, 107, DateTimeKind.Local).AddTicks(7556), new DateTime(2024, 11, 18, 15, 24, 34, 107, DateTimeKind.Local).AddTicks(7561), new DateTime(2024, 11, 18, 15, 24, 34, 107, DateTimeKind.Local).AddTicks(7562) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("7c7616f2-3c2c-4c5f-9f40-470e78a847c7"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 18, 15, 24, 34, 107, DateTimeKind.Local).AddTicks(7570), new DateTime(2024, 11, 18, 15, 24, 34, 107, DateTimeKind.Local).AddTicks(7574), new DateTime(2024, 11, 18, 15, 24, 34, 107, DateTimeKind.Local).AddTicks(7575) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("82cfed84-d067-4d70-bef9-f08b0636a6b0"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 18, 15, 24, 34, 107, DateTimeKind.Local).AddTicks(7508), new DateTime(2024, 11, 18, 15, 24, 34, 107, DateTimeKind.Local).AddTicks(7513), new DateTime(2024, 11, 18, 15, 24, 34, 107, DateTimeKind.Local).AddTicks(7514) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("8845c741-6b0f-4f95-b179-3d007ba28a41"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 18, 15, 24, 34, 107, DateTimeKind.Local).AddTicks(7339), new DateTime(2024, 11, 18, 15, 24, 34, 107, DateTimeKind.Local).AddTicks(7344), new DateTime(2024, 11, 18, 15, 24, 34, 107, DateTimeKind.Local).AddTicks(7345) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("8c78bbac-4a5e-49ab-aafb-5a6c3f0c4b5d"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 6, 18, 15, 24, 34, 107, DateTimeKind.Local).AddTicks(7421), new DateTime(2024, 11, 18, 15, 24, 34, 107, DateTimeKind.Local).AddTicks(7425), new DateTime(2024, 11, 18, 15, 24, 34, 107, DateTimeKind.Local).AddTicks(7426) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("8f31d3d0-dc53-45d6-bccd-fd2d15dacb77"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 18, 15, 24, 34, 107, DateTimeKind.Local).AddTicks(7379), new DateTime(2024, 11, 18, 15, 24, 34, 107, DateTimeKind.Local).AddTicks(7386), new DateTime(2024, 11, 18, 15, 24, 34, 107, DateTimeKind.Local).AddTicks(7387) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("9127e8f9-a91c-4dca-8008-3cb7a8dcfb22"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 18, 15, 24, 34, 107, DateTimeKind.Local).AddTicks(7318), new DateTime(2024, 11, 18, 15, 24, 34, 107, DateTimeKind.Local).AddTicks(7322), new DateTime(2024, 11, 18, 15, 24, 34, 107, DateTimeKind.Local).AddTicks(7323) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("a6b3ec6a-1d44-4b00-aa18-7d3f1a2e2f6d"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 18, 15, 24, 34, 107, DateTimeKind.Local).AddTicks(7396), new DateTime(2024, 11, 18, 15, 24, 34, 107, DateTimeKind.Local).AddTicks(7401), new DateTime(2024, 11, 18, 15, 24, 34, 107, DateTimeKind.Local).AddTicks(7401) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("af7bcf34-a92d-4b2b-9937-3e6b7f4f2c6d"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 18, 15, 24, 34, 107, DateTimeKind.Local).AddTicks(7443), new DateTime(2024, 11, 18, 15, 24, 34, 107, DateTimeKind.Local).AddTicks(7447), new DateTime(2024, 11, 18, 15, 24, 34, 107, DateTimeKind.Local).AddTicks(7447) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("b3f9d8c7-a1f4-4e3d-b7c2-7e3f9a4f1c5d"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 4, 18, 15, 24, 34, 107, DateTimeKind.Local).AddTicks(7457), new DateTime(2024, 11, 18, 15, 24, 34, 107, DateTimeKind.Local).AddTicks(7461), new DateTime(2024, 11, 18, 15, 24, 34, 107, DateTimeKind.Local).AddTicks(7462) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("c0a173ff-5be0-4bc9-877b-8d632eeb6da6"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 18, 15, 24, 34, 107, DateTimeKind.Local).AddTicks(7577), new DateTime(2024, 11, 18, 15, 24, 34, 107, DateTimeKind.Local).AddTicks(7581), new DateTime(2024, 11, 18, 15, 24, 34, 107, DateTimeKind.Local).AddTicks(7581) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("c3d3aa6b-ac70-4aa9-a8c2-88b3e0581d87"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 18, 15, 24, 34, 107, DateTimeKind.Local).AddTicks(7310), new DateTime(2024, 11, 18, 15, 24, 34, 107, DateTimeKind.Local).AddTicks(7314), new DateTime(2024, 11, 18, 15, 24, 34, 107, DateTimeKind.Local).AddTicks(7315) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("c3e8ff99-9f1a-4e4e-aaa4-4d1c8e5e3b5a"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 18, 15, 24, 34, 107, DateTimeKind.Local).AddTicks(7405), new DateTime(2024, 11, 18, 15, 24, 34, 107, DateTimeKind.Local).AddTicks(7409), new DateTime(2024, 11, 18, 15, 24, 34, 107, DateTimeKind.Local).AddTicks(7410) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("c8e2c78e-f68e-4c7e-a22f-5c81b4b5a8b0"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 18, 15, 24, 34, 107, DateTimeKind.Local).AddTicks(7548), new DateTime(2024, 11, 18, 15, 24, 34, 107, DateTimeKind.Local).AddTicks(7553), new DateTime(2024, 11, 18, 15, 24, 34, 107, DateTimeKind.Local).AddTicks(7554) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("ca01ec6a-8d39-4e00-ab98-6c3f9a2e0b1e"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 18, 15, 24, 34, 107, DateTimeKind.Local).AddTicks(7301), new DateTime(2024, 11, 18, 15, 24, 34, 107, DateTimeKind.Local).AddTicks(7306), new DateTime(2024, 11, 18, 15, 24, 34, 107, DateTimeKind.Local).AddTicks(7307) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("d0d69bba-c6c0-4e1e-b8a1-9b4b44e69b93"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 18, 15, 24, 34, 107, DateTimeKind.Local).AddTicks(7494), new DateTime(2024, 11, 18, 15, 24, 34, 107, DateTimeKind.Local).AddTicks(7498), new DateTime(2024, 11, 18, 15, 24, 34, 107, DateTimeKind.Local).AddTicks(7498) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("dd6b2a14-0f8b-41a8-ae5d-53de0a92d764"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 18, 15, 24, 34, 107, DateTimeKind.Local).AddTicks(7464), new DateTime(2024, 11, 18, 15, 24, 34, 107, DateTimeKind.Local).AddTicks(7469), new DateTime(2024, 11, 18, 15, 24, 34, 107, DateTimeKind.Local).AddTicks(7470) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("def969c3-e7ad-4f71-9907-2c0d594d3ecb"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 18, 15, 24, 34, 107, DateTimeKind.Local).AddTicks(7325), new DateTime(2024, 11, 18, 15, 24, 34, 107, DateTimeKind.Local).AddTicks(7329), new DateTime(2024, 11, 18, 15, 24, 34, 107, DateTimeKind.Local).AddTicks(7330) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("df024b07-216f-41d7-b79b-25eb8f28762d"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 4, 18, 15, 24, 34, 107, DateTimeKind.Local).AddTicks(7516), new DateTime(2024, 11, 18, 15, 24, 34, 107, DateTimeKind.Local).AddTicks(7521), new DateTime(2024, 11, 18, 15, 24, 34, 107, DateTimeKind.Local).AddTicks(7521) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("f07a1be4-bd6d-4c2d-9537-303e0c7a5dcf"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 18, 15, 24, 34, 107, DateTimeKind.Local).AddTicks(7472), new DateTime(2024, 11, 18, 15, 24, 34, 107, DateTimeKind.Local).AddTicks(7476), new DateTime(2024, 11, 18, 15, 24, 34, 107, DateTimeKind.Local).AddTicks(7476) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("fa01ec6a-8d39-4e00-ab98-6c3f9a2e0b1f"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 4, 18, 15, 24, 34, 107, DateTimeKind.Local).AddTicks(7389), new DateTime(2024, 11, 18, 15, 24, 34, 107, DateTimeKind.Local).AddTicks(7393), new DateTime(2024, 11, 18, 15, 24, 34, 107, DateTimeKind.Local).AddTicks(7394) });
        }
    }
}
