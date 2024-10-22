using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace JobFinder.Migrations
{
    /// <inheritdoc />
    public partial class AddSeedingData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("47b55518-e18d-4caa-bf26-24e527a036e5"));

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "Email", "Password", "Phone", "UpdatedAt", "UpdatedBy", "Username" },
                values: new object[,]
                {
                    { new Guid("0867b588-51f2-4c25-bffe-5e1d8e9646de"), null, null, "", "account1", "0823456789", null, null, "account1" },
                    { new Guid("156013c8-2152-4c23-bb85-31c88f31be2d"), null, null, "", "admin", "113", null, null, "admin" },
                    { new Guid("69258856-6fc1-44d2-843c-f826659d5393"), null, null, "", "account0", "0123456789", null, null, "account0" },
                    { new Guid("82a3fb5b-641e-4c7c-bd09-dfb00747f150"), null, null, "", "account2", "0183456789", null, null, "account2" },
                    { new Guid("b218139a-7b7a-4394-bc57-e41be3520353"), null, null, "", "account3", "0128456789", null, null, "account3" },
                    { new Guid("b9ba5465-fb70-4f23-86d6-df702778a320"), null, null, "", "account4", "0123856789", null, null, "account4" }
                });

            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "Id", "AccountId", "Address", "CreatedAt", "CreatedBy", "EmailContact", "EmployeeCount", "Industry", "Name", "Nation", "PhoneContact", "Slug", "UpdatedAt", "UpdatedBy", "Website" },
                values: new object[,]
                {
                    { new Guid("1bf76ac0-5244-4992-b810-120c59b57e4d"), new Guid("156013c8-2152-4c23-bb85-31c88f31be2d"), "123 Tech Lane", null, null, "info@techcorp.com", 500, "Technology", "Tech Corp", "USA", "123456789", "tech-corp", null, null, "www.techcorp.com" },
                    { new Guid("23e740e8-38f0-4bfa-a8a5-7739b999059d"), new Guid("69258856-6fc1-44d2-843c-f826659d5393"), "456 Health Blvd", null, null, "info@healthinc.com", 300, "Healthcare", "Health Inc.", "USA", "987654321", "health-inc", null, null, "www.healthinc.com" },
                    { new Guid("93392940-7c80-4366-8f0b-48ed2b0445bf"), new Guid("0867b588-51f2-4c25-bffe-5e1d8e9646de"), "45688 London", null, null, "info@AnRe.com", 300, "IT", "An Inc.", "VN", "98765432112", "an-pro-ga", null, null, "www.Anrp.com" }
                });

            migrationBuilder.InsertData(
                table: "Positions",
                columns: new[] { "Id", "CloseDate", "CommitmentTypeId", "CompanyId", "CreatedAt", "CreatedBy", "Description", "DistrictId", "EducationLevelRequirementId", "GenderRequirementId", "MaxAgeRequirement", "MinAgeRequirement", "ProvinceId", "Salary", "Status", "Title", "UpdatedAt", "UpdatedBy", "WorkArrangementId", "WorkExperienceRequirementId" },
                values: new object[,]
                {
                    { new Guid("6c89316c-508f-42be-bced-ef25963eca96"), new DateTime(2025, 2, 21, 17, 22, 36, 271, DateTimeKind.Local).AddTicks(3342), new Guid("540f318e-b42f-4485-9e60-8faa5bf80962"), new Guid("93392940-7c80-4366-8f0b-48ed2b0445bf"), new DateTime(2024, 10, 21, 17, 22, 36, 271, DateTimeKind.Local).AddTicks(3349), null, "Oversee product development lifecycle.", 20, new Guid("a3fb036a-04fc-4590-b87d-6ed32e2ec692"), new Guid("12497687-64b8-4d8e-814a-b7d1d33d3aab"), 45, 28, 3, 95000.0, 1, "Product Manager", new DateTime(2024, 10, 21, 17, 22, 36, 271, DateTimeKind.Local).AddTicks(3350), null, new Guid("c199da74-c2fb-4381-b093-cf2f1e3e8f06"), new Guid("646ccd9f-aa2f-413e-8d3e-eb8ab0b14c96") },
                    { new Guid("83e368d9-09cd-4deb-a70f-99dccc6d9588"), new DateTime(2025, 1, 21, 17, 22, 36, 271, DateTimeKind.Local).AddTicks(3352), new Guid("44b668b2-09ee-499e-af95-73598f9153a2"), new Guid("1bf76ac0-5244-4992-b810-120c59b57e4d"), new DateTime(2024, 10, 21, 17, 22, 36, 271, DateTimeKind.Local).AddTicks(3356), null, "Design intuitive user interfaces.", 25, new Guid("bc4ecf1e-8841-47f2-86ec-b0c523f03da1"), new Guid("79685cdb-be26-49cc-b7f9-1fb51686f5ba"), 38, 24, 4, 70000.0, 1, "UX Designer", new DateTime(2024, 10, 21, 17, 22, 36, 271, DateTimeKind.Local).AddTicks(3357), null, new Guid("04a9de34-0869-41b2-87a8-63c20c4ba22a"), new Guid("cc4121b2-72c2-4226-ad12-24e722b50cc2") },
                    { new Guid("91e8cc97-9f36-4ab2-a925-2abf60004462"), new DateTime(2024, 12, 21, 17, 22, 36, 271, DateTimeKind.Local).AddTicks(3333), new Guid("5d06c3b1-2bd1-4c68-96b4-f4cd8c899dff"), new Guid("23e740e8-38f0-4bfa-a8a5-7739b999059d"), new DateTime(2024, 10, 21, 17, 22, 36, 271, DateTimeKind.Local).AddTicks(3339), null, "Analyze large datasets to generate business insights.", 15, new Guid("bc44b9a9-5cd6-4195-a7bd-92b4bef6d8fb"), new Guid("7b5f69cb-5996-4a57-b9c6-9fee2a791bf6"), 40, 23, 2, 60000.0, 1, "Data Analyst", new DateTime(2024, 10, 21, 17, 22, 36, 271, DateTimeKind.Local).AddTicks(3339), null, new Guid("376764fa-28ec-4a08-80e3-a6ab407e8601"), new Guid("bf38a1b9-dee3-455a-87c1-4e034fe806f7") },
                    { new Guid("a6a9de87-336a-4c77-b75c-a7a90aa99583"), new DateTime(2025, 1, 21, 17, 22, 36, 271, DateTimeKind.Local).AddTicks(3290), new Guid("540f318e-b42f-4485-9e60-8faa5bf80962"), new Guid("1bf76ac0-5244-4992-b810-120c59b57e4d"), new DateTime(2024, 10, 21, 17, 22, 36, 271, DateTimeKind.Local).AddTicks(3327), null, "Develop and maintain web applications.", 10, new Guid("bc4ecf1e-8841-47f2-86ec-b0c523f03da1"), new Guid("79685cdb-be26-49cc-b7f9-1fb51686f5ba"), 35, 21, 1, 80000.0, 1, "Software Engineer", new DateTime(2024, 10, 21, 17, 22, 36, 271, DateTimeKind.Local).AddTicks(3329), null, new Guid("04a9de34-0869-41b2-87a8-63c20c4ba22a"), new Guid("67db1aef-c1b1-4424-8313-774a5dccdb9d") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("82a3fb5b-641e-4c7c-bd09-dfb00747f150"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("b218139a-7b7a-4394-bc57-e41be3520353"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("b9ba5465-fb70-4f23-86d6-df702778a320"));

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumn: "Id",
                keyValue: new Guid("6c89316c-508f-42be-bced-ef25963eca96"));

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumn: "Id",
                keyValue: new Guid("83e368d9-09cd-4deb-a70f-99dccc6d9588"));

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumn: "Id",
                keyValue: new Guid("91e8cc97-9f36-4ab2-a925-2abf60004462"));

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumn: "Id",
                keyValue: new Guid("a6a9de87-336a-4c77-b75c-a7a90aa99583"));

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: new Guid("1bf76ac0-5244-4992-b810-120c59b57e4d"));

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: new Guid("23e740e8-38f0-4bfa-a8a5-7739b999059d"));

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: new Guid("93392940-7c80-4366-8f0b-48ed2b0445bf"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("0867b588-51f2-4c25-bffe-5e1d8e9646de"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("156013c8-2152-4c23-bb85-31c88f31be2d"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("69258856-6fc1-44d2-843c-f826659d5393"));

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "Email", "Password", "Phone", "UpdatedAt", "UpdatedBy", "Username" },
                values: new object[] { new Guid("47b55518-e18d-4caa-bf26-24e527a036e5"), null, null, "admin@gmail.com", "Admin", "0123456789", null, null, "Admin" });
        }
    }
}
