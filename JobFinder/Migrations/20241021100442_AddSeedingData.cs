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
                    { new Guid("13f848e1-32f6-4c54-8b88-037689640c6f"), null, null, "", "account2", "0183456789", null, null, "account2" },
                    { new Guid("297dec55-ed24-47c6-8b86-705fbb165558"), null, null, "", "admin", "113", null, null, "admin" },
                    { new Guid("30b577ed-7dbc-4030-9a8b-a8fcae96121e"), null, null, "", "account4", "0123856789", null, null, "account4" },
                    { new Guid("30ce66ac-e95f-4f1b-aa69-70e02e0857c8"), null, null, "", "account0", "0123456789", null, null, "account0" },
                    { new Guid("bae4fafd-cf6b-425e-9672-55b481e92bed"), null, null, "", "account1", "0823456789", null, null, "account1" },
                    { new Guid("cb4229b9-8644-46f4-a072-47d17f769e0d"), null, null, "", "account3", "0128456789", null, null, "account3" }
                });

            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "Id", "AccountId", "Address", "CreatedAt", "CreatedBy", "EmailContact", "EmployeeCount", "Industry", "Name", "Nation", "PhoneContact", "Slug", "UpdatedAt", "UpdatedBy", "Website" },
                values: new object[,]
                {
                    { new Guid("2e3fee08-3e49-4b5e-94b7-94104a790361"), new Guid("30ce66ac-e95f-4f1b-aa69-70e02e0857c8"), "456 Health Blvd", null, null, "info@healthinc.com", 300, "Healthcare", "Health Inc.", "USA", "987654321", "health-inc", null, null, "www.healthinc.com" },
                    { new Guid("ba515074-84d0-4db5-a2be-72b8cc200fa5"), new Guid("297dec55-ed24-47c6-8b86-705fbb165558"), "123 Tech Lane", null, null, "info@techcorp.com", 500, "Technology", "Tech Corp", "USA", "123456789", "tech-corp", null, null, "www.techcorp.com" },
                    { new Guid("c083c613-0a3b-4b93-9a6b-eca88a648e7d"), new Guid("bae4fafd-cf6b-425e-9672-55b481e92bed"), "45688 London", null, null, "info@AnRe.com", 300, "IT", "An Inc.", "VN", "98765432112", "an-pro-ga", null, null, "www.Anrp.com" }
                });

            migrationBuilder.InsertData(
                table: "Positions",
                columns: new[] { "Id", "CloseDate", "CommitmentTypeId", "CompanyId", "CreatedAt", "CreatedBy", "Description", "DistrictId", "EducationLevelRequirementId", "GenderRequirementId", "MaxAgeRequirement", "MinAgeRequirement", "ProvinceId", "Salary", "Status", "Title", "UpdatedAt", "UpdatedBy", "WorkArrangementId", "WorkExperienceRequirementId" },
                values: new object[,]
                {
                    { new Guid("08542b94-2921-41e1-8dd6-298a16f0b238"), new DateTime(2024, 12, 21, 17, 4, 42, 532, DateTimeKind.Local).AddTicks(2730), new Guid("5d06c3b1-2bd1-4c68-96b4-f4cd8c899dff"), new Guid("2e3fee08-3e49-4b5e-94b7-94104a790361"), new DateTime(2024, 10, 21, 17, 4, 42, 532, DateTimeKind.Local).AddTicks(2735), null, "Analyze large datasets to generate business insights.", 15, new Guid("bc44b9a9-5cd6-4195-a7bd-92b4bef6d8fb"), new Guid("7b5f69cb-5996-4a57-b9c6-9fee2a791bf6"), 40, 23, 2, 60000.0, 1, "Data Analyst", new DateTime(2024, 10, 21, 17, 4, 42, 532, DateTimeKind.Local).AddTicks(2735), null, new Guid("376764fa-28ec-4a08-80e3-a6ab407e8601"), new Guid("bf38a1b9-dee3-455a-87c1-4e034fe806f7") },
                    { new Guid("54674294-2976-41f8-8b74-3156dc10a3e8"), new DateTime(2025, 1, 21, 17, 4, 42, 532, DateTimeKind.Local).AddTicks(2755), new Guid("44b668b2-09ee-499e-af95-73598f9153a2"), new Guid("ba515074-84d0-4db5-a2be-72b8cc200fa5"), new DateTime(2024, 10, 21, 17, 4, 42, 532, DateTimeKind.Local).AddTicks(2759), null, "Design intuitive user interfaces.", 25, new Guid("bc4ecf1e-8841-47f2-86ec-b0c523f03da1"), new Guid("79685cdb-be26-49cc-b7f9-1fb51686f5ba"), 38, 24, 4, 70000.0, 1, "UX Designer", new DateTime(2024, 10, 21, 17, 4, 42, 532, DateTimeKind.Local).AddTicks(2760), null, new Guid("04a9de34-0869-41b2-87a8-63c20c4ba22a"), new Guid("cc4121b2-72c2-4226-ad12-24e722b50cc2") },
                    { new Guid("579c16a6-d21d-4768-837f-8bac7e9f84ab"), new DateTime(2025, 2, 21, 17, 4, 42, 532, DateTimeKind.Local).AddTicks(2748), new Guid("540f318e-b42f-4485-9e60-8faa5bf80962"), new Guid("c083c613-0a3b-4b93-9a6b-eca88a648e7d"), new DateTime(2024, 10, 21, 17, 4, 42, 532, DateTimeKind.Local).AddTicks(2752), null, "Oversee product development lifecycle.", 20, new Guid("a3fb036a-04fc-4590-b87d-6ed32e2ec692"), new Guid("12497687-64b8-4d8e-814a-b7d1d33d3aab"), 45, 28, 3, 95000.0, 1, "Product Manager", new DateTime(2024, 10, 21, 17, 4, 42, 532, DateTimeKind.Local).AddTicks(2752), null, new Guid("c199da74-c2fb-4381-b093-cf2f1e3e8f06"), new Guid("646ccd9f-aa2f-413e-8d3e-eb8ab0b14c96") },
                    { new Guid("8665ec02-69c2-4d8c-aaba-52c5361ba928"), new DateTime(2025, 1, 21, 17, 4, 42, 532, DateTimeKind.Local).AddTicks(2699), new Guid("540f318e-b42f-4485-9e60-8faa5bf80962"), new Guid("ba515074-84d0-4db5-a2be-72b8cc200fa5"), new DateTime(2024, 10, 21, 17, 4, 42, 532, DateTimeKind.Local).AddTicks(2724), null, "Develop and maintain web applications.", 10, new Guid("bc4ecf1e-8841-47f2-86ec-b0c523f03da1"), new Guid("79685cdb-be26-49cc-b7f9-1fb51686f5ba"), 35, 21, 1, 80000.0, 1, "Software Engineer", new DateTime(2024, 10, 21, 17, 4, 42, 532, DateTimeKind.Local).AddTicks(2725), null, new Guid("04a9de34-0869-41b2-87a8-63c20c4ba22a"), new Guid("67db1aef-c1b1-4424-8313-774a5dccdb9d") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("13f848e1-32f6-4c54-8b88-037689640c6f"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("30b577ed-7dbc-4030-9a8b-a8fcae96121e"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("cb4229b9-8644-46f4-a072-47d17f769e0d"));

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumn: "Id",
                keyValue: new Guid("08542b94-2921-41e1-8dd6-298a16f0b238"));

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumn: "Id",
                keyValue: new Guid("54674294-2976-41f8-8b74-3156dc10a3e8"));

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumn: "Id",
                keyValue: new Guid("579c16a6-d21d-4768-837f-8bac7e9f84ab"));

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumn: "Id",
                keyValue: new Guid("8665ec02-69c2-4d8c-aaba-52c5361ba928"));

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: new Guid("2e3fee08-3e49-4b5e-94b7-94104a790361"));

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: new Guid("ba515074-84d0-4db5-a2be-72b8cc200fa5"));

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: new Guid("c083c613-0a3b-4b93-9a6b-eca88a648e7d"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("297dec55-ed24-47c6-8b86-705fbb165558"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("30ce66ac-e95f-4f1b-aa69-70e02e0857c8"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("bae4fafd-cf6b-425e-9672-55b481e92bed"));

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "Email", "Password", "Phone", "UpdatedAt", "UpdatedBy", "Username" },
                values: new object[] { new Guid("47b55518-e18d-4caa-bf26-24e527a036e5"), null, null, "admin@gmail.com", "Admin", "0123456789", null, null, "Admin" });
        }
    }
}
