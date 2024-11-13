using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JobFinder.Migrations
{
    /// <inheritdoc />
    public partial class AddCoverLetterAndPhoneNumberForApplication : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CoverLetter",
                table: "JobApplications",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Phonenumber",
                table: "JobApplications",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("17e0cd7e-5887-44e2-bf2a-cd1b1f631f76"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 4, 13, 17, 3, 17, 605, DateTimeKind.Local).AddTicks(3761), new DateTime(2024, 11, 13, 17, 3, 17, 605, DateTimeKind.Local).AddTicks(3765), new DateTime(2024, 11, 13, 17, 3, 17, 605, DateTimeKind.Local).AddTicks(3765) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("1b9a3a57-5a94-4cc3-9af1-0380d074dd65"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 13, 17, 3, 17, 605, DateTimeKind.Local).AddTicks(3780), new DateTime(2024, 11, 13, 17, 3, 17, 605, DateTimeKind.Local).AddTicks(3785), new DateTime(2024, 11, 13, 17, 3, 17, 605, DateTimeKind.Local).AddTicks(3785) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("1c8a7d6b-2d7f-4c2b-a9c5-8b3e9f6f2d8b"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 13, 17, 3, 17, 605, DateTimeKind.Local).AddTicks(3732), new DateTime(2024, 11, 13, 17, 3, 17, 605, DateTimeKind.Local).AddTicks(3736), new DateTime(2024, 11, 13, 17, 3, 17, 605, DateTimeKind.Local).AddTicks(3737) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("1d41e60a-ffb5-4039-b4b6-3e25e68d0f2c"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 3, 17, 605, DateTimeKind.Local).AddTicks(3767), new DateTime(2024, 11, 13, 17, 3, 17, 605, DateTimeKind.Local).AddTicks(3771), new DateTime(2024, 11, 13, 17, 3, 17, 605, DateTimeKind.Local).AddTicks(3771) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("22aadfc7-6022-4f15-ac49-13fa33f8afbe"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 13, 17, 3, 17, 605, DateTimeKind.Local).AddTicks(3576), new DateTime(2024, 11, 13, 17, 3, 17, 605, DateTimeKind.Local).AddTicks(3580), new DateTime(2024, 11, 13, 17, 3, 17, 605, DateTimeKind.Local).AddTicks(3580) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("3d6b9f9b-6f2d-4b4a-b4c7-2c8b5f4e1b4e"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 13, 17, 3, 17, 605, DateTimeKind.Local).AddTicks(3680), new DateTime(2024, 11, 13, 17, 3, 17, 605, DateTimeKind.Local).AddTicks(3684), new DateTime(2024, 11, 13, 17, 3, 17, 605, DateTimeKind.Local).AddTicks(3684) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("3d8db2d5-5020-497e-917b-500a1f663c60"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 4, 13, 17, 3, 17, 605, DateTimeKind.Local).AddTicks(3815), new DateTime(2024, 11, 13, 17, 3, 17, 605, DateTimeKind.Local).AddTicks(3819), new DateTime(2024, 11, 13, 17, 3, 17, 605, DateTimeKind.Local).AddTicks(3820) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("4b3dff90-4d8a-4cbb-a3e8-6c7e5a4d3c4a"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 13, 17, 3, 17, 605, DateTimeKind.Local).AddTicks(3686), new DateTime(2024, 11, 13, 17, 3, 17, 605, DateTimeKind.Local).AddTicks(3690), new DateTime(2024, 11, 13, 17, 3, 17, 605, DateTimeKind.Local).AddTicks(3691) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("4c695d62-51f0-4070-a625-c030208dffb7"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 13, 17, 3, 17, 605, DateTimeKind.Local).AddTicks(3502), new DateTime(2024, 11, 13, 17, 3, 17, 605, DateTimeKind.Local).AddTicks(3527), new DateTime(2024, 11, 13, 17, 3, 17, 605, DateTimeKind.Local).AddTicks(3527) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("5540bd1d-b228-410e-8fbf-0842aeda7cb1"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 13, 17, 3, 17, 605, DateTimeKind.Local).AddTicks(3530), new DateTime(2024, 11, 13, 17, 3, 17, 605, DateTimeKind.Local).AddTicks(3535), new DateTime(2024, 11, 13, 17, 3, 17, 605, DateTimeKind.Local).AddTicks(3536) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("571827fa-78f4-4192-ad3b-06bb014309c2"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 13, 17, 3, 17, 605, DateTimeKind.Local).AddTicks(3539), new DateTime(2024, 11, 13, 17, 3, 17, 605, DateTimeKind.Local).AddTicks(3544), new DateTime(2024, 11, 13, 17, 3, 17, 605, DateTimeKind.Local).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("5f9c2d8f-a7f2-45a4-8e4a-90b8f7a03b3e"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 13, 17, 3, 17, 605, DateTimeKind.Local).AddTicks(3615), new DateTime(2024, 11, 13, 17, 3, 17, 605, DateTimeKind.Local).AddTicks(3621), new DateTime(2024, 11, 13, 17, 3, 17, 605, DateTimeKind.Local).AddTicks(3622) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("6f0e2a6f-54d7-493c-bcb4-8f5eeb2fba1b"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 13, 17, 3, 17, 605, DateTimeKind.Local).AddTicks(3808), new DateTime(2024, 11, 13, 17, 3, 17, 605, DateTimeKind.Local).AddTicks(3813), new DateTime(2024, 11, 13, 17, 3, 17, 605, DateTimeKind.Local).AddTicks(3813) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("7c7616f2-3c2c-4c5f-9f40-470e78a847c7"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 13, 17, 3, 17, 605, DateTimeKind.Local).AddTicks(3822), new DateTime(2024, 11, 13, 17, 3, 17, 605, DateTimeKind.Local).AddTicks(3826), new DateTime(2024, 11, 13, 17, 3, 17, 605, DateTimeKind.Local).AddTicks(3826) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("82cfed84-d067-4d70-bef9-f08b0636a6b0"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 13, 17, 3, 17, 605, DateTimeKind.Local).AddTicks(3787), new DateTime(2024, 11, 13, 17, 3, 17, 605, DateTimeKind.Local).AddTicks(3792), new DateTime(2024, 11, 13, 17, 3, 17, 605, DateTimeKind.Local).AddTicks(3792) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("8845c741-6b0f-4f95-b179-3d007ba28a41"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 13, 17, 3, 17, 605, DateTimeKind.Local).AddTicks(3582), new DateTime(2024, 11, 13, 17, 3, 17, 605, DateTimeKind.Local).AddTicks(3586), new DateTime(2024, 11, 13, 17, 3, 17, 605, DateTimeKind.Local).AddTicks(3587) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("8c78bbac-4a5e-49ab-aafb-5a6c3f0c4b5d"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 6, 13, 17, 3, 17, 605, DateTimeKind.Local).AddTicks(3672), new DateTime(2024, 11, 13, 17, 3, 17, 605, DateTimeKind.Local).AddTicks(3677), new DateTime(2024, 11, 13, 17, 3, 17, 605, DateTimeKind.Local).AddTicks(3678) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("8f31d3d0-dc53-45d6-bccd-fd2d15dacb77"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 13, 17, 3, 17, 605, DateTimeKind.Local).AddTicks(3589), new DateTime(2024, 11, 13, 17, 3, 17, 605, DateTimeKind.Local).AddTicks(3594), new DateTime(2024, 11, 13, 17, 3, 17, 605, DateTimeKind.Local).AddTicks(3594) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("9127e8f9-a91c-4dca-8008-3cb7a8dcfb22"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 13, 17, 3, 17, 605, DateTimeKind.Local).AddTicks(3561), new DateTime(2024, 11, 13, 17, 3, 17, 605, DateTimeKind.Local).AddTicks(3565), new DateTime(2024, 11, 13, 17, 3, 17, 605, DateTimeKind.Local).AddTicks(3566) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("a6b3ec6a-1d44-4b00-aa18-7d3f1a2e2f6d"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 13, 17, 3, 17, 605, DateTimeKind.Local).AddTicks(3603), new DateTime(2024, 11, 13, 17, 3, 17, 605, DateTimeKind.Local).AddTicks(3607), new DateTime(2024, 11, 13, 17, 3, 17, 605, DateTimeKind.Local).AddTicks(3607) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("af7bcf34-a92d-4b2b-9937-3e6b7f4f2c6d"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 13, 17, 3, 17, 605, DateTimeKind.Local).AddTicks(3695), new DateTime(2024, 11, 13, 17, 3, 17, 605, DateTimeKind.Local).AddTicks(3727), new DateTime(2024, 11, 13, 17, 3, 17, 605, DateTimeKind.Local).AddTicks(3727) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("b3f9d8c7-a1f4-4e3d-b7c2-7e3f9a4f1c5d"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 4, 13, 17, 3, 17, 605, DateTimeKind.Local).AddTicks(3739), new DateTime(2024, 11, 13, 17, 3, 17, 605, DateTimeKind.Local).AddTicks(3744), new DateTime(2024, 11, 13, 17, 3, 17, 605, DateTimeKind.Local).AddTicks(3744) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("c0a173ff-5be0-4bc9-877b-8d632eeb6da6"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 13, 17, 3, 17, 605, DateTimeKind.Local).AddTicks(3829), new DateTime(2024, 11, 13, 17, 3, 17, 605, DateTimeKind.Local).AddTicks(3833), new DateTime(2024, 11, 13, 17, 3, 17, 605, DateTimeKind.Local).AddTicks(3833) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("c3d3aa6b-ac70-4aa9-a8c2-88b3e0581d87"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 13, 17, 3, 17, 605, DateTimeKind.Local).AddTicks(3554), new DateTime(2024, 11, 13, 17, 3, 17, 605, DateTimeKind.Local).AddTicks(3558), new DateTime(2024, 11, 13, 17, 3, 17, 605, DateTimeKind.Local).AddTicks(3558) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("c3e8ff99-9f1a-4e4e-aaa4-4d1c8e5e3b5a"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 3, 17, 605, DateTimeKind.Local).AddTicks(3609), new DateTime(2024, 11, 13, 17, 3, 17, 605, DateTimeKind.Local).AddTicks(3613), new DateTime(2024, 11, 13, 17, 3, 17, 605, DateTimeKind.Local).AddTicks(3614) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("c8e2c78e-f68e-4c7e-a22f-5c81b4b5a8b0"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 13, 17, 3, 17, 605, DateTimeKind.Local).AddTicks(3801), new DateTime(2024, 11, 13, 17, 3, 17, 605, DateTimeKind.Local).AddTicks(3805), new DateTime(2024, 11, 13, 17, 3, 17, 605, DateTimeKind.Local).AddTicks(3806) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("ca01ec6a-8d39-4e00-ab98-6c3f9a2e0b1e"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 13, 17, 3, 17, 605, DateTimeKind.Local).AddTicks(3546), new DateTime(2024, 11, 13, 17, 3, 17, 605, DateTimeKind.Local).AddTicks(3550), new DateTime(2024, 11, 13, 17, 3, 17, 605, DateTimeKind.Local).AddTicks(3551) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("d0d69bba-c6c0-4e1e-b8a1-9b4b44e69b93"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 13, 17, 3, 17, 605, DateTimeKind.Local).AddTicks(3774), new DateTime(2024, 11, 13, 17, 3, 17, 605, DateTimeKind.Local).AddTicks(3778), new DateTime(2024, 11, 13, 17, 3, 17, 605, DateTimeKind.Local).AddTicks(3779) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("dd6b2a14-0f8b-41a8-ae5d-53de0a92d764"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 13, 17, 3, 17, 605, DateTimeKind.Local).AddTicks(3746), new DateTime(2024, 11, 13, 17, 3, 17, 605, DateTimeKind.Local).AddTicks(3751), new DateTime(2024, 11, 13, 17, 3, 17, 605, DateTimeKind.Local).AddTicks(3751) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("def969c3-e7ad-4f71-9907-2c0d594d3ecb"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 13, 17, 3, 17, 605, DateTimeKind.Local).AddTicks(3568), new DateTime(2024, 11, 13, 17, 3, 17, 605, DateTimeKind.Local).AddTicks(3572), new DateTime(2024, 11, 13, 17, 3, 17, 605, DateTimeKind.Local).AddTicks(3572) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("df024b07-216f-41d7-b79b-25eb8f28762d"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 4, 13, 17, 3, 17, 605, DateTimeKind.Local).AddTicks(3794), new DateTime(2024, 11, 13, 17, 3, 17, 605, DateTimeKind.Local).AddTicks(3798), new DateTime(2024, 11, 13, 17, 3, 17, 605, DateTimeKind.Local).AddTicks(3799) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("f07a1be4-bd6d-4c2d-9537-303e0c7a5dcf"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 13, 17, 3, 17, 605, DateTimeKind.Local).AddTicks(3754), new DateTime(2024, 11, 13, 17, 3, 17, 605, DateTimeKind.Local).AddTicks(3758), new DateTime(2024, 11, 13, 17, 3, 17, 605, DateTimeKind.Local).AddTicks(3759) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("fa01ec6a-8d39-4e00-ab98-6c3f9a2e0b1f"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 4, 13, 17, 3, 17, 605, DateTimeKind.Local).AddTicks(3597), new DateTime(2024, 11, 13, 17, 3, 17, 605, DateTimeKind.Local).AddTicks(3600), new DateTime(2024, 11, 13, 17, 3, 17, 605, DateTimeKind.Local).AddTicks(3601) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CoverLetter",
                table: "JobApplications");

            migrationBuilder.DropColumn(
                name: "Phonenumber",
                table: "JobApplications");

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("17e0cd7e-5887-44e2-bf2a-cd1b1f631f76"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 4, 8, 16, 0, 28, 323, DateTimeKind.Local).AddTicks(7825), new DateTime(2024, 11, 8, 16, 0, 28, 323, DateTimeKind.Local).AddTicks(7830), new DateTime(2024, 11, 8, 16, 0, 28, 323, DateTimeKind.Local).AddTicks(7831) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("1b9a3a57-5a94-4cc3-9af1-0380d074dd65"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 8, 16, 0, 28, 323, DateTimeKind.Local).AddTicks(7856), new DateTime(2024, 11, 8, 16, 0, 28, 323, DateTimeKind.Local).AddTicks(7861), new DateTime(2024, 11, 8, 16, 0, 28, 323, DateTimeKind.Local).AddTicks(7862) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("1c8a7d6b-2d7f-4c2b-a9c5-8b3e9f6f2d8b"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 8, 16, 0, 28, 323, DateTimeKind.Local).AddTicks(7793), new DateTime(2024, 11, 8, 16, 0, 28, 323, DateTimeKind.Local).AddTicks(7798), new DateTime(2024, 11, 8, 16, 0, 28, 323, DateTimeKind.Local).AddTicks(7798) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("1d41e60a-ffb5-4039-b4b6-3e25e68d0f2c"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 8, 16, 0, 28, 323, DateTimeKind.Local).AddTicks(7834), new DateTime(2024, 11, 8, 16, 0, 28, 323, DateTimeKind.Local).AddTicks(7840), new DateTime(2024, 11, 8, 16, 0, 28, 323, DateTimeKind.Local).AddTicks(7841) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("22aadfc7-6022-4f15-ac49-13fa33f8afbe"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 8, 16, 0, 28, 323, DateTimeKind.Local).AddTicks(7664), new DateTime(2024, 11, 8, 16, 0, 28, 323, DateTimeKind.Local).AddTicks(7668), new DateTime(2024, 11, 8, 16, 0, 28, 323, DateTimeKind.Local).AddTicks(7668) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("3d6b9f9b-6f2d-4b4a-b4c7-2c8b5f4e1b4e"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 8, 16, 0, 28, 323, DateTimeKind.Local).AddTicks(7737), new DateTime(2024, 11, 8, 16, 0, 28, 323, DateTimeKind.Local).AddTicks(7740), new DateTime(2024, 11, 8, 16, 0, 28, 323, DateTimeKind.Local).AddTicks(7741) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("3d8db2d5-5020-497e-917b-500a1f663c60"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 4, 8, 16, 0, 28, 323, DateTimeKind.Local).AddTicks(7904), new DateTime(2024, 11, 8, 16, 0, 28, 323, DateTimeKind.Local).AddTicks(7911), new DateTime(2024, 11, 8, 16, 0, 28, 323, DateTimeKind.Local).AddTicks(7912) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("4b3dff90-4d8a-4cbb-a3e8-6c7e5a4d3c4a"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 8, 16, 0, 28, 323, DateTimeKind.Local).AddTicks(7743), new DateTime(2024, 11, 8, 16, 0, 28, 323, DateTimeKind.Local).AddTicks(7748), new DateTime(2024, 11, 8, 16, 0, 28, 323, DateTimeKind.Local).AddTicks(7748) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("4c695d62-51f0-4070-a625-c030208dffb7"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 8, 16, 0, 28, 323, DateTimeKind.Local).AddTicks(7552), new DateTime(2024, 11, 8, 16, 0, 28, 323, DateTimeKind.Local).AddTicks(7597), new DateTime(2024, 11, 8, 16, 0, 28, 323, DateTimeKind.Local).AddTicks(7598) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("5540bd1d-b228-410e-8fbf-0842aeda7cb1"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 8, 16, 0, 28, 323, DateTimeKind.Local).AddTicks(7608), new DateTime(2024, 11, 8, 16, 0, 28, 323, DateTimeKind.Local).AddTicks(7614), new DateTime(2024, 11, 8, 16, 0, 28, 323, DateTimeKind.Local).AddTicks(7615) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("571827fa-78f4-4192-ad3b-06bb014309c2"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 8, 16, 0, 28, 323, DateTimeKind.Local).AddTicks(7617), new DateTime(2024, 11, 8, 16, 0, 28, 323, DateTimeKind.Local).AddTicks(7622), new DateTime(2024, 11, 8, 16, 0, 28, 323, DateTimeKind.Local).AddTicks(7622) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("5f9c2d8f-a7f2-45a4-8e4a-90b8f7a03b3e"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 8, 16, 0, 28, 323, DateTimeKind.Local).AddTicks(7722), new DateTime(2024, 11, 8, 16, 0, 28, 323, DateTimeKind.Local).AddTicks(7727), new DateTime(2024, 11, 8, 16, 0, 28, 323, DateTimeKind.Local).AddTicks(7727) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("6f0e2a6f-54d7-493c-bcb4-8f5eeb2fba1b"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 8, 16, 0, 28, 323, DateTimeKind.Local).AddTicks(7895), new DateTime(2024, 11, 8, 16, 0, 28, 323, DateTimeKind.Local).AddTicks(7900), new DateTime(2024, 11, 8, 16, 0, 28, 323, DateTimeKind.Local).AddTicks(7901) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("7c7616f2-3c2c-4c5f-9f40-470e78a847c7"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 8, 16, 0, 28, 323, DateTimeKind.Local).AddTicks(7915), new DateTime(2024, 11, 8, 16, 0, 28, 323, DateTimeKind.Local).AddTicks(7922), new DateTime(2024, 11, 8, 16, 0, 28, 323, DateTimeKind.Local).AddTicks(7923) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("82cfed84-d067-4d70-bef9-f08b0636a6b0"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 8, 16, 0, 28, 323, DateTimeKind.Local).AddTicks(7866), new DateTime(2024, 11, 8, 16, 0, 28, 323, DateTimeKind.Local).AddTicks(7873), new DateTime(2024, 11, 8, 16, 0, 28, 323, DateTimeKind.Local).AddTicks(7873) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("8845c741-6b0f-4f95-b179-3d007ba28a41"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 8, 16, 0, 28, 323, DateTimeKind.Local).AddTicks(7670), new DateTime(2024, 11, 8, 16, 0, 28, 323, DateTimeKind.Local).AddTicks(7680), new DateTime(2024, 11, 8, 16, 0, 28, 323, DateTimeKind.Local).AddTicks(7680) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("8c78bbac-4a5e-49ab-aafb-5a6c3f0c4b5d"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 6, 8, 16, 0, 28, 323, DateTimeKind.Local).AddTicks(7730), new DateTime(2024, 11, 8, 16, 0, 28, 323, DateTimeKind.Local).AddTicks(7734), new DateTime(2024, 11, 8, 16, 0, 28, 323, DateTimeKind.Local).AddTicks(7735) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("8f31d3d0-dc53-45d6-bccd-fd2d15dacb77"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 8, 16, 0, 28, 323, DateTimeKind.Local).AddTicks(7683), new DateTime(2024, 11, 8, 16, 0, 28, 323, DateTimeKind.Local).AddTicks(7691), new DateTime(2024, 11, 8, 16, 0, 28, 323, DateTimeKind.Local).AddTicks(7692) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("9127e8f9-a91c-4dca-8008-3cb7a8dcfb22"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 8, 16, 0, 28, 323, DateTimeKind.Local).AddTicks(7645), new DateTime(2024, 11, 8, 16, 0, 28, 323, DateTimeKind.Local).AddTicks(7651), new DateTime(2024, 11, 8, 16, 0, 28, 323, DateTimeKind.Local).AddTicks(7652) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("a6b3ec6a-1d44-4b00-aa18-7d3f1a2e2f6d"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 8, 16, 0, 28, 323, DateTimeKind.Local).AddTicks(7703), new DateTime(2024, 11, 8, 16, 0, 28, 323, DateTimeKind.Local).AddTicks(7710), new DateTime(2024, 11, 8, 16, 0, 28, 323, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("af7bcf34-a92d-4b2b-9937-3e6b7f4f2c6d"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 8, 16, 0, 28, 323, DateTimeKind.Local).AddTicks(7785), new DateTime(2024, 11, 8, 16, 0, 28, 323, DateTimeKind.Local).AddTicks(7790), new DateTime(2024, 11, 8, 16, 0, 28, 323, DateTimeKind.Local).AddTicks(7791) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("b3f9d8c7-a1f4-4e3d-b7c2-7e3f9a4f1c5d"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 4, 8, 16, 0, 28, 323, DateTimeKind.Local).AddTicks(7800), new DateTime(2024, 11, 8, 16, 0, 28, 323, DateTimeKind.Local).AddTicks(7804), new DateTime(2024, 11, 8, 16, 0, 28, 323, DateTimeKind.Local).AddTicks(7805) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("c0a173ff-5be0-4bc9-877b-8d632eeb6da6"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 8, 16, 0, 28, 323, DateTimeKind.Local).AddTicks(7925), new DateTime(2024, 11, 8, 16, 0, 28, 323, DateTimeKind.Local).AddTicks(7930), new DateTime(2024, 11, 8, 16, 0, 28, 323, DateTimeKind.Local).AddTicks(7931) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("c3d3aa6b-ac70-4aa9-a8c2-88b3e0581d87"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 8, 16, 0, 28, 323, DateTimeKind.Local).AddTicks(7632), new DateTime(2024, 11, 8, 16, 0, 28, 323, DateTimeKind.Local).AddTicks(7637), new DateTime(2024, 11, 8, 16, 0, 28, 323, DateTimeKind.Local).AddTicks(7637) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("c3e8ff99-9f1a-4e4e-aaa4-4d1c8e5e3b5a"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 8, 16, 0, 28, 323, DateTimeKind.Local).AddTicks(7713), new DateTime(2024, 11, 8, 16, 0, 28, 323, DateTimeKind.Local).AddTicks(7719), new DateTime(2024, 11, 8, 16, 0, 28, 323, DateTimeKind.Local).AddTicks(7719) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("c8e2c78e-f68e-4c7e-a22f-5c81b4b5a8b0"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 8, 16, 0, 28, 323, DateTimeKind.Local).AddTicks(7885), new DateTime(2024, 11, 8, 16, 0, 28, 323, DateTimeKind.Local).AddTicks(7892), new DateTime(2024, 11, 8, 16, 0, 28, 323, DateTimeKind.Local).AddTicks(7893) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("ca01ec6a-8d39-4e00-ab98-6c3f9a2e0b1e"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 8, 16, 0, 28, 323, DateTimeKind.Local).AddTicks(7624), new DateTime(2024, 11, 8, 16, 0, 28, 323, DateTimeKind.Local).AddTicks(7628), new DateTime(2024, 11, 8, 16, 0, 28, 323, DateTimeKind.Local).AddTicks(7629) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("d0d69bba-c6c0-4e1e-b8a1-9b4b44e69b93"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 8, 16, 0, 28, 323, DateTimeKind.Local).AddTicks(7845), new DateTime(2024, 11, 8, 16, 0, 28, 323, DateTimeKind.Local).AddTicks(7850), new DateTime(2024, 11, 8, 16, 0, 28, 323, DateTimeKind.Local).AddTicks(7851) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("dd6b2a14-0f8b-41a8-ae5d-53de0a92d764"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 8, 16, 0, 28, 323, DateTimeKind.Local).AddTicks(7808), new DateTime(2024, 11, 8, 16, 0, 28, 323, DateTimeKind.Local).AddTicks(7813), new DateTime(2024, 11, 8, 16, 0, 28, 323, DateTimeKind.Local).AddTicks(7814) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("def969c3-e7ad-4f71-9907-2c0d594d3ecb"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 8, 16, 0, 28, 323, DateTimeKind.Local).AddTicks(7654), new DateTime(2024, 11, 8, 16, 0, 28, 323, DateTimeKind.Local).AddTicks(7658), new DateTime(2024, 11, 8, 16, 0, 28, 323, DateTimeKind.Local).AddTicks(7658) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("df024b07-216f-41d7-b79b-25eb8f28762d"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 4, 8, 16, 0, 28, 323, DateTimeKind.Local).AddTicks(7876), new DateTime(2024, 11, 8, 16, 0, 28, 323, DateTimeKind.Local).AddTicks(7881), new DateTime(2024, 11, 8, 16, 0, 28, 323, DateTimeKind.Local).AddTicks(7881) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("f07a1be4-bd6d-4c2d-9537-303e0c7a5dcf"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 8, 16, 0, 28, 323, DateTimeKind.Local).AddTicks(7816), new DateTime(2024, 11, 8, 16, 0, 28, 323, DateTimeKind.Local).AddTicks(7820), new DateTime(2024, 11, 8, 16, 0, 28, 323, DateTimeKind.Local).AddTicks(7822) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("fa01ec6a-8d39-4e00-ab98-6c3f9a2e0b1f"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 4, 8, 16, 0, 28, 323, DateTimeKind.Local).AddTicks(7693), new DateTime(2024, 11, 8, 16, 0, 28, 323, DateTimeKind.Local).AddTicks(7701), new DateTime(2024, 11, 8, 16, 0, 28, 323, DateTimeKind.Local).AddTicks(7701) });
        }
    }
}
