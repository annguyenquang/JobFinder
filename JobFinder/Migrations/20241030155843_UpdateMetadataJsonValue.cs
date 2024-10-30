using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace JobFinder.Migrations
{
    /// <inheritdoc />
    public partial class UpdateMetadataJsonValue : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("2084431c-0dcd-4394-95df-4cbca139cdd0"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("41c60b57-5374-41a9-a1ee-6cd52d798479"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("f7eaeb61-4347-40d6-bcac-d8566f010e3b"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("0eb8641e-99cf-427a-9088-a6006fc3a095"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("605420b5-e0a3-4b5c-a4de-22972c848625"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("9d02e989-f879-489a-87e2-fd844a874134"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("ba81cfe8-ceea-4a42-a4bd-073a3cc6a0b8"));

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: new Guid("3341c9fe-3d9e-490a-9be0-7a3bd2daf0e5"));

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: new Guid("c9f35421-51b8-4d3e-9dd2-671af01f04bf"));

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: new Guid("fe57b774-4c2e-48dd-bd67-5982398ee24d"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("4eb3aa31-74cd-4161-92f0-cbd6920bbc29"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("bd8ef476-446a-4637-8a5c-ed6f88a93cb2"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("c0cc30cf-d777-4046-98d1-b15cca43b8e3"));

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "Email", "Password", "Phone", "UpdatedAt", "UpdatedBy", "Username" },
                values: new object[,]
                {
                    { new Guid("1fbc0766-5439-42c9-9bc9-863ac21687d8"), null, null, "", "$2a$11$pZwTZVlg/JaMhgCiDqEeH.qx51jdZJoESfzrU0XxAXEV7R8wFEabC", "0183456789", null, null, "account2" },
                    { new Guid("898a181d-26c4-4ef3-991b-9b3599eeada5"), null, null, "", "$2a$11$knY14bfKzEJOlPLldGKT.O3.AXWyFEMna8vb1M.DUw2Pw3MdWkrBO", "0123856789", null, null, "account4" },
                    { new Guid("8c09a4ae-98b3-452c-8ba2-5e34ab3fd749"), null, null, "", "$2a$11$.x9JwCNh/nD/i4RZN8j2lelJtYFU4z4c/oDaVVe.yXHVBFtpJ7PUO", "0823456789", null, null, "account1" },
                    { new Guid("a93d2cb5-5444-4b2f-8180-08f683fc9fcb"), null, null, "", "$2a$11$gfgrGD4PiEfa851K3nW6lO2IEXmQMexSPHphyD/dpCtIeWPec/EYu", "0123456789", null, null, "account0" },
                    { new Guid("dfeee51f-90d7-47b1-b3d6-4d4aa5c6903b"), null, null, "", "$2a$11$6UR3WSl9mVIGh0NiuTXv6ufyerJcvhNi.EecBc4UYOgdBDRG3GbSK", "113", null, null, "admin" },
                    { new Guid("ea182cf7-5033-41fb-9a0b-2cc2256cbafe"), null, null, "", "$2a$11$UMXPgSohYtpUrOC3Hzoo9unwQCiBH1FAptyfz1IfrxqUBYg6rMOb6", "0128456789", null, null, "account3" }
                });

            migrationBuilder.UpdateData(
                table: "Metadatas",
                keyColumn: "Id",
                keyValue: new Guid("04a9de34-0869-41b2-87a8-63c20c4ba22a"),
                column: "Value",
                value: "{\"data\": \"Onsite\"}");

            migrationBuilder.UpdateData(
                table: "Metadatas",
                keyColumn: "Id",
                keyValue: new Guid("12497687-64b8-4d8e-814a-b7d1d33d3aab"),
                column: "Value",
                value: "{\"data\": \"Others\"}");

            migrationBuilder.UpdateData(
                table: "Metadatas",
                keyColumn: "Id",
                keyValue: new Guid("26a49bd7-ad8c-40be-8e7c-dd903f7a653e"),
                column: "Value",
                value: "{\"data\": \"Freelance\"}");

            migrationBuilder.UpdateData(
                table: "Metadatas",
                keyColumn: "Id",
                keyValue: new Guid("376764fa-28ec-4a08-80e3-a6ab407e8601"),
                column: "Value",
                value: "{\"data\": \"Remote/WFH\"}");

            migrationBuilder.UpdateData(
                table: "Metadatas",
                keyColumn: "Id",
                keyValue: new Guid("3fbef738-ed16-4778-8463-8390444841de"),
                column: "Value",
                value: "{\"data\": \"Internship\"}");

            migrationBuilder.UpdateData(
                table: "Metadatas",
                keyColumn: "Id",
                keyValue: new Guid("44b668b2-09ee-499e-af95-73598f9153a2"),
                column: "Value",
                value: "{\"data\": \"Contract\"}");

            migrationBuilder.UpdateData(
                table: "Metadatas",
                keyColumn: "Id",
                keyValue: new Guid("4a3e2365-47f4-45d9-b1d4-326d9f2f3203"),
                column: "Value",
                value: "{\"data\": \"LessThanOneYear\"}");

            migrationBuilder.UpdateData(
                table: "Metadatas",
                keyColumn: "Id",
                keyValue: new Guid("52e22ea6-7f97-4816-b64a-bfd4aa21cd74"),
                column: "Value",
                value: "{\"data\": \"SeniorOrVocationalHighSchool\"}");

            migrationBuilder.UpdateData(
                table: "Metadatas",
                keyColumn: "Id",
                keyValue: new Guid("540f318e-b42f-4485-9e60-8faa5bf80962"),
                column: "Value",
                value: "{\"data\": \"Fulltime\"}");

            migrationBuilder.UpdateData(
                table: "Metadatas",
                keyColumn: "Id",
                keyValue: new Guid("5d06c3b1-2bd1-4c68-96b4-f4cd8c899dff"),
                column: "Value",
                value: "{\"data\": \"PartTime\"}");

            migrationBuilder.UpdateData(
                table: "Metadatas",
                keyColumn: "Id",
                keyValue: new Guid("646ccd9f-aa2f-413e-8d3e-eb8ab0b14c96"),
                column: "Value",
                value: "{\"data\": \"MoreThanTenYears\"}");

            migrationBuilder.UpdateData(
                table: "Metadatas",
                keyColumn: "Id",
                keyValue: new Guid("67db1aef-c1b1-4424-8313-774a5dccdb9d"),
                column: "Value",
                value: "{\"data\": \"ThreeToFiveYears\"}");

            migrationBuilder.UpdateData(
                table: "Metadatas",
                keyColumn: "Id",
                keyValue: new Guid("79685cdb-be26-49cc-b7f9-1fb51686f5ba"),
                column: "Value",
                value: "{\"data\": \"Male\"}");

            migrationBuilder.UpdateData(
                table: "Metadatas",
                keyColumn: "Id",
                keyValue: new Guid("7b5f69cb-5996-4a57-b9c6-9fee2a791bf6"),
                column: "Value",
                value: "{\"data\": \"Female\"}");

            migrationBuilder.UpdateData(
                table: "Metadatas",
                keyColumn: "Id",
                keyValue: new Guid("853384de-154c-4187-bf5d-aa684b85736d"),
                column: "Value",
                value: "{\"data\": \"Doctorate\"}");

            migrationBuilder.UpdateData(
                table: "Metadatas",
                keyColumn: "Id",
                keyValue: new Guid("96279c48-1bfe-441d-992e-db86cb3bf315"),
                column: "Value",
                value: "{\"data\": \"Daily\"}");

            migrationBuilder.UpdateData(
                table: "Metadatas",
                keyColumn: "Id",
                keyValue: new Guid("a3fb036a-04fc-4590-b87d-6ed32e2ec692"),
                column: "Value",
                value: "{\"data\": \"CollegeDegree\"}");

            migrationBuilder.UpdateData(
                table: "Metadatas",
                keyColumn: "Id",
                keyValue: new Guid("bc44b9a9-5cd6-4195-a7bd-92b4bef6d8fb"),
                column: "Value",
                value: "{\"data\": \"MasterDegree\"}");

            migrationBuilder.UpdateData(
                table: "Metadatas",
                keyColumn: "Id",
                keyValue: new Guid("bc4ecf1e-8841-47f2-86ec-b0c523f03da1"),
                column: "Value",
                value: "{\"data\": \"BachelorDegree\"}");

            migrationBuilder.UpdateData(
                table: "Metadatas",
                keyColumn: "Id",
                keyValue: new Guid("bf38a1b9-dee3-455a-87c1-4e034fe806f7"),
                column: "Value",
                value: "{\"data\": \"FiveToTenYears\"}");

            migrationBuilder.UpdateData(
                table: "Metadatas",
                keyColumn: "Id",
                keyValue: new Guid("c199da74-c2fb-4381-b093-cf2f1e3e8f06"),
                column: "Value",
                value: "{\"data\": \"Hybrid\"}");

            migrationBuilder.UpdateData(
                table: "Metadatas",
                keyColumn: "Id",
                keyValue: new Guid("c9d2f457-06bf-40ad-9a4a-d6e201888129"),
                column: "Value",
                value: "{\"data\": \"SecondarySchool\"}");

            migrationBuilder.UpdateData(
                table: "Metadatas",
                keyColumn: "Id",
                keyValue: new Guid("cc4121b2-72c2-4226-ad12-24e722b50cc2"),
                column: "Value",
                value: "{\"data\": \"OneToThreeYears\"}");

            migrationBuilder.UpdateData(
                table: "Metadatas",
                keyColumn: "Id",
                keyValue: new Guid("ceb115a0-3ffe-455c-b24e-9eff074e1ec1"),
                column: "Value",
                value: "{\"data\": \"PrimarySchool\"}");

            migrationBuilder.UpdateData(
                table: "Metadatas",
                keyColumn: "Id",
                keyValue: new Guid("ebb6a034-ce37-41a4-b1f6-c70f1698c4f2"),
                column: "Value",
                value: "{\"data\": \"Diploma\"}");

            migrationBuilder.UpdateData(
                table: "Metadatas",
                keyColumn: "Id",
                keyValue: new Guid("fbce1042-bce0-47a3-92cc-54e3b86eb570"),
                column: "Value",
                value: "{\"data\": \"FreshGradute\"}");

            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "Id", "AccountId", "Address", "CreatedAt", "CreatedBy", "Description", "DistrictId", "EmailContact", "EmployeeCount", "Industry", "Logo", "Name", "PhoneContact", "ProvinceId", "Slug", "UpdatedAt", "UpdatedBy", "Website" },
                values: new object[,]
                {
                    { new Guid("2a2fb0b3-84ac-46ac-bb7c-89c139f81281"), new Guid("a93d2cb5-5444-4b2f-8180-08f683fc9fcb"), "456 Health Blvd", null, null, "Health Inc. is a health corp company.", 0, "info@healthinc.com", 300, "Healthcare", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRyD1QcAiMJyNvRptFkjJXovZouhRkTEMlazQ&s", "Health Inc.", "987654321", 0, "health-inc", null, null, "www.healthinc.com" },
                    { new Guid("985c3f62-645e-4171-b097-da3f5bbe3c42"), new Guid("dfeee51f-90d7-47b1-b3d6-4d4aa5c6903b"), "123 Tech Lane", null, null, "Tech Corp is a tech corp company.", 0, "info@techcorp.com", 500, "Technology", "https://images-platform.99static.com/7v8-fjWpezqDYFTxbYGvEE3gnw8=/191x0:1338x1147/500x500/top/smart/99designs-contests-attachments/60/60612/attachment_60612660", "Tech Corp", "123456789", 0, "tech-corp", null, null, "www.techcorp.com" },
                    { new Guid("acd990cd-24bd-468e-9ff9-6c941fd3e4f8"), new Guid("8c09a4ae-98b3-452c-8ba2-5e34ab3fd749"), "45688 London", null, null, "An Inc. is a an incident company.", 0, "info@AnRe.com", 300, "IT", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRsowdkWEAhFe0idqRamO_CAvGutpD1CHKpcA&s", "An Inc.", "98765432112", 0, "an-pro-ga", null, null, "www.Anrp.com" }
                });

            migrationBuilder.InsertData(
                table: "Jobs",
                columns: new[] { "Id", "CloseDate", "CommitmentTypeId", "CompanyId", "CreatedAt", "CreatedBy", "Description", "DistrictId", "EducationLevelRequirementId", "GenderRequirementId", "MaxAgeRequirement", "MinAgeRequirement", "ProvinceId", "Salary", "Status", "Title", "UpdatedAt", "UpdatedBy", "WorkArrangementId", "WorkExperienceRequirementId" },
                values: new object[,]
                {
                    { new Guid("0f4e349c-e916-4d61-ba76-67381dc76f4e"), new DateTime(2025, 1, 30, 22, 58, 42, 654, DateTimeKind.Local).AddTicks(1091), new Guid("44b668b2-09ee-499e-af95-73598f9153a2"), new Guid("985c3f62-645e-4171-b097-da3f5bbe3c42"), new DateTime(2024, 10, 30, 22, 58, 42, 654, DateTimeKind.Local).AddTicks(1095), null, "Design intuitive user interfaces.", 25, new Guid("bc4ecf1e-8841-47f2-86ec-b0c523f03da1"), new Guid("79685cdb-be26-49cc-b7f9-1fb51686f5ba"), 38, 24, 4, 70000.0, 1, "UX Designer", new DateTime(2024, 10, 30, 22, 58, 42, 654, DateTimeKind.Local).AddTicks(1096), null, new Guid("04a9de34-0869-41b2-87a8-63c20c4ba22a"), new Guid("cc4121b2-72c2-4226-ad12-24e722b50cc2") },
                    { new Guid("548ecb2c-180c-4376-8727-dc121ea4bcc8"), new DateTime(2025, 1, 30, 22, 58, 42, 654, DateTimeKind.Local).AddTicks(1029), new Guid("540f318e-b42f-4485-9e60-8faa5bf80962"), new Guid("985c3f62-645e-4171-b097-da3f5bbe3c42"), new DateTime(2024, 10, 30, 22, 58, 42, 654, DateTimeKind.Local).AddTicks(1062), null, "Develop and maintain web applications.", 10, new Guid("bc4ecf1e-8841-47f2-86ec-b0c523f03da1"), new Guid("79685cdb-be26-49cc-b7f9-1fb51686f5ba"), 35, 21, 1, 80000.0, 1, "Software Engineer", new DateTime(2024, 10, 30, 22, 58, 42, 654, DateTimeKind.Local).AddTicks(1063), null, new Guid("04a9de34-0869-41b2-87a8-63c20c4ba22a"), new Guid("67db1aef-c1b1-4424-8313-774a5dccdb9d") },
                    { new Guid("9fbd4482-15d5-4005-a829-716a94a92e79"), new DateTime(2025, 2, 28, 22, 58, 42, 654, DateTimeKind.Local).AddTicks(1076), new Guid("540f318e-b42f-4485-9e60-8faa5bf80962"), new Guid("acd990cd-24bd-468e-9ff9-6c941fd3e4f8"), new DateTime(2024, 10, 30, 22, 58, 42, 654, DateTimeKind.Local).AddTicks(1081), null, "Oversee product development lifecycle.", 20, new Guid("a3fb036a-04fc-4590-b87d-6ed32e2ec692"), new Guid("12497687-64b8-4d8e-814a-b7d1d33d3aab"), 45, 28, 3, 95000.0, 1, "Product Manager", new DateTime(2024, 10, 30, 22, 58, 42, 654, DateTimeKind.Local).AddTicks(1082), null, new Guid("c199da74-c2fb-4381-b093-cf2f1e3e8f06"), new Guid("646ccd9f-aa2f-413e-8d3e-eb8ab0b14c96") },
                    { new Guid("c0dd1f0e-ae29-4015-8e0b-d39feece8a95"), new DateTime(2024, 12, 30, 22, 58, 42, 654, DateTimeKind.Local).AddTicks(1067), new Guid("5d06c3b1-2bd1-4c68-96b4-f4cd8c899dff"), new Guid("2a2fb0b3-84ac-46ac-bb7c-89c139f81281"), new DateTime(2024, 10, 30, 22, 58, 42, 654, DateTimeKind.Local).AddTicks(1073), null, "Analyze large datasets to generate business insights.", 15, new Guid("bc44b9a9-5cd6-4195-a7bd-92b4bef6d8fb"), new Guid("7b5f69cb-5996-4a57-b9c6-9fee2a791bf6"), 40, 23, 2, 60000.0, 1, "Data Analyst", new DateTime(2024, 10, 30, 22, 58, 42, 654, DateTimeKind.Local).AddTicks(1073), null, new Guid("376764fa-28ec-4a08-80e3-a6ab407e8601"), new Guid("bf38a1b9-dee3-455a-87c1-4e034fe806f7") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("1fbc0766-5439-42c9-9bc9-863ac21687d8"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("898a181d-26c4-4ef3-991b-9b3599eeada5"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("ea182cf7-5033-41fb-9a0b-2cc2256cbafe"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("0f4e349c-e916-4d61-ba76-67381dc76f4e"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("548ecb2c-180c-4376-8727-dc121ea4bcc8"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("9fbd4482-15d5-4005-a829-716a94a92e79"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("c0dd1f0e-ae29-4015-8e0b-d39feece8a95"));

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: new Guid("2a2fb0b3-84ac-46ac-bb7c-89c139f81281"));

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: new Guid("985c3f62-645e-4171-b097-da3f5bbe3c42"));

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: new Guid("acd990cd-24bd-468e-9ff9-6c941fd3e4f8"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("8c09a4ae-98b3-452c-8ba2-5e34ab3fd749"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("a93d2cb5-5444-4b2f-8180-08f683fc9fcb"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("dfeee51f-90d7-47b1-b3d6-4d4aa5c6903b"));

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "Email", "Password", "Phone", "UpdatedAt", "UpdatedBy", "Username" },
                values: new object[,]
                {
                    { new Guid("2084431c-0dcd-4394-95df-4cbca139cdd0"), null, null, "", "$2a$11$9LSoHQJNMlW0UO47hWwY6.u1FZjOED1yUZGAAfFEaTLuKbKvgwW6C", "0183456789", null, null, "account2" },
                    { new Guid("41c60b57-5374-41a9-a1ee-6cd52d798479"), null, null, "", "$2a$11$Wn.7fjL2ICAD/dc1LRTXX.7sG/KGOzjZSsYizVMvFh5jLkCc0qhB.", "0123856789", null, null, "account4" },
                    { new Guid("4eb3aa31-74cd-4161-92f0-cbd6920bbc29"), null, null, "", "$2a$11$PmqaxK8vsPrESzr1MIIQyenCESmwSbhmOT1nS0e0HAUmQcN4sOUmq", "0123456789", null, null, "account0" },
                    { new Guid("bd8ef476-446a-4637-8a5c-ed6f88a93cb2"), null, null, "", "$2a$11$LBYX.zc7WJjtjWxnn4Vs2eKQd9vZ/oxLLUzAM5ATRUf8FZz4ehODe", "113", null, null, "admin" },
                    { new Guid("c0cc30cf-d777-4046-98d1-b15cca43b8e3"), null, null, "", "$2a$11$DmGGbgaEyO3.uqUNnBQa4.5G6VDnp3AmPsr/R9B87wfoiq/RlMZsy", "0823456789", null, null, "account1" },
                    { new Guid("f7eaeb61-4347-40d6-bcac-d8566f010e3b"), null, null, "", "$2a$11$CptGBo2VmlfHjfpQJgSGvuBwGD/ysT/1TTEDyGXAf7r7n.YRjV5Na", "0128456789", null, null, "account3" }
                });

            migrationBuilder.UpdateData(
                table: "Metadatas",
                keyColumn: "Id",
                keyValue: new Guid("04a9de34-0869-41b2-87a8-63c20c4ba22a"),
                column: "Value",
                value: "{\"data\"}: \"Onsite\"}");

            migrationBuilder.UpdateData(
                table: "Metadatas",
                keyColumn: "Id",
                keyValue: new Guid("12497687-64b8-4d8e-814a-b7d1d33d3aab"),
                column: "Value",
                value: "{\"data\"}: \"Others\"}");

            migrationBuilder.UpdateData(
                table: "Metadatas",
                keyColumn: "Id",
                keyValue: new Guid("26a49bd7-ad8c-40be-8e7c-dd903f7a653e"),
                column: "Value",
                value: "{\"data\"}: \"Freelance\"}");

            migrationBuilder.UpdateData(
                table: "Metadatas",
                keyColumn: "Id",
                keyValue: new Guid("376764fa-28ec-4a08-80e3-a6ab407e8601"),
                column: "Value",
                value: "{\"data\"}: \"Remote/WFH\"}");

            migrationBuilder.UpdateData(
                table: "Metadatas",
                keyColumn: "Id",
                keyValue: new Guid("3fbef738-ed16-4778-8463-8390444841de"),
                column: "Value",
                value: "{\"data\"}: \"Internship\"}");

            migrationBuilder.UpdateData(
                table: "Metadatas",
                keyColumn: "Id",
                keyValue: new Guid("44b668b2-09ee-499e-af95-73598f9153a2"),
                column: "Value",
                value: "{\"data\"}: \"Contract\"}");

            migrationBuilder.UpdateData(
                table: "Metadatas",
                keyColumn: "Id",
                keyValue: new Guid("4a3e2365-47f4-45d9-b1d4-326d9f2f3203"),
                column: "Value",
                value: "{\"data\"}: \"LessThanOneYear\"}");

            migrationBuilder.UpdateData(
                table: "Metadatas",
                keyColumn: "Id",
                keyValue: new Guid("52e22ea6-7f97-4816-b64a-bfd4aa21cd74"),
                column: "Value",
                value: "{\"data\"}: \"SeniorOrVocationalHighSchool\"}");

            migrationBuilder.UpdateData(
                table: "Metadatas",
                keyColumn: "Id",
                keyValue: new Guid("540f318e-b42f-4485-9e60-8faa5bf80962"),
                column: "Value",
                value: "{\"data\"}: \"Fulltime\"}");

            migrationBuilder.UpdateData(
                table: "Metadatas",
                keyColumn: "Id",
                keyValue: new Guid("5d06c3b1-2bd1-4c68-96b4-f4cd8c899dff"),
                column: "Value",
                value: "{\"data\"}: \"PartTime\"}");

            migrationBuilder.UpdateData(
                table: "Metadatas",
                keyColumn: "Id",
                keyValue: new Guid("646ccd9f-aa2f-413e-8d3e-eb8ab0b14c96"),
                column: "Value",
                value: "{\"data\"}: \"MoreThanTenYears\"}");

            migrationBuilder.UpdateData(
                table: "Metadatas",
                keyColumn: "Id",
                keyValue: new Guid("67db1aef-c1b1-4424-8313-774a5dccdb9d"),
                column: "Value",
                value: "{\"data\"}: \"ThreeToFiveYears\"}");

            migrationBuilder.UpdateData(
                table: "Metadatas",
                keyColumn: "Id",
                keyValue: new Guid("79685cdb-be26-49cc-b7f9-1fb51686f5ba"),
                column: "Value",
                value: "{\"data\"}: \"Male\"}");

            migrationBuilder.UpdateData(
                table: "Metadatas",
                keyColumn: "Id",
                keyValue: new Guid("7b5f69cb-5996-4a57-b9c6-9fee2a791bf6"),
                column: "Value",
                value: "{\"data\"}: \"Female\"}");

            migrationBuilder.UpdateData(
                table: "Metadatas",
                keyColumn: "Id",
                keyValue: new Guid("853384de-154c-4187-bf5d-aa684b85736d"),
                column: "Value",
                value: "{\"data\"}: \"Doctorate\"}");

            migrationBuilder.UpdateData(
                table: "Metadatas",
                keyColumn: "Id",
                keyValue: new Guid("96279c48-1bfe-441d-992e-db86cb3bf315"),
                column: "Value",
                value: "{\"data\"}: \"Daily\"}");

            migrationBuilder.UpdateData(
                table: "Metadatas",
                keyColumn: "Id",
                keyValue: new Guid("a3fb036a-04fc-4590-b87d-6ed32e2ec692"),
                column: "Value",
                value: "{\"data\"}: \"CollegeDegree\"}");

            migrationBuilder.UpdateData(
                table: "Metadatas",
                keyColumn: "Id",
                keyValue: new Guid("bc44b9a9-5cd6-4195-a7bd-92b4bef6d8fb"),
                column: "Value",
                value: "{\"data\"}: \"MasterDegree\"}");

            migrationBuilder.UpdateData(
                table: "Metadatas",
                keyColumn: "Id",
                keyValue: new Guid("bc4ecf1e-8841-47f2-86ec-b0c523f03da1"),
                column: "Value",
                value: "{\"data\"}: \"BachelorDegree\"}");

            migrationBuilder.UpdateData(
                table: "Metadatas",
                keyColumn: "Id",
                keyValue: new Guid("bf38a1b9-dee3-455a-87c1-4e034fe806f7"),
                column: "Value",
                value: "{\"data\"}: \"FiveToTenYears\"}");

            migrationBuilder.UpdateData(
                table: "Metadatas",
                keyColumn: "Id",
                keyValue: new Guid("c199da74-c2fb-4381-b093-cf2f1e3e8f06"),
                column: "Value",
                value: "{\"data\"}: \"Hybrid\"}");

            migrationBuilder.UpdateData(
                table: "Metadatas",
                keyColumn: "Id",
                keyValue: new Guid("c9d2f457-06bf-40ad-9a4a-d6e201888129"),
                column: "Value",
                value: "{\"data\"}: \"SecondarySchool\"}");

            migrationBuilder.UpdateData(
                table: "Metadatas",
                keyColumn: "Id",
                keyValue: new Guid("cc4121b2-72c2-4226-ad12-24e722b50cc2"),
                column: "Value",
                value: "{\"data\"}: \"OneToThreeYears\"}");

            migrationBuilder.UpdateData(
                table: "Metadatas",
                keyColumn: "Id",
                keyValue: new Guid("ceb115a0-3ffe-455c-b24e-9eff074e1ec1"),
                column: "Value",
                value: "{\"data\"}: \"PrimarySchool\"}");

            migrationBuilder.UpdateData(
                table: "Metadatas",
                keyColumn: "Id",
                keyValue: new Guid("ebb6a034-ce37-41a4-b1f6-c70f1698c4f2"),
                column: "Value",
                value: "{\"data\"}: \"Diploma\"}");

            migrationBuilder.UpdateData(
                table: "Metadatas",
                keyColumn: "Id",
                keyValue: new Guid("fbce1042-bce0-47a3-92cc-54e3b86eb570"),
                column: "Value",
                value: "{\"data\"}: \"FreshGradute\"}");

            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "Id", "AccountId", "Address", "CreatedAt", "CreatedBy", "Description", "DistrictId", "EmailContact", "EmployeeCount", "Industry", "Logo", "Name", "PhoneContact", "ProvinceId", "Slug", "UpdatedAt", "UpdatedBy", "Website" },
                values: new object[,]
                {
                    { new Guid("3341c9fe-3d9e-490a-9be0-7a3bd2daf0e5"), new Guid("c0cc30cf-d777-4046-98d1-b15cca43b8e3"), "45688 London", null, null, "An Inc. is a an incident company.", 0, "info@AnRe.com", 300, "IT", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRsowdkWEAhFe0idqRamO_CAvGutpD1CHKpcA&s", "An Inc.", "98765432112", 0, "an-pro-ga", null, null, "www.Anrp.com" },
                    { new Guid("c9f35421-51b8-4d3e-9dd2-671af01f04bf"), new Guid("bd8ef476-446a-4637-8a5c-ed6f88a93cb2"), "123 Tech Lane", null, null, "Tech Corp is a tech corp company.", 0, "info@techcorp.com", 500, "Technology", "https://images-platform.99static.com/7v8-fjWpezqDYFTxbYGvEE3gnw8=/191x0:1338x1147/500x500/top/smart/99designs-contests-attachments/60/60612/attachment_60612660", "Tech Corp", "123456789", 0, "tech-corp", null, null, "www.techcorp.com" },
                    { new Guid("fe57b774-4c2e-48dd-bd67-5982398ee24d"), new Guid("4eb3aa31-74cd-4161-92f0-cbd6920bbc29"), "456 Health Blvd", null, null, "Health Inc. is a health corp company.", 0, "info@healthinc.com", 300, "Healthcare", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRyD1QcAiMJyNvRptFkjJXovZouhRkTEMlazQ&s", "Health Inc.", "987654321", 0, "health-inc", null, null, "www.healthinc.com" }
                });

            migrationBuilder.InsertData(
                table: "Jobs",
                columns: new[] { "Id", "CloseDate", "CommitmentTypeId", "CompanyId", "CreatedAt", "CreatedBy", "Description", "DistrictId", "EducationLevelRequirementId", "GenderRequirementId", "MaxAgeRequirement", "MinAgeRequirement", "ProvinceId", "Salary", "Status", "Title", "UpdatedAt", "UpdatedBy", "WorkArrangementId", "WorkExperienceRequirementId" },
                values: new object[,]
                {
                    { new Guid("0eb8641e-99cf-427a-9088-a6006fc3a095"), new DateTime(2024, 12, 30, 17, 51, 28, 141, DateTimeKind.Local).AddTicks(3919), new Guid("5d06c3b1-2bd1-4c68-96b4-f4cd8c899dff"), new Guid("fe57b774-4c2e-48dd-bd67-5982398ee24d"), new DateTime(2024, 10, 30, 17, 51, 28, 141, DateTimeKind.Local).AddTicks(3924), null, "Analyze large datasets to generate business insights.", 15, new Guid("bc44b9a9-5cd6-4195-a7bd-92b4bef6d8fb"), new Guid("7b5f69cb-5996-4a57-b9c6-9fee2a791bf6"), 40, 23, 2, 60000.0, 1, "Data Analyst", new DateTime(2024, 10, 30, 17, 51, 28, 141, DateTimeKind.Local).AddTicks(3925), null, new Guid("376764fa-28ec-4a08-80e3-a6ab407e8601"), new Guid("bf38a1b9-dee3-455a-87c1-4e034fe806f7") },
                    { new Guid("605420b5-e0a3-4b5c-a4de-22972c848625"), new DateTime(2025, 2, 28, 17, 51, 28, 141, DateTimeKind.Local).AddTicks(3927), new Guid("540f318e-b42f-4485-9e60-8faa5bf80962"), new Guid("3341c9fe-3d9e-490a-9be0-7a3bd2daf0e5"), new DateTime(2024, 10, 30, 17, 51, 28, 141, DateTimeKind.Local).AddTicks(3934), null, "Oversee product development lifecycle.", 20, new Guid("a3fb036a-04fc-4590-b87d-6ed32e2ec692"), new Guid("12497687-64b8-4d8e-814a-b7d1d33d3aab"), 45, 28, 3, 95000.0, 1, "Product Manager", new DateTime(2024, 10, 30, 17, 51, 28, 141, DateTimeKind.Local).AddTicks(3934), null, new Guid("c199da74-c2fb-4381-b093-cf2f1e3e8f06"), new Guid("646ccd9f-aa2f-413e-8d3e-eb8ab0b14c96") },
                    { new Guid("9d02e989-f879-489a-87e2-fd844a874134"), new DateTime(2025, 1, 30, 17, 51, 28, 141, DateTimeKind.Local).AddTicks(3944), new Guid("44b668b2-09ee-499e-af95-73598f9153a2"), new Guid("c9f35421-51b8-4d3e-9dd2-671af01f04bf"), new DateTime(2024, 10, 30, 17, 51, 28, 141, DateTimeKind.Local).AddTicks(3948), null, "Design intuitive user interfaces.", 25, new Guid("bc4ecf1e-8841-47f2-86ec-b0c523f03da1"), new Guid("79685cdb-be26-49cc-b7f9-1fb51686f5ba"), 38, 24, 4, 70000.0, 1, "UX Designer", new DateTime(2024, 10, 30, 17, 51, 28, 141, DateTimeKind.Local).AddTicks(3949), null, new Guid("04a9de34-0869-41b2-87a8-63c20c4ba22a"), new Guid("cc4121b2-72c2-4226-ad12-24e722b50cc2") },
                    { new Guid("ba81cfe8-ceea-4a42-a4bd-073a3cc6a0b8"), new DateTime(2025, 1, 30, 17, 51, 28, 141, DateTimeKind.Local).AddTicks(3885), new Guid("540f318e-b42f-4485-9e60-8faa5bf80962"), new Guid("c9f35421-51b8-4d3e-9dd2-671af01f04bf"), new DateTime(2024, 10, 30, 17, 51, 28, 141, DateTimeKind.Local).AddTicks(3914), null, "Develop and maintain web applications.", 10, new Guid("bc4ecf1e-8841-47f2-86ec-b0c523f03da1"), new Guid("79685cdb-be26-49cc-b7f9-1fb51686f5ba"), 35, 21, 1, 80000.0, 1, "Software Engineer", new DateTime(2024, 10, 30, 17, 51, 28, 141, DateTimeKind.Local).AddTicks(3915), null, new Guid("04a9de34-0869-41b2-87a8-63c20c4ba22a"), new Guid("67db1aef-c1b1-4424-8313-774a5dccdb9d") }
                });
        }
    }
}
