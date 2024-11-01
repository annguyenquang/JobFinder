using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace JobFinder.Migrations
{
    /// <inheritdoc />
    public partial class AddMoreSeedJobData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: new Guid("4b28785a-e6d8-4bde-bc61-4fcd3c7edcb9"));

            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "Id", "AccountId", "Address", "CreatedAt", "CreatedBy", "Description", "DistrictId", "EmailContact", "EmployeeCount", "Industry", "Logo", "Name", "PhoneContact", "ProvinceId", "Slug", "UpdatedAt", "UpdatedBy", "Website" },
                values: new object[] { new Guid("7f9b407b-80e0-4f0c-a301-5a8bbf813b05"), new Guid("5ecd2d42-4b0e-43a1-9406-961552ca3e87"), "123 Tech Lane", null, null, "Tech Corp is a tech corp company.", 0, "info@techcorp.com", 500, "Technology", "https://images-platform.99static.com/7v8-fjWpezqDYFTxbYGvEE3gnw8=/191x0:1338x1147/500x500/top/smart/99designs-contests-attachments/60/60612/attachment_60612660", "Tech Corp", "123456789", 0, "tech-corp", null, null, "www.techcorp.com" });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("9127e8f9-a91c-4dca-8008-3cb7a8dcfb22"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 1, 17, 31, 17, 847, DateTimeKind.Local).AddTicks(5565), new DateTime(2024, 11, 1, 17, 31, 17, 847, DateTimeKind.Local).AddTicks(5570), new DateTime(2024, 11, 1, 17, 31, 17, 847, DateTimeKind.Local).AddTicks(5570) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("c3d3aa6b-ac70-4aa9-a8c2-88b3e0581d87"),
                columns: new[] { "CloseDate", "CompanyId", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 1, 17, 31, 17, 847, DateTimeKind.Local).AddTicks(5557), new Guid("7f9b407b-80e0-4f0c-a301-5a8bbf813b05"), new DateTime(2024, 11, 1, 17, 31, 17, 847, DateTimeKind.Local).AddTicks(5561), new DateTime(2024, 11, 1, 17, 31, 17, 847, DateTimeKind.Local).AddTicks(5562) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("ca01ec6a-8d39-4e00-ab98-6c3f9a2e0b1e"),
                columns: new[] { "CloseDate", "CompanyId", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 1, 17, 31, 17, 847, DateTimeKind.Local).AddTicks(5548), new Guid("7f9b407b-80e0-4f0c-a301-5a8bbf813b05"), new DateTime(2024, 11, 1, 17, 31, 17, 847, DateTimeKind.Local).AddTicks(5554), new DateTime(2024, 11, 1, 17, 31, 17, 847, DateTimeKind.Local).AddTicks(5555) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("def969c3-e7ad-4f71-9907-2c0d594d3ecb"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 1, 17, 31, 17, 847, DateTimeKind.Local).AddTicks(5573), new DateTime(2024, 11, 1, 17, 31, 17, 847, DateTimeKind.Local).AddTicks(5578), new DateTime(2024, 11, 1, 17, 31, 17, 847, DateTimeKind.Local).AddTicks(5578) });

            migrationBuilder.InsertData(
                table: "Jobs",
                columns: new[] { "Id", "CloseDate", "CommitmentTypeId", "CompanyId", "CreatedAt", "CreatedBy", "Description", "DistrictId", "EducationLevelRequirementId", "GenderRequirementId", "MaxAgeRequirement", "MinAgeRequirement", "ProvinceId", "Salary", "Status", "Title", "UpdatedAt", "UpdatedBy", "WorkArrangementId", "WorkExperienceRequirementId" },
                values: new object[,]
                {
                    { new Guid("17e0cd7e-5887-44e2-bf2a-cd1b1f631f76"), new DateTime(2025, 4, 1, 17, 31, 17, 847, DateTimeKind.Local).AddTicks(5752), new Guid("540f318e-b42f-4485-9e60-8faa5bf80962"), new Guid("ab9af358-61ce-453e-96eb-23eff22e0c3b"), new DateTime(2024, 11, 1, 17, 31, 17, 847, DateTimeKind.Local).AddTicks(5756), null, "Design user interfaces and enhance user experience.", 90, new Guid("bc4ecf1e-8841-47f2-86ec-b0c523f03da1"), new Guid("7b5f69cb-5996-4a57-b9c6-9fee2a791bf6"), 38, 24, 17, 70000.0, 1, "UI/UX Designer", new DateTime(2024, 11, 1, 17, 31, 17, 847, DateTimeKind.Local).AddTicks(5757), null, new Guid("376764fa-28ec-4a08-80e3-a6ab407e8601"), new Guid("cc4121b2-72c2-4226-ad12-24e722b50cc2") },
                    { new Guid("1b9a3a57-5a94-4cc3-9af1-0380d074dd65"), new DateTime(2025, 2, 1, 17, 31, 17, 847, DateTimeKind.Local).AddTicks(5772), new Guid("540f318e-b42f-4485-9e60-8faa5bf80962"), new Guid("ab9af358-61ce-453e-96eb-23eff22e0c3b"), new DateTime(2024, 11, 1, 17, 31, 17, 847, DateTimeKind.Local).AddTicks(5777), null, "Ensure network and system performance and security.", 105, new Guid("bc44b9a9-5cd6-4195-a7bd-92b4bef6d8fb"), new Guid("79685cdb-be26-49cc-b7f9-1fb51686f5ba"), 45, 25, 20, 75000.0, 1, "System Administrator", new DateTime(2024, 11, 1, 17, 31, 17, 847, DateTimeKind.Local).AddTicks(5778), null, new Guid("376764fa-28ec-4a08-80e3-a6ab407e8601"), new Guid("cc4121b2-72c2-4226-ad12-24e722b50cc2") },
                    { new Guid("3d8db2d5-5020-497e-917b-500a1f663c60"), new DateTime(2025, 4, 1, 17, 31, 17, 847, DateTimeKind.Local).AddTicks(5809), new Guid("5d06c3b1-2bd1-4c68-96b4-f4cd8c899dff"), new Guid("ab9af358-61ce-453e-96eb-23eff22e0c3b"), new DateTime(2024, 11, 1, 17, 31, 17, 847, DateTimeKind.Local).AddTicks(5813), null, "Oversee project planning and execution.", 130, new Guid("bc44b9a9-5cd6-4195-a7bd-92b4bef6d8fb"), new Guid("12497687-64b8-4d8e-814a-b7d1d33d3aab"), 50, 30, 25, 100000.0, 1, "Project Manager", new DateTime(2024, 11, 1, 17, 31, 17, 847, DateTimeKind.Local).AddTicks(5813), null, new Guid("c199da74-c2fb-4381-b093-cf2f1e3e8f06"), new Guid("67db1aef-c1b1-4424-8313-774a5dccdb9d") },
                    { new Guid("4b3dff90-4d8a-4cbb-a3e8-6c7e5a4d3c4a"), new DateTime(2025, 1, 1, 17, 31, 17, 847, DateTimeKind.Local).AddTicks(5702), new Guid("5d06c3b1-2bd1-4c68-96b4-f4cd8c899dff"), new Guid("ec7d72b6-e9f4-4c85-bc12-c2db31d5efa7"), new DateTime(2024, 11, 1, 17, 31, 17, 847, DateTimeKind.Local).AddTicks(5710), null, "Plan and manage content creation.", 60, new Guid("ebb6a034-ce37-41a4-b1f6-c70f1698c4f2"), new Guid("7b5f69cb-5996-4a57-b9c6-9fee2a791bf6"), 35, 21, 11, 55000.0, 1, "Content Strategist", new DateTime(2024, 11, 1, 17, 31, 17, 847, DateTimeKind.Local).AddTicks(5711), null, new Guid("376764fa-28ec-4a08-80e3-a6ab407e8601"), new Guid("4a3e2365-47f4-45d9-b1d4-326d9f2f3203") },
                    { new Guid("5540bd1d-b228-410e-8fbf-0842aeda7cb1"), new DateTime(2025, 1, 1, 17, 31, 17, 847, DateTimeKind.Local).AddTicks(5529), new Guid("5d06c3b1-2bd1-4c68-96b4-f4cd8c899dff"), new Guid("ec7d72b6-e9f4-4c85-bc12-c2db31d5efa7"), new DateTime(2024, 11, 1, 17, 31, 17, 847, DateTimeKind.Local).AddTicks(5537), null, "Analyze large datasets to generate business insights.", 15, new Guid("bc44b9a9-5cd6-4195-a7bd-92b4bef6d8fb"), new Guid("7b5f69cb-5996-4a57-b9c6-9fee2a791bf6"), 40, 23, 2, 60000.0, 1, "Data Analyst", new DateTime(2024, 11, 1, 17, 31, 17, 847, DateTimeKind.Local).AddTicks(5537), null, new Guid("376764fa-28ec-4a08-80e3-a6ab407e8601"), new Guid("bf38a1b9-dee3-455a-87c1-4e034fe806f7") },
                    { new Guid("571827fa-78f4-4192-ad3b-06bb014309c2"), new DateTime(2025, 3, 1, 17, 31, 17, 847, DateTimeKind.Local).AddTicks(5540), new Guid("540f318e-b42f-4485-9e60-8faa5bf80962"), new Guid("ab9af358-61ce-453e-96eb-23eff22e0c3b"), new DateTime(2024, 11, 1, 17, 31, 17, 847, DateTimeKind.Local).AddTicks(5545), null, "Oversee product development lifecycle.", 20, new Guid("a3fb036a-04fc-4590-b87d-6ed32e2ec692"), new Guid("12497687-64b8-4d8e-814a-b7d1d33d3aab"), 45, 28, 3, 95000.0, 1, "Product Manager", new DateTime(2024, 11, 1, 17, 31, 17, 847, DateTimeKind.Local).AddTicks(5545), null, new Guid("c199da74-c2fb-4381-b093-cf2f1e3e8f06"), new Guid("646ccd9f-aa2f-413e-8d3e-eb8ab0b14c96") },
                    { new Guid("5f9c2d8f-a7f2-45a4-8e4a-90b8f7a03b3e"), new DateTime(2025, 1, 1, 17, 31, 17, 847, DateTimeKind.Local).AddTicks(5671), new Guid("44b668b2-09ee-499e-af95-73598f9153a2"), new Guid("ec7d72b6-e9f4-4c85-bc12-c2db31d5efa7"), new DateTime(2024, 11, 1, 17, 31, 17, 847, DateTimeKind.Local).AddTicks(5676), null, "Build and maintain server-side applications.", 45, new Guid("bc4ecf1e-8841-47f2-86ec-b0c523f03da1"), new Guid("7b5f69cb-5996-4a57-b9c6-9fee2a791bf6"), 38, 24, 8, 78000.0, 1, "Backend Developer", new DateTime(2024, 11, 1, 17, 31, 17, 847, DateTimeKind.Local).AddTicks(5677), null, new Guid("c199da74-c2fb-4381-b093-cf2f1e3e8f06"), new Guid("cc4121b2-72c2-4226-ad12-24e722b50cc2") },
                    { new Guid("6bf113f5-7f15-4973-aa96-9e0b85072b21"), new DateTime(2025, 2, 1, 17, 31, 17, 847, DateTimeKind.Local).AddTicks(5615), new Guid("5d06c3b1-2bd1-4c68-96b4-f4cd8c899dff"), new Guid("ab9af358-61ce-453e-96eb-23eff22e0c3b"), new DateTime(2024, 11, 1, 17, 31, 17, 847, DateTimeKind.Local).AddTicks(5619), null, "Provide technical support to clients.", 18, new Guid("a3fb036a-04fc-4590-b87d-6ed32e2ec692"), new Guid("12497687-64b8-4d8e-814a-b7d1d33d3aab"), 33, 22, 6, 45000.0, 1, "Customer Support Specialist", new DateTime(2024, 11, 1, 17, 31, 17, 847, DateTimeKind.Local).AddTicks(5619), null, new Guid("c199da74-c2fb-4381-b093-cf2f1e3e8f06"), new Guid("fbce1042-bce0-47a3-92cc-54e3b86eb570") },
                    { new Guid("6f0e2a6f-54d7-493c-bcb4-8f5eeb2fba1b"), new DateTime(2025, 1, 1, 17, 31, 17, 847, DateTimeKind.Local).AddTicks(5801), new Guid("540f318e-b42f-4485-9e60-8faa5bf80962"), new Guid("ec7d72b6-e9f4-4c85-bc12-c2db31d5efa7"), new DateTime(2024, 11, 1, 17, 31, 17, 847, DateTimeKind.Local).AddTicks(5805), null, "Assist in the development and execution of marketing campaigns.", 125, new Guid("bc4ecf1e-8841-47f2-86ec-b0c523f03da1"), new Guid("79685cdb-be26-49cc-b7f9-1fb51686f5ba"), 36, 23, 24, 65000.0, 1, "Marketing Coordinator", new DateTime(2024, 11, 1, 17, 31, 17, 847, DateTimeKind.Local).AddTicks(5806), null, new Guid("04a9de34-0869-41b2-87a8-63c20c4ba22a"), new Guid("4a3e2365-47f4-45d9-b1d4-326d9f2f3203") },
                    { new Guid("82cfed84-d067-4d70-bef9-f08b0636a6b0"), new DateTime(2025, 3, 1, 17, 31, 17, 847, DateTimeKind.Local).AddTicks(5780), new Guid("5d06c3b1-2bd1-4c68-96b4-f4cd8c899dff"), new Guid("ec7d72b6-e9f4-4c85-bc12-c2db31d5efa7"), new DateTime(2024, 11, 1, 17, 31, 17, 847, DateTimeKind.Local).AddTicks(5784), null, "Optimize website content for search engines.", 110, new Guid("bc4ecf1e-8841-47f2-86ec-b0c523f03da1"), new Guid("7b5f69cb-5996-4a57-b9c6-9fee2a791bf6"), 34, 21, 21, 55000.0, 1, "SEO Specialist", new DateTime(2024, 11, 1, 17, 31, 17, 847, DateTimeKind.Local).AddTicks(5784), null, new Guid("04a9de34-0869-41b2-87a8-63c20c4ba22a"), new Guid("4a3e2365-47f4-45d9-b1d4-326d9f2f3203") },
                    { new Guid("8480b848-7ff8-402f-bbe7-dc23dd593a60"), new DateTime(2025, 1, 1, 17, 31, 17, 847, DateTimeKind.Local).AddTicks(5607), new Guid("3fbef738-ed16-4778-8463-8390444841de"), new Guid("ec7d72b6-e9f4-4c85-bc12-c2db31d5efa7"), new DateTime(2024, 11, 1, 17, 31, 17, 847, DateTimeKind.Local).AddTicks(5611), null, "Build and maintain client relationships.", 30, new Guid("ebb6a034-ce37-41a4-b1f6-c70f1698c4f2"), new Guid("7b5f69cb-5996-4a57-b9c6-9fee2a791bf6"), 35, 23, 5, 55000.0, 1, "Sales Executive", new DateTime(2024, 11, 1, 17, 31, 17, 847, DateTimeKind.Local).AddTicks(5611), null, new Guid("376764fa-28ec-4a08-80e3-a6ab407e8601"), new Guid("cc4121b2-72c2-4226-ad12-24e722b50cc2") },
                    { new Guid("8c78bbac-4a5e-49ab-aafb-5a6c3f0c4b5d"), new DateTime(2025, 6, 1, 17, 31, 17, 847, DateTimeKind.Local).AddTicks(5680), new Guid("5d06c3b1-2bd1-4c68-96b4-f4cd8c899dff"), new Guid("ab9af358-61ce-453e-96eb-23eff22e0c3b"), new DateTime(2024, 11, 1, 17, 31, 17, 847, DateTimeKind.Local).AddTicks(5688), null, "Implement machine learning models for automation.", 50, new Guid("bc44b9a9-5cd6-4195-a7bd-92b4bef6d8fb"), new Guid("79685cdb-be26-49cc-b7f9-1fb51686f5ba"), 50, 27, 9, 120000.0, 1, "Machine Learning Engineer", new DateTime(2024, 11, 1, 17, 31, 17, 847, DateTimeKind.Local).AddTicks(5689), null, new Guid("376764fa-28ec-4a08-80e3-a6ab407e8601"), new Guid("bf38a1b9-dee3-455a-87c1-4e034fe806f7") },
                    { new Guid("a6b3ec6a-1d44-4b00-aa18-7d3f1a2e2f6d"), new DateTime(2025, 2, 1, 17, 31, 17, 847, DateTimeKind.Local).AddTicks(5629), new Guid("3fbef738-ed16-4778-8463-8390444841de"), new Guid("ab9af358-61ce-453e-96eb-23eff22e0c3b"), new DateTime(2024, 11, 1, 17, 31, 17, 847, DateTimeKind.Local).AddTicks(5633), null, "Manage and troubleshoot network infrastructure.", 35, new Guid("a3fb036a-04fc-4590-b87d-6ed32e2ec692"), new Guid("79685cdb-be26-49cc-b7f9-1fb51686f5ba"), 40, 25, 6, 75000.0, 1, "Network Engineer", new DateTime(2024, 11, 1, 17, 31, 17, 847, DateTimeKind.Local).AddTicks(5634), null, new Guid("c199da74-c2fb-4381-b093-cf2f1e3e8f06"), new Guid("4a3e2365-47f4-45d9-b1d4-326d9f2f3203") },
                    { new Guid("af7bcf34-a92d-4b2b-9937-3e6b7f4f2c6d"), new DateTime(2025, 3, 1, 17, 31, 17, 847, DateTimeKind.Local).AddTicks(5715), new Guid("540f318e-b42f-4485-9e60-8faa5bf80962"), new Guid("ab9af358-61ce-453e-96eb-23eff22e0c3b"), new DateTime(2024, 11, 1, 17, 31, 17, 847, DateTimeKind.Local).AddTicks(5719), null, "Ensure software quality through testing.", 65, new Guid("bc4ecf1e-8841-47f2-86ec-b0c523f03da1"), new Guid("79685cdb-be26-49cc-b7f9-1fb51686f5ba"), 39, 24, 12, 70000.0, 1, "Quality Assurance Engineer", new DateTime(2024, 11, 1, 17, 31, 17, 847, DateTimeKind.Local).AddTicks(5720), null, new Guid("c199da74-c2fb-4381-b093-cf2f1e3e8f06"), new Guid("cc4121b2-72c2-4226-ad12-24e722b50cc2") },
                    { new Guid("b3f9d8c7-a1f4-4e3d-b7c2-7e3f9a4f1c5d"), new DateTime(2025, 4, 1, 17, 31, 17, 847, DateTimeKind.Local).AddTicks(5731), new Guid("44b668b2-09ee-499e-af95-73598f9153a2"), new Guid("ec7d72b6-e9f4-4c85-bc12-c2db31d5efa7"), new DateTime(2024, 11, 1, 17, 31, 17, 847, DateTimeKind.Local).AddTicks(5735), null, "Analyze financial data to aid in decision-making.", 75, new Guid("bc44b9a9-5cd6-4195-a7bd-92b4bef6d8fb"), new Guid("12497687-64b8-4d8e-814a-b7d1d33d3aab"), 45, 27, 14, 85000.0, 1, "Financial Analyst", new DateTime(2024, 11, 1, 17, 31, 17, 847, DateTimeKind.Local).AddTicks(5736), null, new Guid("04a9de34-0869-41b2-87a8-63c20c4ba22a"), new Guid("bf38a1b9-dee3-455a-87c1-4e034fe806f7") },
                    { new Guid("c0a173ff-5be0-4bc9-877b-8d632eeb6da6"), new DateTime(2025, 2, 1, 17, 31, 17, 847, DateTimeKind.Local).AddTicks(5849), new Guid("540f318e-b42f-4485-9e60-8faa5bf80962"), new Guid("ec7d72b6-e9f4-4c85-bc12-c2db31d5efa7"), new DateTime(2024, 11, 1, 17, 31, 17, 847, DateTimeKind.Local).AddTicks(5853), null, "Build and maintain websites and web applications.", 140, new Guid("bc4ecf1e-8841-47f2-86ec-b0c523f03da1"), new Guid("79685cdb-be26-49cc-b7f9-1fb51686f5ba"), 40, 22, 27, 75000.0, 1, "Web Developer", new DateTime(2024, 11, 1, 17, 31, 17, 847, DateTimeKind.Local).AddTicks(5854), null, new Guid("376764fa-28ec-4a08-80e3-a6ab407e8601"), new Guid("cc4121b2-72c2-4226-ad12-24e722b50cc2") },
                    { new Guid("d0d69bba-c6c0-4e1e-b8a1-9b4b44e69b93"), new DateTime(2025, 1, 1, 17, 31, 17, 847, DateTimeKind.Local).AddTicks(5765), new Guid("44b668b2-09ee-499e-af95-73598f9153a2"), new Guid("ec7d72b6-e9f4-4c85-bc12-c2db31d5efa7"), new DateTime(2024, 11, 1, 17, 31, 17, 847, DateTimeKind.Local).AddTicks(5770), null, "Manage and optimize database systems.", 100, new Guid("bc4ecf1e-8841-47f2-86ec-b0c523f03da1"), new Guid("7b5f69cb-5996-4a57-b9c6-9fee2a791bf6"), 50, 28, 19, 80000.0, 1, "Database Administrator", new DateTime(2024, 11, 1, 17, 31, 17, 847, DateTimeKind.Local).AddTicks(5770), null, new Guid("04a9de34-0869-41b2-87a8-63c20c4ba22a"), new Guid("67db1aef-c1b1-4424-8313-774a5dccdb9d") },
                    { new Guid("df024b07-216f-41d7-b79b-25eb8f28762d"), new DateTime(2025, 4, 1, 17, 31, 17, 847, DateTimeKind.Local).AddTicks(5786), new Guid("540f318e-b42f-4485-9e60-8faa5bf80962"), new Guid("ab9af358-61ce-453e-96eb-23eff22e0c3b"), new DateTime(2024, 11, 1, 17, 31, 17, 847, DateTimeKind.Local).AddTicks(5791), null, "Analyze business processes and provide solutions.", 115, new Guid("a3fb036a-04fc-4590-b87d-6ed32e2ec692"), new Guid("12497687-64b8-4d8e-814a-b7d1d33d3aab"), 44, 26, 22, 70000.0, 1, "Business Analyst", new DateTime(2024, 11, 1, 17, 31, 17, 847, DateTimeKind.Local).AddTicks(5792), null, new Guid("c199da74-c2fb-4381-b093-cf2f1e3e8f06"), new Guid("cc4121b2-72c2-4226-ad12-24e722b50cc2") },
                    { new Guid("f07a1be4-bd6d-4c2d-9537-303e0c7a5dcf"), new DateTime(2025, 2, 1, 17, 31, 17, 847, DateTimeKind.Local).AddTicks(5746), new Guid("5d06c3b1-2bd1-4c68-96b4-f4cd8c899dff"), new Guid("ec7d72b6-e9f4-4c85-bc12-c2db31d5efa7"), new DateTime(2024, 11, 1, 17, 31, 17, 847, DateTimeKind.Local).AddTicks(5750), null, "Implement CI/CD processes for efficient development.", 85, new Guid("bc44b9a9-5cd6-4195-a7bd-92b4bef6d8fb"), new Guid("79685cdb-be26-49cc-b7f9-1fb51686f5ba"), 45, 26, 16, 95000.0, 1, "DevOps Engineer", new DateTime(2024, 11, 1, 17, 31, 17, 847, DateTimeKind.Local).AddTicks(5750), null, new Guid("04a9de34-0869-41b2-87a8-63c20c4ba22a"), new Guid("67db1aef-c1b1-4424-8313-774a5dccdb9d") },
                    { new Guid("fa01ec6a-8d39-4e00-ab98-6c3f9a2e0b1f"), new DateTime(2025, 4, 1, 17, 31, 17, 847, DateTimeKind.Local).AddTicks(5622), new Guid("540f318e-b42f-4485-9e60-8faa5bf80962"), new Guid("ec7d72b6-e9f4-4c85-bc12-c2db31d5efa7"), new DateTime(2024, 11, 1, 17, 31, 17, 847, DateTimeKind.Local).AddTicks(5626), null, "Develop responsive web interfaces.", 30, new Guid("bc4ecf1e-8841-47f2-86ec-b0c523f03da1"), new Guid("7b5f69cb-5996-4a57-b9c6-9fee2a791bf6"), 35, 22, 5, 65000.0, 1, "Front-End Developer", new DateTime(2024, 11, 1, 17, 31, 17, 847, DateTimeKind.Local).AddTicks(5627), null, new Guid("04a9de34-0869-41b2-87a8-63c20c4ba22a"), new Guid("cc4121b2-72c2-4226-ad12-24e722b50cc2") },
                    { new Guid("1c8a7d6b-2d7f-4c2b-a9c5-8b3e9f6f2d8b"), new DateTime(2025, 2, 1, 17, 31, 17, 847, DateTimeKind.Local).AddTicks(5722), new Guid("26a49bd7-ad8c-40be-8e7c-dd903f7a653e"), new Guid("7f9b407b-80e0-4f0c-a301-5a8bbf813b05"), new DateTime(2024, 11, 1, 17, 31, 17, 847, DateTimeKind.Local).AddTicks(5727), null, "Develop marketing strategies to drive growth.", 70, new Guid("a3fb036a-04fc-4590-b87d-6ed32e2ec692"), new Guid("7b5f69cb-5996-4a57-b9c6-9fee2a791bf6"), 37, 23, 13, 60000.0, 1, "Marketing Specialist", new DateTime(2024, 11, 1, 17, 31, 17, 847, DateTimeKind.Local).AddTicks(5729), null, new Guid("376764fa-28ec-4a08-80e3-a6ab407e8601"), new Guid("cc4121b2-72c2-4226-ad12-24e722b50cc2") },
                    { new Guid("1d41e60a-ffb5-4039-b4b6-3e25e68d0f2c"), new DateTime(2025, 5, 1, 17, 31, 17, 847, DateTimeKind.Local).AddTicks(5759), new Guid("540f318e-b42f-4485-9e60-8faa5bf80962"), new Guid("7f9b407b-80e0-4f0c-a301-5a8bbf813b05"), new DateTime(2024, 11, 1, 17, 31, 17, 847, DateTimeKind.Local).AddTicks(5763), null, "Protect an organization's systems from security threats.", 95, new Guid("bc44b9a9-5cd6-4195-a7bd-92b4bef6d8fb"), new Guid("12497687-64b8-4d8e-814a-b7d1d33d3aab"), 45, 27, 18, 90000.0, 1, "Cybersecurity Analyst", new DateTime(2024, 11, 1, 17, 31, 17, 847, DateTimeKind.Local).AddTicks(5764), null, new Guid("c199da74-c2fb-4381-b093-cf2f1e3e8f06"), new Guid("bf38a1b9-dee3-455a-87c1-4e034fe806f7") },
                    { new Guid("3d6b9f9b-6f2d-4b4a-b4c7-2c8b5f4e1b4e"), new DateTime(2025, 2, 1, 17, 31, 17, 847, DateTimeKind.Local).AddTicks(5692), new Guid("44b668b2-09ee-499e-af95-73598f9153a2"), new Guid("7f9b407b-80e0-4f0c-a301-5a8bbf813b05"), new DateTime(2024, 11, 1, 17, 31, 17, 847, DateTimeKind.Local).AddTicks(5699), null, "Coordinate and oversee project delivery.", 55, new Guid("bc4ecf1e-8841-47f2-86ec-b0c523f03da1"), new Guid("12497687-64b8-4d8e-814a-b7d1d33d3aab"), 50, 30, 10, 90000.0, 1, "Project Manager", new DateTime(2024, 11, 1, 17, 31, 17, 847, DateTimeKind.Local).AddTicks(5700), null, new Guid("04a9de34-0869-41b2-87a8-63c20c4ba22a"), new Guid("646ccd9f-aa2f-413e-8d3e-eb8ab0b14c96") },
                    { new Guid("4c695d62-51f0-4070-a625-c030208dffb7"), new DateTime(2025, 2, 1, 17, 31, 17, 847, DateTimeKind.Local).AddTicks(5500), new Guid("540f318e-b42f-4485-9e60-8faa5bf80962"), new Guid("7f9b407b-80e0-4f0c-a301-5a8bbf813b05"), new DateTime(2024, 11, 1, 17, 31, 17, 847, DateTimeKind.Local).AddTicks(5524), null, "Develop and maintain web applications.", 10, new Guid("bc4ecf1e-8841-47f2-86ec-b0c523f03da1"), new Guid("79685cdb-be26-49cc-b7f9-1fb51686f5ba"), 35, 21, 1, 80000.0, 1, "Software Engineer", new DateTime(2024, 11, 1, 17, 31, 17, 847, DateTimeKind.Local).AddTicks(5525), null, new Guid("04a9de34-0869-41b2-87a8-63c20c4ba22a"), new Guid("67db1aef-c1b1-4424-8313-774a5dccdb9d") },
                    { new Guid("7c7616f2-3c2c-4c5f-9f40-470e78a847c7"), new DateTime(2025, 3, 1, 17, 31, 17, 847, DateTimeKind.Local).AddTicks(5815), new Guid("540f318e-b42f-4485-9e60-8faa5bf80962"), new Guid("7f9b407b-80e0-4f0c-a301-5a8bbf813b05"), new DateTime(2024, 11, 1, 17, 31, 17, 847, DateTimeKind.Local).AddTicks(5820), null, "Write and edit content for various platforms.", 135, new Guid("a3fb036a-04fc-4590-b87d-6ed32e2ec692"), new Guid("7b5f69cb-5996-4a57-b9c6-9fee2a791bf6"), 35, 21, 26, 50000.0, 1, "Content Writer", new DateTime(2024, 11, 1, 17, 31, 17, 847, DateTimeKind.Local).AddTicks(5820), null, new Guid("04a9de34-0869-41b2-87a8-63c20c4ba22a"), new Guid("4a3e2365-47f4-45d9-b1d4-326d9f2f3203") },
                    { new Guid("b09a943a-ca96-4d14-be00-b68e517a17e7"), new DateTime(2025, 2, 1, 17, 31, 17, 847, DateTimeKind.Local).AddTicks(5600), new Guid("44b668b2-09ee-499e-af95-73598f9153a2"), new Guid("7f9b407b-80e0-4f0c-a301-5a8bbf813b05"), new DateTime(2024, 11, 1, 17, 31, 17, 847, DateTimeKind.Local).AddTicks(5604), null, "Manage and maintain network infrastructure.", 21, new Guid("bc4ecf1e-8841-47f2-86ec-b0c523f03da1"), new Guid("79685cdb-be26-49cc-b7f9-1fb51686f5ba"), 40, 25, 4, 85000.0, 1, "Network Engineer", new DateTime(2024, 11, 1, 17, 31, 17, 847, DateTimeKind.Local).AddTicks(5605), null, new Guid("04a9de34-0869-41b2-87a8-63c20c4ba22a"), new Guid("bf38a1b9-dee3-455a-87c1-4e034fe806f7") },
                    { new Guid("c3e8ff99-9f1a-4e4e-aaa4-4d1c8e5e3b5a"), new DateTime(2025, 5, 1, 17, 31, 17, 847, DateTimeKind.Local).AddTicks(5636), new Guid("540f318e-b42f-4485-9e60-8faa5bf80962"), new Guid("7f9b407b-80e0-4f0c-a301-5a8bbf813b05"), new DateTime(2024, 11, 1, 17, 31, 17, 847, DateTimeKind.Local).AddTicks(5640), null, "Develop data models and predictive analytics.", 40, new Guid("bc44b9a9-5cd6-4195-a7bd-92b4bef6d8fb"), new Guid("12497687-64b8-4d8e-814a-b7d1d33d3aab"), 45, 26, 7, 95000.0, 1, "Data Scientist", new DateTime(2024, 11, 1, 17, 31, 17, 847, DateTimeKind.Local).AddTicks(5641), null, new Guid("376764fa-28ec-4a08-80e3-a6ab407e8601"), new Guid("67db1aef-c1b1-4424-8313-774a5dccdb9d") },
                    { new Guid("c8e2c78e-f68e-4c7e-a22f-5c81b4b5a8b0"), new DateTime(2025, 5, 1, 17, 31, 17, 847, DateTimeKind.Local).AddTicks(5794), new Guid("44b668b2-09ee-499e-af95-73598f9153a2"), new Guid("7f9b407b-80e0-4f0c-a301-5a8bbf813b05"), new DateTime(2024, 11, 1, 17, 31, 17, 847, DateTimeKind.Local).AddTicks(5798), null, "Lead sales team to achieve targets.", 120, new Guid("bc44b9a9-5cd6-4195-a7bd-92b4bef6d8fb"), new Guid("7b5f69cb-5996-4a57-b9c6-9fee2a791bf6"), 50, 28, 23, 95000.0, 1, "Sales Manager", new DateTime(2024, 11, 1, 17, 31, 17, 847, DateTimeKind.Local).AddTicks(5799), null, new Guid("376764fa-28ec-4a08-80e3-a6ab407e8601"), new Guid("bf38a1b9-dee3-455a-87c1-4e034fe806f7") },
                    { new Guid("dd6b2a14-0f8b-41a8-ae5d-53de0a92d764"), new DateTime(2025, 3, 1, 17, 31, 17, 847, DateTimeKind.Local).AddTicks(5738), new Guid("540f318e-b42f-4485-9e60-8faa5bf80962"), new Guid("7f9b407b-80e0-4f0c-a301-5a8bbf813b05"), new DateTime(2024, 11, 1, 17, 31, 17, 847, DateTimeKind.Local).AddTicks(5743), null, "Create visual content for digital and print media.", 80, new Guid("bc4ecf1e-8841-47f2-86ec-b0c523f03da1"), new Guid("7b5f69cb-5996-4a57-b9c6-9fee2a791bf6"), 35, 22, 15, 60000.0, 1, "Graphic Designer", new DateTime(2024, 11, 1, 17, 31, 17, 847, DateTimeKind.Local).AddTicks(5744), null, new Guid("376764fa-28ec-4a08-80e3-a6ab407e8601"), new Guid("cc4121b2-72c2-4226-ad12-24e722b50cc2") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("17e0cd7e-5887-44e2-bf2a-cd1b1f631f76"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("1b9a3a57-5a94-4cc3-9af1-0380d074dd65"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("1c8a7d6b-2d7f-4c2b-a9c5-8b3e9f6f2d8b"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("1d41e60a-ffb5-4039-b4b6-3e25e68d0f2c"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("3d6b9f9b-6f2d-4b4a-b4c7-2c8b5f4e1b4e"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("3d8db2d5-5020-497e-917b-500a1f663c60"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("4b3dff90-4d8a-4cbb-a3e8-6c7e5a4d3c4a"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("4c695d62-51f0-4070-a625-c030208dffb7"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("5540bd1d-b228-410e-8fbf-0842aeda7cb1"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("571827fa-78f4-4192-ad3b-06bb014309c2"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("5f9c2d8f-a7f2-45a4-8e4a-90b8f7a03b3e"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("6bf113f5-7f15-4973-aa96-9e0b85072b21"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("6f0e2a6f-54d7-493c-bcb4-8f5eeb2fba1b"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("7c7616f2-3c2c-4c5f-9f40-470e78a847c7"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("82cfed84-d067-4d70-bef9-f08b0636a6b0"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("8480b848-7ff8-402f-bbe7-dc23dd593a60"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("8c78bbac-4a5e-49ab-aafb-5a6c3f0c4b5d"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("a6b3ec6a-1d44-4b00-aa18-7d3f1a2e2f6d"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("af7bcf34-a92d-4b2b-9937-3e6b7f4f2c6d"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("b09a943a-ca96-4d14-be00-b68e517a17e7"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("b3f9d8c7-a1f4-4e3d-b7c2-7e3f9a4f1c5d"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("c0a173ff-5be0-4bc9-877b-8d632eeb6da6"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("c3e8ff99-9f1a-4e4e-aaa4-4d1c8e5e3b5a"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("c8e2c78e-f68e-4c7e-a22f-5c81b4b5a8b0"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("d0d69bba-c6c0-4e1e-b8a1-9b4b44e69b93"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("dd6b2a14-0f8b-41a8-ae5d-53de0a92d764"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("df024b07-216f-41d7-b79b-25eb8f28762d"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("f07a1be4-bd6d-4c2d-9537-303e0c7a5dcf"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("fa01ec6a-8d39-4e00-ab98-6c3f9a2e0b1f"));

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: new Guid("7f9b407b-80e0-4f0c-a301-5a8bbf813b05"));

            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "Id", "AccountId", "Address", "CreatedAt", "CreatedBy", "Description", "DistrictId", "EmailContact", "EmployeeCount", "Industry", "Logo", "Name", "PhoneContact", "ProvinceId", "Slug", "UpdatedAt", "UpdatedBy", "Website" },
                values: new object[] { new Guid("4b28785a-e6d8-4bde-bc61-4fcd3c7edcb9"), new Guid("5ecd2d42-4b0e-43a1-9406-961552ca3e87"), "123 Tech Lane", null, null, "Tech Corp is a tech corp company.", 0, "info@techcorp.com", 500, "Technology", "https://images-platform.99static.com/7v8-fjWpezqDYFTxbYGvEE3gnw8=/191x0:1338x1147/500x500/top/smart/99designs-contests-attachments/60/60612/attachment_60612660", "Tech Corp", "123456789", 0, "tech-corp", null, null, "www.techcorp.com" });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("9127e8f9-a91c-4dca-8008-3cb7a8dcfb22"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 30, 23, 43, 4, 223, DateTimeKind.Local).AddTicks(7546), new DateTime(2024, 10, 30, 23, 43, 4, 223, DateTimeKind.Local).AddTicks(7553), new DateTime(2024, 10, 30, 23, 43, 4, 223, DateTimeKind.Local).AddTicks(7554) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("c3d3aa6b-ac70-4aa9-a8c2-88b3e0581d87"),
                columns: new[] { "CloseDate", "CompanyId", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 30, 23, 43, 4, 223, DateTimeKind.Local).AddTicks(7505), new Guid("4b28785a-e6d8-4bde-bc61-4fcd3c7edcb9"), new DateTime(2024, 10, 30, 23, 43, 4, 223, DateTimeKind.Local).AddTicks(7538), new DateTime(2024, 10, 30, 23, 43, 4, 223, DateTimeKind.Local).AddTicks(7539) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("ca01ec6a-8d39-4e00-ab98-6c3f9a2e0b1e"),
                columns: new[] { "CloseDate", "CompanyId", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 30, 23, 43, 4, 223, DateTimeKind.Local).AddTicks(7571), new Guid("4b28785a-e6d8-4bde-bc61-4fcd3c7edcb9"), new DateTime(2024, 10, 30, 23, 43, 4, 223, DateTimeKind.Local).AddTicks(7577), new DateTime(2024, 10, 30, 23, 43, 4, 223, DateTimeKind.Local).AddTicks(7578) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("def969c3-e7ad-4f71-9907-2c0d594d3ecb"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 28, 23, 43, 4, 223, DateTimeKind.Local).AddTicks(7558), new DateTime(2024, 10, 30, 23, 43, 4, 223, DateTimeKind.Local).AddTicks(7567), new DateTime(2024, 10, 30, 23, 43, 4, 223, DateTimeKind.Local).AddTicks(7568) });
        }
    }
}
