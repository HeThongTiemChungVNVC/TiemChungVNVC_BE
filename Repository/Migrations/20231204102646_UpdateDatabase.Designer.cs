﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Repository.DbContexts;

#nullable disable

namespace Repository.Migrations
{
    [DbContext(typeof(VNVCContext))]
    [Migration("20231204102646_UpdateDatabase")]
    partial class UpdateDatabase
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DAL.Dtos.DtoCategoryPosition", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("CreatedBy")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(max)")
                        .HasDefaultValue("admin");

                    b.Property<DateTime>("CreatedTime")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2023, 12, 4, 17, 26, 46, 600, DateTimeKind.Local).AddTicks(2971));

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false);

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("CategoryPosition", (string)null);
                });

            modelBuilder.Entity("DAL.Dtos.DtoCategoryVaccine", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("CreatedBy")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(max)")
                        .HasDefaultValue("admin");

                    b.Property<DateTime>("CreatedTime")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2023, 12, 4, 17, 26, 46, 600, DateTimeKind.Local).AddTicks(4943));

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false);

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("CategoryVaccine", (string)null);
                });

            modelBuilder.Entity("DAL.Dtos.DtoCity", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("CreatedBy")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(max)")
                        .HasDefaultValue("admin");

                    b.Property<DateTime>("CreatedTime")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2023, 12, 4, 17, 26, 46, 597, DateTimeKind.Local).AddTicks(9535));

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false);

                    b.Property<string>("NameCity")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("City", (string)null);
                });

            modelBuilder.Entity("DAL.Dtos.DtoCustomer", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("CreatedBy")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(max)")
                        .HasDefaultValue("admin");

                    b.Property<DateTime>("CreatedTime")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2023, 12, 4, 17, 26, 46, 599, DateTimeKind.Local).AddTicks(9863));

                    b.Property<DateTime>("DateOfBirth")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2023, 12, 4, 17, 26, 46, 600, DateTimeKind.Local).AddTicks(989));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<bool>("Gender")
                        .HasMaxLength(10)
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false);

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("nvarchar(11)");

                    b.HasKey("Id");

                    b.ToTable("Customer", (string)null);
                });

            modelBuilder.Entity("DAL.Dtos.DtoDistrict", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("CreatedBy")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(max)")
                        .HasDefaultValue("admin");

                    b.Property<DateTime>("CreatedTime")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2023, 12, 4, 17, 26, 46, 598, DateTimeKind.Local).AddTicks(2222));

                    b.Property<string>("IdCity")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false);

                    b.Property<string>("NameDistrict")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.HasIndex("IdCity");

                    b.ToTable("District", (string)null);
                });

            modelBuilder.Entity("DAL.Dtos.DtoEmployee", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("IdCategoryPosition")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("CreatedBy")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(max)")
                        .HasDefaultValue("admin");

                    b.Property<DateTime>("CreatedTime")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2023, 12, 4, 17, 26, 46, 599, DateTimeKind.Local).AddTicks(1132));

                    b.Property<DateTime>("DateOfBirth")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2023, 12, 4, 17, 26, 46, 599, DateTimeKind.Local).AddTicks(4151));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Fk_employee_position")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false);

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("nvarchar(11)");

                    b.Property<string>("Position")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id", "IdCategoryPosition");

                    b.HasIndex("Fk_employee_position");

                    b.ToTable("Employee", (string)null);
                });

            modelBuilder.Entity("DAL.Dtos.DtoInformation", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CreatedBy")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(max)")
                        .HasDefaultValue("admin");

                    b.Property<DateTime>("CreatedTime")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2023, 12, 4, 17, 26, 46, 597, DateTimeKind.Local).AddTicks(7113));

                    b.Property<DateTime>("Dob")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(15)
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2023, 12, 4, 17, 26, 46, 597, DateTimeKind.Local).AddTicks(7815));

                    b.Property<string>("Email")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("FullName")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Gender")
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false);

                    b.Property<string>("Phone")
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("Role")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("Information", (string)null);
                });

            modelBuilder.Entity("DAL.Dtos.DtoInjectionChart", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("CreatedBy")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(max)")
                        .HasDefaultValue("admin");

                    b.Property<DateTime>("CreatedTime")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2023, 12, 4, 17, 26, 46, 600, DateTimeKind.Local).AddTicks(7539));

                    b.Property<int>("Doses")
                        .HasColumnType("int");

                    b.Property<string>("IdVaccine")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("Interval")
                        .HasColumnType("int");

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false);

                    b.Property<bool>("Reminder")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false);

                    b.HasKey("Id");

                    b.HasIndex("IdVaccine")
                        .IsUnique();

                    b.ToTable("InjectionChart", (string)null);
                });

            modelBuilder.Entity("DAL.Dtos.DtoPasswordRecoveryToken", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasDefaultValue("1657c5d6_a");

                    b.Property<string>("UserId")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("CreatedBy")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(max)")
                        .HasDefaultValue("admin");

                    b.Property<DateTime>("CreatedTime")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2023, 12, 4, 17, 26, 46, 597, DateTimeKind.Local).AddTicks(4349));

                    b.Property<DateTime>("Expires")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false);

                    b.Property<string>("PinCode")
                        .IsRequired()
                        .HasMaxLength(7)
                        .HasColumnType("nvarchar(7)");

                    b.HasKey("Id", "UserId");

                    b.HasIndex("UserId");

                    b.ToTable("RecoveryToken", (string)null);
                });

            modelBuilder.Entity("DAL.Dtos.DtoPriceVaccine", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("IdVaccine")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<float>("CostPrice")
                        .HasColumnType("real");

                    b.Property<string>("CreatedBy")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(max)")
                        .HasDefaultValue("admin");

                    b.Property<DateTime>("CreatedTime")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2023, 12, 4, 17, 26, 46, 600, DateTimeKind.Local).AddTicks(9905));

                    b.Property<string>("IdVaccineBacth")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false);

                    b.Property<float>("PreOrderPrice")
                        .HasColumnType("real");

                    b.Property<float>("RetailPrice")
                        .HasColumnType("real");

                    b.HasKey("Id", "IdVaccine");

                    b.HasIndex("IdVaccine")
                        .IsUnique();

                    b.HasIndex("IdVaccineBacth")
                        .IsUnique();

                    b.ToTable("PriceVaccine", (string)null);
                });

            modelBuilder.Entity("DAL.Dtos.DtoRefeshToken", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasDefaultValue("bb6302db_b");

                    b.Property<string>("RefeshToken")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("UserId")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("CreatedBy")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(max)")
                        .HasDefaultValue("admin");

                    b.Property<DateTime>("CreatedTime")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2023, 12, 4, 17, 26, 46, 596, DateTimeKind.Local).AddTicks(6460));

                    b.Property<DateTime>("Expires")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false);

                    b.HasKey("Id", "RefeshToken", "UserId");

                    b.HasIndex("UserId");

                    b.ToTable("RefeshToken", (string)null);
                });

            modelBuilder.Entity("DAL.Dtos.DtoSupplier", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CreatedBy")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(max)")
                        .HasDefaultValue("admin");

                    b.Property<DateTime>("CreatedTime")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2023, 12, 4, 17, 26, 46, 601, DateTimeKind.Local).AddTicks(4201));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false);

                    b.Property<string>("NameSupplier")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Supplier", (string)null);
                });

            modelBuilder.Entity("DAL.Dtos.DtoUser", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("CreatedBy")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(max)")
                        .HasDefaultValue("admin");

                    b.Property<DateTime>("CreatedTime")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2023, 12, 4, 17, 26, 46, 596, DateTimeKind.Local).AddTicks(9303));

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false);

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("User", (string)null);
                });

            modelBuilder.Entity("DAL.Dtos.DtoVaccinationCenter", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CenterName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<TimeSpan>("CloseTime")
                        .HasColumnType("time");

                    b.Property<string>("CreatedBy")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(max)")
                        .HasDefaultValue("admin");

                    b.Property<DateTime>("CreatedTime")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2023, 12, 4, 17, 26, 46, 601, DateTimeKind.Local).AddTicks(6904));

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false);

                    b.Property<TimeSpan>("OpenTime")
                        .HasColumnType("time");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("VaccinationCenter", (string)null);
                });

            modelBuilder.Entity("DAL.Dtos.DtoVaccine", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("CategoryVaccineId")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Condition")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CreatedBy")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(max)")
                        .HasDefaultValue("admin");

                    b.Property<DateTime>("CreatedTime")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2023, 12, 4, 17, 26, 46, 601, DateTimeKind.Local).AddTicks(8966));

                    b.Property<string>("IdCategoryVaccine")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("InjectionSite")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false);

                    b.Property<string>("NameVaccine")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Prevention")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryVaccineId");

                    b.ToTable("Vaccine", (string)null);
                });

            modelBuilder.Entity("DAL.Dtos.DtoVaccineBatch", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("CodeBatch")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CreatedBy")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(max)")
                        .HasDefaultValue("admin");

                    b.Property<DateTime>("CreatedTime")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2023, 12, 4, 17, 26, 46, 602, DateTimeKind.Local).AddTicks(9558));

                    b.Property<DateTime>("ExpirationDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2023, 12, 4, 17, 26, 46, 603, DateTimeKind.Local).AddTicks(1129));

                    b.Property<string>("IdSupplier")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("IdVaccine")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false);

                    b.Property<DateTime>("ManufacturingDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2023, 12, 4, 17, 26, 46, 603, DateTimeKind.Local).AddTicks(760));

                    b.Property<int>("QuantityOfVaccine")
                        .HasColumnType("int");

                    b.Property<string>("SupplierId")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("VaccineId")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("SupplierId");

                    b.HasIndex("VaccineId");

                    b.ToTable("VaccineBatch", (string)null);
                });

            modelBuilder.Entity("DAL.Dtos.DtoWard", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("CreatedBy")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(max)")
                        .HasDefaultValue("admin");

                    b.Property<DateTime>("CreatedTime")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2023, 12, 4, 17, 26, 46, 598, DateTimeKind.Local).AddTicks(7126));

                    b.Property<string>("IdDistrict")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false);

                    b.Property<string>("NameWard")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.HasIndex("IdDistrict");

                    b.ToTable("Ward", (string)null);
                });

            modelBuilder.Entity("DAL.Dtos.DtoDistrict", b =>
                {
                    b.HasOne("DAL.Dtos.DtoCity", "City")
                        .WithMany("Districts")
                        .HasForeignKey("IdCity")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_District_City");

                    b.Navigation("City");
                });

            modelBuilder.Entity("DAL.Dtos.DtoEmployee", b =>
                {
                    b.HasOne("DAL.Dtos.DtoCategoryPosition", "CategoryPosition")
                        .WithMany("Employees")
                        .HasForeignKey("Fk_employee_position")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.Navigation("CategoryPosition");
                });

            modelBuilder.Entity("DAL.Dtos.DtoInformation", b =>
                {
                    b.HasOne("DAL.Dtos.DtoUser", "User")
                        .WithOne("Information")
                        .HasForeignKey("DAL.Dtos.DtoInformation", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("DAL.Dtos.DtoInjectionChart", b =>
                {
                    b.HasOne("DAL.Dtos.DtoVaccine", "Vaccine")
                        .WithOne("InjectionChart")
                        .HasForeignKey("DAL.Dtos.DtoInjectionChart", "IdVaccine")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Vaccine");
                });

            modelBuilder.Entity("DAL.Dtos.DtoPasswordRecoveryToken", b =>
                {
                    b.HasOne("DAL.Dtos.DtoUser", "User")
                        .WithMany("PasswordRecoveryTokens")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_Recovery_User");

                    b.Navigation("User");
                });

            modelBuilder.Entity("DAL.Dtos.DtoPriceVaccine", b =>
                {
                    b.HasOne("DAL.Dtos.DtoVaccine", "Vaccine")
                        .WithOne("PriceVaccine")
                        .HasForeignKey("DAL.Dtos.DtoPriceVaccine", "IdVaccine")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("DAL.Dtos.DtoVaccineBatch", "VaccinceBatch")
                        .WithOne("PriceVaccine")
                        .HasForeignKey("DAL.Dtos.DtoPriceVaccine", "IdVaccineBacth")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("VaccinceBatch");

                    b.Navigation("Vaccine");
                });

            modelBuilder.Entity("DAL.Dtos.DtoRefeshToken", b =>
                {
                    b.HasOne("DAL.Dtos.DtoUser", "User")
                        .WithMany("RefeshTokens")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_RefeshToken_User");

                    b.Navigation("User");
                });

            modelBuilder.Entity("DAL.Dtos.DtoVaccine", b =>
                {
                    b.HasOne("DAL.Dtos.DtoCategoryVaccine", "CategoryVaccine")
                        .WithMany("Vaccines")
                        .HasForeignKey("CategoryVaccineId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("Fk_Category_Vaccine");

                    b.Navigation("CategoryVaccine");
                });

            modelBuilder.Entity("DAL.Dtos.DtoVaccineBatch", b =>
                {
                    b.HasOne("DAL.Dtos.DtoSupplier", "Supplier")
                        .WithMany("VaccineBatches")
                        .HasForeignKey("SupplierId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_batch_supplier");

                    b.HasOne("DAL.Dtos.DtoVaccine", "Vaccine")
                        .WithMany("VaccineBatches")
                        .HasForeignKey("VaccineId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Supplier");

                    b.Navigation("Vaccine");
                });

            modelBuilder.Entity("DAL.Dtos.DtoWard", b =>
                {
                    b.HasOne("DAL.Dtos.DtoDistrict", "District")
                        .WithMany("Wards")
                        .HasForeignKey("IdDistrict")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_Ward_District");

                    b.Navigation("District");
                });

            modelBuilder.Entity("DAL.Dtos.DtoCategoryPosition", b =>
                {
                    b.Navigation("Employees");
                });

            modelBuilder.Entity("DAL.Dtos.DtoCategoryVaccine", b =>
                {
                    b.Navigation("Vaccines");
                });

            modelBuilder.Entity("DAL.Dtos.DtoCity", b =>
                {
                    b.Navigation("Districts");
                });

            modelBuilder.Entity("DAL.Dtos.DtoDistrict", b =>
                {
                    b.Navigation("Wards");
                });

            modelBuilder.Entity("DAL.Dtos.DtoSupplier", b =>
                {
                    b.Navigation("VaccineBatches");
                });

            modelBuilder.Entity("DAL.Dtos.DtoUser", b =>
                {
                    b.Navigation("Information")
                        .IsRequired();

                    b.Navigation("PasswordRecoveryTokens");

                    b.Navigation("RefeshTokens");
                });

            modelBuilder.Entity("DAL.Dtos.DtoVaccine", b =>
                {
                    b.Navigation("InjectionChart")
                        .IsRequired();

                    b.Navigation("PriceVaccine")
                        .IsRequired();

                    b.Navigation("VaccineBatches");
                });

            modelBuilder.Entity("DAL.Dtos.DtoVaccineBatch", b =>
                {
                    b.Navigation("PriceVaccine")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
