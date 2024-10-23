using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace JobFinder.Migrations
{
    /// <inheritdoc />
    public partial class RenameTablePositionToJob : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PositionApplications");

            migrationBuilder.DropTable(
                name: "Positions");

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("090b311e-3067-4b89-9732-f6448f815197"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("9bec4410-37a8-4d09-8ec3-ca84ba8eb591"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("b6cc6d88-e7b9-483b-b161-a500276b2550"));

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: new Guid("69d3dce1-544e-40ca-84fc-71cba06c7247"));

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: new Guid("8520a30d-7152-43d1-a87a-5ef858506350"));

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: new Guid("f1583a4d-ceca-4734-b3dd-cbe10d77fdae"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("7b1f6639-dd3e-45f2-8793-3db862a84c2e"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("e159c805-7d6b-4133-8036-12ff80c9d04f"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("ec489dc4-e1d0-4a46-9f98-dffccf025e79"));

            migrationBuilder.CreateTable(
                name: "Jobs",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Salary = table.Column<double>(type: "float", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CloseDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ProvinceId = table.Column<int>(type: "int", nullable: true),
                    DistrictId = table.Column<int>(type: "int", nullable: true),
                    MinAgeRequirement = table.Column<int>(type: "int", nullable: true),
                    MaxAgeRequirement = table.Column<int>(type: "int", nullable: true),
                    WorkArrangementId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CommitmentTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    GenderRequirementId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    EducationLevelRequirementId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    WorkExperienceRequirementId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CompanyId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UpdatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Jobs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Jobs_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Jobs_Metadatas_CommitmentTypeId",
                        column: x => x.CommitmentTypeId,
                        principalTable: "Metadatas",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Jobs_Metadatas_EducationLevelRequirementId",
                        column: x => x.EducationLevelRequirementId,
                        principalTable: "Metadatas",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Jobs_Metadatas_GenderRequirementId",
                        column: x => x.GenderRequirementId,
                        principalTable: "Metadatas",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Jobs_Metadatas_WorkArrangementId",
                        column: x => x.WorkArrangementId,
                        principalTable: "Metadatas",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Jobs_Metadatas_WorkExperienceRequirementId",
                        column: x => x.WorkExperienceRequirementId,
                        principalTable: "Metadatas",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "JobApplications",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    JobId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CVLink = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UpdatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobApplications", x => x.Id);
                    table.ForeignKey(
                        name: "FK_JobApplications_Jobs_JobId",
                        column: x => x.JobId,
                        principalTable: "Jobs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_JobApplications_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_JobApplications_JobId",
                table: "JobApplications",
                column: "JobId");

            migrationBuilder.CreateIndex(
                name: "IX_JobApplications_UserId",
                table: "JobApplications",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Jobs_CommitmentTypeId",
                table: "Jobs",
                column: "CommitmentTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Jobs_CompanyId",
                table: "Jobs",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Jobs_EducationLevelRequirementId",
                table: "Jobs",
                column: "EducationLevelRequirementId");

            migrationBuilder.CreateIndex(
                name: "IX_Jobs_GenderRequirementId",
                table: "Jobs",
                column: "GenderRequirementId");

            migrationBuilder.CreateIndex(
                name: "IX_Jobs_WorkArrangementId",
                table: "Jobs",
                column: "WorkArrangementId");

            migrationBuilder.CreateIndex(
                name: "IX_Jobs_WorkExperienceRequirementId",
                table: "Jobs",
                column: "WorkExperienceRequirementId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "JobApplications");

            migrationBuilder.DropTable(
                name: "Jobs");

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

            migrationBuilder.CreateTable(
                name: "Positions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CommitmentTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CompanyId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EducationLevelRequirementId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    GenderRequirementId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    WorkArrangementId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    WorkExperienceRequirementId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CloseDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DistrictId = table.Column<int>(type: "int", nullable: true),
                    MaxAgeRequirement = table.Column<int>(type: "int", nullable: true),
                    MinAgeRequirement = table.Column<int>(type: "int", nullable: true),
                    ProvinceId = table.Column<int>(type: "int", nullable: true),
                    Salary = table.Column<double>(type: "float", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Positions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Positions_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Positions_Metadatas_CommitmentTypeId",
                        column: x => x.CommitmentTypeId,
                        principalTable: "Metadatas",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Positions_Metadatas_EducationLevelRequirementId",
                        column: x => x.EducationLevelRequirementId,
                        principalTable: "Metadatas",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Positions_Metadatas_GenderRequirementId",
                        column: x => x.GenderRequirementId,
                        principalTable: "Metadatas",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Positions_Metadatas_WorkArrangementId",
                        column: x => x.WorkArrangementId,
                        principalTable: "Metadatas",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Positions_Metadatas_WorkExperienceRequirementId",
                        column: x => x.WorkExperienceRequirementId,
                        principalTable: "Metadatas",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "PositionApplications",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PositionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CVLink = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PositionApplications", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PositionApplications_Positions_PositionId",
                        column: x => x.PositionId,
                        principalTable: "Positions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PositionApplications_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "Email", "Password", "Phone", "UpdatedAt", "UpdatedBy", "Username" },
                values: new object[,]
                {
                    { new Guid("090b311e-3067-4b89-9732-f6448f815197"), null, null, "", "account3", "0128456789", null, null, "account3" },
                    { new Guid("7b1f6639-dd3e-45f2-8793-3db862a84c2e"), null, null, "", "account1", "0823456789", null, null, "account1" },
                    { new Guid("9bec4410-37a8-4d09-8ec3-ca84ba8eb591"), null, null, "", "account4", "0123856789", null, null, "account4" },
                    { new Guid("b6cc6d88-e7b9-483b-b161-a500276b2550"), null, null, "", "account2", "0183456789", null, null, "account2" },
                    { new Guid("e159c805-7d6b-4133-8036-12ff80c9d04f"), null, null, "", "account0", "0123456789", null, null, "account0" },
                    { new Guid("ec489dc4-e1d0-4a46-9f98-dffccf025e79"), null, null, "", "admin", "113", null, null, "admin" }
                });

            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "Id", "AccountId", "Address", "CreatedAt", "CreatedBy", "EmailContact", "EmployeeCount", "Industry", "Name", "Nation", "PhoneContact", "Slug", "UpdatedAt", "UpdatedBy", "Website" },
                values: new object[,]
                {
                    { new Guid("69d3dce1-544e-40ca-84fc-71cba06c7247"), new Guid("7b1f6639-dd3e-45f2-8793-3db862a84c2e"), "45688 London", null, null, "info@AnRe.com", 300, "IT", "An Inc.", "VN", "98765432112", "an-pro-ga", null, null, "www.Anrp.com" },
                    { new Guid("8520a30d-7152-43d1-a87a-5ef858506350"), new Guid("ec489dc4-e1d0-4a46-9f98-dffccf025e79"), "123 Tech Lane", null, null, "info@techcorp.com", 500, "Technology", "Tech Corp", "USA", "123456789", "tech-corp", null, null, "www.techcorp.com" },
                    { new Guid("f1583a4d-ceca-4734-b3dd-cbe10d77fdae"), new Guid("e159c805-7d6b-4133-8036-12ff80c9d04f"), "456 Health Blvd", null, null, "info@healthinc.com", 300, "Healthcare", "Health Inc.", "USA", "987654321", "health-inc", null, null, "www.healthinc.com" }
                });

            migrationBuilder.InsertData(
                table: "Positions",
                columns: new[] { "Id", "CloseDate", "CommitmentTypeId", "CompanyId", "CreatedAt", "CreatedBy", "Description", "DistrictId", "EducationLevelRequirementId", "GenderRequirementId", "MaxAgeRequirement", "MinAgeRequirement", "ProvinceId", "Salary", "Status", "Title", "UpdatedAt", "UpdatedBy", "WorkArrangementId", "WorkExperienceRequirementId" },
                values: new object[,]
                {
                    { new Guid("2c7203db-2844-468a-8bae-adb61ec5a2b3"), new DateTime(2024, 12, 22, 17, 13, 12, 906, DateTimeKind.Local).AddTicks(7389), new Guid("5d06c3b1-2bd1-4c68-96b4-f4cd8c899dff"), new Guid("f1583a4d-ceca-4734-b3dd-cbe10d77fdae"), new DateTime(2024, 10, 22, 17, 13, 12, 906, DateTimeKind.Local).AddTicks(7396), null, "Analyze large datasets to generate business insights.", 15, new Guid("bc44b9a9-5cd6-4195-a7bd-92b4bef6d8fb"), new Guid("7b5f69cb-5996-4a57-b9c6-9fee2a791bf6"), 40, 23, 2, 60000.0, 1, "Data Analyst", new DateTime(2024, 10, 22, 17, 13, 12, 906, DateTimeKind.Local).AddTicks(7397), null, new Guid("376764fa-28ec-4a08-80e3-a6ab407e8601"), new Guid("bf38a1b9-dee3-455a-87c1-4e034fe806f7") },
                    { new Guid("57a0a2a3-d146-455f-acc5-9bdb26876d8a"), new DateTime(2025, 1, 22, 17, 13, 12, 906, DateTimeKind.Local).AddTicks(7317), new Guid("540f318e-b42f-4485-9e60-8faa5bf80962"), new Guid("8520a30d-7152-43d1-a87a-5ef858506350"), new DateTime(2024, 10, 22, 17, 13, 12, 906, DateTimeKind.Local).AddTicks(7341), null, "Develop and maintain web applications.", 10, new Guid("bc4ecf1e-8841-47f2-86ec-b0c523f03da1"), new Guid("79685cdb-be26-49cc-b7f9-1fb51686f5ba"), 35, 21, 1, 80000.0, 1, "Software Engineer", new DateTime(2024, 10, 22, 17, 13, 12, 906, DateTimeKind.Local).AddTicks(7342), null, new Guid("04a9de34-0869-41b2-87a8-63c20c4ba22a"), new Guid("67db1aef-c1b1-4424-8313-774a5dccdb9d") },
                    { new Guid("7d615254-6a0b-483e-8c7e-395ad03ae399"), new DateTime(2025, 2, 22, 17, 13, 12, 906, DateTimeKind.Local).AddTicks(7400), new Guid("540f318e-b42f-4485-9e60-8faa5bf80962"), new Guid("69d3dce1-544e-40ca-84fc-71cba06c7247"), new DateTime(2024, 10, 22, 17, 13, 12, 906, DateTimeKind.Local).AddTicks(7404), null, "Oversee product development lifecycle.", 20, new Guid("a3fb036a-04fc-4590-b87d-6ed32e2ec692"), new Guid("12497687-64b8-4d8e-814a-b7d1d33d3aab"), 45, 28, 3, 95000.0, 1, "Product Manager", new DateTime(2024, 10, 22, 17, 13, 12, 906, DateTimeKind.Local).AddTicks(7405), null, new Guid("c199da74-c2fb-4381-b093-cf2f1e3e8f06"), new Guid("646ccd9f-aa2f-413e-8d3e-eb8ab0b14c96") },
                    { new Guid("f91bb54d-4ac9-4089-bc0a-e3981e9298b3"), new DateTime(2025, 1, 22, 17, 13, 12, 906, DateTimeKind.Local).AddTicks(7408), new Guid("44b668b2-09ee-499e-af95-73598f9153a2"), new Guid("8520a30d-7152-43d1-a87a-5ef858506350"), new DateTime(2024, 10, 22, 17, 13, 12, 906, DateTimeKind.Local).AddTicks(7412), null, "Design intuitive user interfaces.", 25, new Guid("bc4ecf1e-8841-47f2-86ec-b0c523f03da1"), new Guid("79685cdb-be26-49cc-b7f9-1fb51686f5ba"), 38, 24, 4, 70000.0, 1, "UX Designer", new DateTime(2024, 10, 22, 17, 13, 12, 906, DateTimeKind.Local).AddTicks(7413), null, new Guid("04a9de34-0869-41b2-87a8-63c20c4ba22a"), new Guid("cc4121b2-72c2-4226-ad12-24e722b50cc2") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_PositionApplications_PositionId",
                table: "PositionApplications",
                column: "PositionId");

            migrationBuilder.CreateIndex(
                name: "IX_PositionApplications_UserId",
                table: "PositionApplications",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Positions_CommitmentTypeId",
                table: "Positions",
                column: "CommitmentTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Positions_CompanyId",
                table: "Positions",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Positions_EducationLevelRequirementId",
                table: "Positions",
                column: "EducationLevelRequirementId");

            migrationBuilder.CreateIndex(
                name: "IX_Positions_GenderRequirementId",
                table: "Positions",
                column: "GenderRequirementId");

            migrationBuilder.CreateIndex(
                name: "IX_Positions_WorkArrangementId",
                table: "Positions",
                column: "WorkArrangementId");

            migrationBuilder.CreateIndex(
                name: "IX_Positions_WorkExperienceRequirementId",
                table: "Positions",
                column: "WorkExperienceRequirementId");
        }
    }
}
