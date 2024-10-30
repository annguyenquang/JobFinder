using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace JobFinder.Migrations
{
    /// <inheritdoc />
    public partial class MakeSlugNullable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Companies_Slug",
                table: "Companies");

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("24a4e412-7880-45d7-a26f-502e7aaee04f"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("48e90d58-682b-42e9-8e29-a5149a416d32"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("87893976-ffaf-4e0a-bf16-4feacac010a0"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("1d05a525-67a2-4d75-80e8-6c9dd1e939fc"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("2670170e-b1a4-4b05-aefe-384f8dd8f6d5"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("79ea2482-a495-4657-940c-62f0cad9468a"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("e9ba6a33-4f51-4a6d-81c4-9f5d0476f04c"));

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: new Guid("bb6a0c56-37e3-4723-b648-d6e535e0d208"));

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: new Guid("c0b05dd2-104d-4e02-ba1f-61261bca222c"));

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: new Guid("eed26f1d-40b8-4e82-9de0-3af04233db8e"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("3425f2ca-b7c6-4217-b422-a051472fdd58"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("b6b0468b-21d0-4bbe-986c-408c05de9ae3"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("c6260ba8-5d57-4c83-bff0-ea27b2f02631"));

            migrationBuilder.AlterColumn<string>(
                name: "Slug",
                table: "Companies",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

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

            migrationBuilder.CreateIndex(
                name: "IX_Companies_Slug",
                table: "Companies",
                column: "Slug",
                unique: true,
                filter: "[Slug] IS NOT NULL");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Companies_Slug",
                table: "Companies");

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

            migrationBuilder.AlterColumn<string>(
                name: "Slug",
                table: "Companies",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "Email", "Password", "Phone", "UpdatedAt", "UpdatedBy", "Username" },
                values: new object[,]
                {
                    { new Guid("24a4e412-7880-45d7-a26f-502e7aaee04f"), null, null, "", "$2a$11$wMWoYNt51MGuwj6SH1BefOe.g7sXcsXt2.sHsB4KtDeTBFP.nm0tS", "0123856789", null, null, "account4" },
                    { new Guid("3425f2ca-b7c6-4217-b422-a051472fdd58"), null, null, "", "$2a$11$d2zDyPWWVp4b7Pezm94yWeL5C7Kt328QRnCrSPNOn3/xKARnt0lRO", "0123456789", null, null, "account0" },
                    { new Guid("48e90d58-682b-42e9-8e29-a5149a416d32"), null, null, "", "$2a$11$HZ6/pkdjyqLXf8hQllUjtON9M6G0FNaNxJUwQfmGW8PADJEcDGn7.", "0183456789", null, null, "account2" },
                    { new Guid("87893976-ffaf-4e0a-bf16-4feacac010a0"), null, null, "", "$2a$11$ivZF/89H7HwAo2i2/PxQ.e8Ri7LU2FBI1K5rU0QV1kNqIqEw0Lplu", "0128456789", null, null, "account3" },
                    { new Guid("b6b0468b-21d0-4bbe-986c-408c05de9ae3"), null, null, "", "$2a$11$G7cPC2klMACaWmoRo7sNh.j7lTTOc6eajKvyy1qqGSN/XiJrIMpVy", "0823456789", null, null, "account1" },
                    { new Guid("c6260ba8-5d57-4c83-bff0-ea27b2f02631"), null, null, "", "$2a$11$uAEz5YAeJiz5lJUr6HfPEuBBjSCKWYE8N38s8BpS9KqU6wJT91mmi", "113", null, null, "admin" }
                });

            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "Id", "AccountId", "Address", "CreatedAt", "CreatedBy", "Description", "DistrictId", "EmailContact", "EmployeeCount", "Industry", "Logo", "Name", "PhoneContact", "ProvinceId", "Slug", "UpdatedAt", "UpdatedBy", "Website" },
                values: new object[,]
                {
                    { new Guid("bb6a0c56-37e3-4723-b648-d6e535e0d208"), new Guid("b6b0468b-21d0-4bbe-986c-408c05de9ae3"), "45688 London", null, null, "An Inc. is a an incident company.", 0, "info@AnRe.com", 300, "IT", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRsowdkWEAhFe0idqRamO_CAvGutpD1CHKpcA&s", "An Inc.", "98765432112", 0, "an-pro-ga", null, null, "www.Anrp.com" },
                    { new Guid("c0b05dd2-104d-4e02-ba1f-61261bca222c"), new Guid("c6260ba8-5d57-4c83-bff0-ea27b2f02631"), "123 Tech Lane", null, null, "Tech Corp is a tech corp company.", 0, "info@techcorp.com", 500, "Technology", "https://images-platform.99static.com/7v8-fjWpezqDYFTxbYGvEE3gnw8=/191x0:1338x1147/500x500/top/smart/99designs-contests-attachments/60/60612/attachment_60612660", "Tech Corp", "123456789", 0, "tech-corp", null, null, "www.techcorp.com" },
                    { new Guid("eed26f1d-40b8-4e82-9de0-3af04233db8e"), new Guid("3425f2ca-b7c6-4217-b422-a051472fdd58"), "456 Health Blvd", null, null, "Health Inc. is a health corp company.", 0, "info@healthinc.com", 300, "Healthcare", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRyD1QcAiMJyNvRptFkjJXovZouhRkTEMlazQ&s", "Health Inc.", "987654321", 0, "health-inc", null, null, "www.healthinc.com" }
                });

            migrationBuilder.InsertData(
                table: "Jobs",
                columns: new[] { "Id", "CloseDate", "CommitmentTypeId", "CompanyId", "CreatedAt", "CreatedBy", "Description", "DistrictId", "EducationLevelRequirementId", "GenderRequirementId", "MaxAgeRequirement", "MinAgeRequirement", "ProvinceId", "Salary", "Status", "Title", "UpdatedAt", "UpdatedBy", "WorkArrangementId", "WorkExperienceRequirementId" },
                values: new object[,]
                {
                    { new Guid("1d05a525-67a2-4d75-80e8-6c9dd1e939fc"), new DateTime(2024, 12, 30, 11, 26, 11, 833, DateTimeKind.Local).AddTicks(2023), new Guid("5d06c3b1-2bd1-4c68-96b4-f4cd8c899dff"), new Guid("eed26f1d-40b8-4e82-9de0-3af04233db8e"), new DateTime(2024, 10, 30, 11, 26, 11, 833, DateTimeKind.Local).AddTicks(2030), null, "Analyze large datasets to generate business insights.", 15, new Guid("bc44b9a9-5cd6-4195-a7bd-92b4bef6d8fb"), new Guid("7b5f69cb-5996-4a57-b9c6-9fee2a791bf6"), 40, 23, 2, 60000.0, 1, "Data Analyst", new DateTime(2024, 10, 30, 11, 26, 11, 833, DateTimeKind.Local).AddTicks(2031), null, new Guid("376764fa-28ec-4a08-80e3-a6ab407e8601"), new Guid("bf38a1b9-dee3-455a-87c1-4e034fe806f7") },
                    { new Guid("2670170e-b1a4-4b05-aefe-384f8dd8f6d5"), new DateTime(2025, 1, 30, 11, 26, 11, 833, DateTimeKind.Local).AddTicks(2081), new Guid("44b668b2-09ee-499e-af95-73598f9153a2"), new Guid("c0b05dd2-104d-4e02-ba1f-61261bca222c"), new DateTime(2024, 10, 30, 11, 26, 11, 833, DateTimeKind.Local).AddTicks(2088), null, "Design intuitive user interfaces.", 25, new Guid("bc4ecf1e-8841-47f2-86ec-b0c523f03da1"), new Guid("79685cdb-be26-49cc-b7f9-1fb51686f5ba"), 38, 24, 4, 70000.0, 1, "UX Designer", new DateTime(2024, 10, 30, 11, 26, 11, 833, DateTimeKind.Local).AddTicks(2088), null, new Guid("04a9de34-0869-41b2-87a8-63c20c4ba22a"), new Guid("cc4121b2-72c2-4226-ad12-24e722b50cc2") },
                    { new Guid("79ea2482-a495-4657-940c-62f0cad9468a"), new DateTime(2025, 2, 28, 11, 26, 11, 833, DateTimeKind.Local).AddTicks(2035), new Guid("540f318e-b42f-4485-9e60-8faa5bf80962"), new Guid("bb6a0c56-37e3-4723-b648-d6e535e0d208"), new DateTime(2024, 10, 30, 11, 26, 11, 833, DateTimeKind.Local).AddTicks(2040), null, "Oversee product development lifecycle.", 20, new Guid("a3fb036a-04fc-4590-b87d-6ed32e2ec692"), new Guid("12497687-64b8-4d8e-814a-b7d1d33d3aab"), 45, 28, 3, 95000.0, 1, "Product Manager", new DateTime(2024, 10, 30, 11, 26, 11, 833, DateTimeKind.Local).AddTicks(2041), null, new Guid("c199da74-c2fb-4381-b093-cf2f1e3e8f06"), new Guid("646ccd9f-aa2f-413e-8d3e-eb8ab0b14c96") },
                    { new Guid("e9ba6a33-4f51-4a6d-81c4-9f5d0476f04c"), new DateTime(2025, 1, 30, 11, 26, 11, 833, DateTimeKind.Local).AddTicks(1982), new Guid("540f318e-b42f-4485-9e60-8faa5bf80962"), new Guid("c0b05dd2-104d-4e02-ba1f-61261bca222c"), new DateTime(2024, 10, 30, 11, 26, 11, 833, DateTimeKind.Local).AddTicks(2016), null, "Develop and maintain web applications.", 10, new Guid("bc4ecf1e-8841-47f2-86ec-b0c523f03da1"), new Guid("79685cdb-be26-49cc-b7f9-1fb51686f5ba"), 35, 21, 1, 80000.0, 1, "Software Engineer", new DateTime(2024, 10, 30, 11, 26, 11, 833, DateTimeKind.Local).AddTicks(2017), null, new Guid("04a9de34-0869-41b2-87a8-63c20c4ba22a"), new Guid("67db1aef-c1b1-4424-8313-774a5dccdb9d") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Companies_Slug",
                table: "Companies",
                column: "Slug",
                unique: true);
        }
    }
}
