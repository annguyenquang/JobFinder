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
                            Id = new Guid("ec489dc4-e1d0-4a46-9f98-dffccf025e79"),
                            Email = "",
                            Password = "admin",
                            Phone = "113",
                            Username = "admin"
                        },
                        new
                        {
                            Id = new Guid("e159c805-7d6b-4133-8036-12ff80c9d04f"),
                            Email = "",
                            Password = "account0",
                            Phone = "0123456789",
                            Username = "account0"
                        },
                        new
                        {
                            Id = new Guid("7b1f6639-dd3e-45f2-8793-3db862a84c2e"),
                            Email = "",
                            Password = "account1",
                            Phone = "0823456789",
                            Username = "account1"
                        },
                        new
                        {
                            Id = new Guid("b6cc6d88-e7b9-483b-b161-a500276b2550"),
                            Email = "",
                            Password = "account2",
                            Phone = "0183456789",
                            Username = "account2"
                        },
                        new
                        {
                            Id = new Guid("090b311e-3067-4b89-9732-f6448f815197"),
                            Email = "",
                            Password = "account3",
                            Phone = "0128456789",
                            Username = "account3"
                        },
                        new
                        {
                            Id = new Guid("9bec4410-37a8-4d09-8ec3-ca84ba8eb591"),
                            Email = "",
                            Password = "account4",
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

                    b.Property<string>("EmailContact")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("EmployeeCount")
                        .HasColumnType("int");

                    b.Property<string>("Industry")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneContact")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Slug")
                        .IsRequired()
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
                        .IsUnique();

                    b.ToTable("Companies");

                    b.HasData(
                        new
                        {
                            Id = new Guid("8520a30d-7152-43d1-a87a-5ef858506350"),
                            AccountId = new Guid("ec489dc4-e1d0-4a46-9f98-dffccf025e79"),
                            Address = "123 Tech Lane",
                            EmailContact = "info@techcorp.com",
                            EmployeeCount = 500,
                            Industry = "Technology",
                            Name = "Tech Corp",
                            Nation = "USA",
                            PhoneContact = "123456789",
                            Slug = "tech-corp",
                            Website = "www.techcorp.com"
                        },
                        new
                        {
                            Id = new Guid("f1583a4d-ceca-4734-b3dd-cbe10d77fdae"),
                            AccountId = new Guid("e159c805-7d6b-4133-8036-12ff80c9d04f"),
                            Address = "456 Health Blvd",
                            EmailContact = "info@healthinc.com",
                            EmployeeCount = 300,
                            Industry = "Healthcare",
                            Name = "Health Inc.",
                            Nation = "USA",
                            PhoneContact = "987654321",
                            Slug = "health-inc",
                            Website = "www.healthinc.com"
                        },
                        new
                        {
                            Id = new Guid("69d3dce1-544e-40ca-84fc-71cba06c7247"),
                            AccountId = new Guid("7b1f6639-dd3e-45f2-8793-3db862a84c2e"),
                            Address = "45688 London",
                            EmailContact = "info@AnRe.com",
                            EmployeeCount = 300,
                            Industry = "IT",
                            Name = "An Inc.",
                            Nation = "VN",
                            PhoneContact = "98765432112",
                            Slug = "an-pro-ga",
                            Website = "www.Anrp.com"
                        });
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

            modelBuilder.Entity("JobFinder.Core.Entity.Position", b =>
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

                    b.ToTable("Positions");

                    b.HasData(
                        new
                        {
                            Id = new Guid("57a0a2a3-d146-455f-acc5-9bdb26876d8a"),
                            CloseDate = new DateTime(2025, 1, 22, 17, 13, 12, 906, DateTimeKind.Local).AddTicks(7317),
                            CommitmentTypeId = new Guid("540f318e-b42f-4485-9e60-8faa5bf80962"),
                            CompanyId = new Guid("8520a30d-7152-43d1-a87a-5ef858506350"),
                            CreatedAt = new DateTime(2024, 10, 22, 17, 13, 12, 906, DateTimeKind.Local).AddTicks(7341),
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
                            UpdatedAt = new DateTime(2024, 10, 22, 17, 13, 12, 906, DateTimeKind.Local).AddTicks(7342),
                            WorkArrangementId = new Guid("04a9de34-0869-41b2-87a8-63c20c4ba22a"),
                            WorkExperienceRequirementId = new Guid("67db1aef-c1b1-4424-8313-774a5dccdb9d")
                        },
                        new
                        {
                            Id = new Guid("2c7203db-2844-468a-8bae-adb61ec5a2b3"),
                            CloseDate = new DateTime(2024, 12, 22, 17, 13, 12, 906, DateTimeKind.Local).AddTicks(7389),
                            CommitmentTypeId = new Guid("5d06c3b1-2bd1-4c68-96b4-f4cd8c899dff"),
                            CompanyId = new Guid("f1583a4d-ceca-4734-b3dd-cbe10d77fdae"),
                            CreatedAt = new DateTime(2024, 10, 22, 17, 13, 12, 906, DateTimeKind.Local).AddTicks(7396),
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
                            UpdatedAt = new DateTime(2024, 10, 22, 17, 13, 12, 906, DateTimeKind.Local).AddTicks(7397),
                            WorkArrangementId = new Guid("376764fa-28ec-4a08-80e3-a6ab407e8601"),
                            WorkExperienceRequirementId = new Guid("bf38a1b9-dee3-455a-87c1-4e034fe806f7")
                        },
                        new
                        {
                            Id = new Guid("7d615254-6a0b-483e-8c7e-395ad03ae399"),
                            CloseDate = new DateTime(2025, 2, 22, 17, 13, 12, 906, DateTimeKind.Local).AddTicks(7400),
                            CommitmentTypeId = new Guid("540f318e-b42f-4485-9e60-8faa5bf80962"),
                            CompanyId = new Guid("69d3dce1-544e-40ca-84fc-71cba06c7247"),
                            CreatedAt = new DateTime(2024, 10, 22, 17, 13, 12, 906, DateTimeKind.Local).AddTicks(7404),
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
                            UpdatedAt = new DateTime(2024, 10, 22, 17, 13, 12, 906, DateTimeKind.Local).AddTicks(7405),
                            WorkArrangementId = new Guid("c199da74-c2fb-4381-b093-cf2f1e3e8f06"),
                            WorkExperienceRequirementId = new Guid("646ccd9f-aa2f-413e-8d3e-eb8ab0b14c96")
                        },
                        new
                        {
                            Id = new Guid("f91bb54d-4ac9-4089-bc0a-e3981e9298b3"),
                            CloseDate = new DateTime(2025, 1, 22, 17, 13, 12, 906, DateTimeKind.Local).AddTicks(7408),
                            CommitmentTypeId = new Guid("44b668b2-09ee-499e-af95-73598f9153a2"),
                            CompanyId = new Guid("8520a30d-7152-43d1-a87a-5ef858506350"),
                            CreatedAt = new DateTime(2024, 10, 22, 17, 13, 12, 906, DateTimeKind.Local).AddTicks(7412),
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
                            UpdatedAt = new DateTime(2024, 10, 22, 17, 13, 12, 906, DateTimeKind.Local).AddTicks(7413),
                            WorkArrangementId = new Guid("04a9de34-0869-41b2-87a8-63c20c4ba22a"),
                            WorkExperienceRequirementId = new Guid("cc4121b2-72c2-4226-ad12-24e722b50cc2")
                        });
                });

            modelBuilder.Entity("JobFinder.Core.Entity.PositionApplication", b =>
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

                    b.Property<Guid>("PositionId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("UpdatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("PositionId");

                    b.HasIndex("UserId");

                    b.ToTable("PositionApplications");
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

            modelBuilder.Entity("JobFinder.Core.Entity.Position", b =>
                {
                    b.HasOne("JobFinder.Core.Entity.Metadata", "CommitmentType")
                        .WithMany("CommitmentTypePositions")
                        .HasForeignKey("CommitmentTypeId");

                    b.HasOne("JobFinder.Core.Entity.Company", "Company")
                        .WithMany("Positions")
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("JobFinder.Core.Entity.Metadata", "EducationLevelRequirement")
                        .WithMany("EducationLevelRequirementPositions")
                        .HasForeignKey("EducationLevelRequirementId");

                    b.HasOne("JobFinder.Core.Entity.Metadata", "GenderRequirement")
                        .WithMany("GenderRequirementPositions")
                        .HasForeignKey("GenderRequirementId");

                    b.HasOne("JobFinder.Core.Entity.Metadata", "WorkArrangement")
                        .WithMany("WorkArrangementPositions")
                        .HasForeignKey("WorkArrangementId");

                    b.HasOne("JobFinder.Core.Entity.Metadata", "WorkExperienceRequirement")
                        .WithMany("WorkExperienceRequirementPositions")
                        .HasForeignKey("WorkExperienceRequirementId");

                    b.Navigation("CommitmentType");

                    b.Navigation("Company");

                    b.Navigation("EducationLevelRequirement");

                    b.Navigation("GenderRequirement");

                    b.Navigation("WorkArrangement");

                    b.Navigation("WorkExperienceRequirement");
                });

            modelBuilder.Entity("JobFinder.Core.Entity.PositionApplication", b =>
                {
                    b.HasOne("JobFinder.Core.Entity.Position", "Position")
                        .WithMany("PositionApplications")
                        .HasForeignKey("PositionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("JobFinder.Core.Entity.User", "User")
                        .WithMany("PositionApplications")
                        .HasForeignKey("UserId");

                    b.Navigation("Position");

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
                    b.Navigation("Positions");
                });

            modelBuilder.Entity("JobFinder.Core.Entity.Metadata", b =>
                {
                    b.Navigation("CommitmentTypePositions");

                    b.Navigation("EducationLevelRequirementPositions");

                    b.Navigation("GenderRequirementPositions");

                    b.Navigation("WorkArrangementPositions");

                    b.Navigation("WorkExperienceRequirementPositions");
                });

            modelBuilder.Entity("JobFinder.Core.Entity.Position", b =>
                {
                    b.Navigation("PositionApplications");
                });

            modelBuilder.Entity("JobFinder.Core.Entity.User", b =>
                {
                    b.Navigation("PositionApplications");
                });
#pragma warning restore 612, 618
        }
    }
}
