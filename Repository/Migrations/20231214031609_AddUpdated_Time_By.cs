using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Repository.Migrations
{
    /// <inheritdoc />
    public partial class AddUpdated_Time_By : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Ward",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 10, 16, 9, 793, DateTimeKind.Local).AddTicks(7563),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 9, 56, 22, 810, DateTimeKind.Local).AddTicks(2534));

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBy",
                table: "Ward",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedTime",
                table: "Ward",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 10, 16, 9, 794, DateTimeKind.Local).AddTicks(1673));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ManufacturingDate",
                table: "VaccineBatch",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 10, 16, 9, 799, DateTimeKind.Local).AddTicks(4398),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 9, 56, 22, 814, DateTimeKind.Local).AddTicks(8974));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ExpirationDate",
                table: "VaccineBatch",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 10, 16, 9, 799, DateTimeKind.Local).AddTicks(4822),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 9, 56, 22, 814, DateTimeKind.Local).AddTicks(9991));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "VaccineBatch",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 10, 16, 9, 799, DateTimeKind.Local).AddTicks(2761),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 9, 56, 22, 814, DateTimeKind.Local).AddTicks(7043));

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBy",
                table: "VaccineBatch",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedTime",
                table: "VaccineBatch",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 10, 16, 9, 800, DateTimeKind.Local).AddTicks(4348));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Vaccine",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 10, 16, 9, 798, DateTimeKind.Local).AddTicks(3680),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 9, 56, 22, 814, DateTimeKind.Local).AddTicks(192));

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBy",
                table: "Vaccine",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedTime",
                table: "Vaccine",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 10, 16, 9, 799, DateTimeKind.Local).AddTicks(711));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "VaccinationRegistration",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 10, 16, 9, 803, DateTimeKind.Local).AddTicks(3013),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 9, 56, 22, 818, DateTimeKind.Local).AddTicks(3456));

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBy",
                table: "VaccinationRegistration",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedTime",
                table: "VaccinationRegistration",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 10, 16, 9, 804, DateTimeKind.Local).AddTicks(1326));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "VaccinationCenter",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 10, 16, 9, 797, DateTimeKind.Local).AddTicks(8490),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 9, 56, 22, 813, DateTimeKind.Local).AddTicks(5276));

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBy",
                table: "VaccinationCenter",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedTime",
                table: "VaccinationCenter",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 10, 16, 9, 798, DateTimeKind.Local).AddTicks(1690));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "User",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 10, 16, 9, 791, DateTimeKind.Local).AddTicks(64),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 9, 56, 22, 808, DateTimeKind.Local).AddTicks(2162));

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBy",
                table: "User",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedTime",
                table: "User",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 10, 16, 9, 791, DateTimeKind.Local).AddTicks(3472));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Supplier",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 10, 16, 9, 797, DateTimeKind.Local).AddTicks(4258),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 9, 56, 22, 813, DateTimeKind.Local).AddTicks(2383));

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBy",
                table: "Supplier",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedTime",
                table: "Supplier",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 10, 16, 9, 797, DateTimeKind.Local).AddTicks(6995));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "RefeshToken",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 10, 16, 9, 790, DateTimeKind.Local).AddTicks(5834),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 9, 56, 22, 807, DateTimeKind.Local).AddTicks(9019));

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "RefeshToken",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "8030f62a_1",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldDefaultValue: "5514e373_9");

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBy",
                table: "RefeshToken",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedTime",
                table: "RefeshToken",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 10, 16, 9, 790, DateTimeKind.Local).AddTicks(8262));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "RecoveryToken",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 10, 16, 9, 791, DateTimeKind.Local).AddTicks(7519),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 9, 56, 22, 808, DateTimeKind.Local).AddTicks(8095));

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "RecoveryToken",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "253097fd_1",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldDefaultValue: "c9dae8b3_9");

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBy",
                table: "RecoveryToken",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedTime",
                table: "RecoveryToken",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 10, 16, 9, 792, DateTimeKind.Local).AddTicks(481));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "PriceVaccine",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 10, 16, 9, 797, DateTimeKind.Local).AddTicks(931),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 9, 56, 22, 813, DateTimeKind.Local).AddTicks(115));

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBy",
                table: "PriceVaccine",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedTime",
                table: "PriceVaccine",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 10, 16, 9, 797, DateTimeKind.Local).AddTicks(2391));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "MedicalRecord",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 10, 16, 9, 801, DateTimeKind.Local).AddTicks(9219),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 9, 56, 22, 817, DateTimeKind.Local).AddTicks(2153));

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBy",
                table: "MedicalRecord",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedTime",
                table: "MedicalRecord",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 10, 16, 9, 802, DateTimeKind.Local).AddTicks(613));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "InjectionChart",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 10, 16, 9, 796, DateTimeKind.Local).AddTicks(7690),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 9, 56, 22, 812, DateTimeKind.Local).AddTicks(7502));

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBy",
                table: "InjectionChart",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedTime",
                table: "InjectionChart",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 10, 16, 9, 796, DateTimeKind.Local).AddTicks(9293));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Dob",
                table: "Information",
                type: "datetime2",
                maxLength: 15,
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 10, 16, 9, 792, DateTimeKind.Local).AddTicks(3347),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldMaxLength: 15,
                oldDefaultValue: new DateTime(2023, 12, 14, 9, 56, 22, 809, DateTimeKind.Local).AddTicks(2404));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Information",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 10, 16, 9, 792, DateTimeKind.Local).AddTicks(2487),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 9, 56, 22, 809, DateTimeKind.Local).AddTicks(1605));

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBy",
                table: "Information",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedTime",
                table: "Information",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 10, 16, 9, 792, DateTimeKind.Local).AddTicks(4217));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOfBirth",
                table: "Employee",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 10, 16, 9, 794, DateTimeKind.Local).AddTicks(5368),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 9, 56, 22, 810, DateTimeKind.Local).AddTicks(8636));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Employee",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 10, 16, 9, 794, DateTimeKind.Local).AddTicks(3748),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 9, 56, 22, 810, DateTimeKind.Local).AddTicks(7166));

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBy",
                table: "Employee",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedTime",
                table: "Employee",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "District",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 10, 16, 9, 793, DateTimeKind.Local).AddTicks(1330),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 9, 56, 22, 809, DateTimeKind.Local).AddTicks(7183));

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBy",
                table: "District",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedTime",
                table: "District",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 10, 16, 9, 793, DateTimeKind.Local).AddTicks(5812));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateVaccination",
                table: "DetailVaccinationRegistration",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 10, 16, 9, 802, DateTimeKind.Local).AddTicks(3446),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 9, 56, 22, 817, DateTimeKind.Local).AddTicks(5558));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "DetailVaccinationRegistration",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 10, 16, 9, 802, DateTimeKind.Local).AddTicks(2355),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 9, 56, 22, 817, DateTimeKind.Local).AddTicks(4553));

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBy",
                table: "DetailVaccinationRegistration",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedTime",
                table: "DetailVaccinationRegistration",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 10, 16, 9, 803, DateTimeKind.Local).AddTicks(905));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "DetailMedicalRecord",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 10, 16, 9, 800, DateTimeKind.Local).AddTicks(6410),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 9, 56, 22, 816, DateTimeKind.Local).AddTicks(811));

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBy",
                table: "DetailMedicalRecord",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedTime",
                table: "DetailMedicalRecord",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 10, 16, 9, 801, DateTimeKind.Local).AddTicks(7297));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOfBirth",
                table: "Customer",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 10, 16, 9, 795, DateTimeKind.Local).AddTicks(7272),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 9, 56, 22, 811, DateTimeKind.Local).AddTicks(9005));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Customer",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 10, 16, 9, 795, DateTimeKind.Local).AddTicks(6097),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 9, 56, 22, 811, DateTimeKind.Local).AddTicks(7975));

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBy",
                table: "Customer",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedTime",
                table: "Customer",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 10, 16, 9, 795, DateTimeKind.Local).AddTicks(9633));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "City",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 10, 16, 9, 792, DateTimeKind.Local).AddTicks(6550),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 9, 56, 22, 809, DateTimeKind.Local).AddTicks(4198));

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBy",
                table: "City",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedTime",
                table: "City",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 10, 16, 9, 792, DateTimeKind.Local).AddTicks(9270));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "CategoryVaccine",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 10, 16, 9, 796, DateTimeKind.Local).AddTicks(4051),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 9, 56, 22, 812, DateTimeKind.Local).AddTicks(4691));

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBy",
                table: "CategoryVaccine",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedTime",
                table: "CategoryVaccine",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 10, 16, 9, 796, DateTimeKind.Local).AddTicks(5915));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "CategoryPosition",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 10, 16, 9, 796, DateTimeKind.Local).AddTicks(1234),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 9, 56, 22, 812, DateTimeKind.Local).AddTicks(2485));

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBy",
                table: "CategoryPosition",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedTime",
                table: "CategoryPosition",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 10, 16, 9, 796, DateTimeKind.Local).AddTicks(1933));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "Ward");

            migrationBuilder.DropColumn(
                name: "UpdatedTime",
                table: "Ward");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "VaccineBatch");

            migrationBuilder.DropColumn(
                name: "UpdatedTime",
                table: "VaccineBatch");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "Vaccine");

            migrationBuilder.DropColumn(
                name: "UpdatedTime",
                table: "Vaccine");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "VaccinationRegistration");

            migrationBuilder.DropColumn(
                name: "UpdatedTime",
                table: "VaccinationRegistration");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "VaccinationCenter");

            migrationBuilder.DropColumn(
                name: "UpdatedTime",
                table: "VaccinationCenter");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "User");

            migrationBuilder.DropColumn(
                name: "UpdatedTime",
                table: "User");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "Supplier");

            migrationBuilder.DropColumn(
                name: "UpdatedTime",
                table: "Supplier");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "RefeshToken");

            migrationBuilder.DropColumn(
                name: "UpdatedTime",
                table: "RefeshToken");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "RecoveryToken");

            migrationBuilder.DropColumn(
                name: "UpdatedTime",
                table: "RecoveryToken");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "PriceVaccine");

            migrationBuilder.DropColumn(
                name: "UpdatedTime",
                table: "PriceVaccine");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "MedicalRecord");

            migrationBuilder.DropColumn(
                name: "UpdatedTime",
                table: "MedicalRecord");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "InjectionChart");

            migrationBuilder.DropColumn(
                name: "UpdatedTime",
                table: "InjectionChart");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "Information");

            migrationBuilder.DropColumn(
                name: "UpdatedTime",
                table: "Information");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "UpdatedTime",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "District");

            migrationBuilder.DropColumn(
                name: "UpdatedTime",
                table: "District");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "DetailVaccinationRegistration");

            migrationBuilder.DropColumn(
                name: "UpdatedTime",
                table: "DetailVaccinationRegistration");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "DetailMedicalRecord");

            migrationBuilder.DropColumn(
                name: "UpdatedTime",
                table: "DetailMedicalRecord");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "UpdatedTime",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "City");

            migrationBuilder.DropColumn(
                name: "UpdatedTime",
                table: "City");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "CategoryVaccine");

            migrationBuilder.DropColumn(
                name: "UpdatedTime",
                table: "CategoryVaccine");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "CategoryPosition");

            migrationBuilder.DropColumn(
                name: "UpdatedTime",
                table: "CategoryPosition");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Ward",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 9, 56, 22, 810, DateTimeKind.Local).AddTicks(2534),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 10, 16, 9, 793, DateTimeKind.Local).AddTicks(7563));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ManufacturingDate",
                table: "VaccineBatch",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 9, 56, 22, 814, DateTimeKind.Local).AddTicks(8974),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 10, 16, 9, 799, DateTimeKind.Local).AddTicks(4398));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ExpirationDate",
                table: "VaccineBatch",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 9, 56, 22, 814, DateTimeKind.Local).AddTicks(9991),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 10, 16, 9, 799, DateTimeKind.Local).AddTicks(4822));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "VaccineBatch",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 9, 56, 22, 814, DateTimeKind.Local).AddTicks(7043),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 10, 16, 9, 799, DateTimeKind.Local).AddTicks(2761));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Vaccine",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 9, 56, 22, 814, DateTimeKind.Local).AddTicks(192),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 10, 16, 9, 798, DateTimeKind.Local).AddTicks(3680));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "VaccinationRegistration",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 9, 56, 22, 818, DateTimeKind.Local).AddTicks(3456),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 10, 16, 9, 803, DateTimeKind.Local).AddTicks(3013));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "VaccinationCenter",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 9, 56, 22, 813, DateTimeKind.Local).AddTicks(5276),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 10, 16, 9, 797, DateTimeKind.Local).AddTicks(8490));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "User",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 9, 56, 22, 808, DateTimeKind.Local).AddTicks(2162),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 10, 16, 9, 791, DateTimeKind.Local).AddTicks(64));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Supplier",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 9, 56, 22, 813, DateTimeKind.Local).AddTicks(2383),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 10, 16, 9, 797, DateTimeKind.Local).AddTicks(4258));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "RefeshToken",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 9, 56, 22, 807, DateTimeKind.Local).AddTicks(9019),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 10, 16, 9, 790, DateTimeKind.Local).AddTicks(5834));

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "RefeshToken",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "5514e373_9",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldDefaultValue: "8030f62a_1");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "RecoveryToken",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 9, 56, 22, 808, DateTimeKind.Local).AddTicks(8095),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 10, 16, 9, 791, DateTimeKind.Local).AddTicks(7519));

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "RecoveryToken",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "c9dae8b3_9",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldDefaultValue: "253097fd_1");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "PriceVaccine",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 9, 56, 22, 813, DateTimeKind.Local).AddTicks(115),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 10, 16, 9, 797, DateTimeKind.Local).AddTicks(931));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "MedicalRecord",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 9, 56, 22, 817, DateTimeKind.Local).AddTicks(2153),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 10, 16, 9, 801, DateTimeKind.Local).AddTicks(9219));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "InjectionChart",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 9, 56, 22, 812, DateTimeKind.Local).AddTicks(7502),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 10, 16, 9, 796, DateTimeKind.Local).AddTicks(7690));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Dob",
                table: "Information",
                type: "datetime2",
                maxLength: 15,
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 9, 56, 22, 809, DateTimeKind.Local).AddTicks(2404),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldMaxLength: 15,
                oldDefaultValue: new DateTime(2023, 12, 14, 10, 16, 9, 792, DateTimeKind.Local).AddTicks(3347));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Information",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 9, 56, 22, 809, DateTimeKind.Local).AddTicks(1605),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 10, 16, 9, 792, DateTimeKind.Local).AddTicks(2487));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOfBirth",
                table: "Employee",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 9, 56, 22, 810, DateTimeKind.Local).AddTicks(8636),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 10, 16, 9, 794, DateTimeKind.Local).AddTicks(5368));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Employee",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 9, 56, 22, 810, DateTimeKind.Local).AddTicks(7166),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 10, 16, 9, 794, DateTimeKind.Local).AddTicks(3748));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "District",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 9, 56, 22, 809, DateTimeKind.Local).AddTicks(7183),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 10, 16, 9, 793, DateTimeKind.Local).AddTicks(1330));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateVaccination",
                table: "DetailVaccinationRegistration",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 9, 56, 22, 817, DateTimeKind.Local).AddTicks(5558),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 10, 16, 9, 802, DateTimeKind.Local).AddTicks(3446));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "DetailVaccinationRegistration",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 9, 56, 22, 817, DateTimeKind.Local).AddTicks(4553),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 10, 16, 9, 802, DateTimeKind.Local).AddTicks(2355));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "DetailMedicalRecord",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 9, 56, 22, 816, DateTimeKind.Local).AddTicks(811),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 10, 16, 9, 800, DateTimeKind.Local).AddTicks(6410));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOfBirth",
                table: "Customer",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 9, 56, 22, 811, DateTimeKind.Local).AddTicks(9005),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 10, 16, 9, 795, DateTimeKind.Local).AddTicks(7272));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Customer",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 9, 56, 22, 811, DateTimeKind.Local).AddTicks(7975),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 10, 16, 9, 795, DateTimeKind.Local).AddTicks(6097));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "City",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 9, 56, 22, 809, DateTimeKind.Local).AddTicks(4198),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 10, 16, 9, 792, DateTimeKind.Local).AddTicks(6550));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "CategoryVaccine",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 9, 56, 22, 812, DateTimeKind.Local).AddTicks(4691),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 10, 16, 9, 796, DateTimeKind.Local).AddTicks(4051));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "CategoryPosition",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 9, 56, 22, 812, DateTimeKind.Local).AddTicks(2485),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 10, 16, 9, 796, DateTimeKind.Local).AddTicks(1234));
        }
    }
}
