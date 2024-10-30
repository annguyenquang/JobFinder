using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace JobFinder.Migrations
{
    /// <inheritdoc />
    public partial class UpdateFixedId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { new Guid("4b28785a-e6d8-4bde-bc61-4fcd3c7edcb9"), null, null, "", "$2a$11$IZZ6xdXFo09DOlqjYY.bUOcyYxuEk54S6gpROHmYnE3V9OYN43Eae", "0823456789", null, null, "account1" },
                    { new Guid("509c3115-d035-4911-8e1c-a2b46c7a0e6b"), null, null, "", "$2a$11$w/2YhULUMNYfi.BlWIuFTOSv6ngt19dS7EeYkyCSmk5rV3cM9uCYS", "0123456789", null, null, "account0" },
                    { new Guid("5ecd2d42-4b0e-43a1-9406-961552ca3e87"), null, null, "", "$2a$11$hikE.93/ueqzkLgEmg/ZqecSBLDdjFFoAOst74hFbVusInqaD0Zsu", "113", null, null, "admin" },
                    { new Guid("ab9af358-61ce-453e-96eb-23eff22e0c3b"), null, null, "", "$2a$11$IR24pQlXvPNndxyST6tbTumFqbv2hB65pyyJiJKEHOIID4G13neLa", "0183456789", null, null, "account2" },
                    { new Guid("af42a5ad-c0a8-4e72-9f30-88df3c1fa9d4"), null, null, "", "$2a$11$xoYhWtwccyzdujgeI/bUXearKO.hApx7A5sSVAdcKxs.LN1f54VIe", "0128456789", null, null, "account3" },
                    { new Guid("c3d3aa6b-ac70-4aa9-a8c2-88b3e0581d87"), null, null, "", "$2a$11$C1d.rvknxJMAETBUHl.PK.DsvY5hiTUzPSR43mcBG4sJW0YM17udq", "0123856789", null, null, "account4" }
                });

            migrationBuilder.UpdateData(
                table: "Metadatas",
                keyColumn: "Id",
                keyValue: new Guid("540f318e-b42f-4485-9e60-8faa5bf80962"),
                column: "Value",
                value: "{\"data\": \"FullTime\"}");

            migrationBuilder.UpdateData(
                table: "Metadatas",
                keyColumn: "Id",
                keyValue: new Guid("fbce1042-bce0-47a3-92cc-54e3b86eb570"),
                column: "Value",
                value: "{\"data\": \"FreshGraduate\"}");

            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "Id", "AccountId", "Address", "CreatedAt", "CreatedBy", "Description", "DistrictId", "EmailContact", "EmployeeCount", "Industry", "Logo", "Name", "PhoneContact", "ProvinceId", "Slug", "UpdatedAt", "UpdatedBy", "Website" },
                values: new object[,]
                {
                    { new Guid("4b28785a-e6d8-4bde-bc61-4fcd3c7edcb9"), new Guid("5ecd2d42-4b0e-43a1-9406-961552ca3e87"), "123 Tech Lane", null, null, "Tech Corp is a tech corp company.", 0, "info@techcorp.com", 500, "Technology", "https://images-platform.99static.com/7v8-fjWpezqDYFTxbYGvEE3gnw8=/191x0:1338x1147/500x500/top/smart/99designs-contests-attachments/60/60612/attachment_60612660", "Tech Corp", "123456789", 0, "tech-corp", null, null, "www.techcorp.com" },
                    { new Guid("ab9af358-61ce-453e-96eb-23eff22e0c3b"), new Guid("4b28785a-e6d8-4bde-bc61-4fcd3c7edcb9"), "45688 London", null, null, "An Inc. is a an incident company.", 0, "info@AnRe.com", 300, "IT", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRsowdkWEAhFe0idqRamO_CAvGutpD1CHKpcA&s", "An Inc.", "98765432112", 0, "an-pro-ga", null, null, "www.Anrp.com" },
                    { new Guid("ec7d72b6-e9f4-4c85-bc12-c2db31d5efa7"), new Guid("509c3115-d035-4911-8e1c-a2b46c7a0e6b"), "456 Health Blvd", null, null, "Health Inc. is a health corp company.", 0, "info@healthinc.com", 300, "Healthcare", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRyD1QcAiMJyNvRptFkjJXovZouhRkTEMlazQ&s", "Health Inc.", "987654321", 0, "health-inc", null, null, "www.healthinc.com" }
                });

            migrationBuilder.InsertData(
                table: "Jobs",
                columns: new[] { "Id", "CloseDate", "CommitmentTypeId", "CompanyId", "CreatedAt", "CreatedBy", "Description", "DistrictId", "EducationLevelRequirementId", "GenderRequirementId", "MaxAgeRequirement", "MinAgeRequirement", "ProvinceId", "Salary", "Status", "Title", "UpdatedAt", "UpdatedBy", "WorkArrangementId", "WorkExperienceRequirementId" },
                values: new object[,]
                {
                    { new Guid("9127e8f9-a91c-4dca-8008-3cb7a8dcfb22"), new DateTime(2024, 12, 30, 23, 32, 11, 311, DateTimeKind.Local).AddTicks(181), new Guid("5d06c3b1-2bd1-4c68-96b4-f4cd8c899dff"), new Guid("ec7d72b6-e9f4-4c85-bc12-c2db31d5efa7"), new DateTime(2024, 10, 30, 23, 32, 11, 311, DateTimeKind.Local).AddTicks(191), null, "Analyze large datasets to generate business insights.", 15, new Guid("bc44b9a9-5cd6-4195-a7bd-92b4bef6d8fb"), new Guid("7b5f69cb-5996-4a57-b9c6-9fee2a791bf6"), 40, 23, 2, 60000.0, 1, "Data Analyst", new DateTime(2024, 10, 30, 23, 32, 11, 311, DateTimeKind.Local).AddTicks(192), null, new Guid("376764fa-28ec-4a08-80e3-a6ab407e8601"), new Guid("bf38a1b9-dee3-455a-87c1-4e034fe806f7") },
                    { new Guid("c3d3aa6b-ac70-4aa9-a8c2-88b3e0581d87"), new DateTime(2025, 1, 30, 23, 32, 11, 311, DateTimeKind.Local).AddTicks(146), new Guid("540f318e-b42f-4485-9e60-8faa5bf80962"), new Guid("4b28785a-e6d8-4bde-bc61-4fcd3c7edcb9"), new DateTime(2024, 10, 30, 23, 32, 11, 311, DateTimeKind.Local).AddTicks(175), null, "Develop and maintain web applications.", 10, new Guid("bc4ecf1e-8841-47f2-86ec-b0c523f03da1"), new Guid("79685cdb-be26-49cc-b7f9-1fb51686f5ba"), 35, 21, 1, 80000.0, 1, "Software Engineer", new DateTime(2024, 10, 30, 23, 32, 11, 311, DateTimeKind.Local).AddTicks(176), null, new Guid("04a9de34-0869-41b2-87a8-63c20c4ba22a"), new Guid("67db1aef-c1b1-4424-8313-774a5dccdb9d") },
                    { new Guid("ca01ec6a-8d39-4e00-ab98-6c3f9a2e0b1e"), new DateTime(2025, 1, 30, 23, 32, 11, 311, DateTimeKind.Local).AddTicks(226), new Guid("44b668b2-09ee-499e-af95-73598f9153a2"), new Guid("4b28785a-e6d8-4bde-bc61-4fcd3c7edcb9"), new DateTime(2024, 10, 30, 23, 32, 11, 311, DateTimeKind.Local).AddTicks(231), null, "Design intuitive user interfaces.", 25, new Guid("bc4ecf1e-8841-47f2-86ec-b0c523f03da1"), new Guid("79685cdb-be26-49cc-b7f9-1fb51686f5ba"), 38, 24, 4, 70000.0, 1, "UX Designer", new DateTime(2024, 10, 30, 23, 32, 11, 311, DateTimeKind.Local).AddTicks(231), null, new Guid("04a9de34-0869-41b2-87a8-63c20c4ba22a"), new Guid("cc4121b2-72c2-4226-ad12-24e722b50cc2") },
                    { new Guid("def969c3-e7ad-4f71-9907-2c0d594d3ecb"), new DateTime(2025, 2, 28, 23, 32, 11, 311, DateTimeKind.Local).AddTicks(195), new Guid("540f318e-b42f-4485-9e60-8faa5bf80962"), new Guid("ab9af358-61ce-453e-96eb-23eff22e0c3b"), new DateTime(2024, 10, 30, 23, 32, 11, 311, DateTimeKind.Local).AddTicks(199), null, "Oversee product development lifecycle.", 20, new Guid("a3fb036a-04fc-4590-b87d-6ed32e2ec692"), new Guid("12497687-64b8-4d8e-814a-b7d1d33d3aab"), 45, 28, 3, 95000.0, 1, "Product Manager", new DateTime(2024, 10, 30, 23, 32, 11, 311, DateTimeKind.Local).AddTicks(200), null, new Guid("c199da74-c2fb-4381-b093-cf2f1e3e8f06"), new Guid("646ccd9f-aa2f-413e-8d3e-eb8ab0b14c96") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("ab9af358-61ce-453e-96eb-23eff22e0c3b"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("af42a5ad-c0a8-4e72-9f30-88df3c1fa9d4"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("c3d3aa6b-ac70-4aa9-a8c2-88b3e0581d87"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("9127e8f9-a91c-4dca-8008-3cb7a8dcfb22"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("c3d3aa6b-ac70-4aa9-a8c2-88b3e0581d87"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("ca01ec6a-8d39-4e00-ab98-6c3f9a2e0b1e"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("def969c3-e7ad-4f71-9907-2c0d594d3ecb"));

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: new Guid("4b28785a-e6d8-4bde-bc61-4fcd3c7edcb9"));

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: new Guid("ab9af358-61ce-453e-96eb-23eff22e0c3b"));

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: new Guid("ec7d72b6-e9f4-4c85-bc12-c2db31d5efa7"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("4b28785a-e6d8-4bde-bc61-4fcd3c7edcb9"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("509c3115-d035-4911-8e1c-a2b46c7a0e6b"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("5ecd2d42-4b0e-43a1-9406-961552ca3e87"));

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
                keyValue: new Guid("540f318e-b42f-4485-9e60-8faa5bf80962"),
                column: "Value",
                value: "{\"data\": \"Fulltime\"}");

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
    }
}
