using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JobFinder.Migrations
{
    /// <inheritdoc />
    public partial class AddPositionColumn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("edc7a930-0226-42fe-aa78-c161711e8785"));

            migrationBuilder.AlterColumn<double>(
                name: "Salary",
                table: "Positions",
                type: "float",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AddColumn<int>(
                name: "CommitmentType",
                table: "Positions",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DistrictId",
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
                name: "MaxAgeRequirement",
                table: "Positions",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MinAgeRequirement",
                table: "Positions",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ProvinceId",
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
                values: new object[] { new Guid("fdd48c46-5824-4565-af02-8470b0213166"), null, null, "admin@gmail.com", "Admin", "0123456789", null, null, "Admin" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("fdd48c46-5824-4565-af02-8470b0213166"));

            migrationBuilder.DropColumn(
                name: "CommitmentType",
                table: "Positions");

            migrationBuilder.DropColumn(
                name: "DistrictId",
                table: "Positions");

            migrationBuilder.DropColumn(
                name: "EducationLevelRequirement",
                table: "Positions");

            migrationBuilder.DropColumn(
                name: "GenderRequirement",
                table: "Positions");

            migrationBuilder.DropColumn(
                name: "MaxAgeRequirement",
                table: "Positions");

            migrationBuilder.DropColumn(
                name: "MinAgeRequirement",
                table: "Positions");

            migrationBuilder.DropColumn(
                name: "ProvinceId",
                table: "Positions");

            migrationBuilder.DropColumn(
                name: "WorkArrangement",
                table: "Positions");

            migrationBuilder.DropColumn(
                name: "WorkExperienceRequirement",
                table: "Positions");

            migrationBuilder.AlterColumn<double>(
                name: "Salary",
                table: "Positions",
                type: "float",
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(double),
                oldType: "float",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "Email", "Password", "Phone", "UpdatedAt", "UpdatedBy", "Username" },
                values: new object[] { new Guid("edc7a930-0226-42fe-aa78-c161711e8785"), null, null, "admin@gmail.com", "Admin", "0123456789", null, null, "Admin" });
        }
    }
}
