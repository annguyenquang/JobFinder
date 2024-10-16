using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace JobFinder.Migrations
{
    /// <inheritdoc />
    public partial class AddGenderMetadata : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("4f26ea9d-1d0e-4b6d-83e9-c1696ccabb99"));

            migrationBuilder.DeleteData(
                table: "Metadatas",
                keyColumn: "Id",
                keyValue: new Guid("0207dc22-6ff3-4b41-a6da-9c4df7942bfe"));

            migrationBuilder.DeleteData(
                table: "Metadatas",
                keyColumn: "Id",
                keyValue: new Guid("0c46b326-26a4-42a4-b2c6-f3f098bf336a"));

            migrationBuilder.DeleteData(
                table: "Metadatas",
                keyColumn: "Id",
                keyValue: new Guid("2838271a-52bb-4577-b0b5-06fab068015c"));

            migrationBuilder.DeleteData(
                table: "Metadatas",
                keyColumn: "Id",
                keyValue: new Guid("31fe64cd-1040-4971-9050-1a8c841df12c"));

            migrationBuilder.DeleteData(
                table: "Metadatas",
                keyColumn: "Id",
                keyValue: new Guid("34bd0080-6600-49fd-8912-4add4a155fa6"));

            migrationBuilder.DeleteData(
                table: "Metadatas",
                keyColumn: "Id",
                keyValue: new Guid("41138ae7-e56b-465a-a8c1-d8a3b14b8864"));

            migrationBuilder.DeleteData(
                table: "Metadatas",
                keyColumn: "Id",
                keyValue: new Guid("5b9bca28-d2bf-4af0-8c16-ecb9ead0db79"));

            migrationBuilder.DeleteData(
                table: "Metadatas",
                keyColumn: "Id",
                keyValue: new Guid("65b18c88-f642-4902-8858-9da710a707d8"));

            migrationBuilder.DeleteData(
                table: "Metadatas",
                keyColumn: "Id",
                keyValue: new Guid("6a1352ea-7c62-4e27-ad9f-93d63d9b1f7a"));

            migrationBuilder.DeleteData(
                table: "Metadatas",
                keyColumn: "Id",
                keyValue: new Guid("6c2e4155-8e73-4620-9835-92cf0f344f85"));

            migrationBuilder.DeleteData(
                table: "Metadatas",
                keyColumn: "Id",
                keyValue: new Guid("6d77bfa7-61c3-413b-9291-b2b77ab4b23e"));

            migrationBuilder.DeleteData(
                table: "Metadatas",
                keyColumn: "Id",
                keyValue: new Guid("74c02a06-e302-4a3e-aa20-e63b1ae430cf"));

            migrationBuilder.DeleteData(
                table: "Metadatas",
                keyColumn: "Id",
                keyValue: new Guid("81180c69-771d-49b7-a7a1-8b8d2f0cb472"));

            migrationBuilder.DeleteData(
                table: "Metadatas",
                keyColumn: "Id",
                keyValue: new Guid("9403d904-2de5-430c-816a-2fe46cf356f1"));

            migrationBuilder.DeleteData(
                table: "Metadatas",
                keyColumn: "Id",
                keyValue: new Guid("a2d78a08-4ec6-47a7-9aed-a2ca83c32a2b"));

            migrationBuilder.DeleteData(
                table: "Metadatas",
                keyColumn: "Id",
                keyValue: new Guid("ad61a5ff-8075-4c77-9bc3-8eb89568efaa"));

            migrationBuilder.DeleteData(
                table: "Metadatas",
                keyColumn: "Id",
                keyValue: new Guid("b1389b27-932c-47e9-92a1-93881602fc39"));

            migrationBuilder.DeleteData(
                table: "Metadatas",
                keyColumn: "Id",
                keyValue: new Guid("be9fb1e0-c974-43fc-b898-9fa572812967"));

            migrationBuilder.DeleteData(
                table: "Metadatas",
                keyColumn: "Id",
                keyValue: new Guid("bf68acba-be50-4845-ac43-a0328bfd37bc"));

            migrationBuilder.DeleteData(
                table: "Metadatas",
                keyColumn: "Id",
                keyValue: new Guid("bfda60ac-5f66-4bd5-8707-eb914c9fa596"));

            migrationBuilder.DeleteData(
                table: "Metadatas",
                keyColumn: "Id",
                keyValue: new Guid("d6c6ec10-bbe0-44d8-9c7e-51e9e87b0d3c"));

            migrationBuilder.DeleteData(
                table: "Metadatas",
                keyColumn: "Id",
                keyValue: new Guid("f265e422-9000-4a62-8aad-6c895c078925"));

            migrationBuilder.DeleteData(
                table: "Metadatas",
                keyColumn: "Id",
                keyValue: new Guid("fcdb96f8-7e44-4109-9190-617813e993d5"));

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "Email", "Password", "Phone", "UpdatedAt", "UpdatedBy", "Username" },
                values: new object[] { new Guid("2cf91c58-cfc9-41b9-81d4-ddac43359083"), null, null, "admin@gmail.com", "Admin", "0123456789", null, null, "Admin" });

            migrationBuilder.InsertData(
                table: "Metadatas",
                columns: new[] { "Id", "Type", "Value" },
                values: new object[,]
                {
                    { new Guid("03e2f467-5d58-4d0b-8dd4-b9cfd6e2064b"), 0, "{data: \"Internship\"}" },
                    { new Guid("048e5b7f-0f56-48df-8f86-94ee53b5fb20"), 0, "{data: \"Daily\"}" },
                    { new Guid("05efa04b-16e7-494e-86b8-991520c2e511"), 0, "{data: \"PartTime\"}" },
                    { new Guid("06e79622-3bf8-469a-b831-8085ab0e6a7b"), 3, "{data: \"MasterDegree\"}" },
                    { new Guid("130cdb4e-2468-4e09-b744-777299ae9c18"), 3, "{data: \"PrimarySchool\"}" },
                    { new Guid("19bf178a-ef2d-4cc5-92bf-235191b791e1"), 2, "{data: \"MoreThanTenYears\"}" },
                    { new Guid("2687ab67-a685-47f1-b583-c20264c31deb"), 2, "{data: \"LessThanOneYear\"}" },
                    { new Guid("26c21132-df12-467d-84d1-90de5f750864"), 3, "{data: \"CollegeDegree\"}" },
                    { new Guid("2870d315-3761-436c-b3f0-5cc20a9af33b"), 4, "{data: \"Male\"}" },
                    { new Guid("2a37efe0-29b0-4c3f-b1be-73d2a0cb0b50"), 0, "{data: \"Fulltime\"}" },
                    { new Guid("33fbdd36-6d4e-4d0b-9927-fede52a4fb45"), 2, "{data: \"FiveToTenYears\"}" },
                    { new Guid("35d6a8fc-8953-4aec-9d8a-55e4f15f4a58"), 3, "{data: \"BachelorDegree\"}" },
                    { new Guid("3d7e4c9d-af43-4ba8-9112-92277083cd44"), 3, "{data: \"SecondarySchool\"}" },
                    { new Guid("45def8ee-d2fc-42e6-9a24-d43afce728aa"), 4, "{data: \"Others\"}" },
                    { new Guid("53096860-dc18-4a6f-867c-bf5aeb438215"), 3, "{data: \"Doctorate\"}" },
                    { new Guid("7a5c71fa-72e5-45ff-b7ab-0e54aa63cb49"), 3, "{data: \"SeniorOrVocationalHighSchool\"}" },
                    { new Guid("7aaf7adb-8931-41be-9579-47af16bb03f6"), 0, "{data: \"Freelance\"}" },
                    { new Guid("a275f2e0-9fe9-40f3-8b58-4faf1529bfb0"), 2, "{data: \"FreshGradute\"}" },
                    { new Guid("a60f67e5-42c6-4f0b-986e-d9f0e47a992a"), 1, "{data: \"Hybrid\"}" },
                    { new Guid("a9e0bbae-eb86-4a61-8f01-ea15ec6fe930"), 2, "{data: \"ThreeToFiveYears\"}" },
                    { new Guid("b351cb49-3c59-43ab-9449-548e33c27f8c"), 1, "{data: \"Remote/WFH\"}" },
                    { new Guid("dc364068-17f0-492e-b2ed-4708a8caf4dc"), 2, "{data: \"OneToThreeYears\"}" },
                    { new Guid("e7852238-94d1-4317-b773-639d4f482b7a"), 3, "{data: \"Diploma\"}" },
                    { new Guid("ed71618d-81c5-4ac2-a3ef-18f4ab366634"), 1, "{data: \"Onsite\"}" },
                    { new Guid("f0b96c50-543f-4cfb-be0c-f8c629310504"), 4, "{data: \"Female\"}" },
                    { new Guid("ff0102b8-fd35-48a7-9991-2c442bf4614e"), 0, "{data: \"Contract\"}" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("2cf91c58-cfc9-41b9-81d4-ddac43359083"));

            migrationBuilder.DeleteData(
                table: "Metadatas",
                keyColumn: "Id",
                keyValue: new Guid("03e2f467-5d58-4d0b-8dd4-b9cfd6e2064b"));

            migrationBuilder.DeleteData(
                table: "Metadatas",
                keyColumn: "Id",
                keyValue: new Guid("048e5b7f-0f56-48df-8f86-94ee53b5fb20"));

            migrationBuilder.DeleteData(
                table: "Metadatas",
                keyColumn: "Id",
                keyValue: new Guid("05efa04b-16e7-494e-86b8-991520c2e511"));

            migrationBuilder.DeleteData(
                table: "Metadatas",
                keyColumn: "Id",
                keyValue: new Guid("06e79622-3bf8-469a-b831-8085ab0e6a7b"));

            migrationBuilder.DeleteData(
                table: "Metadatas",
                keyColumn: "Id",
                keyValue: new Guid("130cdb4e-2468-4e09-b744-777299ae9c18"));

            migrationBuilder.DeleteData(
                table: "Metadatas",
                keyColumn: "Id",
                keyValue: new Guid("19bf178a-ef2d-4cc5-92bf-235191b791e1"));

            migrationBuilder.DeleteData(
                table: "Metadatas",
                keyColumn: "Id",
                keyValue: new Guid("2687ab67-a685-47f1-b583-c20264c31deb"));

            migrationBuilder.DeleteData(
                table: "Metadatas",
                keyColumn: "Id",
                keyValue: new Guid("26c21132-df12-467d-84d1-90de5f750864"));

            migrationBuilder.DeleteData(
                table: "Metadatas",
                keyColumn: "Id",
                keyValue: new Guid("2870d315-3761-436c-b3f0-5cc20a9af33b"));

            migrationBuilder.DeleteData(
                table: "Metadatas",
                keyColumn: "Id",
                keyValue: new Guid("2a37efe0-29b0-4c3f-b1be-73d2a0cb0b50"));

            migrationBuilder.DeleteData(
                table: "Metadatas",
                keyColumn: "Id",
                keyValue: new Guid("33fbdd36-6d4e-4d0b-9927-fede52a4fb45"));

            migrationBuilder.DeleteData(
                table: "Metadatas",
                keyColumn: "Id",
                keyValue: new Guid("35d6a8fc-8953-4aec-9d8a-55e4f15f4a58"));

            migrationBuilder.DeleteData(
                table: "Metadatas",
                keyColumn: "Id",
                keyValue: new Guid("3d7e4c9d-af43-4ba8-9112-92277083cd44"));

            migrationBuilder.DeleteData(
                table: "Metadatas",
                keyColumn: "Id",
                keyValue: new Guid("45def8ee-d2fc-42e6-9a24-d43afce728aa"));

            migrationBuilder.DeleteData(
                table: "Metadatas",
                keyColumn: "Id",
                keyValue: new Guid("53096860-dc18-4a6f-867c-bf5aeb438215"));

            migrationBuilder.DeleteData(
                table: "Metadatas",
                keyColumn: "Id",
                keyValue: new Guid("7a5c71fa-72e5-45ff-b7ab-0e54aa63cb49"));

            migrationBuilder.DeleteData(
                table: "Metadatas",
                keyColumn: "Id",
                keyValue: new Guid("7aaf7adb-8931-41be-9579-47af16bb03f6"));

            migrationBuilder.DeleteData(
                table: "Metadatas",
                keyColumn: "Id",
                keyValue: new Guid("a275f2e0-9fe9-40f3-8b58-4faf1529bfb0"));

            migrationBuilder.DeleteData(
                table: "Metadatas",
                keyColumn: "Id",
                keyValue: new Guid("a60f67e5-42c6-4f0b-986e-d9f0e47a992a"));

            migrationBuilder.DeleteData(
                table: "Metadatas",
                keyColumn: "Id",
                keyValue: new Guid("a9e0bbae-eb86-4a61-8f01-ea15ec6fe930"));

            migrationBuilder.DeleteData(
                table: "Metadatas",
                keyColumn: "Id",
                keyValue: new Guid("b351cb49-3c59-43ab-9449-548e33c27f8c"));

            migrationBuilder.DeleteData(
                table: "Metadatas",
                keyColumn: "Id",
                keyValue: new Guid("dc364068-17f0-492e-b2ed-4708a8caf4dc"));

            migrationBuilder.DeleteData(
                table: "Metadatas",
                keyColumn: "Id",
                keyValue: new Guid("e7852238-94d1-4317-b773-639d4f482b7a"));

            migrationBuilder.DeleteData(
                table: "Metadatas",
                keyColumn: "Id",
                keyValue: new Guid("ed71618d-81c5-4ac2-a3ef-18f4ab366634"));

            migrationBuilder.DeleteData(
                table: "Metadatas",
                keyColumn: "Id",
                keyValue: new Guid("f0b96c50-543f-4cfb-be0c-f8c629310504"));

            migrationBuilder.DeleteData(
                table: "Metadatas",
                keyColumn: "Id",
                keyValue: new Guid("ff0102b8-fd35-48a7-9991-2c442bf4614e"));

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
        }
    }
}
