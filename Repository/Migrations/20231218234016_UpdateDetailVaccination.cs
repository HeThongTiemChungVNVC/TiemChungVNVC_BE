using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Repository.Migrations
{
    /// <inheritdoc />
    public partial class UpdateDetailVaccination : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "VaccineBatch",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 19, 6, 40, 16, 824, DateTimeKind.Local).AddTicks(4947),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 18, 15, 48, 1, 456, DateTimeKind.Local).AddTicks(3290));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ManufacturingDate",
                table: "VaccineBatch",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 19, 6, 40, 16, 824, DateTimeKind.Local).AddTicks(321),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 18, 15, 48, 1, 455, DateTimeKind.Local).AddTicks(7871));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ExpirationDate",
                table: "VaccineBatch",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 19, 6, 40, 16, 824, DateTimeKind.Local).AddTicks(571),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 18, 15, 48, 1, 455, DateTimeKind.Local).AddTicks(8254));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "VaccineBatch",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 19, 6, 40, 16, 823, DateTimeKind.Local).AddTicks(9304),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 18, 15, 48, 1, 455, DateTimeKind.Local).AddTicks(6633));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "Vaccine",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 19, 6, 40, 16, 823, DateTimeKind.Local).AddTicks(7951),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 18, 15, 48, 1, 455, DateTimeKind.Local).AddTicks(4965));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Vaccine",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 19, 6, 40, 16, 823, DateTimeKind.Local).AddTicks(3377),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 18, 15, 48, 1, 454, DateTimeKind.Local).AddTicks(9409));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "VaccinationRegistration",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 19, 6, 40, 16, 827, DateTimeKind.Local).AddTicks(2049),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 18, 15, 48, 1, 459, DateTimeKind.Local).AddTicks(6804));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "VaccinationRegistration",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 19, 6, 40, 16, 826, DateTimeKind.Local).AddTicks(1669),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 18, 15, 48, 1, 458, DateTimeKind.Local).AddTicks(3422));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "VaccinationCenter",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 19, 6, 40, 16, 823, DateTimeKind.Local).AddTicks(2137),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 18, 15, 48, 1, 454, DateTimeKind.Local).AddTicks(7886));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "VaccinationCenter",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 19, 6, 40, 16, 823, DateTimeKind.Local).AddTicks(55),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 18, 15, 48, 1, 454, DateTimeKind.Local).AddTicks(5522));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "User",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 19, 6, 40, 16, 819, DateTimeKind.Local).AddTicks(8306),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 18, 15, 48, 1, 450, DateTimeKind.Local).AddTicks(7679));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "User",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 19, 6, 40, 16, 819, DateTimeKind.Local).AddTicks(5916),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 18, 15, 48, 1, 450, DateTimeKind.Local).AddTicks(4439));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "Supplier",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 19, 6, 40, 16, 822, DateTimeKind.Local).AddTicks(8910),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 18, 15, 48, 1, 454, DateTimeKind.Local).AddTicks(4092));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Supplier",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 19, 6, 40, 16, 822, DateTimeKind.Local).AddTicks(7440),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 18, 15, 48, 1, 454, DateTimeKind.Local).AddTicks(2288));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "RefeshToken",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 19, 6, 40, 16, 819, DateTimeKind.Local).AddTicks(4005),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 18, 15, 48, 1, 450, DateTimeKind.Local).AddTicks(2860));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "RefeshToken",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 19, 6, 40, 16, 819, DateTimeKind.Local).AddTicks(1495),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 18, 15, 48, 1, 450, DateTimeKind.Local).AddTicks(804));

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "RefeshToken",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "7f484e09_5",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldDefaultValue: "48fd1f11_f");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "RecoveryToken",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 19, 6, 40, 16, 820, DateTimeKind.Local).AddTicks(3114),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 18, 15, 48, 1, 451, DateTimeKind.Local).AddTicks(3084));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "RecoveryToken",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 19, 6, 40, 16, 820, DateTimeKind.Local).AddTicks(1655),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 18, 15, 48, 1, 451, DateTimeKind.Local).AddTicks(1330));

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "RecoveryToken",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "d21063fd_1",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldDefaultValue: "d712a2b2_4");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "PriceVaccine",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 19, 6, 40, 16, 822, DateTimeKind.Local).AddTicks(6377),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 18, 15, 48, 1, 454, DateTimeKind.Local).AddTicks(953));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "PriceVaccine",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 19, 6, 40, 16, 822, DateTimeKind.Local).AddTicks(5522),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 18, 15, 48, 1, 453, DateTimeKind.Local).AddTicks(9884));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "MedicalRecord",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 19, 6, 40, 16, 825, DateTimeKind.Local).AddTicks(3535),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 18, 15, 48, 1, 457, DateTimeKind.Local).AddTicks(3714));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "MedicalRecord",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 19, 6, 40, 16, 825, DateTimeKind.Local).AddTicks(2541),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 18, 15, 48, 1, 457, DateTimeKind.Local).AddTicks(2448));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "InjectionChart",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 19, 6, 40, 16, 822, DateTimeKind.Local).AddTicks(4363),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 18, 15, 48, 1, 453, DateTimeKind.Local).AddTicks(8423));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "InjectionChart",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 19, 6, 40, 16, 822, DateTimeKind.Local).AddTicks(3332),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 18, 15, 48, 1, 453, DateTimeKind.Local).AddTicks(7049));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOfBirth",
                table: "Employee",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 19, 6, 40, 16, 820, DateTimeKind.Local).AddTicks(5851),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 18, 15, 48, 1, 451, DateTimeKind.Local).AddTicks(6206));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Employee",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 19, 6, 40, 16, 820, DateTimeKind.Local).AddTicks(4634),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 18, 15, 48, 1, 451, DateTimeKind.Local).AddTicks(4862));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "DetailVaccinationRegistration",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 19, 6, 40, 16, 826, DateTimeKind.Local).AddTicks(206),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 18, 15, 48, 1, 458, DateTimeKind.Local).AddTicks(1731));

            migrationBuilder.AlterColumn<int>(
                name: "Status",
                table: "DetailVaccinationRegistration",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: false);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateVaccination",
                table: "DetailVaccinationRegistration",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 19, 6, 40, 16, 825, DateTimeKind.Local).AddTicks(7128),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 18, 15, 48, 1, 457, DateTimeKind.Local).AddTicks(8014));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "DetailVaccinationRegistration",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 19, 6, 40, 16, 825, DateTimeKind.Local).AddTicks(6526),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 18, 15, 48, 1, 457, DateTimeKind.Local).AddTicks(7205));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "DetailMedicalRecord",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 19, 6, 40, 16, 825, DateTimeKind.Local).AddTicks(1126),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 18, 15, 48, 1, 457, DateTimeKind.Local).AddTicks(714));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "DetailMedicalRecord",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 19, 6, 40, 16, 824, DateTimeKind.Local).AddTicks(6421),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 18, 15, 48, 1, 456, DateTimeKind.Local).AddTicks(5086));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "Customer",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 19, 6, 40, 16, 821, DateTimeKind.Local).AddTicks(7245),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 18, 15, 48, 1, 452, DateTimeKind.Local).AddTicks(9232));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOfBirth",
                table: "Customer",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 19, 6, 40, 16, 821, DateTimeKind.Local).AddTicks(5455),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 18, 15, 48, 1, 452, DateTimeKind.Local).AddTicks(7188));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Customer",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 19, 6, 40, 16, 821, DateTimeKind.Local).AddTicks(4652),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 18, 15, 48, 1, 452, DateTimeKind.Local).AddTicks(6206));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "CategoryVaccine",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 19, 6, 40, 16, 822, DateTimeKind.Local).AddTicks(1956),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 18, 15, 48, 1, 453, DateTimeKind.Local).AddTicks(5516));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "CategoryVaccine",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 19, 6, 40, 16, 822, DateTimeKind.Local).AddTicks(683),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 18, 15, 48, 1, 453, DateTimeKind.Local).AddTicks(3970));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "CategoryPosition",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 19, 6, 40, 16, 821, DateTimeKind.Local).AddTicks(9256),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 18, 15, 48, 1, 453, DateTimeKind.Local).AddTicks(2374));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "CategoryPosition",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 19, 6, 40, 16, 821, DateTimeKind.Local).AddTicks(8427),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 18, 15, 48, 1, 453, DateTimeKind.Local).AddTicks(1162));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "VaccineBatch",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 18, 15, 48, 1, 456, DateTimeKind.Local).AddTicks(3290),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 19, 6, 40, 16, 824, DateTimeKind.Local).AddTicks(4947));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ManufacturingDate",
                table: "VaccineBatch",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 18, 15, 48, 1, 455, DateTimeKind.Local).AddTicks(7871),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 19, 6, 40, 16, 824, DateTimeKind.Local).AddTicks(321));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ExpirationDate",
                table: "VaccineBatch",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 18, 15, 48, 1, 455, DateTimeKind.Local).AddTicks(8254),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 19, 6, 40, 16, 824, DateTimeKind.Local).AddTicks(571));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "VaccineBatch",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 18, 15, 48, 1, 455, DateTimeKind.Local).AddTicks(6633),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 19, 6, 40, 16, 823, DateTimeKind.Local).AddTicks(9304));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "Vaccine",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 18, 15, 48, 1, 455, DateTimeKind.Local).AddTicks(4965),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 19, 6, 40, 16, 823, DateTimeKind.Local).AddTicks(7951));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Vaccine",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 18, 15, 48, 1, 454, DateTimeKind.Local).AddTicks(9409),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 19, 6, 40, 16, 823, DateTimeKind.Local).AddTicks(3377));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "VaccinationRegistration",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 18, 15, 48, 1, 459, DateTimeKind.Local).AddTicks(6804),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 19, 6, 40, 16, 827, DateTimeKind.Local).AddTicks(2049));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "VaccinationRegistration",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 18, 15, 48, 1, 458, DateTimeKind.Local).AddTicks(3422),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 19, 6, 40, 16, 826, DateTimeKind.Local).AddTicks(1669));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "VaccinationCenter",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 18, 15, 48, 1, 454, DateTimeKind.Local).AddTicks(7886),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 19, 6, 40, 16, 823, DateTimeKind.Local).AddTicks(2137));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "VaccinationCenter",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 18, 15, 48, 1, 454, DateTimeKind.Local).AddTicks(5522),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 19, 6, 40, 16, 823, DateTimeKind.Local).AddTicks(55));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "User",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 18, 15, 48, 1, 450, DateTimeKind.Local).AddTicks(7679),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 19, 6, 40, 16, 819, DateTimeKind.Local).AddTicks(8306));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "User",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 18, 15, 48, 1, 450, DateTimeKind.Local).AddTicks(4439),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 19, 6, 40, 16, 819, DateTimeKind.Local).AddTicks(5916));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "Supplier",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 18, 15, 48, 1, 454, DateTimeKind.Local).AddTicks(4092),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 19, 6, 40, 16, 822, DateTimeKind.Local).AddTicks(8910));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Supplier",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 18, 15, 48, 1, 454, DateTimeKind.Local).AddTicks(2288),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 19, 6, 40, 16, 822, DateTimeKind.Local).AddTicks(7440));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "RefeshToken",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 18, 15, 48, 1, 450, DateTimeKind.Local).AddTicks(2860),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 19, 6, 40, 16, 819, DateTimeKind.Local).AddTicks(4005));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "RefeshToken",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 18, 15, 48, 1, 450, DateTimeKind.Local).AddTicks(804),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 19, 6, 40, 16, 819, DateTimeKind.Local).AddTicks(1495));

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
                oldDefaultValue: "7f484e09_5");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "RecoveryToken",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 18, 15, 48, 1, 451, DateTimeKind.Local).AddTicks(3084),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 19, 6, 40, 16, 820, DateTimeKind.Local).AddTicks(3114));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "RecoveryToken",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 18, 15, 48, 1, 451, DateTimeKind.Local).AddTicks(1330),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 19, 6, 40, 16, 820, DateTimeKind.Local).AddTicks(1655));

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
                oldDefaultValue: "d21063fd_1");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "PriceVaccine",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 18, 15, 48, 1, 454, DateTimeKind.Local).AddTicks(953),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 19, 6, 40, 16, 822, DateTimeKind.Local).AddTicks(6377));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "PriceVaccine",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 18, 15, 48, 1, 453, DateTimeKind.Local).AddTicks(9884),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 19, 6, 40, 16, 822, DateTimeKind.Local).AddTicks(5522));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "MedicalRecord",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 18, 15, 48, 1, 457, DateTimeKind.Local).AddTicks(3714),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 19, 6, 40, 16, 825, DateTimeKind.Local).AddTicks(3535));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "MedicalRecord",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 18, 15, 48, 1, 457, DateTimeKind.Local).AddTicks(2448),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 19, 6, 40, 16, 825, DateTimeKind.Local).AddTicks(2541));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "InjectionChart",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 18, 15, 48, 1, 453, DateTimeKind.Local).AddTicks(8423),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 19, 6, 40, 16, 822, DateTimeKind.Local).AddTicks(4363));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "InjectionChart",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 18, 15, 48, 1, 453, DateTimeKind.Local).AddTicks(7049),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 19, 6, 40, 16, 822, DateTimeKind.Local).AddTicks(3332));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOfBirth",
                table: "Employee",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 18, 15, 48, 1, 451, DateTimeKind.Local).AddTicks(6206),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 19, 6, 40, 16, 820, DateTimeKind.Local).AddTicks(5851));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Employee",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 18, 15, 48, 1, 451, DateTimeKind.Local).AddTicks(4862),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 19, 6, 40, 16, 820, DateTimeKind.Local).AddTicks(4634));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "DetailVaccinationRegistration",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 18, 15, 48, 1, 458, DateTimeKind.Local).AddTicks(1731),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 19, 6, 40, 16, 826, DateTimeKind.Local).AddTicks(206));

            migrationBuilder.AlterColumn<bool>(
                name: "Status",
                table: "DetailVaccinationRegistration",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldDefaultValue: 0);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateVaccination",
                table: "DetailVaccinationRegistration",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 18, 15, 48, 1, 457, DateTimeKind.Local).AddTicks(8014),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 19, 6, 40, 16, 825, DateTimeKind.Local).AddTicks(7128));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "DetailVaccinationRegistration",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 18, 15, 48, 1, 457, DateTimeKind.Local).AddTicks(7205),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 19, 6, 40, 16, 825, DateTimeKind.Local).AddTicks(6526));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "DetailMedicalRecord",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 18, 15, 48, 1, 457, DateTimeKind.Local).AddTicks(714),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 19, 6, 40, 16, 825, DateTimeKind.Local).AddTicks(1126));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "DetailMedicalRecord",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 18, 15, 48, 1, 456, DateTimeKind.Local).AddTicks(5086),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 19, 6, 40, 16, 824, DateTimeKind.Local).AddTicks(6421));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "Customer",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 18, 15, 48, 1, 452, DateTimeKind.Local).AddTicks(9232),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 19, 6, 40, 16, 821, DateTimeKind.Local).AddTicks(7245));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOfBirth",
                table: "Customer",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 18, 15, 48, 1, 452, DateTimeKind.Local).AddTicks(7188),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 19, 6, 40, 16, 821, DateTimeKind.Local).AddTicks(5455));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Customer",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 18, 15, 48, 1, 452, DateTimeKind.Local).AddTicks(6206),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 19, 6, 40, 16, 821, DateTimeKind.Local).AddTicks(4652));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "CategoryVaccine",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 18, 15, 48, 1, 453, DateTimeKind.Local).AddTicks(5516),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 19, 6, 40, 16, 822, DateTimeKind.Local).AddTicks(1956));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "CategoryVaccine",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 18, 15, 48, 1, 453, DateTimeKind.Local).AddTicks(3970),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 19, 6, 40, 16, 822, DateTimeKind.Local).AddTicks(683));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "CategoryPosition",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 18, 15, 48, 1, 453, DateTimeKind.Local).AddTicks(2374),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 19, 6, 40, 16, 821, DateTimeKind.Local).AddTicks(9256));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "CategoryPosition",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 18, 15, 48, 1, 453, DateTimeKind.Local).AddTicks(1162),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 19, 6, 40, 16, 821, DateTimeKind.Local).AddTicks(8427));
        }
    }
}
