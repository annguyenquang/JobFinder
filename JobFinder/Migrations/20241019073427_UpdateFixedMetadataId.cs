using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace JobFinder.Migrations
{
    /// <inheritdoc />
    public partial class UpdateFixedMetadataId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("cf325fca-4731-4318-a084-070a999e2eae"));

            migrationBuilder.DeleteData(
                table: "Metadatas",
                keyColumn: "Id",
                keyValue: new Guid("176a4cc6-548b-4676-b6be-7145213ae61f"));

            migrationBuilder.DeleteData(
                table: "Metadatas",
                keyColumn: "Id",
                keyValue: new Guid("1f02c478-a95b-41e6-a7f0-3a2b94fe8076"));

            migrationBuilder.DeleteData(
                table: "Metadatas",
                keyColumn: "Id",
                keyValue: new Guid("20ef9a77-0cde-47d3-976c-81bb10cb5048"));

            migrationBuilder.DeleteData(
                table: "Metadatas",
                keyColumn: "Id",
                keyValue: new Guid("304b7d54-c3e4-48bb-9822-2a9b40f8681e"));

            migrationBuilder.DeleteData(
                table: "Metadatas",
                keyColumn: "Id",
                keyValue: new Guid("32616001-1f3f-4158-8596-d4376712ae90"));

            migrationBuilder.DeleteData(
                table: "Metadatas",
                keyColumn: "Id",
                keyValue: new Guid("3316dc61-a893-4abf-b92a-853e03a90240"));

            migrationBuilder.DeleteData(
                table: "Metadatas",
                keyColumn: "Id",
                keyValue: new Guid("36dac619-9ff0-4d23-9367-3911ddf5ef4f"));

            migrationBuilder.DeleteData(
                table: "Metadatas",
                keyColumn: "Id",
                keyValue: new Guid("3b461d6f-a810-4e7b-9a39-d590fa0c14c5"));

            migrationBuilder.DeleteData(
                table: "Metadatas",
                keyColumn: "Id",
                keyValue: new Guid("3bb22e2e-7cac-4468-886a-c14c2a6d78f6"));

            migrationBuilder.DeleteData(
                table: "Metadatas",
                keyColumn: "Id",
                keyValue: new Guid("5df29c5c-c741-478d-b642-37a0ca26c87a"));

            migrationBuilder.DeleteData(
                table: "Metadatas",
                keyColumn: "Id",
                keyValue: new Guid("62d8b5b6-49ff-400e-afb8-6f1c07897acc"));

            migrationBuilder.DeleteData(
                table: "Metadatas",
                keyColumn: "Id",
                keyValue: new Guid("8eaf06a3-9bb1-4f26-9876-2eed0d18362b"));

            migrationBuilder.DeleteData(
                table: "Metadatas",
                keyColumn: "Id",
                keyValue: new Guid("918d7f92-69c0-4bf3-aa64-11db742da2e4"));

            migrationBuilder.DeleteData(
                table: "Metadatas",
                keyColumn: "Id",
                keyValue: new Guid("93ebd4a3-353b-405e-8f44-706dd6eccefc"));

            migrationBuilder.DeleteData(
                table: "Metadatas",
                keyColumn: "Id",
                keyValue: new Guid("9c7485f9-53fa-47dc-9365-6b3991395b97"));

            migrationBuilder.DeleteData(
                table: "Metadatas",
                keyColumn: "Id",
                keyValue: new Guid("a25645d2-6603-4661-89a7-3a0a50c3dde2"));

            migrationBuilder.DeleteData(
                table: "Metadatas",
                keyColumn: "Id",
                keyValue: new Guid("a60e6d73-9b12-41c1-bde9-b7b49bd77f78"));

            migrationBuilder.DeleteData(
                table: "Metadatas",
                keyColumn: "Id",
                keyValue: new Guid("a896f2c4-101f-4ad3-9182-2de8e7482b2b"));

            migrationBuilder.DeleteData(
                table: "Metadatas",
                keyColumn: "Id",
                keyValue: new Guid("ad081538-b194-4eaa-b165-bbc00b8d3ccc"));

            migrationBuilder.DeleteData(
                table: "Metadatas",
                keyColumn: "Id",
                keyValue: new Guid("ae75f7ae-806b-4c39-9107-9fc34ba0753d"));

            migrationBuilder.DeleteData(
                table: "Metadatas",
                keyColumn: "Id",
                keyValue: new Guid("c4efb270-f3c0-4f2f-8064-38cfa5822eb7"));

            migrationBuilder.DeleteData(
                table: "Metadatas",
                keyColumn: "Id",
                keyValue: new Guid("ce00f064-2f1a-49cd-97dc-244b939d0061"));

            migrationBuilder.DeleteData(
                table: "Metadatas",
                keyColumn: "Id",
                keyValue: new Guid("d235d8cf-d8dd-42d6-b8af-2f2bb1b23cc1"));

            migrationBuilder.DeleteData(
                table: "Metadatas",
                keyColumn: "Id",
                keyValue: new Guid("d30eb6f0-fd51-412f-aa60-1b1b017e93f6"));

            migrationBuilder.DeleteData(
                table: "Metadatas",
                keyColumn: "Id",
                keyValue: new Guid("de21e631-fc69-42e6-89ff-176b80a3511b"));

            migrationBuilder.DeleteData(
                table: "Metadatas",
                keyColumn: "Id",
                keyValue: new Guid("f58f0289-52e2-4d96-ae21-e10ab6cbfd8d"));

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "Email", "Password", "Phone", "UpdatedAt", "UpdatedBy", "Username" },
                values: new object[] { new Guid("47b55518-e18d-4caa-bf26-24e527a036e5"), null, null, "admin@gmail.com", "Admin", "0123456789", null, null, "Admin" });

            migrationBuilder.InsertData(
                table: "Metadatas",
                columns: new[] { "Id", "Type", "Value" },
                values: new object[,]
                {
                    { new Guid("04a9de34-0869-41b2-87a8-63c20c4ba22a"), 1, "{data: \"Onsite\"}" },
                    { new Guid("12497687-64b8-4d8e-814a-b7d1d33d3aab"), 4, "{data: \"Others\"}" },
                    { new Guid("26a49bd7-ad8c-40be-8e7c-dd903f7a653e"), 0, "{data: \"Freelance\"}" },
                    { new Guid("376764fa-28ec-4a08-80e3-a6ab407e8601"), 1, "{data: \"Remote/WFH\"}" },
                    { new Guid("3fbef738-ed16-4778-8463-8390444841de"), 0, "{data: \"Internship\"}" },
                    { new Guid("44b668b2-09ee-499e-af95-73598f9153a2"), 0, "{data: \"Contract\"}" },
                    { new Guid("4a3e2365-47f4-45d9-b1d4-326d9f2f3203"), 2, "{data: \"LessThanOneYear\"}" },
                    { new Guid("52e22ea6-7f97-4816-b64a-bfd4aa21cd74"), 3, "{data: \"SeniorOrVocationalHighSchool\"}" },
                    { new Guid("540f318e-b42f-4485-9e60-8faa5bf80962"), 0, "{data: \"Fulltime\"}" },
                    { new Guid("5d06c3b1-2bd1-4c68-96b4-f4cd8c899dff"), 0, "{data: \"PartTime\"}" },
                    { new Guid("646ccd9f-aa2f-413e-8d3e-eb8ab0b14c96"), 2, "{data: \"MoreThanTenYears\"}" },
                    { new Guid("67db1aef-c1b1-4424-8313-774a5dccdb9d"), 2, "{data: \"ThreeToFiveYears\"}" },
                    { new Guid("79685cdb-be26-49cc-b7f9-1fb51686f5ba"), 4, "{data: \"Male\"}" },
                    { new Guid("7b5f69cb-5996-4a57-b9c6-9fee2a791bf6"), 4, "{data: \"Female\"}" },
                    { new Guid("853384de-154c-4187-bf5d-aa684b85736d"), 3, "{data: \"Doctorate\"}" },
                    { new Guid("96279c48-1bfe-441d-992e-db86cb3bf315"), 0, "{data: \"Daily\"}" },
                    { new Guid("a3fb036a-04fc-4590-b87d-6ed32e2ec692"), 3, "{data: \"CollegeDegree\"}" },
                    { new Guid("bc44b9a9-5cd6-4195-a7bd-92b4bef6d8fb"), 3, "{data: \"MasterDegree\"}" },
                    { new Guid("bc4ecf1e-8841-47f2-86ec-b0c523f03da1"), 3, "{data: \"BachelorDegree\"}" },
                    { new Guid("bf38a1b9-dee3-455a-87c1-4e034fe806f7"), 2, "{data: \"FiveToTenYears\"}" },
                    { new Guid("c199da74-c2fb-4381-b093-cf2f1e3e8f06"), 1, "{data: \"Hybrid\"}" },
                    { new Guid("c9d2f457-06bf-40ad-9a4a-d6e201888129"), 3, "{data: \"SecondarySchool\"}" },
                    { new Guid("cc4121b2-72c2-4226-ad12-24e722b50cc2"), 2, "{data: \"OneToThreeYears\"}" },
                    { new Guid("ceb115a0-3ffe-455c-b24e-9eff074e1ec1"), 3, "{data: \"PrimarySchool\"}" },
                    { new Guid("ebb6a034-ce37-41a4-b1f6-c70f1698c4f2"), 3, "{data: \"Diploma\"}" },
                    { new Guid("fbce1042-bce0-47a3-92cc-54e3b86eb570"), 2, "{data: \"FreshGradute\"}" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("47b55518-e18d-4caa-bf26-24e527a036e5"));

            migrationBuilder.DeleteData(
                table: "Metadatas",
                keyColumn: "Id",
                keyValue: new Guid("04a9de34-0869-41b2-87a8-63c20c4ba22a"));

            migrationBuilder.DeleteData(
                table: "Metadatas",
                keyColumn: "Id",
                keyValue: new Guid("12497687-64b8-4d8e-814a-b7d1d33d3aab"));

            migrationBuilder.DeleteData(
                table: "Metadatas",
                keyColumn: "Id",
                keyValue: new Guid("26a49bd7-ad8c-40be-8e7c-dd903f7a653e"));

            migrationBuilder.DeleteData(
                table: "Metadatas",
                keyColumn: "Id",
                keyValue: new Guid("376764fa-28ec-4a08-80e3-a6ab407e8601"));

            migrationBuilder.DeleteData(
                table: "Metadatas",
                keyColumn: "Id",
                keyValue: new Guid("3fbef738-ed16-4778-8463-8390444841de"));

            migrationBuilder.DeleteData(
                table: "Metadatas",
                keyColumn: "Id",
                keyValue: new Guid("44b668b2-09ee-499e-af95-73598f9153a2"));

            migrationBuilder.DeleteData(
                table: "Metadatas",
                keyColumn: "Id",
                keyValue: new Guid("4a3e2365-47f4-45d9-b1d4-326d9f2f3203"));

            migrationBuilder.DeleteData(
                table: "Metadatas",
                keyColumn: "Id",
                keyValue: new Guid("52e22ea6-7f97-4816-b64a-bfd4aa21cd74"));

            migrationBuilder.DeleteData(
                table: "Metadatas",
                keyColumn: "Id",
                keyValue: new Guid("540f318e-b42f-4485-9e60-8faa5bf80962"));

            migrationBuilder.DeleteData(
                table: "Metadatas",
                keyColumn: "Id",
                keyValue: new Guid("5d06c3b1-2bd1-4c68-96b4-f4cd8c899dff"));

            migrationBuilder.DeleteData(
                table: "Metadatas",
                keyColumn: "Id",
                keyValue: new Guid("646ccd9f-aa2f-413e-8d3e-eb8ab0b14c96"));

            migrationBuilder.DeleteData(
                table: "Metadatas",
                keyColumn: "Id",
                keyValue: new Guid("67db1aef-c1b1-4424-8313-774a5dccdb9d"));

            migrationBuilder.DeleteData(
                table: "Metadatas",
                keyColumn: "Id",
                keyValue: new Guid("79685cdb-be26-49cc-b7f9-1fb51686f5ba"));

            migrationBuilder.DeleteData(
                table: "Metadatas",
                keyColumn: "Id",
                keyValue: new Guid("7b5f69cb-5996-4a57-b9c6-9fee2a791bf6"));

            migrationBuilder.DeleteData(
                table: "Metadatas",
                keyColumn: "Id",
                keyValue: new Guid("853384de-154c-4187-bf5d-aa684b85736d"));

            migrationBuilder.DeleteData(
                table: "Metadatas",
                keyColumn: "Id",
                keyValue: new Guid("96279c48-1bfe-441d-992e-db86cb3bf315"));

            migrationBuilder.DeleteData(
                table: "Metadatas",
                keyColumn: "Id",
                keyValue: new Guid("a3fb036a-04fc-4590-b87d-6ed32e2ec692"));

            migrationBuilder.DeleteData(
                table: "Metadatas",
                keyColumn: "Id",
                keyValue: new Guid("bc44b9a9-5cd6-4195-a7bd-92b4bef6d8fb"));

            migrationBuilder.DeleteData(
                table: "Metadatas",
                keyColumn: "Id",
                keyValue: new Guid("bc4ecf1e-8841-47f2-86ec-b0c523f03da1"));

            migrationBuilder.DeleteData(
                table: "Metadatas",
                keyColumn: "Id",
                keyValue: new Guid("bf38a1b9-dee3-455a-87c1-4e034fe806f7"));

            migrationBuilder.DeleteData(
                table: "Metadatas",
                keyColumn: "Id",
                keyValue: new Guid("c199da74-c2fb-4381-b093-cf2f1e3e8f06"));

            migrationBuilder.DeleteData(
                table: "Metadatas",
                keyColumn: "Id",
                keyValue: new Guid("c9d2f457-06bf-40ad-9a4a-d6e201888129"));

            migrationBuilder.DeleteData(
                table: "Metadatas",
                keyColumn: "Id",
                keyValue: new Guid("cc4121b2-72c2-4226-ad12-24e722b50cc2"));

            migrationBuilder.DeleteData(
                table: "Metadatas",
                keyColumn: "Id",
                keyValue: new Guid("ceb115a0-3ffe-455c-b24e-9eff074e1ec1"));

            migrationBuilder.DeleteData(
                table: "Metadatas",
                keyColumn: "Id",
                keyValue: new Guid("ebb6a034-ce37-41a4-b1f6-c70f1698c4f2"));

            migrationBuilder.DeleteData(
                table: "Metadatas",
                keyColumn: "Id",
                keyValue: new Guid("fbce1042-bce0-47a3-92cc-54e3b86eb570"));

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
        }
    }
}
