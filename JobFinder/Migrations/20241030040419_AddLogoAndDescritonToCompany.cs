using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace JobFinder.Migrations
{
    /// <inheritdoc />
    public partial class AddLogoAndDescritonToCompany : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Companies",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Logo",
                table: "Companies",
                type: "nvarchar(max)",
                nullable: true);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Companies");

            migrationBuilder.DropColumn(
                name: "Logo",
                table: "Companies");

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
    }
}
