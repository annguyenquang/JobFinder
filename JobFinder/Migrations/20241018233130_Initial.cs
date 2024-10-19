using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace JobFinder.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Accounts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UpdatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Accounts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Metadatas",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Metadatas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Companies",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AccountId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmailContact = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneContact = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmployeeCount = table.Column<int>(type: "int", nullable: true),
                    Slug = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Website = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Industry = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UpdatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Companies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Companies_Accounts_AccountId",
                        column: x => x.AccountId,
                        principalTable: "Accounts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AccountId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateOfBirth = table.Column<DateOnly>(type: "date", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UpdatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_Accounts_AccountId",
                        column: x => x.AccountId,
                        principalTable: "Accounts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Positions",
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
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
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
                values: new object[] { new Guid("cf325fca-4731-4318-a084-070a999e2eae"), null, null, "admin@gmail.com", "Admin", "0123456789", null, null, "Admin" });

            migrationBuilder.InsertData(
                table: "Metadatas",
                columns: new[] { "Id", "Type", "Value" },
                values: new object[,]
                {
                    { new Guid("176a4cc6-548b-4676-b6be-7145213ae61f"), 2, "{data: \"FreshGradute\"}" },
                    { new Guid("1f02c478-a95b-41e6-a7f0-3a2b94fe8076"), 4, "{data: \"Female\"}" },
                    { new Guid("20ef9a77-0cde-47d3-976c-81bb10cb5048"), 2, "{data: \"ThreeToFiveYears\"}" },
                    { new Guid("304b7d54-c3e4-48bb-9822-2a9b40f8681e"), 3, "{data: \"MasterDegree\"}" },
                    { new Guid("32616001-1f3f-4158-8596-d4376712ae90"), 2, "{data: \"LessThanOneYear\"}" },
                    { new Guid("3316dc61-a893-4abf-b92a-853e03a90240"), 3, "{data: \"PrimarySchool\"}" },
                    { new Guid("36dac619-9ff0-4d23-9367-3911ddf5ef4f"), 3, "{data: \"Doctorate\"}" },
                    { new Guid("3b461d6f-a810-4e7b-9a39-d590fa0c14c5"), 1, "{data: \"Onsite\"}" },
                    { new Guid("3bb22e2e-7cac-4468-886a-c14c2a6d78f6"), 4, "{data: \"Others\"}" },
                    { new Guid("5df29c5c-c741-478d-b642-37a0ca26c87a"), 4, "{data: \"Male\"}" },
                    { new Guid("62d8b5b6-49ff-400e-afb8-6f1c07897acc"), 2, "{data: \"MoreThanTenYears\"}" },
                    { new Guid("8eaf06a3-9bb1-4f26-9876-2eed0d18362b"), 1, "{data: \"Remote/WFH\"}" },
                    { new Guid("918d7f92-69c0-4bf3-aa64-11db742da2e4"), 0, "{data: \"PartTime\"}" },
                    { new Guid("93ebd4a3-353b-405e-8f44-706dd6eccefc"), 2, "{data: \"OneToThreeYears\"}" },
                    { new Guid("9c7485f9-53fa-47dc-9365-6b3991395b97"), 3, "{data: \"CollegeDegree\"}" },
                    { new Guid("a25645d2-6603-4661-89a7-3a0a50c3dde2"), 0, "{data: \"Fulltime\"}" },
                    { new Guid("a60e6d73-9b12-41c1-bde9-b7b49bd77f78"), 3, "{data: \"SecondarySchool\"}" },
                    { new Guid("a896f2c4-101f-4ad3-9182-2de8e7482b2b"), 0, "{data: \"Contract\"}" },
                    { new Guid("ad081538-b194-4eaa-b165-bbc00b8d3ccc"), 1, "{data: \"Hybrid\"}" },
                    { new Guid("ae75f7ae-806b-4c39-9107-9fc34ba0753d"), 0, "{data: \"Daily\"}" },
                    { new Guid("c4efb270-f3c0-4f2f-8064-38cfa5822eb7"), 0, "{data: \"Internship\"}" },
                    { new Guid("ce00f064-2f1a-49cd-97dc-244b939d0061"), 0, "{data: \"Freelance\"}" },
                    { new Guid("d235d8cf-d8dd-42d6-b8af-2f2bb1b23cc1"), 3, "{data: \"BachelorDegree\"}" },
                    { new Guid("d30eb6f0-fd51-412f-aa60-1b1b017e93f6"), 2, "{data: \"FiveToTenYears\"}" },
                    { new Guid("de21e631-fc69-42e6-89ff-176b80a3511b"), 3, "{data: \"Diploma\"}" },
                    { new Guid("f58f0289-52e2-4d96-ae21-e10ab6cbfd8d"), 3, "{data: \"SeniorOrVocationalHighSchool\"}" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Companies_AccountId",
                table: "Companies",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_Companies_Slug",
                table: "Companies",
                column: "Slug",
                unique: true);

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

            migrationBuilder.CreateIndex(
                name: "IX_Users_AccountId",
                table: "Users",
                column: "AccountId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PositionApplications");

            migrationBuilder.DropTable(
                name: "Positions");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Companies");

            migrationBuilder.DropTable(
                name: "Metadatas");

            migrationBuilder.DropTable(
                name: "Accounts");
        }
    }
}
