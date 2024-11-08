using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JobFinder.Migrations
{
    /// <inheritdoc />
    public partial class AddJobSkills : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Skills",
                table: "Jobs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("17e0cd7e-5887-44e2-bf2a-cd1b1f631f76"),
                columns: new[] { "CloseDate", "CreatedAt", "Skills", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 4, 8, 16, 0, 28, 323, DateTimeKind.Local).AddTicks(7825), new DateTime(2024, 11, 8, 16, 0, 28, 323, DateTimeKind.Local).AddTicks(7830), null, new DateTime(2024, 11, 8, 16, 0, 28, 323, DateTimeKind.Local).AddTicks(7831) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("1b9a3a57-5a94-4cc3-9af1-0380d074dd65"),
                columns: new[] { "CloseDate", "CreatedAt", "Skills", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 8, 16, 0, 28, 323, DateTimeKind.Local).AddTicks(7856), new DateTime(2024, 11, 8, 16, 0, 28, 323, DateTimeKind.Local).AddTicks(7861), null, new DateTime(2024, 11, 8, 16, 0, 28, 323, DateTimeKind.Local).AddTicks(7862) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("1c8a7d6b-2d7f-4c2b-a9c5-8b3e9f6f2d8b"),
                columns: new[] { "CloseDate", "CreatedAt", "Skills", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 8, 16, 0, 28, 323, DateTimeKind.Local).AddTicks(7793), new DateTime(2024, 11, 8, 16, 0, 28, 323, DateTimeKind.Local).AddTicks(7798), null, new DateTime(2024, 11, 8, 16, 0, 28, 323, DateTimeKind.Local).AddTicks(7798) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("1d41e60a-ffb5-4039-b4b6-3e25e68d0f2c"),
                columns: new[] { "CloseDate", "CreatedAt", "Skills", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 8, 16, 0, 28, 323, DateTimeKind.Local).AddTicks(7834), new DateTime(2024, 11, 8, 16, 0, 28, 323, DateTimeKind.Local).AddTicks(7840), null, new DateTime(2024, 11, 8, 16, 0, 28, 323, DateTimeKind.Local).AddTicks(7841) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("22aadfc7-6022-4f15-ac49-13fa33f8afbe"),
                columns: new[] { "CloseDate", "CreatedAt", "Skills", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 8, 16, 0, 28, 323, DateTimeKind.Local).AddTicks(7664), new DateTime(2024, 11, 8, 16, 0, 28, 323, DateTimeKind.Local).AddTicks(7668), null, new DateTime(2024, 11, 8, 16, 0, 28, 323, DateTimeKind.Local).AddTicks(7668) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("3d6b9f9b-6f2d-4b4a-b4c7-2c8b5f4e1b4e"),
                columns: new[] { "CloseDate", "CreatedAt", "Skills", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 8, 16, 0, 28, 323, DateTimeKind.Local).AddTicks(7737), new DateTime(2024, 11, 8, 16, 0, 28, 323, DateTimeKind.Local).AddTicks(7740), null, new DateTime(2024, 11, 8, 16, 0, 28, 323, DateTimeKind.Local).AddTicks(7741) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("3d8db2d5-5020-497e-917b-500a1f663c60"),
                columns: new[] { "CloseDate", "CreatedAt", "Skills", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 4, 8, 16, 0, 28, 323, DateTimeKind.Local).AddTicks(7904), new DateTime(2024, 11, 8, 16, 0, 28, 323, DateTimeKind.Local).AddTicks(7911), null, new DateTime(2024, 11, 8, 16, 0, 28, 323, DateTimeKind.Local).AddTicks(7912) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("4b3dff90-4d8a-4cbb-a3e8-6c7e5a4d3c4a"),
                columns: new[] { "CloseDate", "CreatedAt", "Skills", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 8, 16, 0, 28, 323, DateTimeKind.Local).AddTicks(7743), new DateTime(2024, 11, 8, 16, 0, 28, 323, DateTimeKind.Local).AddTicks(7748), null, new DateTime(2024, 11, 8, 16, 0, 28, 323, DateTimeKind.Local).AddTicks(7748) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("4c695d62-51f0-4070-a625-c030208dffb7"),
                columns: new[] { "CloseDate", "CreatedAt", "Skills", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 8, 16, 0, 28, 323, DateTimeKind.Local).AddTicks(7552), new DateTime(2024, 11, 8, 16, 0, 28, 323, DateTimeKind.Local).AddTicks(7597), "[\"C#\",\".NET\",\"Machine Learning\",\"Network\",\"Hardware\",\"Marketing\"]", new DateTime(2024, 11, 8, 16, 0, 28, 323, DateTimeKind.Local).AddTicks(7598) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("5540bd1d-b228-410e-8fbf-0842aeda7cb1"),
                columns: new[] { "CloseDate", "CreatedAt", "Skills", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 8, 16, 0, 28, 323, DateTimeKind.Local).AddTicks(7608), new DateTime(2024, 11, 8, 16, 0, 28, 323, DateTimeKind.Local).AddTicks(7614), "[\"C#\",\".NET\",\"Machine Learning\",\"Network\",\"Hardware\",\"Marketing\"]", new DateTime(2024, 11, 8, 16, 0, 28, 323, DateTimeKind.Local).AddTicks(7615) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("571827fa-78f4-4192-ad3b-06bb014309c2"),
                columns: new[] { "CloseDate", "CreatedAt", "Skills", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 8, 16, 0, 28, 323, DateTimeKind.Local).AddTicks(7617), new DateTime(2024, 11, 8, 16, 0, 28, 323, DateTimeKind.Local).AddTicks(7622), null, new DateTime(2024, 11, 8, 16, 0, 28, 323, DateTimeKind.Local).AddTicks(7622) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("5f9c2d8f-a7f2-45a4-8e4a-90b8f7a03b3e"),
                columns: new[] { "CloseDate", "CreatedAt", "Skills", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 8, 16, 0, 28, 323, DateTimeKind.Local).AddTicks(7722), new DateTime(2024, 11, 8, 16, 0, 28, 323, DateTimeKind.Local).AddTicks(7727), null, new DateTime(2024, 11, 8, 16, 0, 28, 323, DateTimeKind.Local).AddTicks(7727) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("6f0e2a6f-54d7-493c-bcb4-8f5eeb2fba1b"),
                columns: new[] { "CloseDate", "CreatedAt", "Skills", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 8, 16, 0, 28, 323, DateTimeKind.Local).AddTicks(7895), new DateTime(2024, 11, 8, 16, 0, 28, 323, DateTimeKind.Local).AddTicks(7900), null, new DateTime(2024, 11, 8, 16, 0, 28, 323, DateTimeKind.Local).AddTicks(7901) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("7c7616f2-3c2c-4c5f-9f40-470e78a847c7"),
                columns: new[] { "CloseDate", "CreatedAt", "Skills", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 8, 16, 0, 28, 323, DateTimeKind.Local).AddTicks(7915), new DateTime(2024, 11, 8, 16, 0, 28, 323, DateTimeKind.Local).AddTicks(7922), null, new DateTime(2024, 11, 8, 16, 0, 28, 323, DateTimeKind.Local).AddTicks(7923) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("82cfed84-d067-4d70-bef9-f08b0636a6b0"),
                columns: new[] { "CloseDate", "CreatedAt", "Skills", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 8, 16, 0, 28, 323, DateTimeKind.Local).AddTicks(7866), new DateTime(2024, 11, 8, 16, 0, 28, 323, DateTimeKind.Local).AddTicks(7873), null, new DateTime(2024, 11, 8, 16, 0, 28, 323, DateTimeKind.Local).AddTicks(7873) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("8845c741-6b0f-4f95-b179-3d007ba28a41"),
                columns: new[] { "CloseDate", "CreatedAt", "Skills", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 8, 16, 0, 28, 323, DateTimeKind.Local).AddTicks(7670), new DateTime(2024, 11, 8, 16, 0, 28, 323, DateTimeKind.Local).AddTicks(7680), null, new DateTime(2024, 11, 8, 16, 0, 28, 323, DateTimeKind.Local).AddTicks(7680) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("8c78bbac-4a5e-49ab-aafb-5a6c3f0c4b5d"),
                columns: new[] { "CloseDate", "CreatedAt", "Skills", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 6, 8, 16, 0, 28, 323, DateTimeKind.Local).AddTicks(7730), new DateTime(2024, 11, 8, 16, 0, 28, 323, DateTimeKind.Local).AddTicks(7734), null, new DateTime(2024, 11, 8, 16, 0, 28, 323, DateTimeKind.Local).AddTicks(7735) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("8f31d3d0-dc53-45d6-bccd-fd2d15dacb77"),
                columns: new[] { "CloseDate", "CreatedAt", "Skills", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 8, 16, 0, 28, 323, DateTimeKind.Local).AddTicks(7683), new DateTime(2024, 11, 8, 16, 0, 28, 323, DateTimeKind.Local).AddTicks(7691), null, new DateTime(2024, 11, 8, 16, 0, 28, 323, DateTimeKind.Local).AddTicks(7692) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("9127e8f9-a91c-4dca-8008-3cb7a8dcfb22"),
                columns: new[] { "CloseDate", "CreatedAt", "Skills", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 8, 16, 0, 28, 323, DateTimeKind.Local).AddTicks(7645), new DateTime(2024, 11, 8, 16, 0, 28, 323, DateTimeKind.Local).AddTicks(7651), null, new DateTime(2024, 11, 8, 16, 0, 28, 323, DateTimeKind.Local).AddTicks(7652) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("a6b3ec6a-1d44-4b00-aa18-7d3f1a2e2f6d"),
                columns: new[] { "CloseDate", "CreatedAt", "Skills", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 8, 16, 0, 28, 323, DateTimeKind.Local).AddTicks(7703), new DateTime(2024, 11, 8, 16, 0, 28, 323, DateTimeKind.Local).AddTicks(7710), null, new DateTime(2024, 11, 8, 16, 0, 28, 323, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("af7bcf34-a92d-4b2b-9937-3e6b7f4f2c6d"),
                columns: new[] { "CloseDate", "CreatedAt", "Skills", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 8, 16, 0, 28, 323, DateTimeKind.Local).AddTicks(7785), new DateTime(2024, 11, 8, 16, 0, 28, 323, DateTimeKind.Local).AddTicks(7790), null, new DateTime(2024, 11, 8, 16, 0, 28, 323, DateTimeKind.Local).AddTicks(7791) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("b3f9d8c7-a1f4-4e3d-b7c2-7e3f9a4f1c5d"),
                columns: new[] { "CloseDate", "CreatedAt", "Skills", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 4, 8, 16, 0, 28, 323, DateTimeKind.Local).AddTicks(7800), new DateTime(2024, 11, 8, 16, 0, 28, 323, DateTimeKind.Local).AddTicks(7804), null, new DateTime(2024, 11, 8, 16, 0, 28, 323, DateTimeKind.Local).AddTicks(7805) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("c0a173ff-5be0-4bc9-877b-8d632eeb6da6"),
                columns: new[] { "CloseDate", "CreatedAt", "Skills", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 8, 16, 0, 28, 323, DateTimeKind.Local).AddTicks(7925), new DateTime(2024, 11, 8, 16, 0, 28, 323, DateTimeKind.Local).AddTicks(7930), null, new DateTime(2024, 11, 8, 16, 0, 28, 323, DateTimeKind.Local).AddTicks(7931) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("c3d3aa6b-ac70-4aa9-a8c2-88b3e0581d87"),
                columns: new[] { "CloseDate", "CreatedAt", "Skills", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 8, 16, 0, 28, 323, DateTimeKind.Local).AddTicks(7632), new DateTime(2024, 11, 8, 16, 0, 28, 323, DateTimeKind.Local).AddTicks(7637), null, new DateTime(2024, 11, 8, 16, 0, 28, 323, DateTimeKind.Local).AddTicks(7637) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("c3e8ff99-9f1a-4e4e-aaa4-4d1c8e5e3b5a"),
                columns: new[] { "CloseDate", "CreatedAt", "Skills", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 8, 16, 0, 28, 323, DateTimeKind.Local).AddTicks(7713), new DateTime(2024, 11, 8, 16, 0, 28, 323, DateTimeKind.Local).AddTicks(7719), null, new DateTime(2024, 11, 8, 16, 0, 28, 323, DateTimeKind.Local).AddTicks(7719) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("c8e2c78e-f68e-4c7e-a22f-5c81b4b5a8b0"),
                columns: new[] { "CloseDate", "CreatedAt", "Skills", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 8, 16, 0, 28, 323, DateTimeKind.Local).AddTicks(7885), new DateTime(2024, 11, 8, 16, 0, 28, 323, DateTimeKind.Local).AddTicks(7892), null, new DateTime(2024, 11, 8, 16, 0, 28, 323, DateTimeKind.Local).AddTicks(7893) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("ca01ec6a-8d39-4e00-ab98-6c3f9a2e0b1e"),
                columns: new[] { "CloseDate", "CreatedAt", "Skills", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 8, 16, 0, 28, 323, DateTimeKind.Local).AddTicks(7624), new DateTime(2024, 11, 8, 16, 0, 28, 323, DateTimeKind.Local).AddTicks(7628), null, new DateTime(2024, 11, 8, 16, 0, 28, 323, DateTimeKind.Local).AddTicks(7629) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("d0d69bba-c6c0-4e1e-b8a1-9b4b44e69b93"),
                columns: new[] { "CloseDate", "CreatedAt", "Skills", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 8, 16, 0, 28, 323, DateTimeKind.Local).AddTicks(7845), new DateTime(2024, 11, 8, 16, 0, 28, 323, DateTimeKind.Local).AddTicks(7850), null, new DateTime(2024, 11, 8, 16, 0, 28, 323, DateTimeKind.Local).AddTicks(7851) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("dd6b2a14-0f8b-41a8-ae5d-53de0a92d764"),
                columns: new[] { "CloseDate", "CreatedAt", "Skills", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 8, 16, 0, 28, 323, DateTimeKind.Local).AddTicks(7808), new DateTime(2024, 11, 8, 16, 0, 28, 323, DateTimeKind.Local).AddTicks(7813), null, new DateTime(2024, 11, 8, 16, 0, 28, 323, DateTimeKind.Local).AddTicks(7814) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("def969c3-e7ad-4f71-9907-2c0d594d3ecb"),
                columns: new[] { "CloseDate", "CreatedAt", "Skills", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 8, 16, 0, 28, 323, DateTimeKind.Local).AddTicks(7654), new DateTime(2024, 11, 8, 16, 0, 28, 323, DateTimeKind.Local).AddTicks(7658), null, new DateTime(2024, 11, 8, 16, 0, 28, 323, DateTimeKind.Local).AddTicks(7658) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("df024b07-216f-41d7-b79b-25eb8f28762d"),
                columns: new[] { "CloseDate", "CreatedAt", "Skills", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 4, 8, 16, 0, 28, 323, DateTimeKind.Local).AddTicks(7876), new DateTime(2024, 11, 8, 16, 0, 28, 323, DateTimeKind.Local).AddTicks(7881), null, new DateTime(2024, 11, 8, 16, 0, 28, 323, DateTimeKind.Local).AddTicks(7881) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("f07a1be4-bd6d-4c2d-9537-303e0c7a5dcf"),
                columns: new[] { "CloseDate", "CreatedAt", "Skills", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 8, 16, 0, 28, 323, DateTimeKind.Local).AddTicks(7816), new DateTime(2024, 11, 8, 16, 0, 28, 323, DateTimeKind.Local).AddTicks(7820), null, new DateTime(2024, 11, 8, 16, 0, 28, 323, DateTimeKind.Local).AddTicks(7822) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("fa01ec6a-8d39-4e00-ab98-6c3f9a2e0b1f"),
                columns: new[] { "CloseDate", "CreatedAt", "Skills", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 4, 8, 16, 0, 28, 323, DateTimeKind.Local).AddTicks(7693), new DateTime(2024, 11, 8, 16, 0, 28, 323, DateTimeKind.Local).AddTicks(7701), null, new DateTime(2024, 11, 8, 16, 0, 28, 323, DateTimeKind.Local).AddTicks(7701) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Skills",
                table: "Jobs");

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("17e0cd7e-5887-44e2-bf2a-cd1b1f631f76"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 4, 6, 17, 34, 11, 173, DateTimeKind.Local).AddTicks(1873), new DateTime(2024, 11, 6, 17, 34, 11, 173, DateTimeKind.Local).AddTicks(1877), new DateTime(2024, 11, 6, 17, 34, 11, 173, DateTimeKind.Local).AddTicks(1878) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("1b9a3a57-5a94-4cc3-9af1-0380d074dd65"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 6, 17, 34, 11, 173, DateTimeKind.Local).AddTicks(1893), new DateTime(2024, 11, 6, 17, 34, 11, 173, DateTimeKind.Local).AddTicks(1897), new DateTime(2024, 11, 6, 17, 34, 11, 173, DateTimeKind.Local).AddTicks(1898) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("1c8a7d6b-2d7f-4c2b-a9c5-8b3e9f6f2d8b"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 6, 17, 34, 11, 173, DateTimeKind.Local).AddTicks(1842), new DateTime(2024, 11, 6, 17, 34, 11, 173, DateTimeKind.Local).AddTicks(1846), new DateTime(2024, 11, 6, 17, 34, 11, 173, DateTimeKind.Local).AddTicks(1847) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("1d41e60a-ffb5-4039-b4b6-3e25e68d0f2c"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 34, 11, 173, DateTimeKind.Local).AddTicks(1880), new DateTime(2024, 11, 6, 17, 34, 11, 173, DateTimeKind.Local).AddTicks(1884), new DateTime(2024, 11, 6, 17, 34, 11, 173, DateTimeKind.Local).AddTicks(1884) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("22aadfc7-6022-4f15-ac49-13fa33f8afbe"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 6, 17, 34, 11, 173, DateTimeKind.Local).AddTicks(1714), new DateTime(2024, 11, 6, 17, 34, 11, 173, DateTimeKind.Local).AddTicks(1719), new DateTime(2024, 11, 6, 17, 34, 11, 173, DateTimeKind.Local).AddTicks(1720) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("3d6b9f9b-6f2d-4b4a-b4c7-2c8b5f4e1b4e"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 6, 17, 34, 11, 173, DateTimeKind.Local).AddTicks(1774), new DateTime(2024, 11, 6, 17, 34, 11, 173, DateTimeKind.Local).AddTicks(1779), new DateTime(2024, 11, 6, 17, 34, 11, 173, DateTimeKind.Local).AddTicks(1779) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("3d8db2d5-5020-497e-917b-500a1f663c60"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 4, 6, 17, 34, 11, 173, DateTimeKind.Local).AddTicks(1927), new DateTime(2024, 11, 6, 17, 34, 11, 173, DateTimeKind.Local).AddTicks(1934), new DateTime(2024, 11, 6, 17, 34, 11, 173, DateTimeKind.Local).AddTicks(1934) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("4b3dff90-4d8a-4cbb-a3e8-6c7e5a4d3c4a"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 6, 17, 34, 11, 173, DateTimeKind.Local).AddTicks(1781), new DateTime(2024, 11, 6, 17, 34, 11, 173, DateTimeKind.Local).AddTicks(1786), new DateTime(2024, 11, 6, 17, 34, 11, 173, DateTimeKind.Local).AddTicks(1786) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("4c695d62-51f0-4070-a625-c030208dffb7"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 6, 17, 34, 11, 173, DateTimeKind.Local).AddTicks(1641), new DateTime(2024, 11, 6, 17, 34, 11, 173, DateTimeKind.Local).AddTicks(1664), new DateTime(2024, 11, 6, 17, 34, 11, 173, DateTimeKind.Local).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("5540bd1d-b228-410e-8fbf-0842aeda7cb1"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 6, 17, 34, 11, 173, DateTimeKind.Local).AddTicks(1670), new DateTime(2024, 11, 6, 17, 34, 11, 173, DateTimeKind.Local).AddTicks(1674), new DateTime(2024, 11, 6, 17, 34, 11, 173, DateTimeKind.Local).AddTicks(1675) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("571827fa-78f4-4192-ad3b-06bb014309c2"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 17, 34, 11, 173, DateTimeKind.Local).AddTicks(1677), new DateTime(2024, 11, 6, 17, 34, 11, 173, DateTimeKind.Local).AddTicks(1681), new DateTime(2024, 11, 6, 17, 34, 11, 173, DateTimeKind.Local).AddTicks(1681) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("5f9c2d8f-a7f2-45a4-8e4a-90b8f7a03b3e"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 6, 17, 34, 11, 173, DateTimeKind.Local).AddTicks(1760), new DateTime(2024, 11, 6, 17, 34, 11, 173, DateTimeKind.Local).AddTicks(1764), new DateTime(2024, 11, 6, 17, 34, 11, 173, DateTimeKind.Local).AddTicks(1764) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("6f0e2a6f-54d7-493c-bcb4-8f5eeb2fba1b"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 6, 17, 34, 11, 173, DateTimeKind.Local).AddTicks(1921), new DateTime(2024, 11, 6, 17, 34, 11, 173, DateTimeKind.Local).AddTicks(1925), new DateTime(2024, 11, 6, 17, 34, 11, 173, DateTimeKind.Local).AddTicks(1925) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("7c7616f2-3c2c-4c5f-9f40-470e78a847c7"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 17, 34, 11, 173, DateTimeKind.Local).AddTicks(1936), new DateTime(2024, 11, 6, 17, 34, 11, 173, DateTimeKind.Local).AddTicks(1940), new DateTime(2024, 11, 6, 17, 34, 11, 173, DateTimeKind.Local).AddTicks(1941) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("82cfed84-d067-4d70-bef9-f08b0636a6b0"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 17, 34, 11, 173, DateTimeKind.Local).AddTicks(1900), new DateTime(2024, 11, 6, 17, 34, 11, 173, DateTimeKind.Local).AddTicks(1904), new DateTime(2024, 11, 6, 17, 34, 11, 173, DateTimeKind.Local).AddTicks(1905) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("8845c741-6b0f-4f95-b179-3d007ba28a41"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 6, 17, 34, 11, 173, DateTimeKind.Local).AddTicks(1722), new DateTime(2024, 11, 6, 17, 34, 11, 173, DateTimeKind.Local).AddTicks(1726), new DateTime(2024, 11, 6, 17, 34, 11, 173, DateTimeKind.Local).AddTicks(1727) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("8c78bbac-4a5e-49ab-aafb-5a6c3f0c4b5d"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 6, 6, 17, 34, 11, 173, DateTimeKind.Local).AddTicks(1767), new DateTime(2024, 11, 6, 17, 34, 11, 173, DateTimeKind.Local).AddTicks(1771), new DateTime(2024, 11, 6, 17, 34, 11, 173, DateTimeKind.Local).AddTicks(1772) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("8f31d3d0-dc53-45d6-bccd-fd2d15dacb77"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 6, 17, 34, 11, 173, DateTimeKind.Local).AddTicks(1730), new DateTime(2024, 11, 6, 17, 34, 11, 173, DateTimeKind.Local).AddTicks(1734), new DateTime(2024, 11, 6, 17, 34, 11, 173, DateTimeKind.Local).AddTicks(1735) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("9127e8f9-a91c-4dca-8008-3cb7a8dcfb22"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 6, 17, 34, 11, 173, DateTimeKind.Local).AddTicks(1699), new DateTime(2024, 11, 6, 17, 34, 11, 173, DateTimeKind.Local).AddTicks(1703), new DateTime(2024, 11, 6, 17, 34, 11, 173, DateTimeKind.Local).AddTicks(1704) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("a6b3ec6a-1d44-4b00-aa18-7d3f1a2e2f6d"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 6, 17, 34, 11, 173, DateTimeKind.Local).AddTicks(1744), new DateTime(2024, 11, 6, 17, 34, 11, 173, DateTimeKind.Local).AddTicks(1749), new DateTime(2024, 11, 6, 17, 34, 11, 173, DateTimeKind.Local).AddTicks(1750) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("af7bcf34-a92d-4b2b-9937-3e6b7f4f2c6d"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 17, 34, 11, 173, DateTimeKind.Local).AddTicks(1834), new DateTime(2024, 11, 6, 17, 34, 11, 173, DateTimeKind.Local).AddTicks(1839), new DateTime(2024, 11, 6, 17, 34, 11, 173, DateTimeKind.Local).AddTicks(1840) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("b3f9d8c7-a1f4-4e3d-b7c2-7e3f9a4f1c5d"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 4, 6, 17, 34, 11, 173, DateTimeKind.Local).AddTicks(1850), new DateTime(2024, 11, 6, 17, 34, 11, 173, DateTimeKind.Local).AddTicks(1856), new DateTime(2024, 11, 6, 17, 34, 11, 173, DateTimeKind.Local).AddTicks(1856) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("c0a173ff-5be0-4bc9-877b-8d632eeb6da6"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 6, 17, 34, 11, 173, DateTimeKind.Local).AddTicks(1943), new DateTime(2024, 11, 6, 17, 34, 11, 173, DateTimeKind.Local).AddTicks(1947), new DateTime(2024, 11, 6, 17, 34, 11, 173, DateTimeKind.Local).AddTicks(1947) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("c3d3aa6b-ac70-4aa9-a8c2-88b3e0581d87"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 6, 17, 34, 11, 173, DateTimeKind.Local).AddTicks(1691), new DateTime(2024, 11, 6, 17, 34, 11, 173, DateTimeKind.Local).AddTicks(1695), new DateTime(2024, 11, 6, 17, 34, 11, 173, DateTimeKind.Local).AddTicks(1696) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("c3e8ff99-9f1a-4e4e-aaa4-4d1c8e5e3b5a"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 34, 11, 173, DateTimeKind.Local).AddTicks(1753), new DateTime(2024, 11, 6, 17, 34, 11, 173, DateTimeKind.Local).AddTicks(1757), new DateTime(2024, 11, 6, 17, 34, 11, 173, DateTimeKind.Local).AddTicks(1758) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("c8e2c78e-f68e-4c7e-a22f-5c81b4b5a8b0"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 34, 11, 173, DateTimeKind.Local).AddTicks(1913), new DateTime(2024, 11, 6, 17, 34, 11, 173, DateTimeKind.Local).AddTicks(1917), new DateTime(2024, 11, 6, 17, 34, 11, 173, DateTimeKind.Local).AddTicks(1918) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("ca01ec6a-8d39-4e00-ab98-6c3f9a2e0b1e"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 6, 17, 34, 11, 173, DateTimeKind.Local).AddTicks(1684), new DateTime(2024, 11, 6, 17, 34, 11, 173, DateTimeKind.Local).AddTicks(1688), new DateTime(2024, 11, 6, 17, 34, 11, 173, DateTimeKind.Local).AddTicks(1689) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("d0d69bba-c6c0-4e1e-b8a1-9b4b44e69b93"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 6, 17, 34, 11, 173, DateTimeKind.Local).AddTicks(1886), new DateTime(2024, 11, 6, 17, 34, 11, 173, DateTimeKind.Local).AddTicks(1891), new DateTime(2024, 11, 6, 17, 34, 11, 173, DateTimeKind.Local).AddTicks(1891) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("dd6b2a14-0f8b-41a8-ae5d-53de0a92d764"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 17, 34, 11, 173, DateTimeKind.Local).AddTicks(1859), new DateTime(2024, 11, 6, 17, 34, 11, 173, DateTimeKind.Local).AddTicks(1863), new DateTime(2024, 11, 6, 17, 34, 11, 173, DateTimeKind.Local).AddTicks(1864) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("def969c3-e7ad-4f71-9907-2c0d594d3ecb"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 17, 34, 11, 173, DateTimeKind.Local).AddTicks(1706), new DateTime(2024, 11, 6, 17, 34, 11, 173, DateTimeKind.Local).AddTicks(1711), new DateTime(2024, 11, 6, 17, 34, 11, 173, DateTimeKind.Local).AddTicks(1712) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("df024b07-216f-41d7-b79b-25eb8f28762d"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 4, 6, 17, 34, 11, 173, DateTimeKind.Local).AddTicks(1907), new DateTime(2024, 11, 6, 17, 34, 11, 173, DateTimeKind.Local).AddTicks(1911), new DateTime(2024, 11, 6, 17, 34, 11, 173, DateTimeKind.Local).AddTicks(1911) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("f07a1be4-bd6d-4c2d-9537-303e0c7a5dcf"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 6, 17, 34, 11, 173, DateTimeKind.Local).AddTicks(1866), new DateTime(2024, 11, 6, 17, 34, 11, 173, DateTimeKind.Local).AddTicks(1870), new DateTime(2024, 11, 6, 17, 34, 11, 173, DateTimeKind.Local).AddTicks(1871) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("fa01ec6a-8d39-4e00-ab98-6c3f9a2e0b1f"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 4, 6, 17, 34, 11, 173, DateTimeKind.Local).AddTicks(1738), new DateTime(2024, 11, 6, 17, 34, 11, 173, DateTimeKind.Local).AddTicks(1742), new DateTime(2024, 11, 6, 17, 34, 11, 173, DateTimeKind.Local).AddTicks(1742) });
        }
    }
}
