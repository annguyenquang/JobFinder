using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace JobFinder.Migrations
{
    /// <inheritdoc />
    public partial class AddMetadataTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("f2eb1697-1342-43b6-82e0-cce758ec73b6"));

            migrationBuilder.DropColumn(
                name: "CommitmentType",
                table: "Positions");

            migrationBuilder.DropColumn(
                name: "EducationLevelRequirement",
                table: "Positions");

            migrationBuilder.DropColumn(
                name: "GenderRequirement",
                table: "Positions");

            migrationBuilder.DropColumn(
                name: "WorkArrangement",
                table: "Positions");

            migrationBuilder.DropColumn(
                name: "WorkExperienceRequirement",
                table: "Positions");

            migrationBuilder.AddColumn<Guid>(
                name: "CommitmentTypeId",
                table: "Positions",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "EducationLevelRequirementId",
                table: "Positions",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "GenderRequirementId",
                table: "Positions",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "WorkArrangementId",
                table: "Positions",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "WorkExperienceRequirementId",
                table: "Positions",
                type: "uniqueidentifier",
                nullable: true);

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

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "Email", "Password", "Phone", "UpdatedAt", "UpdatedBy", "Username" },
                values: new object[] { new Guid("4f26ea9d-1d0e-4b6d-83e9-c1696ccabb99"), null, null, "admin@gmail.com", "Admin", "0123456789", null, null, "Admin" });

            migrationBuilder.InsertData(
                table: "Metadatas",
                columns: new[] { "Id", "Type", "Value" },
                values: new object[,]
                {
                    { new Guid("0207dc22-6ff3-4b41-a6da-9c4df7942bfe"), 2, "{data: \"FiveToTenYears\"}" },
                    { new Guid("0c46b326-26a4-42a4-b2c6-f3f098bf336a"), 3, "{data: \"SeniorOrVocationalHighSchool\"}" },
                    { new Guid("2838271a-52bb-4577-b0b5-06fab068015c"), 2, "{data: \"LessThanOneYear\"}" },
                    { new Guid("31fe64cd-1040-4971-9050-1a8c841df12c"), 1, "{data: \"Remote/WFH\"}" },
                    { new Guid("34bd0080-6600-49fd-8912-4add4a155fa6"), 3, "{data: \"MasterDegree\"}" },
                    { new Guid("41138ae7-e56b-465a-a8c1-d8a3b14b8864"), 3, "{data: \"CollegeDegree\"}" },
                    { new Guid("5b9bca28-d2bf-4af0-8c16-ecb9ead0db79"), 3, "{data: \"PrimarySchool\"}" },
                    { new Guid("65b18c88-f642-4902-8858-9da710a707d8"), 3, "{data: \"Diploma\"}" },
                    { new Guid("6a1352ea-7c62-4e27-ad9f-93d63d9b1f7a"), 2, "{data: \"MoreThanTenYears\"}" },
                    { new Guid("6c2e4155-8e73-4620-9835-92cf0f344f85"), 0, "{data: \"PartTime\"}" },
                    { new Guid("6d77bfa7-61c3-413b-9291-b2b77ab4b23e"), 2, "{data: \"ThreeToFiveYears\"}" },
                    { new Guid("74c02a06-e302-4a3e-aa20-e63b1ae430cf"), 1, "{data: \"Onsite\"}" },
                    { new Guid("81180c69-771d-49b7-a7a1-8b8d2f0cb472"), 0, "{data: \"Internship\"}" },
                    { new Guid("9403d904-2de5-430c-816a-2fe46cf356f1"), 0, "{data: \"Contract\"}" },
                    { new Guid("a2d78a08-4ec6-47a7-9aed-a2ca83c32a2b"), 3, "{data: \"Doctorate\"}" },
                    { new Guid("ad61a5ff-8075-4c77-9bc3-8eb89568efaa"), 2, "{data: \"FreshGradute\"}" },
                    { new Guid("b1389b27-932c-47e9-92a1-93881602fc39"), 0, "{data: \"Freelance\"}" },
                    { new Guid("be9fb1e0-c974-43fc-b898-9fa572812967"), 0, "{data: \"Fulltime\"}" },
                    { new Guid("bf68acba-be50-4845-ac43-a0328bfd37bc"), 2, "{data: \"OneToThreeYears\"}" },
                    { new Guid("bfda60ac-5f66-4bd5-8707-eb914c9fa596"), 3, "{data: \"BachelorDegree\"}" },
                    { new Guid("d6c6ec10-bbe0-44d8-9c7e-51e9e87b0d3c"), 1, "{data: \"Hybrid\"}" },
                    { new Guid("f265e422-9000-4a62-8aad-6c895c078925"), 0, "{data: \"Daily\"}" },
                    { new Guid("fcdb96f8-7e44-4109-9190-617813e993d5"), 3, "{data: \"SecondarySchool\"}" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Positions_CommitmentTypeId",
                table: "Positions",
                column: "CommitmentTypeId");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Positions_Metadatas_CommitmentTypeId",
                table: "Positions",
                column: "CommitmentTypeId",
                principalTable: "Metadatas",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Positions_Metadatas_EducationLevelRequirementId",
                table: "Positions",
                column: "EducationLevelRequirementId",
                principalTable: "Metadatas",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Positions_Metadatas_GenderRequirementId",
                table: "Positions",
                column: "GenderRequirementId",
                principalTable: "Metadatas",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Positions_Metadatas_WorkArrangementId",
                table: "Positions",
                column: "WorkArrangementId",
                principalTable: "Metadatas",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Positions_Metadatas_WorkExperienceRequirementId",
                table: "Positions",
                column: "WorkExperienceRequirementId",
                principalTable: "Metadatas",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Positions_Metadatas_CommitmentTypeId",
                table: "Positions");

            migrationBuilder.DropForeignKey(
                name: "FK_Positions_Metadatas_EducationLevelRequirementId",
                table: "Positions");

            migrationBuilder.DropForeignKey(
                name: "FK_Positions_Metadatas_GenderRequirementId",
                table: "Positions");

            migrationBuilder.DropForeignKey(
                name: "FK_Positions_Metadatas_WorkArrangementId",
                table: "Positions");

            migrationBuilder.DropForeignKey(
                name: "FK_Positions_Metadatas_WorkExperienceRequirementId",
                table: "Positions");

            migrationBuilder.DropTable(
                name: "Metadatas");

            migrationBuilder.DropIndex(
                name: "IX_Positions_CommitmentTypeId",
                table: "Positions");

            migrationBuilder.DropIndex(
                name: "IX_Positions_EducationLevelRequirementId",
                table: "Positions");

            migrationBuilder.DropIndex(
                name: "IX_Positions_GenderRequirementId",
                table: "Positions");

            migrationBuilder.DropIndex(
                name: "IX_Positions_WorkArrangementId",
                table: "Positions");

            migrationBuilder.DropIndex(
                name: "IX_Positions_WorkExperienceRequirementId",
                table: "Positions");

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("4f26ea9d-1d0e-4b6d-83e9-c1696ccabb99"));

            migrationBuilder.DropColumn(
                name: "CommitmentTypeId",
                table: "Positions");

            migrationBuilder.DropColumn(
                name: "EducationLevelRequirementId",
                table: "Positions");

            migrationBuilder.DropColumn(
                name: "GenderRequirementId",
                table: "Positions");

            migrationBuilder.DropColumn(
                name: "WorkArrangementId",
                table: "Positions");

            migrationBuilder.DropColumn(
                name: "WorkExperienceRequirementId",
                table: "Positions");

            migrationBuilder.AddColumn<int>(
                name: "CommitmentType",
                table: "Positions",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EducationLevelRequirement",
                table: "Positions",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "GenderRequirement",
                table: "Positions",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "WorkArrangement",
                table: "Positions",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "WorkExperienceRequirement",
                table: "Positions",
                type: "int",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "Email", "Password", "Phone", "UpdatedAt", "UpdatedBy", "Username" },
                values: new object[] { new Guid("f2eb1697-1342-43b6-82e0-cce758ec73b6"), null, null, "admin@gmail.com", "Admin", "0123456789", null, null, "Admin" });
        }
    }
}
