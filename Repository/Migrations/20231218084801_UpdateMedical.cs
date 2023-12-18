using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Repository.Migrations
{
    /// <inheritdoc />
    public partial class UpdateMedical : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "VaccineBatch",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 18, 15, 48, 1, 456, DateTimeKind.Local).AddTicks(3290),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 18, 14, 30, 9, 655, DateTimeKind.Local).AddTicks(7394));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ManufacturingDate",
                table: "VaccineBatch",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 18, 15, 48, 1, 455, DateTimeKind.Local).AddTicks(7871),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 18, 14, 30, 9, 655, DateTimeKind.Local).AddTicks(1536));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ExpirationDate",
                table: "VaccineBatch",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 18, 15, 48, 1, 455, DateTimeKind.Local).AddTicks(8254),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 18, 14, 30, 9, 655, DateTimeKind.Local).AddTicks(1944));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "VaccineBatch",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 18, 15, 48, 1, 455, DateTimeKind.Local).AddTicks(6633),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 18, 14, 30, 9, 655, DateTimeKind.Local).AddTicks(157));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "Vaccine",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 18, 15, 48, 1, 455, DateTimeKind.Local).AddTicks(4965),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 18, 14, 30, 9, 654, DateTimeKind.Local).AddTicks(8435));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Vaccine",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 18, 15, 48, 1, 454, DateTimeKind.Local).AddTicks(9409),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 18, 14, 30, 9, 654, DateTimeKind.Local).AddTicks(2804));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "VaccinationRegistration",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 18, 15, 48, 1, 459, DateTimeKind.Local).AddTicks(6804),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 18, 14, 30, 9, 659, DateTimeKind.Local).AddTicks(4054));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "VaccinationRegistration",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 18, 15, 48, 1, 458, DateTimeKind.Local).AddTicks(3422),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 18, 14, 30, 9, 657, DateTimeKind.Local).AddTicks(9851));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "VaccinationCenter",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 18, 15, 48, 1, 454, DateTimeKind.Local).AddTicks(7886),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 18, 14, 30, 9, 654, DateTimeKind.Local).AddTicks(1213));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "VaccinationCenter",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 18, 15, 48, 1, 454, DateTimeKind.Local).AddTicks(5522),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 18, 14, 30, 9, 653, DateTimeKind.Local).AddTicks(8516));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "User",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 18, 15, 48, 1, 450, DateTimeKind.Local).AddTicks(7679),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 18, 14, 30, 9, 649, DateTimeKind.Local).AddTicks(7564));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "User",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 18, 15, 48, 1, 450, DateTimeKind.Local).AddTicks(4439),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 18, 14, 30, 9, 649, DateTimeKind.Local).AddTicks(4603));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "Supplier",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 18, 15, 48, 1, 454, DateTimeKind.Local).AddTicks(4092),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 18, 14, 30, 9, 653, DateTimeKind.Local).AddTicks(7022));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Supplier",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 18, 15, 48, 1, 454, DateTimeKind.Local).AddTicks(2288),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 18, 14, 30, 9, 653, DateTimeKind.Local).AddTicks(5058));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "RefeshToken",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 18, 15, 48, 1, 450, DateTimeKind.Local).AddTicks(2860),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 18, 14, 30, 9, 649, DateTimeKind.Local).AddTicks(3083));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "RefeshToken",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 18, 15, 48, 1, 450, DateTimeKind.Local).AddTicks(804),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 18, 14, 30, 9, 649, DateTimeKind.Local).AddTicks(943));

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "RefeshToken",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "48fd1f11_f",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldDefaultValue: "66ccc48f_4");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "RecoveryToken",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 18, 15, 48, 1, 451, DateTimeKind.Local).AddTicks(3084),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 18, 14, 30, 9, 650, DateTimeKind.Local).AddTicks(3265));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "RecoveryToken",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 18, 15, 48, 1, 451, DateTimeKind.Local).AddTicks(1330),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 18, 14, 30, 9, 650, DateTimeKind.Local).AddTicks(1255));

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "RecoveryToken",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "d712a2b2_4",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldDefaultValue: "dcb0ebe2_9");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "PriceVaccine",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 18, 15, 48, 1, 454, DateTimeKind.Local).AddTicks(953),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 18, 14, 30, 9, 653, DateTimeKind.Local).AddTicks(3611));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "PriceVaccine",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 18, 15, 48, 1, 453, DateTimeKind.Local).AddTicks(9884),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 18, 14, 30, 9, 653, DateTimeKind.Local).AddTicks(2401));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "MedicalRecord",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 18, 15, 48, 1, 457, DateTimeKind.Local).AddTicks(3714),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 18, 14, 30, 9, 656, DateTimeKind.Local).AddTicks(8933));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "MedicalRecord",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 18, 15, 48, 1, 457, DateTimeKind.Local).AddTicks(2448),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 18, 14, 30, 9, 656, DateTimeKind.Local).AddTicks(7552));

            migrationBuilder.AddColumn<string>(
                name: "CodeMedicalRecord",
                table: "MedicalRecord",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "InjectionChart",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 18, 15, 48, 1, 453, DateTimeKind.Local).AddTicks(8423),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 18, 14, 30, 9, 653, DateTimeKind.Local).AddTicks(782));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "InjectionChart",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 18, 15, 48, 1, 453, DateTimeKind.Local).AddTicks(7049),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 18, 14, 30, 9, 652, DateTimeKind.Local).AddTicks(9238));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOfBirth",
                table: "Employee",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 18, 15, 48, 1, 451, DateTimeKind.Local).AddTicks(6206),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 18, 14, 30, 9, 650, DateTimeKind.Local).AddTicks(8001));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Employee",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 18, 15, 48, 1, 451, DateTimeKind.Local).AddTicks(4862),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 18, 14, 30, 9, 650, DateTimeKind.Local).AddTicks(5858));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "DetailVaccinationRegistration",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 18, 15, 48, 1, 458, DateTimeKind.Local).AddTicks(1731),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 18, 14, 30, 9, 657, DateTimeKind.Local).AddTicks(8025));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateVaccination",
                table: "DetailVaccinationRegistration",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 18, 15, 48, 1, 457, DateTimeKind.Local).AddTicks(8014),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 18, 14, 30, 9, 657, DateTimeKind.Local).AddTicks(4108));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "DetailVaccinationRegistration",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 18, 15, 48, 1, 457, DateTimeKind.Local).AddTicks(7205),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 18, 14, 30, 9, 657, DateTimeKind.Local).AddTicks(3152));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "DetailMedicalRecord",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 18, 15, 48, 1, 457, DateTimeKind.Local).AddTicks(714),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 18, 14, 30, 9, 656, DateTimeKind.Local).AddTicks(5513));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "DetailMedicalRecord",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 18, 15, 48, 1, 456, DateTimeKind.Local).AddTicks(5086),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 18, 14, 30, 9, 655, DateTimeKind.Local).AddTicks(9272));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "Customer",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 18, 15, 48, 1, 452, DateTimeKind.Local).AddTicks(9232),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 18, 14, 30, 9, 652, DateTimeKind.Local).AddTicks(1514));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOfBirth",
                table: "Customer",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 18, 15, 48, 1, 452, DateTimeKind.Local).AddTicks(7188),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 18, 14, 30, 9, 651, DateTimeKind.Local).AddTicks(9264));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Customer",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 18, 15, 48, 1, 452, DateTimeKind.Local).AddTicks(6206),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 18, 14, 30, 9, 651, DateTimeKind.Local).AddTicks(8149));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "CategoryVaccine",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 18, 15, 48, 1, 453, DateTimeKind.Local).AddTicks(5516),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 18, 14, 30, 9, 652, DateTimeKind.Local).AddTicks(7634));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "CategoryVaccine",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 18, 15, 48, 1, 453, DateTimeKind.Local).AddTicks(3970),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 18, 14, 30, 9, 652, DateTimeKind.Local).AddTicks(5906));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "CategoryPosition",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 18, 15, 48, 1, 453, DateTimeKind.Local).AddTicks(2374),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 18, 14, 30, 9, 652, DateTimeKind.Local).AddTicks(4186));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "CategoryPosition",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 18, 15, 48, 1, 453, DateTimeKind.Local).AddTicks(1162),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 18, 14, 30, 9, 652, DateTimeKind.Local).AddTicks(3001));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CodeMedicalRecord",
                table: "MedicalRecord");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "VaccineBatch",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 18, 14, 30, 9, 655, DateTimeKind.Local).AddTicks(7394),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 18, 15, 48, 1, 456, DateTimeKind.Local).AddTicks(3290));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ManufacturingDate",
                table: "VaccineBatch",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 18, 14, 30, 9, 655, DateTimeKind.Local).AddTicks(1536),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 18, 15, 48, 1, 455, DateTimeKind.Local).AddTicks(7871));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ExpirationDate",
                table: "VaccineBatch",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 18, 14, 30, 9, 655, DateTimeKind.Local).AddTicks(1944),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 18, 15, 48, 1, 455, DateTimeKind.Local).AddTicks(8254));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "VaccineBatch",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 18, 14, 30, 9, 655, DateTimeKind.Local).AddTicks(157),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 18, 15, 48, 1, 455, DateTimeKind.Local).AddTicks(6633));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "Vaccine",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 18, 14, 30, 9, 654, DateTimeKind.Local).AddTicks(8435),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 18, 15, 48, 1, 455, DateTimeKind.Local).AddTicks(4965));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Vaccine",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 18, 14, 30, 9, 654, DateTimeKind.Local).AddTicks(2804),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 18, 15, 48, 1, 454, DateTimeKind.Local).AddTicks(9409));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "VaccinationRegistration",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 18, 14, 30, 9, 659, DateTimeKind.Local).AddTicks(4054),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 18, 15, 48, 1, 459, DateTimeKind.Local).AddTicks(6804));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "VaccinationRegistration",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 18, 14, 30, 9, 657, DateTimeKind.Local).AddTicks(9851),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 18, 15, 48, 1, 458, DateTimeKind.Local).AddTicks(3422));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "VaccinationCenter",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 18, 14, 30, 9, 654, DateTimeKind.Local).AddTicks(1213),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 18, 15, 48, 1, 454, DateTimeKind.Local).AddTicks(7886));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "VaccinationCenter",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 18, 14, 30, 9, 653, DateTimeKind.Local).AddTicks(8516),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 18, 15, 48, 1, 454, DateTimeKind.Local).AddTicks(5522));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "User",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 18, 14, 30, 9, 649, DateTimeKind.Local).AddTicks(7564),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 18, 15, 48, 1, 450, DateTimeKind.Local).AddTicks(7679));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "User",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 18, 14, 30, 9, 649, DateTimeKind.Local).AddTicks(4603),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 18, 15, 48, 1, 450, DateTimeKind.Local).AddTicks(4439));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "Supplier",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 18, 14, 30, 9, 653, DateTimeKind.Local).AddTicks(7022),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 18, 15, 48, 1, 454, DateTimeKind.Local).AddTicks(4092));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Supplier",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 18, 14, 30, 9, 653, DateTimeKind.Local).AddTicks(5058),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 18, 15, 48, 1, 454, DateTimeKind.Local).AddTicks(2288));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "RefeshToken",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 18, 14, 30, 9, 649, DateTimeKind.Local).AddTicks(3083),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 18, 15, 48, 1, 450, DateTimeKind.Local).AddTicks(2860));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "RefeshToken",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 18, 14, 30, 9, 649, DateTimeKind.Local).AddTicks(943),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 18, 15, 48, 1, 450, DateTimeKind.Local).AddTicks(804));

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "RefeshToken",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "66ccc48f_4",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldDefaultValue: "48fd1f11_f");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "RecoveryToken",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 18, 14, 30, 9, 650, DateTimeKind.Local).AddTicks(3265),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 18, 15, 48, 1, 451, DateTimeKind.Local).AddTicks(3084));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "RecoveryToken",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 18, 14, 30, 9, 650, DateTimeKind.Local).AddTicks(1255),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 18, 15, 48, 1, 451, DateTimeKind.Local).AddTicks(1330));

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "RecoveryToken",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "dcb0ebe2_9",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldDefaultValue: "d712a2b2_4");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "PriceVaccine",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 18, 14, 30, 9, 653, DateTimeKind.Local).AddTicks(3611),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 18, 15, 48, 1, 454, DateTimeKind.Local).AddTicks(953));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "PriceVaccine",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 18, 14, 30, 9, 653, DateTimeKind.Local).AddTicks(2401),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 18, 15, 48, 1, 453, DateTimeKind.Local).AddTicks(9884));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "MedicalRecord",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 18, 14, 30, 9, 656, DateTimeKind.Local).AddTicks(8933),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 18, 15, 48, 1, 457, DateTimeKind.Local).AddTicks(3714));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "MedicalRecord",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 18, 14, 30, 9, 656, DateTimeKind.Local).AddTicks(7552),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 18, 15, 48, 1, 457, DateTimeKind.Local).AddTicks(2448));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "InjectionChart",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 18, 14, 30, 9, 653, DateTimeKind.Local).AddTicks(782),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 18, 15, 48, 1, 453, DateTimeKind.Local).AddTicks(8423));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "InjectionChart",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 18, 14, 30, 9, 652, DateTimeKind.Local).AddTicks(9238),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 18, 15, 48, 1, 453, DateTimeKind.Local).AddTicks(7049));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOfBirth",
                table: "Employee",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 18, 14, 30, 9, 650, DateTimeKind.Local).AddTicks(8001),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 18, 15, 48, 1, 451, DateTimeKind.Local).AddTicks(6206));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Employee",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 18, 14, 30, 9, 650, DateTimeKind.Local).AddTicks(5858),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 18, 15, 48, 1, 451, DateTimeKind.Local).AddTicks(4862));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "DetailVaccinationRegistration",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 18, 14, 30, 9, 657, DateTimeKind.Local).AddTicks(8025),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 18, 15, 48, 1, 458, DateTimeKind.Local).AddTicks(1731));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateVaccination",
                table: "DetailVaccinationRegistration",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 18, 14, 30, 9, 657, DateTimeKind.Local).AddTicks(4108),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 18, 15, 48, 1, 457, DateTimeKind.Local).AddTicks(8014));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "DetailVaccinationRegistration",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 18, 14, 30, 9, 657, DateTimeKind.Local).AddTicks(3152),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 18, 15, 48, 1, 457, DateTimeKind.Local).AddTicks(7205));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "DetailMedicalRecord",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 18, 14, 30, 9, 656, DateTimeKind.Local).AddTicks(5513),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 18, 15, 48, 1, 457, DateTimeKind.Local).AddTicks(714));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "DetailMedicalRecord",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 18, 14, 30, 9, 655, DateTimeKind.Local).AddTicks(9272),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 18, 15, 48, 1, 456, DateTimeKind.Local).AddTicks(5086));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "Customer",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 18, 14, 30, 9, 652, DateTimeKind.Local).AddTicks(1514),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 18, 15, 48, 1, 452, DateTimeKind.Local).AddTicks(9232));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOfBirth",
                table: "Customer",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 18, 14, 30, 9, 651, DateTimeKind.Local).AddTicks(9264),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 18, 15, 48, 1, 452, DateTimeKind.Local).AddTicks(7188));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Customer",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 18, 14, 30, 9, 651, DateTimeKind.Local).AddTicks(8149),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 18, 15, 48, 1, 452, DateTimeKind.Local).AddTicks(6206));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "CategoryVaccine",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 18, 14, 30, 9, 652, DateTimeKind.Local).AddTicks(7634),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 18, 15, 48, 1, 453, DateTimeKind.Local).AddTicks(5516));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "CategoryVaccine",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 18, 14, 30, 9, 652, DateTimeKind.Local).AddTicks(5906),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 18, 15, 48, 1, 453, DateTimeKind.Local).AddTicks(3970));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "CategoryPosition",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 18, 14, 30, 9, 652, DateTimeKind.Local).AddTicks(4186),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 18, 15, 48, 1, 453, DateTimeKind.Local).AddTicks(2374));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "CategoryPosition",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 18, 14, 30, 9, 652, DateTimeKind.Local).AddTicks(3001),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 18, 15, 48, 1, 453, DateTimeKind.Local).AddTicks(1162));
        }
    }
}
