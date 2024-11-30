using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JobFinder.Migrations
{
    /// <inheritdoc />
    public partial class UpdateProvinceIdAndDistrictId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: new Guid("7f9b407b-80e0-4f0c-a301-5a8bbf813b05"),
                columns: new[] { "DistrictId", "ProvinceId" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: new Guid("ec6aba4a-1b55-412a-a2e7-9ec8b9f16662"),
                columns: new[] { "DistrictId", "ProvinceId" },
                values: new object[] { 303, 31 });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: new Guid("ec7d72b6-e9f4-4c85-bc12-c2db31d5efa7"),
                columns: new[] { "DistrictId", "ProvinceId" },
                values: new object[] { 760, 79 });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("17e0cd7e-5887-44e2-bf2a-cd1b1f631f76"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 4, 30, 23, 44, 4, 446, DateTimeKind.Local).AddTicks(4756), new DateTime(2024, 11, 30, 23, 44, 4, 446, DateTimeKind.Local).AddTicks(4762), new DateTime(2024, 11, 30, 23, 44, 4, 446, DateTimeKind.Local).AddTicks(4763) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("1b9a3a57-5a94-4cc3-9af1-0380d074dd65"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 28, 23, 44, 4, 446, DateTimeKind.Local).AddTicks(4848), new DateTime(2024, 11, 30, 23, 44, 4, 446, DateTimeKind.Local).AddTicks(4852), new DateTime(2024, 11, 30, 23, 44, 4, 446, DateTimeKind.Local).AddTicks(4853) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("1c8a7d6b-2d7f-4c2b-a9c5-8b3e9f6f2d8b"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 28, 23, 44, 4, 446, DateTimeKind.Local).AddTicks(4729), new DateTime(2024, 11, 30, 23, 44, 4, 446, DateTimeKind.Local).AddTicks(4733), new DateTime(2024, 11, 30, 23, 44, 4, 446, DateTimeKind.Local).AddTicks(4733) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("1d41e60a-ffb5-4039-b4b6-3e25e68d0f2c"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 30, 23, 44, 4, 446, DateTimeKind.Local).AddTicks(4765), new DateTime(2024, 11, 30, 23, 44, 4, 446, DateTimeKind.Local).AddTicks(4769), new DateTime(2024, 11, 30, 23, 44, 4, 446, DateTimeKind.Local).AddTicks(4769) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("22aadfc7-6022-4f15-ac49-13fa33f8afbe"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 28, 23, 44, 4, 446, DateTimeKind.Local).AddTicks(4623), new DateTime(2024, 11, 30, 23, 44, 4, 446, DateTimeKind.Local).AddTicks(4627), new DateTime(2024, 11, 30, 23, 44, 4, 446, DateTimeKind.Local).AddTicks(4628) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("3d6b9f9b-6f2d-4b4a-b4c7-2c8b5f4e1b4e"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 28, 23, 44, 4, 446, DateTimeKind.Local).AddTicks(4679), new DateTime(2024, 11, 30, 23, 44, 4, 446, DateTimeKind.Local).AddTicks(4684), new DateTime(2024, 11, 30, 23, 44, 4, 446, DateTimeKind.Local).AddTicks(4685) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("3d8db2d5-5020-497e-917b-500a1f663c60"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 4, 30, 23, 44, 4, 446, DateTimeKind.Local).AddTicks(4883), new DateTime(2024, 11, 30, 23, 44, 4, 446, DateTimeKind.Local).AddTicks(4888), new DateTime(2024, 11, 30, 23, 44, 4, 446, DateTimeKind.Local).AddTicks(4889) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("4b3dff90-4d8a-4cbb-a3e8-6c7e5a4d3c4a"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 30, 23, 44, 4, 446, DateTimeKind.Local).AddTicks(4687), new DateTime(2024, 11, 30, 23, 44, 4, 446, DateTimeKind.Local).AddTicks(4691), new DateTime(2024, 11, 30, 23, 44, 4, 446, DateTimeKind.Local).AddTicks(4691) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("4c695d62-51f0-4070-a625-c030208dffb7"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 28, 23, 44, 4, 446, DateTimeKind.Local).AddTicks(4539), new DateTime(2024, 11, 30, 23, 44, 4, 446, DateTimeKind.Local).AddTicks(4571), new DateTime(2024, 11, 30, 23, 44, 4, 446, DateTimeKind.Local).AddTicks(4572) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("5540bd1d-b228-410e-8fbf-0842aeda7cb1"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 30, 23, 44, 4, 446, DateTimeKind.Local).AddTicks(4579), new DateTime(2024, 11, 30, 23, 44, 4, 446, DateTimeKind.Local).AddTicks(4584), new DateTime(2024, 11, 30, 23, 44, 4, 446, DateTimeKind.Local).AddTicks(4584) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("571827fa-78f4-4192-ad3b-06bb014309c2"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 30, 23, 44, 4, 446, DateTimeKind.Local).AddTicks(4587), new DateTime(2024, 11, 30, 23, 44, 4, 446, DateTimeKind.Local).AddTicks(4591), new DateTime(2024, 11, 30, 23, 44, 4, 446, DateTimeKind.Local).AddTicks(4592) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("5f9c2d8f-a7f2-45a4-8e4a-90b8f7a03b3e"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 30, 23, 44, 4, 446, DateTimeKind.Local).AddTicks(4666), new DateTime(2024, 11, 30, 23, 44, 4, 446, DateTimeKind.Local).AddTicks(4670), new DateTime(2024, 11, 30, 23, 44, 4, 446, DateTimeKind.Local).AddTicks(4670) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("6f0e2a6f-54d7-493c-bcb4-8f5eeb2fba1b"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 30, 23, 44, 4, 446, DateTimeKind.Local).AddTicks(4877), new DateTime(2024, 11, 30, 23, 44, 4, 446, DateTimeKind.Local).AddTicks(4881), new DateTime(2024, 11, 30, 23, 44, 4, 446, DateTimeKind.Local).AddTicks(4881) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("7c7616f2-3c2c-4c5f-9f40-470e78a847c7"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 30, 23, 44, 4, 446, DateTimeKind.Local).AddTicks(4891), new DateTime(2024, 11, 30, 23, 44, 4, 446, DateTimeKind.Local).AddTicks(4895), new DateTime(2024, 11, 30, 23, 44, 4, 446, DateTimeKind.Local).AddTicks(4896) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("82cfed84-d067-4d70-bef9-f08b0636a6b0"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 30, 23, 44, 4, 446, DateTimeKind.Local).AddTicks(4855), new DateTime(2024, 11, 30, 23, 44, 4, 446, DateTimeKind.Local).AddTicks(4859), new DateTime(2024, 11, 30, 23, 44, 4, 446, DateTimeKind.Local).AddTicks(4860) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("8845c741-6b0f-4f95-b179-3d007ba28a41"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 30, 23, 44, 4, 446, DateTimeKind.Local).AddTicks(4630), new DateTime(2024, 11, 30, 23, 44, 4, 446, DateTimeKind.Local).AddTicks(4634), new DateTime(2024, 11, 30, 23, 44, 4, 446, DateTimeKind.Local).AddTicks(4635) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("8c78bbac-4a5e-49ab-aafb-5a6c3f0c4b5d"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 6, 30, 23, 44, 4, 446, DateTimeKind.Local).AddTicks(4672), new DateTime(2024, 11, 30, 23, 44, 4, 446, DateTimeKind.Local).AddTicks(4677), new DateTime(2024, 11, 30, 23, 44, 4, 446, DateTimeKind.Local).AddTicks(4677) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("8f31d3d0-dc53-45d6-bccd-fd2d15dacb77"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 28, 23, 44, 4, 446, DateTimeKind.Local).AddTicks(4637), new DateTime(2024, 11, 30, 23, 44, 4, 446, DateTimeKind.Local).AddTicks(4641), new DateTime(2024, 11, 30, 23, 44, 4, 446, DateTimeKind.Local).AddTicks(4642) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("9127e8f9-a91c-4dca-8008-3cb7a8dcfb22"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 30, 23, 44, 4, 446, DateTimeKind.Local).AddTicks(4609), new DateTime(2024, 11, 30, 23, 44, 4, 446, DateTimeKind.Local).AddTicks(4614), new DateTime(2024, 11, 30, 23, 44, 4, 446, DateTimeKind.Local).AddTicks(4615) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("a6b3ec6a-1d44-4b00-aa18-7d3f1a2e2f6d"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 28, 23, 44, 4, 446, DateTimeKind.Local).AddTicks(4651), new DateTime(2024, 11, 30, 23, 44, 4, 446, DateTimeKind.Local).AddTicks(4656), new DateTime(2024, 11, 30, 23, 44, 4, 446, DateTimeKind.Local).AddTicks(4656) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("af7bcf34-a92d-4b2b-9937-3e6b7f4f2c6d"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 30, 23, 44, 4, 446, DateTimeKind.Local).AddTicks(4721), new DateTime(2024, 11, 30, 23, 44, 4, 446, DateTimeKind.Local).AddTicks(4726), new DateTime(2024, 11, 30, 23, 44, 4, 446, DateTimeKind.Local).AddTicks(4727) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("b3f9d8c7-a1f4-4e3d-b7c2-7e3f9a4f1c5d"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 4, 30, 23, 44, 4, 446, DateTimeKind.Local).AddTicks(4736), new DateTime(2024, 11, 30, 23, 44, 4, 446, DateTimeKind.Local).AddTicks(4740), new DateTime(2024, 11, 30, 23, 44, 4, 446, DateTimeKind.Local).AddTicks(4741) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("c0a173ff-5be0-4bc9-877b-8d632eeb6da6"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 28, 23, 44, 4, 446, DateTimeKind.Local).AddTicks(4898), new DateTime(2024, 11, 30, 23, 44, 4, 446, DateTimeKind.Local).AddTicks(4902), new DateTime(2024, 11, 30, 23, 44, 4, 446, DateTimeKind.Local).AddTicks(4902) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("c3d3aa6b-ac70-4aa9-a8c2-88b3e0581d87"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 28, 23, 44, 4, 446, DateTimeKind.Local).AddTicks(4601), new DateTime(2024, 11, 30, 23, 44, 4, 446, DateTimeKind.Local).AddTicks(4605), new DateTime(2024, 11, 30, 23, 44, 4, 446, DateTimeKind.Local).AddTicks(4606) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("c3e8ff99-9f1a-4e4e-aaa4-4d1c8e5e3b5a"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 30, 23, 44, 4, 446, DateTimeKind.Local).AddTicks(4659), new DateTime(2024, 11, 30, 23, 44, 4, 446, DateTimeKind.Local).AddTicks(4663), new DateTime(2024, 11, 30, 23, 44, 4, 446, DateTimeKind.Local).AddTicks(4664) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("c8e2c78e-f68e-4c7e-a22f-5c81b4b5a8b0"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 30, 23, 44, 4, 446, DateTimeKind.Local).AddTicks(4870), new DateTime(2024, 11, 30, 23, 44, 4, 446, DateTimeKind.Local).AddTicks(4874), new DateTime(2024, 11, 30, 23, 44, 4, 446, DateTimeKind.Local).AddTicks(4875) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("ca01ec6a-8d39-4e00-ab98-6c3f9a2e0b1e"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 28, 23, 44, 4, 446, DateTimeKind.Local).AddTicks(4594), new DateTime(2024, 11, 30, 23, 44, 4, 446, DateTimeKind.Local).AddTicks(4599), new DateTime(2024, 11, 30, 23, 44, 4, 446, DateTimeKind.Local).AddTicks(4599) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("d0d69bba-c6c0-4e1e-b8a1-9b4b44e69b93"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 30, 23, 44, 4, 446, DateTimeKind.Local).AddTicks(4771), new DateTime(2024, 11, 30, 23, 44, 4, 446, DateTimeKind.Local).AddTicks(4843), new DateTime(2024, 11, 30, 23, 44, 4, 446, DateTimeKind.Local).AddTicks(4844) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("dd6b2a14-0f8b-41a8-ae5d-53de0a92d764"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 30, 23, 44, 4, 446, DateTimeKind.Local).AddTicks(4743), new DateTime(2024, 11, 30, 23, 44, 4, 446, DateTimeKind.Local).AddTicks(4747), new DateTime(2024, 11, 30, 23, 44, 4, 446, DateTimeKind.Local).AddTicks(4747) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("def969c3-e7ad-4f71-9907-2c0d594d3ecb"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 30, 23, 44, 4, 446, DateTimeKind.Local).AddTicks(4617), new DateTime(2024, 11, 30, 23, 44, 4, 446, DateTimeKind.Local).AddTicks(4621), new DateTime(2024, 11, 30, 23, 44, 4, 446, DateTimeKind.Local).AddTicks(4621) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("df024b07-216f-41d7-b79b-25eb8f28762d"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 4, 30, 23, 44, 4, 446, DateTimeKind.Local).AddTicks(4863), new DateTime(2024, 11, 30, 23, 44, 4, 446, DateTimeKind.Local).AddTicks(4868), new DateTime(2024, 11, 30, 23, 44, 4, 446, DateTimeKind.Local).AddTicks(4868) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("f07a1be4-bd6d-4c2d-9537-303e0c7a5dcf"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 28, 23, 44, 4, 446, DateTimeKind.Local).AddTicks(4749), new DateTime(2024, 11, 30, 23, 44, 4, 446, DateTimeKind.Local).AddTicks(4753), new DateTime(2024, 11, 30, 23, 44, 4, 446, DateTimeKind.Local).AddTicks(4754) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("fa01ec6a-8d39-4e00-ab98-6c3f9a2e0b1f"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 4, 30, 23, 44, 4, 446, DateTimeKind.Local).AddTicks(4644), new DateTime(2024, 11, 30, 23, 44, 4, 446, DateTimeKind.Local).AddTicks(4649), new DateTime(2024, 11, 30, 23, 44, 4, 446, DateTimeKind.Local).AddTicks(4649) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: new Guid("7f9b407b-80e0-4f0c-a301-5a8bbf813b05"),
                columns: new[] { "DistrictId", "ProvinceId" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: new Guid("ec6aba4a-1b55-412a-a2e7-9ec8b9f16662"),
                columns: new[] { "DistrictId", "ProvinceId" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: new Guid("ec7d72b6-e9f4-4c85-bc12-c2db31d5efa7"),
                columns: new[] { "DistrictId", "ProvinceId" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("17e0cd7e-5887-44e2-bf2a-cd1b1f631f76"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 4, 18, 17, 3, 4, 561, DateTimeKind.Local).AddTicks(3877), new DateTime(2024, 11, 18, 17, 3, 4, 561, DateTimeKind.Local).AddTicks(3881), new DateTime(2024, 11, 18, 17, 3, 4, 561, DateTimeKind.Local).AddTicks(3881) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("1b9a3a57-5a94-4cc3-9af1-0380d074dd65"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 18, 17, 3, 4, 561, DateTimeKind.Local).AddTicks(3898), new DateTime(2024, 11, 18, 17, 3, 4, 561, DateTimeKind.Local).AddTicks(3902), new DateTime(2024, 11, 18, 17, 3, 4, 561, DateTimeKind.Local).AddTicks(3903) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("1c8a7d6b-2d7f-4c2b-a9c5-8b3e9f6f2d8b"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 18, 17, 3, 4, 561, DateTimeKind.Local).AddTicks(3810), new DateTime(2024, 11, 18, 17, 3, 4, 561, DateTimeKind.Local).AddTicks(3814), new DateTime(2024, 11, 18, 17, 3, 4, 561, DateTimeKind.Local).AddTicks(3814) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("1d41e60a-ffb5-4039-b4b6-3e25e68d0f2c"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 18, 17, 3, 4, 561, DateTimeKind.Local).AddTicks(3883), new DateTime(2024, 11, 18, 17, 3, 4, 561, DateTimeKind.Local).AddTicks(3887), new DateTime(2024, 11, 18, 17, 3, 4, 561, DateTimeKind.Local).AddTicks(3888) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("22aadfc7-6022-4f15-ac49-13fa33f8afbe"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 18, 17, 3, 4, 561, DateTimeKind.Local).AddTicks(3724), new DateTime(2024, 11, 18, 17, 3, 4, 561, DateTimeKind.Local).AddTicks(3729), new DateTime(2024, 11, 18, 17, 3, 4, 561, DateTimeKind.Local).AddTicks(3729) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("3d6b9f9b-6f2d-4b4a-b4c7-2c8b5f4e1b4e"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 18, 17, 3, 4, 561, DateTimeKind.Local).AddTicks(3788), new DateTime(2024, 11, 18, 17, 3, 4, 561, DateTimeKind.Local).AddTicks(3792), new DateTime(2024, 11, 18, 17, 3, 4, 561, DateTimeKind.Local).AddTicks(3793) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("3d8db2d5-5020-497e-917b-500a1f663c60"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 4, 18, 17, 3, 4, 561, DateTimeKind.Local).AddTicks(3936), new DateTime(2024, 11, 18, 17, 3, 4, 561, DateTimeKind.Local).AddTicks(3940), new DateTime(2024, 11, 18, 17, 3, 4, 561, DateTimeKind.Local).AddTicks(3941) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("4b3dff90-4d8a-4cbb-a3e8-6c7e5a4d3c4a"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 18, 17, 3, 4, 561, DateTimeKind.Local).AddTicks(3795), new DateTime(2024, 11, 18, 17, 3, 4, 561, DateTimeKind.Local).AddTicks(3799), new DateTime(2024, 11, 18, 17, 3, 4, 561, DateTimeKind.Local).AddTicks(3800) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("4c695d62-51f0-4070-a625-c030208dffb7"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 18, 17, 3, 4, 561, DateTimeKind.Local).AddTicks(3586), new DateTime(2024, 11, 18, 17, 3, 4, 561, DateTimeKind.Local).AddTicks(3616), new DateTime(2024, 11, 18, 17, 3, 4, 561, DateTimeKind.Local).AddTicks(3617) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("5540bd1d-b228-410e-8fbf-0842aeda7cb1"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 18, 17, 3, 4, 561, DateTimeKind.Local).AddTicks(3623), new DateTime(2024, 11, 18, 17, 3, 4, 561, DateTimeKind.Local).AddTicks(3628), new DateTime(2024, 11, 18, 17, 3, 4, 561, DateTimeKind.Local).AddTicks(3629) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("571827fa-78f4-4192-ad3b-06bb014309c2"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 18, 17, 3, 4, 561, DateTimeKind.Local).AddTicks(3631), new DateTime(2024, 11, 18, 17, 3, 4, 561, DateTimeKind.Local).AddTicks(3636), new DateTime(2024, 11, 18, 17, 3, 4, 561, DateTimeKind.Local).AddTicks(3637) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("5f9c2d8f-a7f2-45a4-8e4a-90b8f7a03b3e"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 18, 17, 3, 4, 561, DateTimeKind.Local).AddTicks(3774), new DateTime(2024, 11, 18, 17, 3, 4, 561, DateTimeKind.Local).AddTicks(3778), new DateTime(2024, 11, 18, 17, 3, 4, 561, DateTimeKind.Local).AddTicks(3779) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("6f0e2a6f-54d7-493c-bcb4-8f5eeb2fba1b"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 18, 17, 3, 4, 561, DateTimeKind.Local).AddTicks(3930), new DateTime(2024, 11, 18, 17, 3, 4, 561, DateTimeKind.Local).AddTicks(3934), new DateTime(2024, 11, 18, 17, 3, 4, 561, DateTimeKind.Local).AddTicks(3934) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("7c7616f2-3c2c-4c5f-9f40-470e78a847c7"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 18, 17, 3, 4, 561, DateTimeKind.Local).AddTicks(3943), new DateTime(2024, 11, 18, 17, 3, 4, 561, DateTimeKind.Local).AddTicks(3947), new DateTime(2024, 11, 18, 17, 3, 4, 561, DateTimeKind.Local).AddTicks(3948) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("82cfed84-d067-4d70-bef9-f08b0636a6b0"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 18, 17, 3, 4, 561, DateTimeKind.Local).AddTicks(3905), new DateTime(2024, 11, 18, 17, 3, 4, 561, DateTimeKind.Local).AddTicks(3910), new DateTime(2024, 11, 18, 17, 3, 4, 561, DateTimeKind.Local).AddTicks(3910) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("8845c741-6b0f-4f95-b179-3d007ba28a41"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 18, 17, 3, 4, 561, DateTimeKind.Local).AddTicks(3733), new DateTime(2024, 11, 18, 17, 3, 4, 561, DateTimeKind.Local).AddTicks(3737), new DateTime(2024, 11, 18, 17, 3, 4, 561, DateTimeKind.Local).AddTicks(3737) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("8c78bbac-4a5e-49ab-aafb-5a6c3f0c4b5d"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 6, 18, 17, 3, 4, 561, DateTimeKind.Local).AddTicks(3781), new DateTime(2024, 11, 18, 17, 3, 4, 561, DateTimeKind.Local).AddTicks(3785), new DateTime(2024, 11, 18, 17, 3, 4, 561, DateTimeKind.Local).AddTicks(3786) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("8f31d3d0-dc53-45d6-bccd-fd2d15dacb77"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 18, 17, 3, 4, 561, DateTimeKind.Local).AddTicks(3742), new DateTime(2024, 11, 18, 17, 3, 4, 561, DateTimeKind.Local).AddTicks(3747), new DateTime(2024, 11, 18, 17, 3, 4, 561, DateTimeKind.Local).AddTicks(3747) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("9127e8f9-a91c-4dca-8008-3cb7a8dcfb22"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 18, 17, 3, 4, 561, DateTimeKind.Local).AddTicks(3711), new DateTime(2024, 11, 18, 17, 3, 4, 561, DateTimeKind.Local).AddTicks(3715), new DateTime(2024, 11, 18, 17, 3, 4, 561, DateTimeKind.Local).AddTicks(3716) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("a6b3ec6a-1d44-4b00-aa18-7d3f1a2e2f6d"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 18, 17, 3, 4, 561, DateTimeKind.Local).AddTicks(3759), new DateTime(2024, 11, 18, 17, 3, 4, 561, DateTimeKind.Local).AddTicks(3765), new DateTime(2024, 11, 18, 17, 3, 4, 561, DateTimeKind.Local).AddTicks(3766) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("af7bcf34-a92d-4b2b-9937-3e6b7f4f2c6d"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 18, 17, 3, 4, 561, DateTimeKind.Local).AddTicks(3803), new DateTime(2024, 11, 18, 17, 3, 4, 561, DateTimeKind.Local).AddTicks(3807), new DateTime(2024, 11, 18, 17, 3, 4, 561, DateTimeKind.Local).AddTicks(3808) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("b3f9d8c7-a1f4-4e3d-b7c2-7e3f9a4f1c5d"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 4, 18, 17, 3, 4, 561, DateTimeKind.Local).AddTicks(3817), new DateTime(2024, 11, 18, 17, 3, 4, 561, DateTimeKind.Local).AddTicks(3822), new DateTime(2024, 11, 18, 17, 3, 4, 561, DateTimeKind.Local).AddTicks(3823) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("c0a173ff-5be0-4bc9-877b-8d632eeb6da6"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 18, 17, 3, 4, 561, DateTimeKind.Local).AddTicks(3949), new DateTime(2024, 11, 18, 17, 3, 4, 561, DateTimeKind.Local).AddTicks(3953), new DateTime(2024, 11, 18, 17, 3, 4, 561, DateTimeKind.Local).AddTicks(3954) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("c3d3aa6b-ac70-4aa9-a8c2-88b3e0581d87"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 18, 17, 3, 4, 561, DateTimeKind.Local).AddTicks(3702), new DateTime(2024, 11, 18, 17, 3, 4, 561, DateTimeKind.Local).AddTicks(3706), new DateTime(2024, 11, 18, 17, 3, 4, 561, DateTimeKind.Local).AddTicks(3707) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("c3e8ff99-9f1a-4e4e-aaa4-4d1c8e5e3b5a"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 18, 17, 3, 4, 561, DateTimeKind.Local).AddTicks(3768), new DateTime(2024, 11, 18, 17, 3, 4, 561, DateTimeKind.Local).AddTicks(3772), new DateTime(2024, 11, 18, 17, 3, 4, 561, DateTimeKind.Local).AddTicks(3772) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("c8e2c78e-f68e-4c7e-a22f-5c81b4b5a8b0"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 18, 17, 3, 4, 561, DateTimeKind.Local).AddTicks(3919), new DateTime(2024, 11, 18, 17, 3, 4, 561, DateTimeKind.Local).AddTicks(3928), new DateTime(2024, 11, 18, 17, 3, 4, 561, DateTimeKind.Local).AddTicks(3928) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("ca01ec6a-8d39-4e00-ab98-6c3f9a2e0b1e"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 18, 17, 3, 4, 561, DateTimeKind.Local).AddTicks(3693), new DateTime(2024, 11, 18, 17, 3, 4, 561, DateTimeKind.Local).AddTicks(3698), new DateTime(2024, 11, 18, 17, 3, 4, 561, DateTimeKind.Local).AddTicks(3699) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("d0d69bba-c6c0-4e1e-b8a1-9b4b44e69b93"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 18, 17, 3, 4, 561, DateTimeKind.Local).AddTicks(3891), new DateTime(2024, 11, 18, 17, 3, 4, 561, DateTimeKind.Local).AddTicks(3895), new DateTime(2024, 11, 18, 17, 3, 4, 561, DateTimeKind.Local).AddTicks(3895) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("dd6b2a14-0f8b-41a8-ae5d-53de0a92d764"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 18, 17, 3, 4, 561, DateTimeKind.Local).AddTicks(3824), new DateTime(2024, 11, 18, 17, 3, 4, 561, DateTimeKind.Local).AddTicks(3828), new DateTime(2024, 11, 18, 17, 3, 4, 561, DateTimeKind.Local).AddTicks(3829) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("def969c3-e7ad-4f71-9907-2c0d594d3ecb"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 18, 17, 3, 4, 561, DateTimeKind.Local).AddTicks(3718), new DateTime(2024, 11, 18, 17, 3, 4, 561, DateTimeKind.Local).AddTicks(3722), new DateTime(2024, 11, 18, 17, 3, 4, 561, DateTimeKind.Local).AddTicks(3722) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("df024b07-216f-41d7-b79b-25eb8f28762d"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 4, 18, 17, 3, 4, 561, DateTimeKind.Local).AddTicks(3913), new DateTime(2024, 11, 18, 17, 3, 4, 561, DateTimeKind.Local).AddTicks(3917), new DateTime(2024, 11, 18, 17, 3, 4, 561, DateTimeKind.Local).AddTicks(3917) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("f07a1be4-bd6d-4c2d-9537-303e0c7a5dcf"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 18, 17, 3, 4, 561, DateTimeKind.Local).AddTicks(3869), new DateTime(2024, 11, 18, 17, 3, 4, 561, DateTimeKind.Local).AddTicks(3874), new DateTime(2024, 11, 18, 17, 3, 4, 561, DateTimeKind.Local).AddTicks(3874) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("fa01ec6a-8d39-4e00-ab98-6c3f9a2e0b1f"),
                columns: new[] { "CloseDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 4, 18, 17, 3, 4, 561, DateTimeKind.Local).AddTicks(3750), new DateTime(2024, 11, 18, 17, 3, 4, 561, DateTimeKind.Local).AddTicks(3756), new DateTime(2024, 11, 18, 17, 3, 4, 561, DateTimeKind.Local).AddTicks(3756) });
        }
    }
}
