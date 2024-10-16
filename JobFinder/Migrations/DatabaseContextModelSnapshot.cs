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
                            Id = new Guid("2cf91c58-cfc9-41b9-81d4-ddac43359083"),
                            Email = "admin@gmail.com",
                            Password = "Admin",
                            Phone = "0123456789",
                            Username = "Admin"
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
                            Id = new Guid("2a37efe0-29b0-4c3f-b1be-73d2a0cb0b50"),
                            Type = 0,
                            Value = "{data: \"Fulltime\"}"
                        },
                        new
                        {
                            Id = new Guid("05efa04b-16e7-494e-86b8-991520c2e511"),
                            Type = 0,
                            Value = "{data: \"PartTime\"}"
                        },
                        new
                        {
                            Id = new Guid("03e2f467-5d58-4d0b-8dd4-b9cfd6e2064b"),
                            Type = 0,
                            Value = "{data: \"Internship\"}"
                        },
                        new
                        {
                            Id = new Guid("7aaf7adb-8931-41be-9579-47af16bb03f6"),
                            Type = 0,
                            Value = "{data: \"Freelance\"}"
                        },
                        new
                        {
                            Id = new Guid("ff0102b8-fd35-48a7-9991-2c442bf4614e"),
                            Type = 0,
                            Value = "{data: \"Contract\"}"
                        },
                        new
                        {
                            Id = new Guid("048e5b7f-0f56-48df-8f86-94ee53b5fb20"),
                            Type = 0,
                            Value = "{data: \"Daily\"}"
                        },
                        new
                        {
                            Id = new Guid("ed71618d-81c5-4ac2-a3ef-18f4ab366634"),
                            Type = 1,
                            Value = "{data: \"Onsite\"}"
                        },
                        new
                        {
                            Id = new Guid("b351cb49-3c59-43ab-9449-548e33c27f8c"),
                            Type = 1,
                            Value = "{data: \"Remote/WFH\"}"
                        },
                        new
                        {
                            Id = new Guid("a60f67e5-42c6-4f0b-986e-d9f0e47a992a"),
                            Type = 1,
                            Value = "{data: \"Hybrid\"}"
                        },
                        new
                        {
                            Id = new Guid("a275f2e0-9fe9-40f3-8b58-4faf1529bfb0"),
                            Type = 2,
                            Value = "{data: \"FreshGradute\"}"
                        },
                        new
                        {
                            Id = new Guid("2687ab67-a685-47f1-b583-c20264c31deb"),
                            Type = 2,
                            Value = "{data: \"LessThanOneYear\"}"
                        },
                        new
                        {
                            Id = new Guid("dc364068-17f0-492e-b2ed-4708a8caf4dc"),
                            Type = 2,
                            Value = "{data: \"OneToThreeYears\"}"
                        },
                        new
                        {
                            Id = new Guid("a9e0bbae-eb86-4a61-8f01-ea15ec6fe930"),
                            Type = 2,
                            Value = "{data: \"ThreeToFiveYears\"}"
                        },
                        new
                        {
                            Id = new Guid("33fbdd36-6d4e-4d0b-9927-fede52a4fb45"),
                            Type = 2,
                            Value = "{data: \"FiveToTenYears\"}"
                        },
                        new
                        {
                            Id = new Guid("19bf178a-ef2d-4cc5-92bf-235191b791e1"),
                            Type = 2,
                            Value = "{data: \"MoreThanTenYears\"}"
                        },
                        new
                        {
                            Id = new Guid("130cdb4e-2468-4e09-b744-777299ae9c18"),
                            Type = 3,
                            Value = "{data: \"PrimarySchool\"}"
                        },
                        new
                        {
                            Id = new Guid("3d7e4c9d-af43-4ba8-9112-92277083cd44"),
                            Type = 3,
                            Value = "{data: \"SecondarySchool\"}"
                        },
                        new
                        {
                            Id = new Guid("7a5c71fa-72e5-45ff-b7ab-0e54aa63cb49"),
                            Type = 3,
                            Value = "{data: \"SeniorOrVocationalHighSchool\"}"
                        },
                        new
                        {
                            Id = new Guid("e7852238-94d1-4317-b773-639d4f482b7a"),
                            Type = 3,
                            Value = "{data: \"Diploma\"}"
                        },
                        new
                        {
                            Id = new Guid("26c21132-df12-467d-84d1-90de5f750864"),
                            Type = 3,
                            Value = "{data: \"CollegeDegree\"}"
                        },
                        new
                        {
                            Id = new Guid("35d6a8fc-8953-4aec-9d8a-55e4f15f4a58"),
                            Type = 3,
                            Value = "{data: \"BachelorDegree\"}"
                        },
                        new
                        {
                            Id = new Guid("06e79622-3bf8-469a-b831-8085ab0e6a7b"),
                            Type = 3,
                            Value = "{data: \"MasterDegree\"}"
                        },
                        new
                        {
                            Id = new Guid("53096860-dc18-4a6f-867c-bf5aeb438215"),
                            Type = 3,
                            Value = "{data: \"Doctorate\"}"
                        },
                        new
                        {
                            Id = new Guid("2870d315-3761-436c-b3f0-5cc20a9af33b"),
                            Type = 4,
                            Value = "{data: \"Male\"}"
                        },
                        new
                        {
                            Id = new Guid("f0b96c50-543f-4cfb-be0c-f8c629310504"),
                            Type = 4,
                            Value = "{data: \"Female\"}"
                        },
                        new
                        {
                            Id = new Guid("45def8ee-d2fc-42e6-9a24-d43afce728aa"),
                            Type = 4,
                            Value = "{data: \"Others\"}"
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
