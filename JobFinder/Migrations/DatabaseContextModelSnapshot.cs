﻿// <auto-generated />
using System;
using JobFinder.DataAccess.Persistent;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace JobFinder.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    partial class DatabaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("JobFinder.Core.Entity.Account", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("CreatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("UpdatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Accounts");

                    b.HasData(
                        new
                        {
                            Id = new Guid("bd8ef476-446a-4637-8a5c-ed6f88a93cb2"),
                            Email = "",
                            Password = "$2a$11$LBYX.zc7WJjtjWxnn4Vs2eKQd9vZ/oxLLUzAM5ATRUf8FZz4ehODe",
                            Phone = "113",
                            Username = "admin"
                        },
                        new
                        {
                            Id = new Guid("4eb3aa31-74cd-4161-92f0-cbd6920bbc29"),
                            Email = "",
                            Password = "$2a$11$PmqaxK8vsPrESzr1MIIQyenCESmwSbhmOT1nS0e0HAUmQcN4sOUmq",
                            Phone = "0123456789",
                            Username = "account0"
                        },
                        new
                        {
                            Id = new Guid("c0cc30cf-d777-4046-98d1-b15cca43b8e3"),
                            Email = "",
                            Password = "$2a$11$DmGGbgaEyO3.uqUNnBQa4.5G6VDnp3AmPsr/R9B87wfoiq/RlMZsy",
                            Phone = "0823456789",
                            Username = "account1"
                        },
                        new
                        {
                            Id = new Guid("2084431c-0dcd-4394-95df-4cbca139cdd0"),
                            Email = "",
                            Password = "$2a$11$9LSoHQJNMlW0UO47hWwY6.u1FZjOED1yUZGAAfFEaTLuKbKvgwW6C",
                            Phone = "0183456789",
                            Username = "account2"
                        },
                        new
                        {
                            Id = new Guid("f7eaeb61-4347-40d6-bcac-d8566f010e3b"),
                            Email = "",
                            Password = "$2a$11$CptGBo2VmlfHjfpQJgSGvuBwGD/ysT/1TTEDyGXAf7r7n.YRjV5Na",
                            Phone = "0128456789",
                            Username = "account3"
                        },
                        new
                        {
                            Id = new Guid("41c60b57-5374-41a9-a1ee-6cd52d798479"),
                            Email = "",
                            Password = "$2a$11$Wn.7fjL2ICAD/dc1LRTXX.7sG/KGOzjZSsYizVMvFh5jLkCc0qhB.",
                            Phone = "0123856789",
                            Username = "account4"
                        });
                });

            modelBuilder.Entity("JobFinder.Core.Entity.Company", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("AccountId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("CreatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DistrictId")
                        .HasColumnType("int");

                    b.Property<string>("EmailContact")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("EmployeeCount")
                        .HasColumnType("int");

                    b.Property<string>("Industry")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Logo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneContact")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProvinceId")
                        .HasColumnType("int");

                    b.Property<string>("Slug")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("UpdatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Website")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AccountId");

                    b.HasIndex("Slug")
                        .IsUnique()
                        .HasFilter("[Slug] IS NOT NULL");

                    b.ToTable("Companies");

                    b.HasData(
                        new
                        {
                            Id = new Guid("c9f35421-51b8-4d3e-9dd2-671af01f04bf"),
                            AccountId = new Guid("bd8ef476-446a-4637-8a5c-ed6f88a93cb2"),
                            Address = "123 Tech Lane",
                            Description = "Tech Corp is a tech corp company.",
                            DistrictId = 0,
                            EmailContact = "info@techcorp.com",
                            EmployeeCount = 500,
                            Industry = "Technology",
                            Logo = "https://images-platform.99static.com/7v8-fjWpezqDYFTxbYGvEE3gnw8=/191x0:1338x1147/500x500/top/smart/99designs-contests-attachments/60/60612/attachment_60612660",
                            Name = "Tech Corp",
                            PhoneContact = "123456789",
                            ProvinceId = 0,
                            Slug = "tech-corp",
                            Website = "www.techcorp.com"
                        },
                        new
                        {
                            Id = new Guid("fe57b774-4c2e-48dd-bd67-5982398ee24d"),
                            AccountId = new Guid("4eb3aa31-74cd-4161-92f0-cbd6920bbc29"),
                            Address = "456 Health Blvd",
                            Description = "Health Inc. is a health corp company.",
                            DistrictId = 0,
                            EmailContact = "info@healthinc.com",
                            EmployeeCount = 300,
                            Industry = "Healthcare",
                            Logo = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRyD1QcAiMJyNvRptFkjJXovZouhRkTEMlazQ&s",
                            Name = "Health Inc.",
                            PhoneContact = "987654321",
                            ProvinceId = 0,
                            Slug = "health-inc",
                            Website = "www.healthinc.com"
                        },
                        new
                        {
                            Id = new Guid("3341c9fe-3d9e-490a-9be0-7a3bd2daf0e5"),
                            AccountId = new Guid("c0cc30cf-d777-4046-98d1-b15cca43b8e3"),
                            Address = "45688 London",
                            Description = "An Inc. is a an incident company.",
                            DistrictId = 0,
                            EmailContact = "info@AnRe.com",
                            EmployeeCount = 300,
                            Industry = "IT",
                            Logo = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRsowdkWEAhFe0idqRamO_CAvGutpD1CHKpcA&s",
                            Name = "An Inc.",
                            PhoneContact = "98765432112",
                            ProvinceId = 0,
                            Slug = "an-pro-ga",
                            Website = "www.Anrp.com"
                        });
                });

            modelBuilder.Entity("JobFinder.Core.Entity.Job", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("CloseDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("CommitmentTypeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CompanyId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("CreatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("DistrictId")
                        .HasColumnType("int");

                    b.Property<Guid?>("EducationLevelRequirementId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("GenderRequirementId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int?>("MaxAgeRequirement")
                        .HasColumnType("int");

                    b.Property<int?>("MinAgeRequirement")
                        .HasColumnType("int");

                    b.Property<int?>("ProvinceId")
                        .HasColumnType("int");

                    b.Property<double?>("Salary")
                        .HasColumnType("float");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("UpdatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("WorkArrangementId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("WorkExperienceRequirementId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("CommitmentTypeId");

                    b.HasIndex("CompanyId");

                    b.HasIndex("EducationLevelRequirementId");

                    b.HasIndex("GenderRequirementId");

                    b.HasIndex("WorkArrangementId");

                    b.HasIndex("WorkExperienceRequirementId");

                    b.ToTable("Jobs");

                    b.HasData(
                        new
                        {
                            Id = new Guid("ba81cfe8-ceea-4a42-a4bd-073a3cc6a0b8"),
                            CloseDate = new DateTime(2025, 1, 30, 17, 51, 28, 141, DateTimeKind.Local).AddTicks(3885),
                            CommitmentTypeId = new Guid("540f318e-b42f-4485-9e60-8faa5bf80962"),
                            CompanyId = new Guid("c9f35421-51b8-4d3e-9dd2-671af01f04bf"),
                            CreatedAt = new DateTime(2024, 10, 30, 17, 51, 28, 141, DateTimeKind.Local).AddTicks(3914),
                            Description = "Develop and maintain web applications.",
                            DistrictId = 10,
                            EducationLevelRequirementId = new Guid("bc4ecf1e-8841-47f2-86ec-b0c523f03da1"),
                            GenderRequirementId = new Guid("79685cdb-be26-49cc-b7f9-1fb51686f5ba"),
                            MaxAgeRequirement = 35,
                            MinAgeRequirement = 21,
                            ProvinceId = 1,
                            Salary = 80000.0,
                            Status = 1,
                            Title = "Software Engineer",
                            UpdatedAt = new DateTime(2024, 10, 30, 17, 51, 28, 141, DateTimeKind.Local).AddTicks(3915),
                            WorkArrangementId = new Guid("04a9de34-0869-41b2-87a8-63c20c4ba22a"),
                            WorkExperienceRequirementId = new Guid("67db1aef-c1b1-4424-8313-774a5dccdb9d")
                        },
                        new
                        {
                            Id = new Guid("0eb8641e-99cf-427a-9088-a6006fc3a095"),
                            CloseDate = new DateTime(2024, 12, 30, 17, 51, 28, 141, DateTimeKind.Local).AddTicks(3919),
                            CommitmentTypeId = new Guid("5d06c3b1-2bd1-4c68-96b4-f4cd8c899dff"),
                            CompanyId = new Guid("fe57b774-4c2e-48dd-bd67-5982398ee24d"),
                            CreatedAt = new DateTime(2024, 10, 30, 17, 51, 28, 141, DateTimeKind.Local).AddTicks(3924),
                            Description = "Analyze large datasets to generate business insights.",
                            DistrictId = 15,
                            EducationLevelRequirementId = new Guid("bc44b9a9-5cd6-4195-a7bd-92b4bef6d8fb"),
                            GenderRequirementId = new Guid("7b5f69cb-5996-4a57-b9c6-9fee2a791bf6"),
                            MaxAgeRequirement = 40,
                            MinAgeRequirement = 23,
                            ProvinceId = 2,
                            Salary = 60000.0,
                            Status = 1,
                            Title = "Data Analyst",
                            UpdatedAt = new DateTime(2024, 10, 30, 17, 51, 28, 141, DateTimeKind.Local).AddTicks(3925),
                            WorkArrangementId = new Guid("376764fa-28ec-4a08-80e3-a6ab407e8601"),
                            WorkExperienceRequirementId = new Guid("bf38a1b9-dee3-455a-87c1-4e034fe806f7")
                        },
                        new
                        {
                            Id = new Guid("605420b5-e0a3-4b5c-a4de-22972c848625"),
                            CloseDate = new DateTime(2025, 2, 28, 17, 51, 28, 141, DateTimeKind.Local).AddTicks(3927),
                            CommitmentTypeId = new Guid("540f318e-b42f-4485-9e60-8faa5bf80962"),
                            CompanyId = new Guid("3341c9fe-3d9e-490a-9be0-7a3bd2daf0e5"),
                            CreatedAt = new DateTime(2024, 10, 30, 17, 51, 28, 141, DateTimeKind.Local).AddTicks(3934),
                            Description = "Oversee product development lifecycle.",
                            DistrictId = 20,
                            EducationLevelRequirementId = new Guid("a3fb036a-04fc-4590-b87d-6ed32e2ec692"),
                            GenderRequirementId = new Guid("12497687-64b8-4d8e-814a-b7d1d33d3aab"),
                            MaxAgeRequirement = 45,
                            MinAgeRequirement = 28,
                            ProvinceId = 3,
                            Salary = 95000.0,
                            Status = 1,
                            Title = "Product Manager",
                            UpdatedAt = new DateTime(2024, 10, 30, 17, 51, 28, 141, DateTimeKind.Local).AddTicks(3934),
                            WorkArrangementId = new Guid("c199da74-c2fb-4381-b093-cf2f1e3e8f06"),
                            WorkExperienceRequirementId = new Guid("646ccd9f-aa2f-413e-8d3e-eb8ab0b14c96")
                        },
                        new
                        {
                            Id = new Guid("9d02e989-f879-489a-87e2-fd844a874134"),
                            CloseDate = new DateTime(2025, 1, 30, 17, 51, 28, 141, DateTimeKind.Local).AddTicks(3944),
                            CommitmentTypeId = new Guid("44b668b2-09ee-499e-af95-73598f9153a2"),
                            CompanyId = new Guid("c9f35421-51b8-4d3e-9dd2-671af01f04bf"),
                            CreatedAt = new DateTime(2024, 10, 30, 17, 51, 28, 141, DateTimeKind.Local).AddTicks(3948),
                            Description = "Design intuitive user interfaces.",
                            DistrictId = 25,
                            EducationLevelRequirementId = new Guid("bc4ecf1e-8841-47f2-86ec-b0c523f03da1"),
                            GenderRequirementId = new Guid("79685cdb-be26-49cc-b7f9-1fb51686f5ba"),
                            MaxAgeRequirement = 38,
                            MinAgeRequirement = 24,
                            ProvinceId = 4,
                            Salary = 70000.0,
                            Status = 1,
                            Title = "UX Designer",
                            UpdatedAt = new DateTime(2024, 10, 30, 17, 51, 28, 141, DateTimeKind.Local).AddTicks(3949),
                            WorkArrangementId = new Guid("04a9de34-0869-41b2-87a8-63c20c4ba22a"),
                            WorkExperienceRequirementId = new Guid("cc4121b2-72c2-4226-ad12-24e722b50cc2")
                        });
                });

            modelBuilder.Entity("JobFinder.Core.Entity.JobApplication", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CVLink")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("CreatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("JobId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("UpdatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("JobId");

                    b.HasIndex("UserId");

                    b.ToTable("JobApplications");
                });

            modelBuilder.Entity("JobFinder.Core.Entity.Metadata", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Metadatas");

                    b.HasData(
                        new
                        {
                            Id = new Guid("540f318e-b42f-4485-9e60-8faa5bf80962"),
                            Type = 0,
                            Value = "{\"data\"}: \"Fulltime\"}"
                        },
                        new
                        {
                            Id = new Guid("5d06c3b1-2bd1-4c68-96b4-f4cd8c899dff"),
                            Type = 0,
                            Value = "{\"data\"}: \"PartTime\"}"
                        },
                        new
                        {
                            Id = new Guid("3fbef738-ed16-4778-8463-8390444841de"),
                            Type = 0,
                            Value = "{\"data\"}: \"Internship\"}"
                        },
                        new
                        {
                            Id = new Guid("26a49bd7-ad8c-40be-8e7c-dd903f7a653e"),
                            Type = 0,
                            Value = "{\"data\"}: \"Freelance\"}"
                        },
                        new
                        {
                            Id = new Guid("44b668b2-09ee-499e-af95-73598f9153a2"),
                            Type = 0,
                            Value = "{\"data\"}: \"Contract\"}"
                        },
                        new
                        {
                            Id = new Guid("96279c48-1bfe-441d-992e-db86cb3bf315"),
                            Type = 0,
                            Value = "{\"data\"}: \"Daily\"}"
                        },
                        new
                        {
                            Id = new Guid("04a9de34-0869-41b2-87a8-63c20c4ba22a"),
                            Type = 1,
                            Value = "{\"data\"}: \"Onsite\"}"
                        },
                        new
                        {
                            Id = new Guid("376764fa-28ec-4a08-80e3-a6ab407e8601"),
                            Type = 1,
                            Value = "{\"data\"}: \"Remote/WFH\"}"
                        },
                        new
                        {
                            Id = new Guid("c199da74-c2fb-4381-b093-cf2f1e3e8f06"),
                            Type = 1,
                            Value = "{\"data\"}: \"Hybrid\"}"
                        },
                        new
                        {
                            Id = new Guid("fbce1042-bce0-47a3-92cc-54e3b86eb570"),
                            Type = 2,
                            Value = "{\"data\"}: \"FreshGradute\"}"
                        },
                        new
                        {
                            Id = new Guid("4a3e2365-47f4-45d9-b1d4-326d9f2f3203"),
                            Type = 2,
                            Value = "{\"data\"}: \"LessThanOneYear\"}"
                        },
                        new
                        {
                            Id = new Guid("cc4121b2-72c2-4226-ad12-24e722b50cc2"),
                            Type = 2,
                            Value = "{\"data\"}: \"OneToThreeYears\"}"
                        },
                        new
                        {
                            Id = new Guid("67db1aef-c1b1-4424-8313-774a5dccdb9d"),
                            Type = 2,
                            Value = "{\"data\"}: \"ThreeToFiveYears\"}"
                        },
                        new
                        {
                            Id = new Guid("bf38a1b9-dee3-455a-87c1-4e034fe806f7"),
                            Type = 2,
                            Value = "{\"data\"}: \"FiveToTenYears\"}"
                        },
                        new
                        {
                            Id = new Guid("646ccd9f-aa2f-413e-8d3e-eb8ab0b14c96"),
                            Type = 2,
                            Value = "{\"data\"}: \"MoreThanTenYears\"}"
                        },
                        new
                        {
                            Id = new Guid("ceb115a0-3ffe-455c-b24e-9eff074e1ec1"),
                            Type = 3,
                            Value = "{\"data\"}: \"PrimarySchool\"}"
                        },
                        new
                        {
                            Id = new Guid("c9d2f457-06bf-40ad-9a4a-d6e201888129"),
                            Type = 3,
                            Value = "{\"data\"}: \"SecondarySchool\"}"
                        },
                        new
                        {
                            Id = new Guid("52e22ea6-7f97-4816-b64a-bfd4aa21cd74"),
                            Type = 3,
                            Value = "{\"data\"}: \"SeniorOrVocationalHighSchool\"}"
                        },
                        new
                        {
                            Id = new Guid("ebb6a034-ce37-41a4-b1f6-c70f1698c4f2"),
                            Type = 3,
                            Value = "{\"data\"}: \"Diploma\"}"
                        },
                        new
                        {
                            Id = new Guid("a3fb036a-04fc-4590-b87d-6ed32e2ec692"),
                            Type = 3,
                            Value = "{\"data\"}: \"CollegeDegree\"}"
                        },
                        new
                        {
                            Id = new Guid("bc4ecf1e-8841-47f2-86ec-b0c523f03da1"),
                            Type = 3,
                            Value = "{\"data\"}: \"BachelorDegree\"}"
                        },
                        new
                        {
                            Id = new Guid("bc44b9a9-5cd6-4195-a7bd-92b4bef6d8fb"),
                            Type = 3,
                            Value = "{\"data\"}: \"MasterDegree\"}"
                        },
                        new
                        {
                            Id = new Guid("853384de-154c-4187-bf5d-aa684b85736d"),
                            Type = 3,
                            Value = "{\"data\"}: \"Doctorate\"}"
                        },
                        new
                        {
                            Id = new Guid("79685cdb-be26-49cc-b7f9-1fb51686f5ba"),
                            Type = 4,
                            Value = "{\"data\"}: \"Male\"}"
                        },
                        new
                        {
                            Id = new Guid("7b5f69cb-5996-4a57-b9c6-9fee2a791bf6"),
                            Type = 4,
                            Value = "{\"data\"}: \"Female\"}"
                        },
                        new
                        {
                            Id = new Guid("12497687-64b8-4d8e-814a-b7d1d33d3aab"),
                            Type = 4,
                            Value = "{\"data\"}: \"Others\"}"
                        });
                });

            modelBuilder.Entity("JobFinder.Core.Entity.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("AccountId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("CreatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateOnly>("DateOfBirth")
                        .HasColumnType("date");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("UpdatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("AccountId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("JobFinder.Core.Entity.Company", b =>
                {
                    b.HasOne("JobFinder.Core.Entity.Account", "Account")
                        .WithMany()
                        .HasForeignKey("AccountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Account");
                });

            modelBuilder.Entity("JobFinder.Core.Entity.Job", b =>
                {
                    b.HasOne("JobFinder.Core.Entity.Metadata", "CommitmentType")
                        .WithMany("CommitmentTypeJobs")
                        .HasForeignKey("CommitmentTypeId");

                    b.HasOne("JobFinder.Core.Entity.Company", "Company")
                        .WithMany("Jobs")
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("JobFinder.Core.Entity.Metadata", "EducationLevelRequirement")
                        .WithMany("EducationLevelRequirementJobs")
                        .HasForeignKey("EducationLevelRequirementId");

                    b.HasOne("JobFinder.Core.Entity.Metadata", "GenderRequirement")
                        .WithMany("GenderRequirementJobs")
                        .HasForeignKey("GenderRequirementId");

                    b.HasOne("JobFinder.Core.Entity.Metadata", "WorkArrangement")
                        .WithMany("WorkArrangementJobs")
                        .HasForeignKey("WorkArrangementId");

                    b.HasOne("JobFinder.Core.Entity.Metadata", "WorkExperienceRequirement")
                        .WithMany("WorkExperienceRequirementJobs")
                        .HasForeignKey("WorkExperienceRequirementId");

                    b.Navigation("CommitmentType");

                    b.Navigation("Company");

                    b.Navigation("EducationLevelRequirement");

                    b.Navigation("GenderRequirement");

                    b.Navigation("WorkArrangement");

                    b.Navigation("WorkExperienceRequirement");
                });

            modelBuilder.Entity("JobFinder.Core.Entity.JobApplication", b =>
                {
                    b.HasOne("JobFinder.Core.Entity.Job", "Job")
                        .WithMany("JobApplications")
                        .HasForeignKey("JobId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("JobFinder.Core.Entity.User", "User")
                        .WithMany("JobApplications")
                        .HasForeignKey("UserId");

                    b.Navigation("Job");

                    b.Navigation("User");
                });

            modelBuilder.Entity("JobFinder.Core.Entity.User", b =>
                {
                    b.HasOne("JobFinder.Core.Entity.Account", "Account")
                        .WithMany()
                        .HasForeignKey("AccountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Account");
                });

            modelBuilder.Entity("JobFinder.Core.Entity.Company", b =>
                {
                    b.Navigation("Jobs");
                });

            modelBuilder.Entity("JobFinder.Core.Entity.Job", b =>
                {
                    b.Navigation("JobApplications");
                });

            modelBuilder.Entity("JobFinder.Core.Entity.Metadata", b =>
                {
                    b.Navigation("CommitmentTypeJobs");

                    b.Navigation("EducationLevelRequirementJobs");

                    b.Navigation("GenderRequirementJobs");

                    b.Navigation("WorkArrangementJobs");

                    b.Navigation("WorkExperienceRequirementJobs");
                });

            modelBuilder.Entity("JobFinder.Core.Entity.User", b =>
                {
                    b.Navigation("JobApplications");
                });
#pragma warning restore 612, 618
        }
    }
}
