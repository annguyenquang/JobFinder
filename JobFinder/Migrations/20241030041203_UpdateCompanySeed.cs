using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace JobFinder.Migrations
{
    /// <inheritdoc />
    public partial class UpdateCompanySeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("0b6e77a9-1a1a-4421-b741-e515fd607b4b"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("e89e0267-ebc9-4e8b-9df3-335315b0890f"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("fe78eae5-581d-4221-b806-f5e42f30ea7f"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("0ba58892-48d8-477b-9833-cd2381003fbc"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("40759c71-828d-4590-ad33-8c0316e05d2e"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("affb0c72-f5ae-4dc1-9c85-0809403b7cfa"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("e015e2c2-9f1e-4bae-a690-99f1ce776f40"));

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: new Guid("1bee4af0-1878-4e02-9b8a-d173631ce5e8"));

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: new Guid("4438ea3f-3eaf-45f2-8717-b9e123cd4360"));

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: new Guid("70529ace-2558-4a85-a612-f26dafef89d2"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("1b0b2d4c-5a8c-45f5-b294-063c78219065"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("7ce665e7-3c17-4de1-b90c-6816ad5e9900"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("f48748f2-9ed5-47f2-b7c9-b1de8d738f67"));

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "Email", "Password", "Phone", "UpdatedAt", "UpdatedBy", "Username" },
                values: new object[,]
                {
                    { new Guid("27c6c283-cabc-4254-968d-f0f667a1d5da"), null, null, "", "$2a$11$7GptUZ96ZCXRr7TNVjrTfuHzOQQgDXxW7fGemV3JYwgR4gQkyuHna", "0123456789", null, null, "account0" },
                    { new Guid("2adb34f9-630d-4d53-88f2-c9976a3a7b9d"), null, null, "", "$2a$11$jQ.ufXd4GpcQO/QVYKN4ROlP.zr2aCjl9rEcd0R1H1S2UJCu72kyS", "113", null, null, "admin" },
                    { new Guid("9c611243-2d7a-4b42-a204-a0357c127188"), null, null, "", "$2a$11$VTqrM4nVJoleVqqhGE1rneL8zMmEGNTQ3y5blT8mlAmj8obo5OtCO", "0128456789", null, null, "account3" },
                    { new Guid("cc799c2c-4dd5-4eb2-b62f-ad34434fa916"), null, null, "", "$2a$11$bukypsDYqlelrVs/ARzzn.3mNKKHZBBUyuZZ6kSmfnZYLjO1F6RXq", "0123856789", null, null, "account4" },
                    { new Guid("d36164c5-e3cd-4d12-9c10-a68078ce716e"), null, null, "", "$2a$11$lji4I6Q0EFBm1qvEHCTJpe9lSMlLqgMlJj0N3b9DDSWJAuU.m6Y4y", "0823456789", null, null, "account1" },
                    { new Guid("daacfb8a-8c63-4039-bf37-53ca029f6726"), null, null, "", "$2a$11$L8UqTR64GiV2QCOi6BPlluu4XM3//MGTKWJPHewFFANsZGADFLvSa", "0183456789", null, null, "account2" }
                });

            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "Id", "AccountId", "Address", "CreatedAt", "CreatedBy", "Description", "DistrictId", "EmailContact", "EmployeeCount", "Industry", "Logo", "Name", "Nation", "PhoneContact", "ProvinceId", "Slug", "UpdatedAt", "UpdatedBy", "Website" },
                values: new object[,]
                {
                    { new Guid("0a0ef7c4-853c-4817-afa1-0e073981495c"), new Guid("d36164c5-e3cd-4d12-9c10-a68078ce716e"), "45688 London", null, null, "An Inc. is a an incident company.", 0, "info@AnRe.com", 300, "IT", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRsowdkWEAhFe0idqRamO_CAvGutpD1CHKpcA&s", "An Inc.", "VN", "98765432112", 0, "an-pro-ga", null, null, "www.Anrp.com" },
                    { new Guid("2919e2b6-4e03-42c4-a08c-1262396e8281"), new Guid("2adb34f9-630d-4d53-88f2-c9976a3a7b9d"), "123 Tech Lane", null, null, "Tech Corp is a tech corp company.", 0, "info@techcorp.com", 500, "Technology", "https://images-platform.99static.com/7v8-fjWpezqDYFTxbYGvEE3gnw8=/191x0:1338x1147/500x500/top/smart/99designs-contests-attachments/60/60612/attachment_60612660", "Tech Corp", "USA", "123456789", 0, "tech-corp", null, null, "www.techcorp.com" },
                    { new Guid("42541e47-f6ea-4931-bf84-bbca75b71349"), new Guid("27c6c283-cabc-4254-968d-f0f667a1d5da"), "456 Health Blvd", null, null, "Health Inc. is a health corp company.", 0, "info@healthinc.com", 300, "Healthcare", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRyD1QcAiMJyNvRptFkjJXovZouhRkTEMlazQ&s", "Health Inc.", "USA", "987654321", 0, "health-inc", null, null, "www.healthinc.com" }
                });

            migrationBuilder.InsertData(
                table: "Jobs",
                columns: new[] { "Id", "CloseDate", "CommitmentTypeId", "CompanyId", "CreatedAt", "CreatedBy", "Description", "DistrictId", "EducationLevelRequirementId", "GenderRequirementId", "MaxAgeRequirement", "MinAgeRequirement", "ProvinceId", "Salary", "Status", "Title", "UpdatedAt", "UpdatedBy", "WorkArrangementId", "WorkExperienceRequirementId" },
                values: new object[,]
                {
                    { new Guid("5ae15353-66bc-44b6-b88a-3df9f32903de"), new DateTime(2024, 12, 30, 11, 12, 2, 667, DateTimeKind.Local).AddTicks(2176), new Guid("5d06c3b1-2bd1-4c68-96b4-f4cd8c899dff"), new Guid("42541e47-f6ea-4931-bf84-bbca75b71349"), new DateTime(2024, 10, 30, 11, 12, 2, 667, DateTimeKind.Local).AddTicks(2184), null, "Analyze large datasets to generate business insights.", 15, new Guid("bc44b9a9-5cd6-4195-a7bd-92b4bef6d8fb"), new Guid("7b5f69cb-5996-4a57-b9c6-9fee2a791bf6"), 40, 23, 2, 60000.0, 1, "Data Analyst", new DateTime(2024, 10, 30, 11, 12, 2, 667, DateTimeKind.Local).AddTicks(2185), null, new Guid("376764fa-28ec-4a08-80e3-a6ab407e8601"), new Guid("bf38a1b9-dee3-455a-87c1-4e034fe806f7") },
                    { new Guid("ae88d992-8de7-43c9-8568-237818ee0c90"), new DateTime(2025, 1, 30, 11, 12, 2, 667, DateTimeKind.Local).AddTicks(2196), new Guid("44b668b2-09ee-499e-af95-73598f9153a2"), new Guid("2919e2b6-4e03-42c4-a08c-1262396e8281"), new DateTime(2024, 10, 30, 11, 12, 2, 667, DateTimeKind.Local).AddTicks(2200), null, "Design intuitive user interfaces.", 25, new Guid("bc4ecf1e-8841-47f2-86ec-b0c523f03da1"), new Guid("79685cdb-be26-49cc-b7f9-1fb51686f5ba"), 38, 24, 4, 70000.0, 1, "UX Designer", new DateTime(2024, 10, 30, 11, 12, 2, 667, DateTimeKind.Local).AddTicks(2201), null, new Guid("04a9de34-0869-41b2-87a8-63c20c4ba22a"), new Guid("cc4121b2-72c2-4226-ad12-24e722b50cc2") },
                    { new Guid("d5356024-bb17-4fb5-9ac6-d13dda25f095"), new DateTime(2025, 1, 30, 11, 12, 2, 667, DateTimeKind.Local).AddTicks(2138), new Guid("540f318e-b42f-4485-9e60-8faa5bf80962"), new Guid("2919e2b6-4e03-42c4-a08c-1262396e8281"), new DateTime(2024, 10, 30, 11, 12, 2, 667, DateTimeKind.Local).AddTicks(2164), null, "Develop and maintain web applications.", 10, new Guid("bc4ecf1e-8841-47f2-86ec-b0c523f03da1"), new Guid("79685cdb-be26-49cc-b7f9-1fb51686f5ba"), 35, 21, 1, 80000.0, 1, "Software Engineer", new DateTime(2024, 10, 30, 11, 12, 2, 667, DateTimeKind.Local).AddTicks(2165), null, new Guid("04a9de34-0869-41b2-87a8-63c20c4ba22a"), new Guid("67db1aef-c1b1-4424-8313-774a5dccdb9d") },
                    { new Guid("e426af21-d35e-4f33-9612-8086eb3abf6b"), new DateTime(2025, 2, 28, 11, 12, 2, 667, DateTimeKind.Local).AddTicks(2188), new Guid("540f318e-b42f-4485-9e60-8faa5bf80962"), new Guid("0a0ef7c4-853c-4817-afa1-0e073981495c"), new DateTime(2024, 10, 30, 11, 12, 2, 667, DateTimeKind.Local).AddTicks(2192), null, "Oversee product development lifecycle.", 20, new Guid("a3fb036a-04fc-4590-b87d-6ed32e2ec692"), new Guid("12497687-64b8-4d8e-814a-b7d1d33d3aab"), 45, 28, 3, 95000.0, 1, "Product Manager", new DateTime(2024, 10, 30, 11, 12, 2, 667, DateTimeKind.Local).AddTicks(2193), null, new Guid("c199da74-c2fb-4381-b093-cf2f1e3e8f06"), new Guid("646ccd9f-aa2f-413e-8d3e-eb8ab0b14c96") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("9c611243-2d7a-4b42-a204-a0357c127188"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("cc799c2c-4dd5-4eb2-b62f-ad34434fa916"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("daacfb8a-8c63-4039-bf37-53ca029f6726"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("5ae15353-66bc-44b6-b88a-3df9f32903de"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("ae88d992-8de7-43c9-8568-237818ee0c90"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("d5356024-bb17-4fb5-9ac6-d13dda25f095"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("e426af21-d35e-4f33-9612-8086eb3abf6b"));

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: new Guid("0a0ef7c4-853c-4817-afa1-0e073981495c"));

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: new Guid("2919e2b6-4e03-42c4-a08c-1262396e8281"));

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: new Guid("42541e47-f6ea-4931-bf84-bbca75b71349"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("27c6c283-cabc-4254-968d-f0f667a1d5da"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("2adb34f9-630d-4d53-88f2-c9976a3a7b9d"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("d36164c5-e3cd-4d12-9c10-a68078ce716e"));

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "Email", "Password", "Phone", "UpdatedAt", "UpdatedBy", "Username" },
                values: new object[,]
                {
                    { new Guid("0b6e77a9-1a1a-4421-b741-e515fd607b4b"), null, null, "", "$2a$11$xAaFhES7rz79WDbIyXFCp.9HeFm1eB4bw5PAt8R2LqcEso.S/zBgu", "0183456789", null, null, "account2" },
                    { new Guid("1b0b2d4c-5a8c-45f5-b294-063c78219065"), null, null, "", "$2a$11$cgP04FrhXqg135chpSgCRejtopszfhumxfcVk6grpCj0MU3xX.dd6", "0123456789", null, null, "account0" },
                    { new Guid("7ce665e7-3c17-4de1-b90c-6816ad5e9900"), null, null, "", "$2a$11$lEfoBX93qCcjR/DXciwWQ.sJrgZ3wrAzrh71k3qnsF5Z/OzYKl7BO", "0823456789", null, null, "account1" },
                    { new Guid("e89e0267-ebc9-4e8b-9df3-335315b0890f"), null, null, "", "$2a$11$OYLkmx8F1ah46KLG5Zspa.CUxMtYOGSkMtqi96Fh4eVuhBxeYwhvG", "0123856789", null, null, "account4" },
                    { new Guid("f48748f2-9ed5-47f2-b7c9-b1de8d738f67"), null, null, "", "$2a$11$PwUZgDAC.rNaFK/sYXQ9ieJcrfEtG/itAzP982vyQXViwD8FVocEm", "113", null, null, "admin" },
                    { new Guid("fe78eae5-581d-4221-b806-f5e42f30ea7f"), null, null, "", "$2a$11$NeXh9Yt1WpYEG5rf60/oz.v.TuEMYgSCAcjWawZd7z/pwuFa1jica", "0128456789", null, null, "account3" }
                });

            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "Id", "AccountId", "Address", "CreatedAt", "CreatedBy", "Description", "DistrictId", "EmailContact", "EmployeeCount", "Industry", "Logo", "Name", "Nation", "PhoneContact", "ProvinceId", "Slug", "UpdatedAt", "UpdatedBy", "Website" },
                values: new object[,]
                {
                    { new Guid("1bee4af0-1878-4e02-9b8a-d173631ce5e8"), new Guid("1b0b2d4c-5a8c-45f5-b294-063c78219065"), "456 Health Blvd", null, null, "", 0, "info@healthinc.com", 300, "Healthcare", "", "Health Inc.", "USA", "987654321", 0, "health-inc", null, null, "www.healthinc.com" },
                    { new Guid("4438ea3f-3eaf-45f2-8717-b9e123cd4360"), new Guid("f48748f2-9ed5-47f2-b7c9-b1de8d738f67"), "123 Tech Lane", null, null, "", 0, "info@techcorp.com", 500, "Technology", "", "Tech Corp", "USA", "123456789", 0, "tech-corp", null, null, "www.techcorp.com" },
                    { new Guid("70529ace-2558-4a85-a612-f26dafef89d2"), new Guid("7ce665e7-3c17-4de1-b90c-6816ad5e9900"), "45688 London", null, null, "", 0, "info@AnRe.com", 300, "IT", "", "An Inc.", "VN", "98765432112", 0, "an-pro-ga", null, null, "www.Anrp.com" }
                });

            migrationBuilder.InsertData(
                table: "Jobs",
                columns: new[] { "Id", "CloseDate", "CommitmentTypeId", "CompanyId", "CreatedAt", "CreatedBy", "Description", "DistrictId", "EducationLevelRequirementId", "GenderRequirementId", "MaxAgeRequirement", "MinAgeRequirement", "ProvinceId", "Salary", "Status", "Title", "UpdatedAt", "UpdatedBy", "WorkArrangementId", "WorkExperienceRequirementId" },
                values: new object[,]
                {
                    { new Guid("0ba58892-48d8-477b-9833-cd2381003fbc"), new DateTime(2025, 1, 30, 11, 4, 19, 120, DateTimeKind.Local).AddTicks(649), new Guid("44b668b2-09ee-499e-af95-73598f9153a2"), new Guid("4438ea3f-3eaf-45f2-8717-b9e123cd4360"), new DateTime(2024, 10, 30, 11, 4, 19, 120, DateTimeKind.Local).AddTicks(653), null, "Design intuitive user interfaces.", 25, new Guid("bc4ecf1e-8841-47f2-86ec-b0c523f03da1"), new Guid("79685cdb-be26-49cc-b7f9-1fb51686f5ba"), 38, 24, 4, 70000.0, 1, "UX Designer", new DateTime(2024, 10, 30, 11, 4, 19, 120, DateTimeKind.Local).AddTicks(653), null, new Guid("04a9de34-0869-41b2-87a8-63c20c4ba22a"), new Guid("cc4121b2-72c2-4226-ad12-24e722b50cc2") },
                    { new Guid("40759c71-828d-4590-ad33-8c0316e05d2e"), new DateTime(2024, 12, 30, 11, 4, 19, 120, DateTimeKind.Local).AddTicks(554), new Guid("5d06c3b1-2bd1-4c68-96b4-f4cd8c899dff"), new Guid("1bee4af0-1878-4e02-9b8a-d173631ce5e8"), new DateTime(2024, 10, 30, 11, 4, 19, 120, DateTimeKind.Local).AddTicks(560), null, "Analyze large datasets to generate business insights.", 15, new Guid("bc44b9a9-5cd6-4195-a7bd-92b4bef6d8fb"), new Guid("7b5f69cb-5996-4a57-b9c6-9fee2a791bf6"), 40, 23, 2, 60000.0, 1, "Data Analyst", new DateTime(2024, 10, 30, 11, 4, 19, 120, DateTimeKind.Local).AddTicks(560), null, new Guid("376764fa-28ec-4a08-80e3-a6ab407e8601"), new Guid("bf38a1b9-dee3-455a-87c1-4e034fe806f7") },
                    { new Guid("affb0c72-f5ae-4dc1-9c85-0809403b7cfa"), new DateTime(2025, 1, 30, 11, 4, 19, 120, DateTimeKind.Local).AddTicks(505), new Guid("540f318e-b42f-4485-9e60-8faa5bf80962"), new Guid("4438ea3f-3eaf-45f2-8717-b9e123cd4360"), new DateTime(2024, 10, 30, 11, 4, 19, 120, DateTimeKind.Local).AddTicks(536), null, "Develop and maintain web applications.", 10, new Guid("bc4ecf1e-8841-47f2-86ec-b0c523f03da1"), new Guid("79685cdb-be26-49cc-b7f9-1fb51686f5ba"), 35, 21, 1, 80000.0, 1, "Software Engineer", new DateTime(2024, 10, 30, 11, 4, 19, 120, DateTimeKind.Local).AddTicks(537), null, new Guid("04a9de34-0869-41b2-87a8-63c20c4ba22a"), new Guid("67db1aef-c1b1-4424-8313-774a5dccdb9d") },
                    { new Guid("e015e2c2-9f1e-4bae-a690-99f1ce776f40"), new DateTime(2025, 2, 28, 11, 4, 19, 120, DateTimeKind.Local).AddTicks(640), new Guid("540f318e-b42f-4485-9e60-8faa5bf80962"), new Guid("70529ace-2558-4a85-a612-f26dafef89d2"), new DateTime(2024, 10, 30, 11, 4, 19, 120, DateTimeKind.Local).AddTicks(645), null, "Oversee product development lifecycle.", 20, new Guid("a3fb036a-04fc-4590-b87d-6ed32e2ec692"), new Guid("12497687-64b8-4d8e-814a-b7d1d33d3aab"), 45, 28, 3, 95000.0, 1, "Product Manager", new DateTime(2024, 10, 30, 11, 4, 19, 120, DateTimeKind.Local).AddTicks(646), null, new Guid("c199da74-c2fb-4381-b093-cf2f1e3e8f06"), new Guid("646ccd9f-aa2f-413e-8d3e-eb8ab0b14c96") }
                });
        }
    }
}
