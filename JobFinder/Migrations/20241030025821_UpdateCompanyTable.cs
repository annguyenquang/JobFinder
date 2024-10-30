using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace JobFinder.Migrations
{
    /// <inheritdoc />
    public partial class UpdateCompanyTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<int>(
                name: "DistrictId",
                table: "Companies",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ProvinceId",
                table: "Companies",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "Email", "Password", "Phone", "UpdatedAt", "UpdatedBy", "Username" },
                values: new object[,]
                {
                    { new Guid("0a904056-86fa-4a12-8f9d-ed5b8885b169"), null, null, "", "$2a$11$CGt/OgR6rEUg3O3umr9Emu8MlfxRHKyWrLMT7dqnu.VpkOQ4gU2Hq", "0123456789", null, null, "account0" },
                    { new Guid("182bb695-6974-486f-9814-884d60ef5796"), null, null, "", "$2a$11$dfxG/ZVZAWe9/EMWg7cyC.YVyoRwQ5TAqoslfGEQG36xZ86GzQmeG", "0183456789", null, null, "account2" },
                    { new Guid("9ff9d02e-dbc3-43fb-8505-af2df5272bf7"), null, null, "", "$2a$11$.cIL3wPJ2Fp8mkD5djCPue3W.vhRVg8V91ULresv32MmHi17zCc6W", "0128456789", null, null, "account3" },
                    { new Guid("bc8d8175-4f7f-4df3-8884-e73cf9e5f806"), null, null, "", "$2a$11$KVJ3hqaB2y68MGgQ8zG8SuNPykgZa1Um961SQ0oo8vzJDtGntcVcC", "0823456789", null, null, "account1" },
                    { new Guid("d89dab75-113f-4473-b9e3-a8e5722b6daa"), null, null, "", "$2a$11$XSzQxsWtMTt0TAl8HM187u62hYlNcsU6pNk83M7RldOAJe728To1O", "0123856789", null, null, "account4" },
                    { new Guid("db4dee3c-ba00-46e7-9ad6-16e6744d2f39"), null, null, "", "$2a$11$O10PD8hAm5V7TMvRJCOgXO/t3nceiTlGEu63IdSxfXZgMj54nWSsa", "113", null, null, "admin" }
                });

            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "Id", "AccountId", "Address", "CreatedAt", "CreatedBy", "DistrictId", "EmailContact", "EmployeeCount", "Industry", "Name", "Nation", "PhoneContact", "ProvinceId", "Slug", "UpdatedAt", "UpdatedBy", "Website" },
                values: new object[,]
                {
                    { new Guid("439702cb-8f30-468c-ae76-142f2de3795f"), new Guid("0a904056-86fa-4a12-8f9d-ed5b8885b169"), "456 Health Blvd", null, null, 0, "info@healthinc.com", 300, "Healthcare", "Health Inc.", "USA", "987654321", 0, "health-inc", null, null, "www.healthinc.com" },
                    { new Guid("f0ddaeaf-5bdf-47fa-9ecf-7f56de756751"), new Guid("db4dee3c-ba00-46e7-9ad6-16e6744d2f39"), "123 Tech Lane", null, null, 0, "info@techcorp.com", 500, "Technology", "Tech Corp", "USA", "123456789", 0, "tech-corp", null, null, "www.techcorp.com" },
                    { new Guid("f1097236-4070-4cb1-acc4-dc6a174b66bb"), new Guid("bc8d8175-4f7f-4df3-8884-e73cf9e5f806"), "45688 London", null, null, 0, "info@AnRe.com", 300, "IT", "An Inc.", "VN", "98765432112", 0, "an-pro-ga", null, null, "www.Anrp.com" }
                });

            migrationBuilder.InsertData(
                table: "Jobs",
                columns: new[] { "Id", "CloseDate", "CommitmentTypeId", "CompanyId", "CreatedAt", "CreatedBy", "Description", "DistrictId", "EducationLevelRequirementId", "GenderRequirementId", "MaxAgeRequirement", "MinAgeRequirement", "ProvinceId", "Salary", "Status", "Title", "UpdatedAt", "UpdatedBy", "WorkArrangementId", "WorkExperienceRequirementId" },
                values: new object[,]
                {
                    { new Guid("0d77bde7-4f3e-40cf-a2b3-1ba013e04784"), new DateTime(2025, 1, 30, 9, 58, 20, 621, DateTimeKind.Local).AddTicks(1953), new Guid("540f318e-b42f-4485-9e60-8faa5bf80962"), new Guid("f0ddaeaf-5bdf-47fa-9ecf-7f56de756751"), new DateTime(2024, 10, 30, 9, 58, 20, 621, DateTimeKind.Local).AddTicks(1995), null, "Develop and maintain web applications.", 10, new Guid("bc4ecf1e-8841-47f2-86ec-b0c523f03da1"), new Guid("79685cdb-be26-49cc-b7f9-1fb51686f5ba"), 35, 21, 1, 80000.0, 1, "Software Engineer", new DateTime(2024, 10, 30, 9, 58, 20, 621, DateTimeKind.Local).AddTicks(2001), null, new Guid("04a9de34-0869-41b2-87a8-63c20c4ba22a"), new Guid("67db1aef-c1b1-4424-8313-774a5dccdb9d") },
                    { new Guid("1e8f4302-e9ef-4b91-810b-f2fb2d8c0614"), new DateTime(2024, 12, 30, 9, 58, 20, 621, DateTimeKind.Local).AddTicks(2006), new Guid("5d06c3b1-2bd1-4c68-96b4-f4cd8c899dff"), new Guid("439702cb-8f30-468c-ae76-142f2de3795f"), new DateTime(2024, 10, 30, 9, 58, 20, 621, DateTimeKind.Local).AddTicks(2012), null, "Analyze large datasets to generate business insights.", 15, new Guid("bc44b9a9-5cd6-4195-a7bd-92b4bef6d8fb"), new Guid("7b5f69cb-5996-4a57-b9c6-9fee2a791bf6"), 40, 23, 2, 60000.0, 1, "Data Analyst", new DateTime(2024, 10, 30, 9, 58, 20, 621, DateTimeKind.Local).AddTicks(2013), null, new Guid("376764fa-28ec-4a08-80e3-a6ab407e8601"), new Guid("bf38a1b9-dee3-455a-87c1-4e034fe806f7") },
                    { new Guid("b7198938-ecef-4395-be03-b288024d67cd"), new DateTime(2025, 1, 30, 9, 58, 20, 621, DateTimeKind.Local).AddTicks(2026), new Guid("44b668b2-09ee-499e-af95-73598f9153a2"), new Guid("f0ddaeaf-5bdf-47fa-9ecf-7f56de756751"), new DateTime(2024, 10, 30, 9, 58, 20, 621, DateTimeKind.Local).AddTicks(2031), null, "Design intuitive user interfaces.", 25, new Guid("bc4ecf1e-8841-47f2-86ec-b0c523f03da1"), new Guid("79685cdb-be26-49cc-b7f9-1fb51686f5ba"), 38, 24, 4, 70000.0, 1, "UX Designer", new DateTime(2024, 10, 30, 9, 58, 20, 621, DateTimeKind.Local).AddTicks(2031), null, new Guid("04a9de34-0869-41b2-87a8-63c20c4ba22a"), new Guid("cc4121b2-72c2-4226-ad12-24e722b50cc2") },
                    { new Guid("c3d96351-3ab0-45ab-b3eb-f30b6d20d494"), new DateTime(2025, 2, 28, 9, 58, 20, 621, DateTimeKind.Local).AddTicks(2018), new Guid("540f318e-b42f-4485-9e60-8faa5bf80962"), new Guid("f1097236-4070-4cb1-acc4-dc6a174b66bb"), new DateTime(2024, 10, 30, 9, 58, 20, 621, DateTimeKind.Local).AddTicks(2023), null, "Oversee product development lifecycle.", 20, new Guid("a3fb036a-04fc-4590-b87d-6ed32e2ec692"), new Guid("12497687-64b8-4d8e-814a-b7d1d33d3aab"), 45, 28, 3, 95000.0, 1, "Product Manager", new DateTime(2024, 10, 30, 9, 58, 20, 621, DateTimeKind.Local).AddTicks(2024), null, new Guid("c199da74-c2fb-4381-b093-cf2f1e3e8f06"), new Guid("646ccd9f-aa2f-413e-8d3e-eb8ab0b14c96") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("182bb695-6974-486f-9814-884d60ef5796"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("9ff9d02e-dbc3-43fb-8505-af2df5272bf7"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("d89dab75-113f-4473-b9e3-a8e5722b6daa"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("0d77bde7-4f3e-40cf-a2b3-1ba013e04784"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("1e8f4302-e9ef-4b91-810b-f2fb2d8c0614"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("b7198938-ecef-4395-be03-b288024d67cd"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("c3d96351-3ab0-45ab-b3eb-f30b6d20d494"));

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: new Guid("439702cb-8f30-468c-ae76-142f2de3795f"));

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: new Guid("f0ddaeaf-5bdf-47fa-9ecf-7f56de756751"));

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: new Guid("f1097236-4070-4cb1-acc4-dc6a174b66bb"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("0a904056-86fa-4a12-8f9d-ed5b8885b169"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("bc8d8175-4f7f-4df3-8884-e73cf9e5f806"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("db4dee3c-ba00-46e7-9ad6-16e6744d2f39"));

            migrationBuilder.DropColumn(
                name: "DistrictId",
                table: "Companies");

            migrationBuilder.DropColumn(
                name: "ProvinceId",
                table: "Companies");

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
    }
}
