using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace JobFinder.Migrations
{
    /// <inheritdoc />
    public partial class UseTpcForAccount : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Companies_Accounts_AccountId",
                table: "Companies");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Accounts_AccountId",
                table: "Users");

            migrationBuilder.DropTable(
                name: "Accounts");

            migrationBuilder.DropIndex(
                name: "IX_Users_AccountId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Companies_AccountId",
                table: "Companies");

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("6bf113f5-7f15-4973-aa96-9e0b85072b21"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("8480b848-7ff8-402f-bbe7-dc23dd593a60"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("b09a943a-ca96-4d14-be00-b68e517a17e7"));

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: new Guid("ab9af358-61ce-453e-96eb-23eff22e0c3b"));

            migrationBuilder.DropColumn(
                name: "AccountId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "AccountId",
                table: "Companies");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Phone",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Username",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Companies",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "Companies",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Phone",
                table: "Companies",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Username",
                table: "Companies",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: new Guid("7f9b407b-80e0-4f0c-a301-5a8bbf813b05"),
                columns: new[] { "Email", "Password", "Phone", "Username" },
                values: new object[] { "", "$2a$11$hikE.93/ueqzkLgEmg/ZqecSBLDdjFFoAOst74hFbVusInqaD0Zsu", "", "admin" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: new Guid("ec7d72b6-e9f4-4c85-bc12-c2db31d5efa7"),
                columns: new[] { "Email", "Password", "Phone", "Username" },
                values: new object[] { "", "$2a$11$IZZ6xdXFo09DOlqjYY.bUOcyYxuEk54S6gpROHmYnE3V9OYN43Eae", "", "account1" });

            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "Id", "Address", "CreatedAt", "CreatedBy", "Description", "DistrictId", "Email", "EmailContact", "EmployeeCount", "Industry", "Logo", "Name", "Password", "Phone", "PhoneContact", "ProvinceId", "Slug", "UpdatedAt", "UpdatedBy", "Username", "Website" },
                values: new object[] { new Guid("ec6aba4a-1b55-412a-a2e7-9ec8b9f16662"), "45688 London", null, null, "An Inc. is a an incident company.", 0, "", "info@AnRe.com", 300, "IT", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRsowdkWEAhFe0idqRamO_CAvGutpD1CHKpcA&s", "An Inc.", "$2a$11$IR24pQlXvPNndxyST6tbTumFqbv2hB65pyyJiJKEHOIID4G13neLa", "", "98765432112", 0, "an-pro-ga", null, null, "account2", "www.Anrp.com" });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("17e0cd7e-5887-44e2-bf2a-cd1b1f631f76"),
                columns: new[] { "CloseDate", "CompanyId", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 4, 6, 16, 39, 25, 703, DateTimeKind.Local).AddTicks(7979), new Guid("ec6aba4a-1b55-412a-a2e7-9ec8b9f16662"), new DateTime(2024, 11, 6, 16, 39, 25, 703, DateTimeKind.Local).AddTicks(7985), new DateTime(2024, 11, 6, 16, 39, 25, 703, DateTimeKind.Local).AddTicks(7986) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("1b9a3a57-5a94-4cc3-9af1-0380d074dd65"),
                columns: new[] { "CloseDate", "CompanyId", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 6, 16, 39, 25, 703, DateTimeKind.Local).AddTicks(8039), new Guid("ec6aba4a-1b55-412a-a2e7-9ec8b9f16662"), new DateTime(2024, 11, 6, 16, 39, 25, 703, DateTimeKind.Local).AddTicks(8046), new DateTime(2024, 11, 6, 16, 39, 25, 703, DateTimeKind.Local).AddTicks(8047) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("1c8a7d6b-2d7f-4c2b-a9c5-8b3e9f6f2d8b"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 6, 16, 39, 25, 703, DateTimeKind.Local).AddTicks(7943), new DateTime(2024, 11, 6, 16, 39, 25, 703, DateTimeKind.Local).AddTicks(7949), new DateTime(2024, 11, 6, 16, 39, 25, 703, DateTimeKind.Local).AddTicks(7949) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("1d41e60a-ffb5-4039-b4b6-3e25e68d0f2c"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 6, 16, 39, 25, 703, DateTimeKind.Local).AddTicks(8016), new DateTime(2024, 11, 6, 16, 39, 25, 703, DateTimeKind.Local).AddTicks(8023), new DateTime(2024, 11, 6, 16, 39, 25, 703, DateTimeKind.Local).AddTicks(8024) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("3d6b9f9b-6f2d-4b4a-b4c7-2c8b5f4e1b4e"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 6, 16, 39, 25, 703, DateTimeKind.Local).AddTicks(7913), new DateTime(2024, 11, 6, 16, 39, 25, 703, DateTimeKind.Local).AddTicks(7918), new DateTime(2024, 11, 6, 16, 39, 25, 703, DateTimeKind.Local).AddTicks(7919) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("3d8db2d5-5020-497e-917b-500a1f663c60"),
                columns: new[] { "CloseDate", "CompanyId", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 4, 6, 16, 39, 25, 703, DateTimeKind.Local).AddTicks(8093), new Guid("ec6aba4a-1b55-412a-a2e7-9ec8b9f16662"), new DateTime(2024, 11, 6, 16, 39, 25, 703, DateTimeKind.Local).AddTicks(8098), new DateTime(2024, 11, 6, 16, 39, 25, 703, DateTimeKind.Local).AddTicks(8099) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("4b3dff90-4d8a-4cbb-a3e8-6c7e5a4d3c4a"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 6, 16, 39, 25, 703, DateTimeKind.Local).AddTicks(7921), new DateTime(2024, 11, 6, 16, 39, 25, 703, DateTimeKind.Local).AddTicks(7927), new DateTime(2024, 11, 6, 16, 39, 25, 703, DateTimeKind.Local).AddTicks(7927) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("4c695d62-51f0-4070-a625-c030208dffb7"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 6, 16, 39, 25, 703, DateTimeKind.Local).AddTicks(7707), new DateTime(2024, 11, 6, 16, 39, 25, 703, DateTimeKind.Local).AddTicks(7739), new DateTime(2024, 11, 6, 16, 39, 25, 703, DateTimeKind.Local).AddTicks(7740) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("5540bd1d-b228-410e-8fbf-0842aeda7cb1"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 6, 16, 39, 25, 703, DateTimeKind.Local).AddTicks(7745), new DateTime(2024, 11, 6, 16, 39, 25, 703, DateTimeKind.Local).AddTicks(7750), new DateTime(2024, 11, 6, 16, 39, 25, 703, DateTimeKind.Local).AddTicks(7751) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("571827fa-78f4-4192-ad3b-06bb014309c2"),
                columns: new[] { "CloseDate", "CompanyId", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 16, 39, 25, 703, DateTimeKind.Local).AddTicks(7755), new Guid("ec6aba4a-1b55-412a-a2e7-9ec8b9f16662"), new DateTime(2024, 11, 6, 16, 39, 25, 703, DateTimeKind.Local).AddTicks(7761), new DateTime(2024, 11, 6, 16, 39, 25, 703, DateTimeKind.Local).AddTicks(7761) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("5f9c2d8f-a7f2-45a4-8e4a-90b8f7a03b3e"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 6, 16, 39, 25, 703, DateTimeKind.Local).AddTicks(7894), new DateTime(2024, 11, 6, 16, 39, 25, 703, DateTimeKind.Local).AddTicks(7899), new DateTime(2024, 11, 6, 16, 39, 25, 703, DateTimeKind.Local).AddTicks(7900) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("6f0e2a6f-54d7-493c-bcb4-8f5eeb2fba1b"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 6, 16, 39, 25, 703, DateTimeKind.Local).AddTicks(8081), new DateTime(2024, 11, 6, 16, 39, 25, 703, DateTimeKind.Local).AddTicks(8088), new DateTime(2024, 11, 6, 16, 39, 25, 703, DateTimeKind.Local).AddTicks(8089) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("7c7616f2-3c2c-4c5f-9f40-470e78a847c7"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 16, 39, 25, 703, DateTimeKind.Local).AddTicks(8102), new DateTime(2024, 11, 6, 16, 39, 25, 703, DateTimeKind.Local).AddTicks(8107), new DateTime(2024, 11, 6, 16, 39, 25, 703, DateTimeKind.Local).AddTicks(8108) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("82cfed84-d067-4d70-bef9-f08b0636a6b0"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 16, 39, 25, 703, DateTimeKind.Local).AddTicks(8051), new DateTime(2024, 11, 6, 16, 39, 25, 703, DateTimeKind.Local).AddTicks(8058), new DateTime(2024, 11, 6, 16, 39, 25, 703, DateTimeKind.Local).AddTicks(8059) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("8c78bbac-4a5e-49ab-aafb-5a6c3f0c4b5d"),
                columns: new[] { "CloseDate", "CompanyId", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 6, 6, 16, 39, 25, 703, DateTimeKind.Local).AddTicks(7903), new Guid("ec6aba4a-1b55-412a-a2e7-9ec8b9f16662"), new DateTime(2024, 11, 6, 16, 39, 25, 703, DateTimeKind.Local).AddTicks(7908), new DateTime(2024, 11, 6, 16, 39, 25, 703, DateTimeKind.Local).AddTicks(7909) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("9127e8f9-a91c-4dca-8008-3cb7a8dcfb22"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 6, 16, 39, 25, 703, DateTimeKind.Local).AddTicks(7821), new DateTime(2024, 11, 6, 16, 39, 25, 703, DateTimeKind.Local).AddTicks(7826), new DateTime(2024, 11, 6, 16, 39, 25, 703, DateTimeKind.Local).AddTicks(7827) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("a6b3ec6a-1d44-4b00-aa18-7d3f1a2e2f6d"),
                columns: new[] { "CloseDate", "CompanyId", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 6, 16, 39, 25, 703, DateTimeKind.Local).AddTicks(7877), new Guid("ec6aba4a-1b55-412a-a2e7-9ec8b9f16662"), new DateTime(2024, 11, 6, 16, 39, 25, 703, DateTimeKind.Local).AddTicks(7883), new DateTime(2024, 11, 6, 16, 39, 25, 703, DateTimeKind.Local).AddTicks(7883) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("af7bcf34-a92d-4b2b-9937-3e6b7f4f2c6d"),
                columns: new[] { "CloseDate", "CompanyId", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 16, 39, 25, 703, DateTimeKind.Local).AddTicks(7935), new Guid("ec6aba4a-1b55-412a-a2e7-9ec8b9f16662"), new DateTime(2024, 11, 6, 16, 39, 25, 703, DateTimeKind.Local).AddTicks(7939), new DateTime(2024, 11, 6, 16, 39, 25, 703, DateTimeKind.Local).AddTicks(7940) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("b3f9d8c7-a1f4-4e3d-b7c2-7e3f9a4f1c5d"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 4, 6, 16, 39, 25, 703, DateTimeKind.Local).AddTicks(7953), new DateTime(2024, 11, 6, 16, 39, 25, 703, DateTimeKind.Local).AddTicks(7958), new DateTime(2024, 11, 6, 16, 39, 25, 703, DateTimeKind.Local).AddTicks(7958) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("c0a173ff-5be0-4bc9-877b-8d632eeb6da6"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 6, 16, 39, 25, 703, DateTimeKind.Local).AddTicks(8111), new DateTime(2024, 11, 6, 16, 39, 25, 703, DateTimeKind.Local).AddTicks(8116), new DateTime(2024, 11, 6, 16, 39, 25, 703, DateTimeKind.Local).AddTicks(8117) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("c3d3aa6b-ac70-4aa9-a8c2-88b3e0581d87"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 6, 16, 39, 25, 703, DateTimeKind.Local).AddTicks(7811), new DateTime(2024, 11, 6, 16, 39, 25, 703, DateTimeKind.Local).AddTicks(7816), new DateTime(2024, 11, 6, 16, 39, 25, 703, DateTimeKind.Local).AddTicks(7817) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("c3e8ff99-9f1a-4e4e-aaa4-4d1c8e5e3b5a"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 6, 16, 39, 25, 703, DateTimeKind.Local).AddTicks(7886), new DateTime(2024, 11, 6, 16, 39, 25, 703, DateTimeKind.Local).AddTicks(7891), new DateTime(2024, 11, 6, 16, 39, 25, 703, DateTimeKind.Local).AddTicks(7892) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("c8e2c78e-f68e-4c7e-a22f-5c81b4b5a8b0"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 6, 16, 39, 25, 703, DateTimeKind.Local).AddTicks(8072), new DateTime(2024, 11, 6, 16, 39, 25, 703, DateTimeKind.Local).AddTicks(8078), new DateTime(2024, 11, 6, 16, 39, 25, 703, DateTimeKind.Local).AddTicks(8078) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("ca01ec6a-8d39-4e00-ab98-6c3f9a2e0b1e"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 6, 16, 39, 25, 703, DateTimeKind.Local).AddTicks(7802), new DateTime(2024, 11, 6, 16, 39, 25, 703, DateTimeKind.Local).AddTicks(7807), new DateTime(2024, 11, 6, 16, 39, 25, 703, DateTimeKind.Local).AddTicks(7808) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("d0d69bba-c6c0-4e1e-b8a1-9b4b44e69b93"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 6, 16, 39, 25, 703, DateTimeKind.Local).AddTicks(8027), new DateTime(2024, 11, 6, 16, 39, 25, 703, DateTimeKind.Local).AddTicks(8035), new DateTime(2024, 11, 6, 16, 39, 25, 703, DateTimeKind.Local).AddTicks(8035) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("dd6b2a14-0f8b-41a8-ae5d-53de0a92d764"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 16, 39, 25, 703, DateTimeKind.Local).AddTicks(7961), new DateTime(2024, 11, 6, 16, 39, 25, 703, DateTimeKind.Local).AddTicks(7966), new DateTime(2024, 11, 6, 16, 39, 25, 703, DateTimeKind.Local).AddTicks(7967) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("def969c3-e7ad-4f71-9907-2c0d594d3ecb"),
                columns: new[] { "CloseDate", "CompanyId", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 16, 39, 25, 703, DateTimeKind.Local).AddTicks(7830), new Guid("ec6aba4a-1b55-412a-a2e7-9ec8b9f16662"), new DateTime(2024, 11, 6, 16, 39, 25, 703, DateTimeKind.Local).AddTicks(7835), new DateTime(2024, 11, 6, 16, 39, 25, 703, DateTimeKind.Local).AddTicks(7835) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("df024b07-216f-41d7-b79b-25eb8f28762d"),
                columns: new[] { "CloseDate", "CompanyId", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 4, 6, 16, 39, 25, 703, DateTimeKind.Local).AddTicks(8063), new Guid("ec6aba4a-1b55-412a-a2e7-9ec8b9f16662"), new DateTime(2024, 11, 6, 16, 39, 25, 703, DateTimeKind.Local).AddTicks(8068), new DateTime(2024, 11, 6, 16, 39, 25, 703, DateTimeKind.Local).AddTicks(8069) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("f07a1be4-bd6d-4c2d-9537-303e0c7a5dcf"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 6, 16, 39, 25, 703, DateTimeKind.Local).AddTicks(7970), new DateTime(2024, 11, 6, 16, 39, 25, 703, DateTimeKind.Local).AddTicks(7976), new DateTime(2024, 11, 6, 16, 39, 25, 703, DateTimeKind.Local).AddTicks(7976) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("fa01ec6a-8d39-4e00-ab98-6c3f9a2e0b1f"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 4, 6, 16, 39, 25, 703, DateTimeKind.Local).AddTicks(7869), new DateTime(2024, 11, 6, 16, 39, 25, 703, DateTimeKind.Local).AddTicks(7874), new DateTime(2024, 11, 6, 16, 39, 25, 703, DateTimeKind.Local).AddTicks(7875) });

            migrationBuilder.InsertData(
                table: "Jobs",
                columns: new[] { "Id", "CloseDate", "CommitmentTypeId", "CompanyId", "CreatedAt", "CreatedBy", "Description", "DistrictId", "EducationLevelRequirementId", "GenderRequirementId", "MaxAgeRequirement", "MinAgeRequirement", "ProvinceId", "Salary", "Status", "Title", "UpdatedAt", "UpdatedBy", "WorkArrangementId", "WorkExperienceRequirementId" },
                values: new object[,]
                {
                    { new Guid("22aadfc7-6022-4f15-ac49-13fa33f8afbe"), new DateTime(2025, 2, 6, 16, 39, 25, 703, DateTimeKind.Local).AddTicks(7838), new Guid("44b668b2-09ee-499e-af95-73598f9153a2"), new Guid("7f9b407b-80e0-4f0c-a301-5a8bbf813b05"), new DateTime(2024, 11, 6, 16, 39, 25, 703, DateTimeKind.Local).AddTicks(7844), null, "Manage and maintain network infrastructure.", 21, new Guid("bc4ecf1e-8841-47f2-86ec-b0c523f03da1"), new Guid("79685cdb-be26-49cc-b7f9-1fb51686f5ba"), 40, 25, 4, 85000.0, 1, "Network Engineer", new DateTime(2024, 11, 6, 16, 39, 25, 703, DateTimeKind.Local).AddTicks(7845), null, new Guid("04a9de34-0869-41b2-87a8-63c20c4ba22a"), new Guid("bf38a1b9-dee3-455a-87c1-4e034fe806f7") },
                    { new Guid("8845c741-6b0f-4f95-b179-3d007ba28a41"), new DateTime(2025, 1, 6, 16, 39, 25, 703, DateTimeKind.Local).AddTicks(7847), new Guid("3fbef738-ed16-4778-8463-8390444841de"), new Guid("ec7d72b6-e9f4-4c85-bc12-c2db31d5efa7"), new DateTime(2024, 11, 6, 16, 39, 25, 703, DateTimeKind.Local).AddTicks(7854), null, "Build and maintain client relationships.", 30, new Guid("ebb6a034-ce37-41a4-b1f6-c70f1698c4f2"), new Guid("7b5f69cb-5996-4a57-b9c6-9fee2a791bf6"), 35, 23, 5, 55000.0, 1, "Sales Executive", new DateTime(2024, 11, 6, 16, 39, 25, 703, DateTimeKind.Local).AddTicks(7855), null, new Guid("376764fa-28ec-4a08-80e3-a6ab407e8601"), new Guid("cc4121b2-72c2-4226-ad12-24e722b50cc2") },
                    { new Guid("8f31d3d0-dc53-45d6-bccd-fd2d15dacb77"), new DateTime(2025, 2, 6, 16, 39, 25, 703, DateTimeKind.Local).AddTicks(7859), new Guid("5d06c3b1-2bd1-4c68-96b4-f4cd8c899dff"), new Guid("ec6aba4a-1b55-412a-a2e7-9ec8b9f16662"), new DateTime(2024, 11, 6, 16, 39, 25, 703, DateTimeKind.Local).AddTicks(7865), null, "Provide technical support to clients.", 18, new Guid("a3fb036a-04fc-4590-b87d-6ed32e2ec692"), new Guid("12497687-64b8-4d8e-814a-b7d1d33d3aab"), 33, 22, 6, 45000.0, 1, "Customer Support Specialist", new DateTime(2024, 11, 6, 16, 39, 25, 703, DateTimeKind.Local).AddTicks(7866), null, new Guid("c199da74-c2fb-4381-b093-cf2f1e3e8f06"), new Guid("fbce1042-bce0-47a3-92cc-54e3b86eb570") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("22aadfc7-6022-4f15-ac49-13fa33f8afbe"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("8845c741-6b0f-4f95-b179-3d007ba28a41"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("8f31d3d0-dc53-45d6-bccd-fd2d15dacb77"));

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: new Guid("ec6aba4a-1b55-412a-a2e7-9ec8b9f16662"));

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Password",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Phone",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Username",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Companies");

            migrationBuilder.DropColumn(
                name: "Password",
                table: "Companies");

            migrationBuilder.DropColumn(
                name: "Phone",
                table: "Companies");

            migrationBuilder.DropColumn(
                name: "Username",
                table: "Companies");

            migrationBuilder.AddColumn<Guid>(
                name: "AccountId",
                table: "Users",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "AccountId",
                table: "Companies",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateTable(
                name: "Accounts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Accounts", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "Email", "Password", "Phone", "UpdatedAt", "UpdatedBy", "Username" },
                values: new object[,]
                {
                    { new Guid("4b28785a-e6d8-4bde-bc61-4fcd3c7edcb9"), null, null, "", "$2a$11$IZZ6xdXFo09DOlqjYY.bUOcyYxuEk54S6gpROHmYnE3V9OYN43Eae", "0823456789", null, null, "account1" },
                    { new Guid("509c3115-d035-4911-8e1c-a2b46c7a0e6b"), null, null, "", "$2a$11$w/2YhULUMNYfi.BlWIuFTOSv6ngt19dS7EeYkyCSmk5rV3cM9uCYS", "0123456789", null, null, "account0" },
                    { new Guid("5ecd2d42-4b0e-43a1-9406-961552ca3e87"), null, null, "", "$2a$11$hikE.93/ueqzkLgEmg/ZqecSBLDdjFFoAOst74hFbVusInqaD0Zsu", "113", null, null, "admin" },
                    { new Guid("ab9af358-61ce-453e-96eb-23eff22e0c3b"), null, null, "", "$2a$11$IR24pQlXvPNndxyST6tbTumFqbv2hB65pyyJiJKEHOIID4G13neLa", "0183456789", null, null, "account2" },
                    { new Guid("af42a5ad-c0a8-4e72-9f30-88df3c1fa9d4"), null, null, "", "$2a$11$xoYhWtwccyzdujgeI/bUXearKO.hApx7A5sSVAdcKxs.LN1f54VIe", "0128456789", null, null, "account3" },
                    { new Guid("c3d3aa6b-ac70-4aa9-a8c2-88b3e0581d87"), null, null, "", "$2a$11$C1d.rvknxJMAETBUHl.PK.DsvY5hiTUzPSR43mcBG4sJW0YM17udq", "0123856789", null, null, "account4" }
                });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: new Guid("7f9b407b-80e0-4f0c-a301-5a8bbf813b05"),
                column: "AccountId",
                value: new Guid("5ecd2d42-4b0e-43a1-9406-961552ca3e87"));

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: new Guid("ec7d72b6-e9f4-4c85-bc12-c2db31d5efa7"),
                column: "AccountId",
                value: new Guid("509c3115-d035-4911-8e1c-a2b46c7a0e6b"));

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("17e0cd7e-5887-44e2-bf2a-cd1b1f631f76"),
                columns: new[] { "CloseDate", "CompanyId", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 4, 1, 17, 31, 17, 847, DateTimeKind.Local).AddTicks(5752), new Guid("ab9af358-61ce-453e-96eb-23eff22e0c3b"), new DateTime(2024, 11, 1, 17, 31, 17, 847, DateTimeKind.Local).AddTicks(5756), new DateTime(2024, 11, 1, 17, 31, 17, 847, DateTimeKind.Local).AddTicks(5757) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("1b9a3a57-5a94-4cc3-9af1-0380d074dd65"),
                columns: new[] { "CloseDate", "CompanyId", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 1, 17, 31, 17, 847, DateTimeKind.Local).AddTicks(5772), new Guid("ab9af358-61ce-453e-96eb-23eff22e0c3b"), new DateTime(2024, 11, 1, 17, 31, 17, 847, DateTimeKind.Local).AddTicks(5777), new DateTime(2024, 11, 1, 17, 31, 17, 847, DateTimeKind.Local).AddTicks(5778) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("1c8a7d6b-2d7f-4c2b-a9c5-8b3e9f6f2d8b"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 1, 17, 31, 17, 847, DateTimeKind.Local).AddTicks(5722), new DateTime(2024, 11, 1, 17, 31, 17, 847, DateTimeKind.Local).AddTicks(5727), new DateTime(2024, 11, 1, 17, 31, 17, 847, DateTimeKind.Local).AddTicks(5729) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("1d41e60a-ffb5-4039-b4b6-3e25e68d0f2c"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 1, 17, 31, 17, 847, DateTimeKind.Local).AddTicks(5759), new DateTime(2024, 11, 1, 17, 31, 17, 847, DateTimeKind.Local).AddTicks(5763), new DateTime(2024, 11, 1, 17, 31, 17, 847, DateTimeKind.Local).AddTicks(5764) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("3d6b9f9b-6f2d-4b4a-b4c7-2c8b5f4e1b4e"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 1, 17, 31, 17, 847, DateTimeKind.Local).AddTicks(5692), new DateTime(2024, 11, 1, 17, 31, 17, 847, DateTimeKind.Local).AddTicks(5699), new DateTime(2024, 11, 1, 17, 31, 17, 847, DateTimeKind.Local).AddTicks(5700) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("3d8db2d5-5020-497e-917b-500a1f663c60"),
                columns: new[] { "CloseDate", "CompanyId", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 4, 1, 17, 31, 17, 847, DateTimeKind.Local).AddTicks(5809), new Guid("ab9af358-61ce-453e-96eb-23eff22e0c3b"), new DateTime(2024, 11, 1, 17, 31, 17, 847, DateTimeKind.Local).AddTicks(5813), new DateTime(2024, 11, 1, 17, 31, 17, 847, DateTimeKind.Local).AddTicks(5813) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("4b3dff90-4d8a-4cbb-a3e8-6c7e5a4d3c4a"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 1, 17, 31, 17, 847, DateTimeKind.Local).AddTicks(5702), new DateTime(2024, 11, 1, 17, 31, 17, 847, DateTimeKind.Local).AddTicks(5710), new DateTime(2024, 11, 1, 17, 31, 17, 847, DateTimeKind.Local).AddTicks(5711) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("4c695d62-51f0-4070-a625-c030208dffb7"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 1, 17, 31, 17, 847, DateTimeKind.Local).AddTicks(5500), new DateTime(2024, 11, 1, 17, 31, 17, 847, DateTimeKind.Local).AddTicks(5524), new DateTime(2024, 11, 1, 17, 31, 17, 847, DateTimeKind.Local).AddTicks(5525) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("5540bd1d-b228-410e-8fbf-0842aeda7cb1"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 1, 17, 31, 17, 847, DateTimeKind.Local).AddTicks(5529), new DateTime(2024, 11, 1, 17, 31, 17, 847, DateTimeKind.Local).AddTicks(5537), new DateTime(2024, 11, 1, 17, 31, 17, 847, DateTimeKind.Local).AddTicks(5537) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("571827fa-78f4-4192-ad3b-06bb014309c2"),
                columns: new[] { "CloseDate", "CompanyId", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 1, 17, 31, 17, 847, DateTimeKind.Local).AddTicks(5540), new Guid("ab9af358-61ce-453e-96eb-23eff22e0c3b"), new DateTime(2024, 11, 1, 17, 31, 17, 847, DateTimeKind.Local).AddTicks(5545), new DateTime(2024, 11, 1, 17, 31, 17, 847, DateTimeKind.Local).AddTicks(5545) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("5f9c2d8f-a7f2-45a4-8e4a-90b8f7a03b3e"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 1, 17, 31, 17, 847, DateTimeKind.Local).AddTicks(5671), new DateTime(2024, 11, 1, 17, 31, 17, 847, DateTimeKind.Local).AddTicks(5676), new DateTime(2024, 11, 1, 17, 31, 17, 847, DateTimeKind.Local).AddTicks(5677) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("6f0e2a6f-54d7-493c-bcb4-8f5eeb2fba1b"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 1, 17, 31, 17, 847, DateTimeKind.Local).AddTicks(5801), new DateTime(2024, 11, 1, 17, 31, 17, 847, DateTimeKind.Local).AddTicks(5805), new DateTime(2024, 11, 1, 17, 31, 17, 847, DateTimeKind.Local).AddTicks(5806) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("7c7616f2-3c2c-4c5f-9f40-470e78a847c7"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 1, 17, 31, 17, 847, DateTimeKind.Local).AddTicks(5815), new DateTime(2024, 11, 1, 17, 31, 17, 847, DateTimeKind.Local).AddTicks(5820), new DateTime(2024, 11, 1, 17, 31, 17, 847, DateTimeKind.Local).AddTicks(5820) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("82cfed84-d067-4d70-bef9-f08b0636a6b0"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 1, 17, 31, 17, 847, DateTimeKind.Local).AddTicks(5780), new DateTime(2024, 11, 1, 17, 31, 17, 847, DateTimeKind.Local).AddTicks(5784), new DateTime(2024, 11, 1, 17, 31, 17, 847, DateTimeKind.Local).AddTicks(5784) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("8c78bbac-4a5e-49ab-aafb-5a6c3f0c4b5d"),
                columns: new[] { "CloseDate", "CompanyId", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 6, 1, 17, 31, 17, 847, DateTimeKind.Local).AddTicks(5680), new Guid("ab9af358-61ce-453e-96eb-23eff22e0c3b"), new DateTime(2024, 11, 1, 17, 31, 17, 847, DateTimeKind.Local).AddTicks(5688), new DateTime(2024, 11, 1, 17, 31, 17, 847, DateTimeKind.Local).AddTicks(5689) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("9127e8f9-a91c-4dca-8008-3cb7a8dcfb22"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 1, 17, 31, 17, 847, DateTimeKind.Local).AddTicks(5565), new DateTime(2024, 11, 1, 17, 31, 17, 847, DateTimeKind.Local).AddTicks(5570), new DateTime(2024, 11, 1, 17, 31, 17, 847, DateTimeKind.Local).AddTicks(5570) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("a6b3ec6a-1d44-4b00-aa18-7d3f1a2e2f6d"),
                columns: new[] { "CloseDate", "CompanyId", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 1, 17, 31, 17, 847, DateTimeKind.Local).AddTicks(5629), new Guid("ab9af358-61ce-453e-96eb-23eff22e0c3b"), new DateTime(2024, 11, 1, 17, 31, 17, 847, DateTimeKind.Local).AddTicks(5633), new DateTime(2024, 11, 1, 17, 31, 17, 847, DateTimeKind.Local).AddTicks(5634) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("af7bcf34-a92d-4b2b-9937-3e6b7f4f2c6d"),
                columns: new[] { "CloseDate", "CompanyId", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 1, 17, 31, 17, 847, DateTimeKind.Local).AddTicks(5715), new Guid("ab9af358-61ce-453e-96eb-23eff22e0c3b"), new DateTime(2024, 11, 1, 17, 31, 17, 847, DateTimeKind.Local).AddTicks(5719), new DateTime(2024, 11, 1, 17, 31, 17, 847, DateTimeKind.Local).AddTicks(5720) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("b3f9d8c7-a1f4-4e3d-b7c2-7e3f9a4f1c5d"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 4, 1, 17, 31, 17, 847, DateTimeKind.Local).AddTicks(5731), new DateTime(2024, 11, 1, 17, 31, 17, 847, DateTimeKind.Local).AddTicks(5735), new DateTime(2024, 11, 1, 17, 31, 17, 847, DateTimeKind.Local).AddTicks(5736) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("c0a173ff-5be0-4bc9-877b-8d632eeb6da6"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 1, 17, 31, 17, 847, DateTimeKind.Local).AddTicks(5849), new DateTime(2024, 11, 1, 17, 31, 17, 847, DateTimeKind.Local).AddTicks(5853), new DateTime(2024, 11, 1, 17, 31, 17, 847, DateTimeKind.Local).AddTicks(5854) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("c3d3aa6b-ac70-4aa9-a8c2-88b3e0581d87"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 1, 17, 31, 17, 847, DateTimeKind.Local).AddTicks(5557), new DateTime(2024, 11, 1, 17, 31, 17, 847, DateTimeKind.Local).AddTicks(5561), new DateTime(2024, 11, 1, 17, 31, 17, 847, DateTimeKind.Local).AddTicks(5562) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("c3e8ff99-9f1a-4e4e-aaa4-4d1c8e5e3b5a"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 1, 17, 31, 17, 847, DateTimeKind.Local).AddTicks(5636), new DateTime(2024, 11, 1, 17, 31, 17, 847, DateTimeKind.Local).AddTicks(5640), new DateTime(2024, 11, 1, 17, 31, 17, 847, DateTimeKind.Local).AddTicks(5641) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("c8e2c78e-f68e-4c7e-a22f-5c81b4b5a8b0"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 1, 17, 31, 17, 847, DateTimeKind.Local).AddTicks(5794), new DateTime(2024, 11, 1, 17, 31, 17, 847, DateTimeKind.Local).AddTicks(5798), new DateTime(2024, 11, 1, 17, 31, 17, 847, DateTimeKind.Local).AddTicks(5799) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("ca01ec6a-8d39-4e00-ab98-6c3f9a2e0b1e"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 1, 17, 31, 17, 847, DateTimeKind.Local).AddTicks(5548), new DateTime(2024, 11, 1, 17, 31, 17, 847, DateTimeKind.Local).AddTicks(5554), new DateTime(2024, 11, 1, 17, 31, 17, 847, DateTimeKind.Local).AddTicks(5555) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("d0d69bba-c6c0-4e1e-b8a1-9b4b44e69b93"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 1, 17, 31, 17, 847, DateTimeKind.Local).AddTicks(5765), new DateTime(2024, 11, 1, 17, 31, 17, 847, DateTimeKind.Local).AddTicks(5770), new DateTime(2024, 11, 1, 17, 31, 17, 847, DateTimeKind.Local).AddTicks(5770) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("dd6b2a14-0f8b-41a8-ae5d-53de0a92d764"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 1, 17, 31, 17, 847, DateTimeKind.Local).AddTicks(5738), new DateTime(2024, 11, 1, 17, 31, 17, 847, DateTimeKind.Local).AddTicks(5743), new DateTime(2024, 11, 1, 17, 31, 17, 847, DateTimeKind.Local).AddTicks(5744) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("def969c3-e7ad-4f71-9907-2c0d594d3ecb"),
                columns: new[] { "CloseDate", "CompanyId", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 1, 17, 31, 17, 847, DateTimeKind.Local).AddTicks(5573), new Guid("ab9af358-61ce-453e-96eb-23eff22e0c3b"), new DateTime(2024, 11, 1, 17, 31, 17, 847, DateTimeKind.Local).AddTicks(5578), new DateTime(2024, 11, 1, 17, 31, 17, 847, DateTimeKind.Local).AddTicks(5578) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("df024b07-216f-41d7-b79b-25eb8f28762d"),
                columns: new[] { "CloseDate", "CompanyId", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 4, 1, 17, 31, 17, 847, DateTimeKind.Local).AddTicks(5786), new Guid("ab9af358-61ce-453e-96eb-23eff22e0c3b"), new DateTime(2024, 11, 1, 17, 31, 17, 847, DateTimeKind.Local).AddTicks(5791), new DateTime(2024, 11, 1, 17, 31, 17, 847, DateTimeKind.Local).AddTicks(5792) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("f07a1be4-bd6d-4c2d-9537-303e0c7a5dcf"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 1, 17, 31, 17, 847, DateTimeKind.Local).AddTicks(5746), new DateTime(2024, 11, 1, 17, 31, 17, 847, DateTimeKind.Local).AddTicks(5750), new DateTime(2024, 11, 1, 17, 31, 17, 847, DateTimeKind.Local).AddTicks(5750) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("fa01ec6a-8d39-4e00-ab98-6c3f9a2e0b1f"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 4, 1, 17, 31, 17, 847, DateTimeKind.Local).AddTicks(5622), new DateTime(2024, 11, 1, 17, 31, 17, 847, DateTimeKind.Local).AddTicks(5626), new DateTime(2024, 11, 1, 17, 31, 17, 847, DateTimeKind.Local).AddTicks(5627) });

            migrationBuilder.InsertData(
                table: "Jobs",
                columns: new[] { "Id", "CloseDate", "CommitmentTypeId", "CompanyId", "CreatedAt", "CreatedBy", "Description", "DistrictId", "EducationLevelRequirementId", "GenderRequirementId", "MaxAgeRequirement", "MinAgeRequirement", "ProvinceId", "Salary", "Status", "Title", "UpdatedAt", "UpdatedBy", "WorkArrangementId", "WorkExperienceRequirementId" },
                values: new object[,]
                {
                    { new Guid("8480b848-7ff8-402f-bbe7-dc23dd593a60"), new DateTime(2025, 1, 1, 17, 31, 17, 847, DateTimeKind.Local).AddTicks(5607), new Guid("3fbef738-ed16-4778-8463-8390444841de"), new Guid("ec7d72b6-e9f4-4c85-bc12-c2db31d5efa7"), new DateTime(2024, 11, 1, 17, 31, 17, 847, DateTimeKind.Local).AddTicks(5611), null, "Build and maintain client relationships.", 30, new Guid("ebb6a034-ce37-41a4-b1f6-c70f1698c4f2"), new Guid("7b5f69cb-5996-4a57-b9c6-9fee2a791bf6"), 35, 23, 5, 55000.0, 1, "Sales Executive", new DateTime(2024, 11, 1, 17, 31, 17, 847, DateTimeKind.Local).AddTicks(5611), null, new Guid("376764fa-28ec-4a08-80e3-a6ab407e8601"), new Guid("cc4121b2-72c2-4226-ad12-24e722b50cc2") },
                    { new Guid("b09a943a-ca96-4d14-be00-b68e517a17e7"), new DateTime(2025, 2, 1, 17, 31, 17, 847, DateTimeKind.Local).AddTicks(5600), new Guid("44b668b2-09ee-499e-af95-73598f9153a2"), new Guid("7f9b407b-80e0-4f0c-a301-5a8bbf813b05"), new DateTime(2024, 11, 1, 17, 31, 17, 847, DateTimeKind.Local).AddTicks(5604), null, "Manage and maintain network infrastructure.", 21, new Guid("bc4ecf1e-8841-47f2-86ec-b0c523f03da1"), new Guid("79685cdb-be26-49cc-b7f9-1fb51686f5ba"), 40, 25, 4, 85000.0, 1, "Network Engineer", new DateTime(2024, 11, 1, 17, 31, 17, 847, DateTimeKind.Local).AddTicks(5605), null, new Guid("04a9de34-0869-41b2-87a8-63c20c4ba22a"), new Guid("bf38a1b9-dee3-455a-87c1-4e034fe806f7") }
                });

            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "Id", "AccountId", "Address", "CreatedAt", "CreatedBy", "Description", "DistrictId", "EmailContact", "EmployeeCount", "Industry", "Logo", "Name", "PhoneContact", "ProvinceId", "Slug", "UpdatedAt", "UpdatedBy", "Website" },
                values: new object[] { new Guid("ab9af358-61ce-453e-96eb-23eff22e0c3b"), new Guid("4b28785a-e6d8-4bde-bc61-4fcd3c7edcb9"), "45688 London", null, null, "An Inc. is a an incident company.", 0, "info@AnRe.com", 300, "IT", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRsowdkWEAhFe0idqRamO_CAvGutpD1CHKpcA&s", "An Inc.", "98765432112", 0, "an-pro-ga", null, null, "www.Anrp.com" });

            migrationBuilder.InsertData(
                table: "Jobs",
                columns: new[] { "Id", "CloseDate", "CommitmentTypeId", "CompanyId", "CreatedAt", "CreatedBy", "Description", "DistrictId", "EducationLevelRequirementId", "GenderRequirementId", "MaxAgeRequirement", "MinAgeRequirement", "ProvinceId", "Salary", "Status", "Title", "UpdatedAt", "UpdatedBy", "WorkArrangementId", "WorkExperienceRequirementId" },
                values: new object[] { new Guid("6bf113f5-7f15-4973-aa96-9e0b85072b21"), new DateTime(2025, 2, 1, 17, 31, 17, 847, DateTimeKind.Local).AddTicks(5615), new Guid("5d06c3b1-2bd1-4c68-96b4-f4cd8c899dff"), new Guid("ab9af358-61ce-453e-96eb-23eff22e0c3b"), new DateTime(2024, 11, 1, 17, 31, 17, 847, DateTimeKind.Local).AddTicks(5619), null, "Provide technical support to clients.", 18, new Guid("a3fb036a-04fc-4590-b87d-6ed32e2ec692"), new Guid("12497687-64b8-4d8e-814a-b7d1d33d3aab"), 33, 22, 6, 45000.0, 1, "Customer Support Specialist", new DateTime(2024, 11, 1, 17, 31, 17, 847, DateTimeKind.Local).AddTicks(5619), null, new Guid("c199da74-c2fb-4381-b093-cf2f1e3e8f06"), new Guid("fbce1042-bce0-47a3-92cc-54e3b86eb570") });

            migrationBuilder.CreateIndex(
                name: "IX_Users_AccountId",
                table: "Users",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_Companies_AccountId",
                table: "Companies",
                column: "AccountId");

            migrationBuilder.AddForeignKey(
                name: "FK_Companies_Accounts_AccountId",
                table: "Companies",
                column: "AccountId",
                principalTable: "Accounts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Accounts_AccountId",
                table: "Users",
                column: "AccountId",
                principalTable: "Accounts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
