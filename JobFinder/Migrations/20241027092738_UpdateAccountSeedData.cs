using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace JobFinder.Migrations
{
    /// <inheritdoc />
    public partial class UpdateAccountSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("222d5289-21ea-41ca-a6cf-026b54642cc3"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("5925f5cd-2c71-4b62-a212-fb6a1c5111a6"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("b9bb9c4e-86ba-415e-8e37-10b46d1dc836"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("01075104-9a8b-4ddc-9285-7f9dd88707d3"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("4de4f55b-db6f-4789-a182-01e7e3402367"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("67b425cb-39ab-4bfe-b222-b76430064590"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("d802b669-34bf-4b9d-9163-c955fc827729"));

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: new Guid("1b93b95c-8203-4105-9ab1-f0fa303ef2ad"));

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: new Guid("2a13fe71-f3b5-4f40-b9ac-69e207365ab9"));

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: new Guid("37f6c5c7-6380-43f6-a66f-6a64379910b3"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("76846414-036b-4892-8093-15c46d101333"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("d8b16970-bad3-4856-ac4b-5d3c342b759d"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("e291b60a-2f72-42c1-ad22-cba5364b1446"));

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "Email", "Password", "Phone", "UpdatedAt", "UpdatedBy", "Username" },
                values: new object[,]
                {
                    { new Guid("045b336c-4c6b-4d6e-8a5e-754410415630"), null, null, "", "$2a$11$BACDPGJyB8L6W00C9bzLx.7G/AM2TucN7HfrPPcEM0Td35.f/B9XW", "0128456789", null, null, "account3" },
                    { new Guid("2331de86-e1c1-48c1-9517-a43f5e651fdb"), null, null, "", "$2a$11$Q3mmWrF0iXG5V.2VG5jpTug3pE0kREjnM45yiH2QFYtpH8WeVtb/6", "0123856789", null, null, "account4" },
                    { new Guid("23c255a5-eaf9-44aa-8daf-86d4d429960d"), null, null, "", "$2a$11$o6UUGpvEaYRml6ihRbv/nOmiijHsXXLEaNELpuxrbB5JdsuH.7p1e", "0823456789", null, null, "account1" },
                    { new Guid("2eaeeb0c-f11f-4e70-97c4-e7d7c70a4989"), null, null, "", "$2a$11$LT1iJJ69oAe2VIBQ7W6aTuqqXP3zPKajn.wvLBAufynpCNaVGlijC", "0123456789", null, null, "account0" },
                    { new Guid("65e2187f-eacf-4f46-beb0-902bcfae95b2"), null, null, "", "$2a$11$bIu0djWFoQBmo5VSR0d8Keo.VwZKjOu4NVa0U4VNINMDCPdzpVdKG", "0183456789", null, null, "account2" },
                    { new Guid("f45d7725-3bf9-4cf2-9708-145c14eee7ee"), null, null, "", "$2a$11$f8Qkea/64xg9mMpMdh6a8.yb4KVnUOwT/XnidIojqBqR0G.SG7OOK", "113", null, null, "admin" }
                });

            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "Id", "AccountId", "Address", "CreatedAt", "CreatedBy", "EmailContact", "EmployeeCount", "Industry", "Name", "Nation", "PhoneContact", "Slug", "UpdatedAt", "UpdatedBy", "Website" },
                values: new object[,]
                {
                    { new Guid("3f7abc66-1336-4aa5-9d5f-57890a8a1b48"), new Guid("2eaeeb0c-f11f-4e70-97c4-e7d7c70a4989"), "456 Health Blvd", null, null, "info@healthinc.com", 300, "Healthcare", "Health Inc.", "USA", "987654321", "health-inc", null, null, "www.healthinc.com" },
                    { new Guid("51537cfc-b358-44b5-81c9-f5e08245021e"), new Guid("23c255a5-eaf9-44aa-8daf-86d4d429960d"), "45688 London", null, null, "info@AnRe.com", 300, "IT", "An Inc.", "VN", "98765432112", "an-pro-ga", null, null, "www.Anrp.com" },
                    { new Guid("c2c0df4d-ff19-4548-bcab-a5aa064bed4c"), new Guid("f45d7725-3bf9-4cf2-9708-145c14eee7ee"), "123 Tech Lane", null, null, "info@techcorp.com", 500, "Technology", "Tech Corp", "USA", "123456789", "tech-corp", null, null, "www.techcorp.com" }
                });

            migrationBuilder.InsertData(
                table: "Jobs",
                columns: new[] { "Id", "CloseDate", "CommitmentTypeId", "CompanyId", "CreatedAt", "CreatedBy", "Description", "DistrictId", "EducationLevelRequirementId", "GenderRequirementId", "MaxAgeRequirement", "MinAgeRequirement", "ProvinceId", "Salary", "Status", "Title", "UpdatedAt", "UpdatedBy", "WorkArrangementId", "WorkExperienceRequirementId" },
                values: new object[,]
                {
                    { new Guid("00160ec7-7664-4e60-8a82-bec826c8b4b2"), new DateTime(2024, 12, 27, 16, 27, 36, 762, DateTimeKind.Local).AddTicks(3257), new Guid("5d06c3b1-2bd1-4c68-96b4-f4cd8c899dff"), new Guid("3f7abc66-1336-4aa5-9d5f-57890a8a1b48"), new DateTime(2024, 10, 27, 16, 27, 36, 762, DateTimeKind.Local).AddTicks(3262), null, "Analyze large datasets to generate business insights.", 15, new Guid("bc44b9a9-5cd6-4195-a7bd-92b4bef6d8fb"), new Guid("7b5f69cb-5996-4a57-b9c6-9fee2a791bf6"), 40, 23, 2, 60000.0, 1, "Data Analyst", new DateTime(2024, 10, 27, 16, 27, 36, 762, DateTimeKind.Local).AddTicks(3263), null, new Guid("376764fa-28ec-4a08-80e3-a6ab407e8601"), new Guid("bf38a1b9-dee3-455a-87c1-4e034fe806f7") },
                    { new Guid("358879b5-b1db-4443-b38a-aaa71b0dff22"), new DateTime(2025, 2, 27, 16, 27, 36, 762, DateTimeKind.Local).AddTicks(3266), new Guid("540f318e-b42f-4485-9e60-8faa5bf80962"), new Guid("51537cfc-b358-44b5-81c9-f5e08245021e"), new DateTime(2024, 10, 27, 16, 27, 36, 762, DateTimeKind.Local).AddTicks(3270), null, "Oversee product development lifecycle.", 20, new Guid("a3fb036a-04fc-4590-b87d-6ed32e2ec692"), new Guid("12497687-64b8-4d8e-814a-b7d1d33d3aab"), 45, 28, 3, 95000.0, 1, "Product Manager", new DateTime(2024, 10, 27, 16, 27, 36, 762, DateTimeKind.Local).AddTicks(3271), null, new Guid("c199da74-c2fb-4381-b093-cf2f1e3e8f06"), new Guid("646ccd9f-aa2f-413e-8d3e-eb8ab0b14c96") },
                    { new Guid("6fb8fc0d-f3b8-4802-a54e-065e069f28e8"), new DateTime(2025, 1, 27, 16, 27, 36, 762, DateTimeKind.Local).AddTicks(3273), new Guid("44b668b2-09ee-499e-af95-73598f9153a2"), new Guid("c2c0df4d-ff19-4548-bcab-a5aa064bed4c"), new DateTime(2024, 10, 27, 16, 27, 36, 762, DateTimeKind.Local).AddTicks(3278), null, "Design intuitive user interfaces.", 25, new Guid("bc4ecf1e-8841-47f2-86ec-b0c523f03da1"), new Guid("79685cdb-be26-49cc-b7f9-1fb51686f5ba"), 38, 24, 4, 70000.0, 1, "UX Designer", new DateTime(2024, 10, 27, 16, 27, 36, 762, DateTimeKind.Local).AddTicks(3279), null, new Guid("04a9de34-0869-41b2-87a8-63c20c4ba22a"), new Guid("cc4121b2-72c2-4226-ad12-24e722b50cc2") },
                    { new Guid("91b5757a-c767-4647-9ff5-4f4dd294d887"), new DateTime(2025, 1, 27, 16, 27, 36, 762, DateTimeKind.Local).AddTicks(3224), new Guid("540f318e-b42f-4485-9e60-8faa5bf80962"), new Guid("c2c0df4d-ff19-4548-bcab-a5aa064bed4c"), new DateTime(2024, 10, 27, 16, 27, 36, 762, DateTimeKind.Local).AddTicks(3252), null, "Develop and maintain web applications.", 10, new Guid("bc4ecf1e-8841-47f2-86ec-b0c523f03da1"), new Guid("79685cdb-be26-49cc-b7f9-1fb51686f5ba"), 35, 21, 1, 80000.0, 1, "Software Engineer", new DateTime(2024, 10, 27, 16, 27, 36, 762, DateTimeKind.Local).AddTicks(3253), null, new Guid("04a9de34-0869-41b2-87a8-63c20c4ba22a"), new Guid("67db1aef-c1b1-4424-8313-774a5dccdb9d") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("045b336c-4c6b-4d6e-8a5e-754410415630"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("2331de86-e1c1-48c1-9517-a43f5e651fdb"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("65e2187f-eacf-4f46-beb0-902bcfae95b2"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("00160ec7-7664-4e60-8a82-bec826c8b4b2"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("358879b5-b1db-4443-b38a-aaa71b0dff22"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("6fb8fc0d-f3b8-4802-a54e-065e069f28e8"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("91b5757a-c767-4647-9ff5-4f4dd294d887"));

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: new Guid("3f7abc66-1336-4aa5-9d5f-57890a8a1b48"));

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: new Guid("51537cfc-b358-44b5-81c9-f5e08245021e"));

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: new Guid("c2c0df4d-ff19-4548-bcab-a5aa064bed4c"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("23c255a5-eaf9-44aa-8daf-86d4d429960d"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("2eaeeb0c-f11f-4e70-97c4-e7d7c70a4989"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("f45d7725-3bf9-4cf2-9708-145c14eee7ee"));

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "Email", "Password", "Phone", "UpdatedAt", "UpdatedBy", "Username" },
                values: new object[,]
                {
                    { new Guid("222d5289-21ea-41ca-a6cf-026b54642cc3"), null, null, "", "account2", "0183456789", null, null, "account2" },
                    { new Guid("5925f5cd-2c71-4b62-a212-fb6a1c5111a6"), null, null, "", "account4", "0123856789", null, null, "account4" },
                    { new Guid("76846414-036b-4892-8093-15c46d101333"), null, null, "", "account0", "0123456789", null, null, "account0" },
                    { new Guid("b9bb9c4e-86ba-415e-8e37-10b46d1dc836"), null, null, "", "account3", "0128456789", null, null, "account3" },
                    { new Guid("d8b16970-bad3-4856-ac4b-5d3c342b759d"), null, null, "", "account1", "0823456789", null, null, "account1" },
                    { new Guid("e291b60a-2f72-42c1-ad22-cba5364b1446"), null, null, "", "admin", "113", null, null, "admin" }
                });

            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "Id", "AccountId", "Address", "CreatedAt", "CreatedBy", "EmailContact", "EmployeeCount", "Industry", "Name", "Nation", "PhoneContact", "Slug", "UpdatedAt", "UpdatedBy", "Website" },
                values: new object[,]
                {
                    { new Guid("1b93b95c-8203-4105-9ab1-f0fa303ef2ad"), new Guid("d8b16970-bad3-4856-ac4b-5d3c342b759d"), "45688 London", null, null, "info@AnRe.com", 300, "IT", "An Inc.", "VN", "98765432112", "an-pro-ga", null, null, "www.Anrp.com" },
                    { new Guid("2a13fe71-f3b5-4f40-b9ac-69e207365ab9"), new Guid("e291b60a-2f72-42c1-ad22-cba5364b1446"), "123 Tech Lane", null, null, "info@techcorp.com", 500, "Technology", "Tech Corp", "USA", "123456789", "tech-corp", null, null, "www.techcorp.com" },
                    { new Guid("37f6c5c7-6380-43f6-a66f-6a64379910b3"), new Guid("76846414-036b-4892-8093-15c46d101333"), "456 Health Blvd", null, null, "info@healthinc.com", 300, "Healthcare", "Health Inc.", "USA", "987654321", "health-inc", null, null, "www.healthinc.com" }
                });

            migrationBuilder.InsertData(
                table: "Jobs",
                columns: new[] { "Id", "CloseDate", "CommitmentTypeId", "CompanyId", "CreatedAt", "CreatedBy", "Description", "DistrictId", "EducationLevelRequirementId", "GenderRequirementId", "MaxAgeRequirement", "MinAgeRequirement", "ProvinceId", "Salary", "Status", "Title", "UpdatedAt", "UpdatedBy", "WorkArrangementId", "WorkExperienceRequirementId" },
                values: new object[,]
                {
                    { new Guid("01075104-9a8b-4ddc-9285-7f9dd88707d3"), new DateTime(2024, 12, 23, 21, 6, 59, 524, DateTimeKind.Local).AddTicks(7512), new Guid("5d06c3b1-2bd1-4c68-96b4-f4cd8c899dff"), new Guid("37f6c5c7-6380-43f6-a66f-6a64379910b3"), new DateTime(2024, 10, 23, 21, 6, 59, 524, DateTimeKind.Local).AddTicks(7519), null, "Analyze large datasets to generate business insights.", 15, new Guid("bc44b9a9-5cd6-4195-a7bd-92b4bef6d8fb"), new Guid("7b5f69cb-5996-4a57-b9c6-9fee2a791bf6"), 40, 23, 2, 60000.0, 1, "Data Analyst", new DateTime(2024, 10, 23, 21, 6, 59, 524, DateTimeKind.Local).AddTicks(7520), null, new Guid("376764fa-28ec-4a08-80e3-a6ab407e8601"), new Guid("bf38a1b9-dee3-455a-87c1-4e034fe806f7") },
                    { new Guid("4de4f55b-db6f-4789-a182-01e7e3402367"), new DateTime(2025, 1, 23, 21, 6, 59, 524, DateTimeKind.Local).AddTicks(7477), new Guid("540f318e-b42f-4485-9e60-8faa5bf80962"), new Guid("2a13fe71-f3b5-4f40-b9ac-69e207365ab9"), new DateTime(2024, 10, 23, 21, 6, 59, 524, DateTimeKind.Local).AddTicks(7507), null, "Develop and maintain web applications.", 10, new Guid("bc4ecf1e-8841-47f2-86ec-b0c523f03da1"), new Guid("79685cdb-be26-49cc-b7f9-1fb51686f5ba"), 35, 21, 1, 80000.0, 1, "Software Engineer", new DateTime(2024, 10, 23, 21, 6, 59, 524, DateTimeKind.Local).AddTicks(7508), null, new Guid("04a9de34-0869-41b2-87a8-63c20c4ba22a"), new Guid("67db1aef-c1b1-4424-8313-774a5dccdb9d") },
                    { new Guid("67b425cb-39ab-4bfe-b222-b76430064590"), new DateTime(2025, 2, 23, 21, 6, 59, 524, DateTimeKind.Local).AddTicks(7523), new Guid("540f318e-b42f-4485-9e60-8faa5bf80962"), new Guid("1b93b95c-8203-4105-9ab1-f0fa303ef2ad"), new DateTime(2024, 10, 23, 21, 6, 59, 524, DateTimeKind.Local).AddTicks(7528), null, "Oversee product development lifecycle.", 20, new Guid("a3fb036a-04fc-4590-b87d-6ed32e2ec692"), new Guid("12497687-64b8-4d8e-814a-b7d1d33d3aab"), 45, 28, 3, 95000.0, 1, "Product Manager", new DateTime(2024, 10, 23, 21, 6, 59, 524, DateTimeKind.Local).AddTicks(7528), null, new Guid("c199da74-c2fb-4381-b093-cf2f1e3e8f06"), new Guid("646ccd9f-aa2f-413e-8d3e-eb8ab0b14c96") },
                    { new Guid("d802b669-34bf-4b9d-9163-c955fc827729"), new DateTime(2025, 1, 23, 21, 6, 59, 524, DateTimeKind.Local).AddTicks(7531), new Guid("44b668b2-09ee-499e-af95-73598f9153a2"), new Guid("2a13fe71-f3b5-4f40-b9ac-69e207365ab9"), new DateTime(2024, 10, 23, 21, 6, 59, 524, DateTimeKind.Local).AddTicks(7536), null, "Design intuitive user interfaces.", 25, new Guid("bc4ecf1e-8841-47f2-86ec-b0c523f03da1"), new Guid("79685cdb-be26-49cc-b7f9-1fb51686f5ba"), 38, 24, 4, 70000.0, 1, "UX Designer", new DateTime(2024, 10, 23, 21, 6, 59, 524, DateTimeKind.Local).AddTicks(7536), null, new Guid("04a9de34-0869-41b2-87a8-63c20c4ba22a"), new Guid("cc4121b2-72c2-4226-ad12-24e722b50cc2") }
                });
        }
    }
}
