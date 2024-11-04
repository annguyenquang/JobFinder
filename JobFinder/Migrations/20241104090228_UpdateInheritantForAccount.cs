using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace JobFinder.Migrations
{
    /// <inheritdoc />
    public partial class UpdateInheritantForAccount : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("77aed6d9-7e67-4fce-a8ed-09e71abc6f76"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("c0c6b157-ca77-490d-8afa-4b5af1409737"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("faf91f9e-a73f-4b3c-bef0-e73806155bf0"));

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("17e0cd7e-5887-44e2-bf2a-cd1b1f631f76"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 4, 4, 16, 2, 28, 149, DateTimeKind.Local).AddTicks(3163), new DateTime(2024, 11, 4, 16, 2, 28, 149, DateTimeKind.Local).AddTicks(3167), new DateTime(2024, 11, 4, 16, 2, 28, 149, DateTimeKind.Local).AddTicks(3168) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("1b9a3a57-5a94-4cc3-9af1-0380d074dd65"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 4, 16, 2, 28, 149, DateTimeKind.Local).AddTicks(3185), new DateTime(2024, 11, 4, 16, 2, 28, 149, DateTimeKind.Local).AddTicks(3189), new DateTime(2024, 11, 4, 16, 2, 28, 149, DateTimeKind.Local).AddTicks(3190) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("1c8a7d6b-2d7f-4c2b-a9c5-8b3e9f6f2d8b"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 4, 16, 2, 28, 149, DateTimeKind.Local).AddTicks(3134), new DateTime(2024, 11, 4, 16, 2, 28, 149, DateTimeKind.Local).AddTicks(3138), new DateTime(2024, 11, 4, 16, 2, 28, 149, DateTimeKind.Local).AddTicks(3139) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("1d41e60a-ffb5-4039-b4b6-3e25e68d0f2c"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 4, 16, 2, 28, 149, DateTimeKind.Local).AddTicks(3170), new DateTime(2024, 11, 4, 16, 2, 28, 149, DateTimeKind.Local).AddTicks(3175), new DateTime(2024, 11, 4, 16, 2, 28, 149, DateTimeKind.Local).AddTicks(3175) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("3d6b9f9b-6f2d-4b4a-b4c7-2c8b5f4e1b4e"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 4, 16, 2, 28, 149, DateTimeKind.Local).AddTicks(3110), new DateTime(2024, 11, 4, 16, 2, 28, 149, DateTimeKind.Local).AddTicks(3114), new DateTime(2024, 11, 4, 16, 2, 28, 149, DateTimeKind.Local).AddTicks(3115) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("3d8db2d5-5020-497e-917b-500a1f663c60"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 4, 4, 16, 2, 28, 149, DateTimeKind.Local).AddTicks(3222), new DateTime(2024, 11, 4, 16, 2, 28, 149, DateTimeKind.Local).AddTicks(3227), new DateTime(2024, 11, 4, 16, 2, 28, 149, DateTimeKind.Local).AddTicks(3227) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("4b3dff90-4d8a-4cbb-a3e8-6c7e5a4d3c4a"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 4, 16, 2, 28, 149, DateTimeKind.Local).AddTicks(3118), new DateTime(2024, 11, 4, 16, 2, 28, 149, DateTimeKind.Local).AddTicks(3122), new DateTime(2024, 11, 4, 16, 2, 28, 149, DateTimeKind.Local).AddTicks(3122) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("4c695d62-51f0-4070-a625-c030208dffb7"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 4, 16, 2, 28, 149, DateTimeKind.Local).AddTicks(2949), new DateTime(2024, 11, 4, 16, 2, 28, 149, DateTimeKind.Local).AddTicks(2974), new DateTime(2024, 11, 4, 16, 2, 28, 149, DateTimeKind.Local).AddTicks(2975) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("5540bd1d-b228-410e-8fbf-0842aeda7cb1"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 4, 16, 2, 28, 149, DateTimeKind.Local).AddTicks(2979), new DateTime(2024, 11, 4, 16, 2, 28, 149, DateTimeKind.Local).AddTicks(2984), new DateTime(2024, 11, 4, 16, 2, 28, 149, DateTimeKind.Local).AddTicks(2985) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("571827fa-78f4-4192-ad3b-06bb014309c2"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 4, 16, 2, 28, 149, DateTimeKind.Local).AddTicks(2987), new DateTime(2024, 11, 4, 16, 2, 28, 149, DateTimeKind.Local).AddTicks(2992), new DateTime(2024, 11, 4, 16, 2, 28, 149, DateTimeKind.Local).AddTicks(2993) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("5f9c2d8f-a7f2-45a4-8e4a-90b8f7a03b3e"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 4, 16, 2, 28, 149, DateTimeKind.Local).AddTicks(3071), new DateTime(2024, 11, 4, 16, 2, 28, 149, DateTimeKind.Local).AddTicks(3075), new DateTime(2024, 11, 4, 16, 2, 28, 149, DateTimeKind.Local).AddTicks(3076) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("6f0e2a6f-54d7-493c-bcb4-8f5eeb2fba1b"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 4, 16, 2, 28, 149, DateTimeKind.Local).AddTicks(3215), new DateTime(2024, 11, 4, 16, 2, 28, 149, DateTimeKind.Local).AddTicks(3220), new DateTime(2024, 11, 4, 16, 2, 28, 149, DateTimeKind.Local).AddTicks(3220) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("7c7616f2-3c2c-4c5f-9f40-470e78a847c7"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 4, 16, 2, 28, 149, DateTimeKind.Local).AddTicks(3229), new DateTime(2024, 11, 4, 16, 2, 28, 149, DateTimeKind.Local).AddTicks(3233), new DateTime(2024, 11, 4, 16, 2, 28, 149, DateTimeKind.Local).AddTicks(3234) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("82cfed84-d067-4d70-bef9-f08b0636a6b0"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 4, 16, 2, 28, 149, DateTimeKind.Local).AddTicks(3193), new DateTime(2024, 11, 4, 16, 2, 28, 149, DateTimeKind.Local).AddTicks(3197), new DateTime(2024, 11, 4, 16, 2, 28, 149, DateTimeKind.Local).AddTicks(3198) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("8c78bbac-4a5e-49ab-aafb-5a6c3f0c4b5d"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 6, 4, 16, 2, 28, 149, DateTimeKind.Local).AddTicks(3102), new DateTime(2024, 11, 4, 16, 2, 28, 149, DateTimeKind.Local).AddTicks(3107), new DateTime(2024, 11, 4, 16, 2, 28, 149, DateTimeKind.Local).AddTicks(3107) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("9127e8f9-a91c-4dca-8008-3cb7a8dcfb22"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 4, 16, 2, 28, 149, DateTimeKind.Local).AddTicks(3010), new DateTime(2024, 11, 4, 16, 2, 28, 149, DateTimeKind.Local).AddTicks(3016), new DateTime(2024, 11, 4, 16, 2, 28, 149, DateTimeKind.Local).AddTicks(3016) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("a6b3ec6a-1d44-4b00-aa18-7d3f1a2e2f6d"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 4, 16, 2, 28, 149, DateTimeKind.Local).AddTicks(3057), new DateTime(2024, 11, 4, 16, 2, 28, 149, DateTimeKind.Local).AddTicks(3061), new DateTime(2024, 11, 4, 16, 2, 28, 149, DateTimeKind.Local).AddTicks(3061) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("af7bcf34-a92d-4b2b-9937-3e6b7f4f2c6d"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 4, 16, 2, 28, 149, DateTimeKind.Local).AddTicks(3126), new DateTime(2024, 11, 4, 16, 2, 28, 149, DateTimeKind.Local).AddTicks(3131), new DateTime(2024, 11, 4, 16, 2, 28, 149, DateTimeKind.Local).AddTicks(3132) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("b3f9d8c7-a1f4-4e3d-b7c2-7e3f9a4f1c5d"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 4, 4, 16, 2, 28, 149, DateTimeKind.Local).AddTicks(3141), new DateTime(2024, 11, 4, 16, 2, 28, 149, DateTimeKind.Local).AddTicks(3146), new DateTime(2024, 11, 4, 16, 2, 28, 149, DateTimeKind.Local).AddTicks(3147) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("c0a173ff-5be0-4bc9-877b-8d632eeb6da6"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 4, 16, 2, 28, 149, DateTimeKind.Local).AddTicks(3236), new DateTime(2024, 11, 4, 16, 2, 28, 149, DateTimeKind.Local).AddTicks(3240), new DateTime(2024, 11, 4, 16, 2, 28, 149, DateTimeKind.Local).AddTicks(3241) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("c3d3aa6b-ac70-4aa9-a8c2-88b3e0581d87"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 4, 16, 2, 28, 149, DateTimeKind.Local).AddTicks(3002), new DateTime(2024, 11, 4, 16, 2, 28, 149, DateTimeKind.Local).AddTicks(3006), new DateTime(2024, 11, 4, 16, 2, 28, 149, DateTimeKind.Local).AddTicks(3007) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("c3e8ff99-9f1a-4e4e-aaa4-4d1c8e5e3b5a"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 4, 16, 2, 28, 149, DateTimeKind.Local).AddTicks(3063), new DateTime(2024, 11, 4, 16, 2, 28, 149, DateTimeKind.Local).AddTicks(3068), new DateTime(2024, 11, 4, 16, 2, 28, 149, DateTimeKind.Local).AddTicks(3069) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("c8e2c78e-f68e-4c7e-a22f-5c81b4b5a8b0"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 4, 16, 2, 28, 149, DateTimeKind.Local).AddTicks(3208), new DateTime(2024, 11, 4, 16, 2, 28, 149, DateTimeKind.Local).AddTicks(3212), new DateTime(2024, 11, 4, 16, 2, 28, 149, DateTimeKind.Local).AddTicks(3213) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("ca01ec6a-8d39-4e00-ab98-6c3f9a2e0b1e"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 4, 16, 2, 28, 149, DateTimeKind.Local).AddTicks(2995), new DateTime(2024, 11, 4, 16, 2, 28, 149, DateTimeKind.Local).AddTicks(2999), new DateTime(2024, 11, 4, 16, 2, 28, 149, DateTimeKind.Local).AddTicks(3000) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("d0d69bba-c6c0-4e1e-b8a1-9b4b44e69b93"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 4, 16, 2, 28, 149, DateTimeKind.Local).AddTicks(3177), new DateTime(2024, 11, 4, 16, 2, 28, 149, DateTimeKind.Local).AddTicks(3182), new DateTime(2024, 11, 4, 16, 2, 28, 149, DateTimeKind.Local).AddTicks(3183) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("dd6b2a14-0f8b-41a8-ae5d-53de0a92d764"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 4, 16, 2, 28, 149, DateTimeKind.Local).AddTicks(3149), new DateTime(2024, 11, 4, 16, 2, 28, 149, DateTimeKind.Local).AddTicks(3153), new DateTime(2024, 11, 4, 16, 2, 28, 149, DateTimeKind.Local).AddTicks(3154) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("def969c3-e7ad-4f71-9907-2c0d594d3ecb"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 4, 16, 2, 28, 149, DateTimeKind.Local).AddTicks(3019), new DateTime(2024, 11, 4, 16, 2, 28, 149, DateTimeKind.Local).AddTicks(3023), new DateTime(2024, 11, 4, 16, 2, 28, 149, DateTimeKind.Local).AddTicks(3024) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("df024b07-216f-41d7-b79b-25eb8f28762d"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 4, 4, 16, 2, 28, 149, DateTimeKind.Local).AddTicks(3200), new DateTime(2024, 11, 4, 16, 2, 28, 149, DateTimeKind.Local).AddTicks(3204), new DateTime(2024, 11, 4, 16, 2, 28, 149, DateTimeKind.Local).AddTicks(3205) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("f07a1be4-bd6d-4c2d-9537-303e0c7a5dcf"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 4, 16, 2, 28, 149, DateTimeKind.Local).AddTicks(3156), new DateTime(2024, 11, 4, 16, 2, 28, 149, DateTimeKind.Local).AddTicks(3160), new DateTime(2024, 11, 4, 16, 2, 28, 149, DateTimeKind.Local).AddTicks(3161) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("fa01ec6a-8d39-4e00-ab98-6c3f9a2e0b1f"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 4, 4, 16, 2, 28, 149, DateTimeKind.Local).AddTicks(3049), new DateTime(2024, 11, 4, 16, 2, 28, 149, DateTimeKind.Local).AddTicks(3054), new DateTime(2024, 11, 4, 16, 2, 28, 149, DateTimeKind.Local).AddTicks(3054) });

            migrationBuilder.InsertData(
                table: "Jobs",
                columns: new[] { "Id", "CloseDate", "CommitmentTypeId", "CompanyId", "CreatedAt", "CreatedBy", "Description", "DistrictId", "EducationLevelRequirementId", "GenderRequirementId", "MaxAgeRequirement", "MinAgeRequirement", "ProvinceId", "Salary", "Status", "Title", "UpdatedAt", "UpdatedBy", "WorkArrangementId", "WorkExperienceRequirementId" },
                values: new object[,]
                {
                    { new Guid("22aadfc7-6022-4f15-ac49-13fa33f8afbe"), new DateTime(2025, 2, 4, 16, 2, 28, 149, DateTimeKind.Local).AddTicks(3026), new Guid("44b668b2-09ee-499e-af95-73598f9153a2"), new Guid("7f9b407b-80e0-4f0c-a301-5a8bbf813b05"), new DateTime(2024, 11, 4, 16, 2, 28, 149, DateTimeKind.Local).AddTicks(3030), null, "Manage and maintain network infrastructure.", 21, new Guid("bc4ecf1e-8841-47f2-86ec-b0c523f03da1"), new Guid("79685cdb-be26-49cc-b7f9-1fb51686f5ba"), 40, 25, 4, 85000.0, 1, "Network Engineer", new DateTime(2024, 11, 4, 16, 2, 28, 149, DateTimeKind.Local).AddTicks(3031), null, new Guid("04a9de34-0869-41b2-87a8-63c20c4ba22a"), new Guid("bf38a1b9-dee3-455a-87c1-4e034fe806f7") },
                    { new Guid("8845c741-6b0f-4f95-b179-3d007ba28a41"), new DateTime(2025, 1, 4, 16, 2, 28, 149, DateTimeKind.Local).AddTicks(3033), new Guid("3fbef738-ed16-4778-8463-8390444841de"), new Guid("ec7d72b6-e9f4-4c85-bc12-c2db31d5efa7"), new DateTime(2024, 11, 4, 16, 2, 28, 149, DateTimeKind.Local).AddTicks(3037), null, "Build and maintain client relationships.", 30, new Guid("ebb6a034-ce37-41a4-b1f6-c70f1698c4f2"), new Guid("7b5f69cb-5996-4a57-b9c6-9fee2a791bf6"), 35, 23, 5, 55000.0, 1, "Sales Executive", new DateTime(2024, 11, 4, 16, 2, 28, 149, DateTimeKind.Local).AddTicks(3038), null, new Guid("376764fa-28ec-4a08-80e3-a6ab407e8601"), new Guid("cc4121b2-72c2-4226-ad12-24e722b50cc2") },
                    { new Guid("8f31d3d0-dc53-45d6-bccd-fd2d15dacb77"), new DateTime(2025, 2, 4, 16, 2, 28, 149, DateTimeKind.Local).AddTicks(3042), new Guid("5d06c3b1-2bd1-4c68-96b4-f4cd8c899dff"), new Guid("ec6aba4a-1b55-412a-a2e7-9ec8b9f16662"), new DateTime(2024, 11, 4, 16, 2, 28, 149, DateTimeKind.Local).AddTicks(3046), null, "Provide technical support to clients.", 18, new Guid("a3fb036a-04fc-4590-b87d-6ed32e2ec692"), new Guid("12497687-64b8-4d8e-814a-b7d1d33d3aab"), 33, 22, 6, 45000.0, 1, "Customer Support Specialist", new DateTime(2024, 11, 4, 16, 2, 28, 149, DateTimeKind.Local).AddTicks(3046), null, new Guid("c199da74-c2fb-4381-b093-cf2f1e3e8f06"), new Guid("fbce1042-bce0-47a3-92cc-54e3b86eb570") }
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

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("17e0cd7e-5887-44e2-bf2a-cd1b1f631f76"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 4, 4, 15, 44, 56, 443, DateTimeKind.Local).AddTicks(2225), new DateTime(2024, 11, 4, 15, 44, 56, 443, DateTimeKind.Local).AddTicks(2229), new DateTime(2024, 11, 4, 15, 44, 56, 443, DateTimeKind.Local).AddTicks(2229) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("1b9a3a57-5a94-4cc3-9af1-0380d074dd65"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 4, 15, 44, 56, 443, DateTimeKind.Local).AddTicks(2248), new DateTime(2024, 11, 4, 15, 44, 56, 443, DateTimeKind.Local).AddTicks(2253), new DateTime(2024, 11, 4, 15, 44, 56, 443, DateTimeKind.Local).AddTicks(2254) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("1c8a7d6b-2d7f-4c2b-a9c5-8b3e9f6f2d8b"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 4, 15, 44, 56, 443, DateTimeKind.Local).AddTicks(2193), new DateTime(2024, 11, 4, 15, 44, 56, 443, DateTimeKind.Local).AddTicks(2199), new DateTime(2024, 11, 4, 15, 44, 56, 443, DateTimeKind.Local).AddTicks(2199) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("1d41e60a-ffb5-4039-b4b6-3e25e68d0f2c"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 4, 15, 44, 56, 443, DateTimeKind.Local).AddTicks(2231), new DateTime(2024, 11, 4, 15, 44, 56, 443, DateTimeKind.Local).AddTicks(2238), new DateTime(2024, 11, 4, 15, 44, 56, 443, DateTimeKind.Local).AddTicks(2239) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("3d6b9f9b-6f2d-4b4a-b4c7-2c8b5f4e1b4e"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 4, 15, 44, 56, 443, DateTimeKind.Local).AddTicks(2170), new DateTime(2024, 11, 4, 15, 44, 56, 443, DateTimeKind.Local).AddTicks(2174), new DateTime(2024, 11, 4, 15, 44, 56, 443, DateTimeKind.Local).AddTicks(2175) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("3d8db2d5-5020-497e-917b-500a1f663c60"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 4, 4, 15, 44, 56, 443, DateTimeKind.Local).AddTicks(2284), new DateTime(2024, 11, 4, 15, 44, 56, 443, DateTimeKind.Local).AddTicks(2288), new DateTime(2024, 11, 4, 15, 44, 56, 443, DateTimeKind.Local).AddTicks(2289) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("4b3dff90-4d8a-4cbb-a3e8-6c7e5a4d3c4a"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 4, 15, 44, 56, 443, DateTimeKind.Local).AddTicks(2177), new DateTime(2024, 11, 4, 15, 44, 56, 443, DateTimeKind.Local).AddTicks(2181), new DateTime(2024, 11, 4, 15, 44, 56, 443, DateTimeKind.Local).AddTicks(2182) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("4c695d62-51f0-4070-a625-c030208dffb7"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 4, 15, 44, 56, 443, DateTimeKind.Local).AddTicks(1972), new DateTime(2024, 11, 4, 15, 44, 56, 443, DateTimeKind.Local).AddTicks(1995), new DateTime(2024, 11, 4, 15, 44, 56, 443, DateTimeKind.Local).AddTicks(1997) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("5540bd1d-b228-410e-8fbf-0842aeda7cb1"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 4, 15, 44, 56, 443, DateTimeKind.Local).AddTicks(2000), new DateTime(2024, 11, 4, 15, 44, 56, 443, DateTimeKind.Local).AddTicks(2005), new DateTime(2024, 11, 4, 15, 44, 56, 443, DateTimeKind.Local).AddTicks(2006) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("571827fa-78f4-4192-ad3b-06bb014309c2"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 4, 15, 44, 56, 443, DateTimeKind.Local).AddTicks(2009), new DateTime(2024, 11, 4, 15, 44, 56, 443, DateTimeKind.Local).AddTicks(2013), new DateTime(2024, 11, 4, 15, 44, 56, 443, DateTimeKind.Local).AddTicks(2014) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("5f9c2d8f-a7f2-45a4-8e4a-90b8f7a03b3e"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 4, 15, 44, 56, 443, DateTimeKind.Local).AddTicks(2153), new DateTime(2024, 11, 4, 15, 44, 56, 443, DateTimeKind.Local).AddTicks(2160), new DateTime(2024, 11, 4, 15, 44, 56, 443, DateTimeKind.Local).AddTicks(2160) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("6f0e2a6f-54d7-493c-bcb4-8f5eeb2fba1b"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 4, 15, 44, 56, 443, DateTimeKind.Local).AddTicks(2277), new DateTime(2024, 11, 4, 15, 44, 56, 443, DateTimeKind.Local).AddTicks(2281), new DateTime(2024, 11, 4, 15, 44, 56, 443, DateTimeKind.Local).AddTicks(2282) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("7c7616f2-3c2c-4c5f-9f40-470e78a847c7"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 4, 15, 44, 56, 443, DateTimeKind.Local).AddTicks(2321), new DateTime(2024, 11, 4, 15, 44, 56, 443, DateTimeKind.Local).AddTicks(2325), new DateTime(2024, 11, 4, 15, 44, 56, 443, DateTimeKind.Local).AddTicks(2326) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("82cfed84-d067-4d70-bef9-f08b0636a6b0"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 4, 15, 44, 56, 443, DateTimeKind.Local).AddTicks(2256), new DateTime(2024, 11, 4, 15, 44, 56, 443, DateTimeKind.Local).AddTicks(2260), new DateTime(2024, 11, 4, 15, 44, 56, 443, DateTimeKind.Local).AddTicks(2261) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("8c78bbac-4a5e-49ab-aafb-5a6c3f0c4b5d"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 6, 4, 15, 44, 56, 443, DateTimeKind.Local).AddTicks(2162), new DateTime(2024, 11, 4, 15, 44, 56, 443, DateTimeKind.Local).AddTicks(2167), new DateTime(2024, 11, 4, 15, 44, 56, 443, DateTimeKind.Local).AddTicks(2167) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("9127e8f9-a91c-4dca-8008-3cb7a8dcfb22"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 4, 15, 44, 56, 443, DateTimeKind.Local).AddTicks(2031), new DateTime(2024, 11, 4, 15, 44, 56, 443, DateTimeKind.Local).AddTicks(2036), new DateTime(2024, 11, 4, 15, 44, 56, 443, DateTimeKind.Local).AddTicks(2036) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("a6b3ec6a-1d44-4b00-aa18-7d3f1a2e2f6d"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 4, 15, 44, 56, 443, DateTimeKind.Local).AddTicks(2137), new DateTime(2024, 11, 4, 15, 44, 56, 443, DateTimeKind.Local).AddTicks(2142), new DateTime(2024, 11, 4, 15, 44, 56, 443, DateTimeKind.Local).AddTicks(2143) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("af7bcf34-a92d-4b2b-9937-3e6b7f4f2c6d"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 4, 15, 44, 56, 443, DateTimeKind.Local).AddTicks(2186), new DateTime(2024, 11, 4, 15, 44, 56, 443, DateTimeKind.Local).AddTicks(2190), new DateTime(2024, 11, 4, 15, 44, 56, 443, DateTimeKind.Local).AddTicks(2191) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("b3f9d8c7-a1f4-4e3d-b7c2-7e3f9a4f1c5d"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 4, 4, 15, 44, 56, 443, DateTimeKind.Local).AddTicks(2202), new DateTime(2024, 11, 4, 15, 44, 56, 443, DateTimeKind.Local).AddTicks(2206), new DateTime(2024, 11, 4, 15, 44, 56, 443, DateTimeKind.Local).AddTicks(2207) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("c0a173ff-5be0-4bc9-877b-8d632eeb6da6"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 4, 15, 44, 56, 443, DateTimeKind.Local).AddTicks(2328), new DateTime(2024, 11, 4, 15, 44, 56, 443, DateTimeKind.Local).AddTicks(2333), new DateTime(2024, 11, 4, 15, 44, 56, 443, DateTimeKind.Local).AddTicks(2333) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("c3d3aa6b-ac70-4aa9-a8c2-88b3e0581d87"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 4, 15, 44, 56, 443, DateTimeKind.Local).AddTicks(2023), new DateTime(2024, 11, 4, 15, 44, 56, 443, DateTimeKind.Local).AddTicks(2027), new DateTime(2024, 11, 4, 15, 44, 56, 443, DateTimeKind.Local).AddTicks(2028) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("c3e8ff99-9f1a-4e4e-aaa4-4d1c8e5e3b5a"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 4, 15, 44, 56, 443, DateTimeKind.Local).AddTicks(2146), new DateTime(2024, 11, 4, 15, 44, 56, 443, DateTimeKind.Local).AddTicks(2150), new DateTime(2024, 11, 4, 15, 44, 56, 443, DateTimeKind.Local).AddTicks(2151) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("c8e2c78e-f68e-4c7e-a22f-5c81b4b5a8b0"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 4, 15, 44, 56, 443, DateTimeKind.Local).AddTicks(2270), new DateTime(2024, 11, 4, 15, 44, 56, 443, DateTimeKind.Local).AddTicks(2274), new DateTime(2024, 11, 4, 15, 44, 56, 443, DateTimeKind.Local).AddTicks(2275) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("ca01ec6a-8d39-4e00-ab98-6c3f9a2e0b1e"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 4, 15, 44, 56, 443, DateTimeKind.Local).AddTicks(2016), new DateTime(2024, 11, 4, 15, 44, 56, 443, DateTimeKind.Local).AddTicks(2020), new DateTime(2024, 11, 4, 15, 44, 56, 443, DateTimeKind.Local).AddTicks(2021) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("d0d69bba-c6c0-4e1e-b8a1-9b4b44e69b93"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 4, 15, 44, 56, 443, DateTimeKind.Local).AddTicks(2241), new DateTime(2024, 11, 4, 15, 44, 56, 443, DateTimeKind.Local).AddTicks(2245), new DateTime(2024, 11, 4, 15, 44, 56, 443, DateTimeKind.Local).AddTicks(2246) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("dd6b2a14-0f8b-41a8-ae5d-53de0a92d764"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 4, 15, 44, 56, 443, DateTimeKind.Local).AddTicks(2209), new DateTime(2024, 11, 4, 15, 44, 56, 443, DateTimeKind.Local).AddTicks(2214), new DateTime(2024, 11, 4, 15, 44, 56, 443, DateTimeKind.Local).AddTicks(2215) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("def969c3-e7ad-4f71-9907-2c0d594d3ecb"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 4, 15, 44, 56, 443, DateTimeKind.Local).AddTicks(2038), new DateTime(2024, 11, 4, 15, 44, 56, 443, DateTimeKind.Local).AddTicks(2044), new DateTime(2024, 11, 4, 15, 44, 56, 443, DateTimeKind.Local).AddTicks(2044) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("df024b07-216f-41d7-b79b-25eb8f28762d"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 4, 4, 15, 44, 56, 443, DateTimeKind.Local).AddTicks(2263), new DateTime(2024, 11, 4, 15, 44, 56, 443, DateTimeKind.Local).AddTicks(2267), new DateTime(2024, 11, 4, 15, 44, 56, 443, DateTimeKind.Local).AddTicks(2268) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("f07a1be4-bd6d-4c2d-9537-303e0c7a5dcf"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 4, 15, 44, 56, 443, DateTimeKind.Local).AddTicks(2217), new DateTime(2024, 11, 4, 15, 44, 56, 443, DateTimeKind.Local).AddTicks(2221), new DateTime(2024, 11, 4, 15, 44, 56, 443, DateTimeKind.Local).AddTicks(2222) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("fa01ec6a-8d39-4e00-ab98-6c3f9a2e0b1f"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 4, 4, 15, 44, 56, 443, DateTimeKind.Local).AddTicks(2094), new DateTime(2024, 11, 4, 15, 44, 56, 443, DateTimeKind.Local).AddTicks(2098), new DateTime(2024, 11, 4, 15, 44, 56, 443, DateTimeKind.Local).AddTicks(2099) });

            migrationBuilder.InsertData(
                table: "Jobs",
                columns: new[] { "Id", "CloseDate", "CommitmentTypeId", "CompanyId", "CreatedAt", "CreatedBy", "Description", "DistrictId", "EducationLevelRequirementId", "GenderRequirementId", "MaxAgeRequirement", "MinAgeRequirement", "ProvinceId", "Salary", "Status", "Title", "UpdatedAt", "UpdatedBy", "WorkArrangementId", "WorkExperienceRequirementId" },
                values: new object[,]
                {
                    { new Guid("77aed6d9-7e67-4fce-a8ed-09e71abc6f76"), new DateTime(2025, 2, 4, 15, 44, 56, 443, DateTimeKind.Local).AddTicks(2086), new Guid("5d06c3b1-2bd1-4c68-96b4-f4cd8c899dff"), new Guid("ec6aba4a-1b55-412a-a2e7-9ec8b9f16662"), new DateTime(2024, 11, 4, 15, 44, 56, 443, DateTimeKind.Local).AddTicks(2090), null, "Provide technical support to clients.", 18, new Guid("a3fb036a-04fc-4590-b87d-6ed32e2ec692"), new Guid("12497687-64b8-4d8e-814a-b7d1d33d3aab"), 33, 22, 6, 45000.0, 1, "Customer Support Specialist", new DateTime(2024, 11, 4, 15, 44, 56, 443, DateTimeKind.Local).AddTicks(2091), null, new Guid("c199da74-c2fb-4381-b093-cf2f1e3e8f06"), new Guid("fbce1042-bce0-47a3-92cc-54e3b86eb570") },
                    { new Guid("c0c6b157-ca77-490d-8afa-4b5af1409737"), new DateTime(2025, 2, 4, 15, 44, 56, 443, DateTimeKind.Local).AddTicks(2068), new Guid("44b668b2-09ee-499e-af95-73598f9153a2"), new Guid("7f9b407b-80e0-4f0c-a301-5a8bbf813b05"), new DateTime(2024, 11, 4, 15, 44, 56, 443, DateTimeKind.Local).AddTicks(2073), null, "Manage and maintain network infrastructure.", 21, new Guid("bc4ecf1e-8841-47f2-86ec-b0c523f03da1"), new Guid("79685cdb-be26-49cc-b7f9-1fb51686f5ba"), 40, 25, 4, 85000.0, 1, "Network Engineer", new DateTime(2024, 11, 4, 15, 44, 56, 443, DateTimeKind.Local).AddTicks(2073), null, new Guid("04a9de34-0869-41b2-87a8-63c20c4ba22a"), new Guid("bf38a1b9-dee3-455a-87c1-4e034fe806f7") },
                    { new Guid("faf91f9e-a73f-4b3c-bef0-e73806155bf0"), new DateTime(2025, 1, 4, 15, 44, 56, 443, DateTimeKind.Local).AddTicks(2076), new Guid("3fbef738-ed16-4778-8463-8390444841de"), new Guid("ec7d72b6-e9f4-4c85-bc12-c2db31d5efa7"), new DateTime(2024, 11, 4, 15, 44, 56, 443, DateTimeKind.Local).AddTicks(2082), null, "Build and maintain client relationships.", 30, new Guid("ebb6a034-ce37-41a4-b1f6-c70f1698c4f2"), new Guid("7b5f69cb-5996-4a57-b9c6-9fee2a791bf6"), 35, 23, 5, 55000.0, 1, "Sales Executive", new DateTime(2024, 11, 4, 15, 44, 56, 443, DateTimeKind.Local).AddTicks(2082), null, new Guid("376764fa-28ec-4a08-80e3-a6ab407e8601"), new Guid("cc4121b2-72c2-4226-ad12-24e722b50cc2") }
                });
        }
    }
}
