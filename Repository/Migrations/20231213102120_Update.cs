using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Repository.Migrations
{
    /// <inheritdoc />
    public partial class Update : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Ward",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 13, 17, 21, 20, 175, DateTimeKind.Local).AddTicks(828),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 12, 17, 36, 17, 160, DateTimeKind.Local).AddTicks(7762));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ManufacturingDate",
                table: "VaccineBatch",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 13, 17, 21, 20, 179, DateTimeKind.Local).AddTicks(5565),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 12, 17, 36, 17, 164, DateTimeKind.Local).AddTicks(7829));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ExpirationDate",
                table: "VaccineBatch",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 13, 17, 21, 20, 179, DateTimeKind.Local).AddTicks(5905),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 12, 17, 36, 17, 164, DateTimeKind.Local).AddTicks(8142));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "VaccineBatch",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 13, 17, 21, 20, 179, DateTimeKind.Local).AddTicks(4325),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 12, 17, 36, 17, 164, DateTimeKind.Local).AddTicks(6668));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Vaccine",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 13, 17, 21, 20, 178, DateTimeKind.Local).AddTicks(7890),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 12, 17, 36, 17, 164, DateTimeKind.Local).AddTicks(684));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "VaccinationRegistration",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 13, 17, 21, 20, 182, DateTimeKind.Local).AddTicks(7925),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 12, 17, 36, 17, 167, DateTimeKind.Local).AddTicks(6029));

            migrationBuilder.AddColumn<string>(
                name: "NameCustomer",
                table: "VaccinationRegistration",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "VaccinationCenter",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 13, 17, 21, 20, 178, DateTimeKind.Local).AddTicks(4287),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 12, 17, 36, 17, 163, DateTimeKind.Local).AddTicks(7356));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "User",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 13, 17, 21, 20, 172, DateTimeKind.Local).AddTicks(7724),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 12, 17, 36, 17, 159, DateTimeKind.Local).AddTicks(275));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Supplier",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 13, 17, 21, 20, 178, DateTimeKind.Local).AddTicks(1568),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 12, 17, 36, 17, 163, DateTimeKind.Local).AddTicks(4854));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "RefeshToken",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 13, 17, 21, 20, 172, DateTimeKind.Local).AddTicks(2692),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 12, 17, 36, 17, 158, DateTimeKind.Local).AddTicks(7583));

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "RefeshToken",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "04a8e4c2_7",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldDefaultValue: "98f39b9d_9");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "RecoveryToken",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 13, 17, 21, 20, 173, DateTimeKind.Local).AddTicks(5078),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 12, 17, 36, 17, 159, DateTimeKind.Local).AddTicks(5629));

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "RecoveryToken",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "b6295fcf_c",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldDefaultValue: "9351c51b_a");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "PriceVaccine",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 13, 17, 21, 20, 177, DateTimeKind.Local).AddTicks(9569),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 12, 17, 36, 17, 163, DateTimeKind.Local).AddTicks(2906));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "MedicalRecord",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 13, 17, 21, 20, 181, DateTimeKind.Local).AddTicks(7243),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 12, 17, 36, 17, 166, DateTimeKind.Local).AddTicks(6029));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "InjectionChart",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 13, 17, 21, 20, 177, DateTimeKind.Local).AddTicks(7093),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 12, 17, 36, 17, 163, DateTimeKind.Local).AddTicks(654));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Dob",
                table: "Information",
                type: "datetime2",
                maxLength: 15,
                nullable: false,
                defaultValue: new DateTime(2023, 12, 13, 17, 21, 20, 173, DateTimeKind.Local).AddTicks(8950),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldMaxLength: 15,
                oldDefaultValue: new DateTime(2023, 12, 12, 17, 36, 17, 159, DateTimeKind.Local).AddTicks(9048));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Information",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 13, 17, 21, 20, 173, DateTimeKind.Local).AddTicks(8183),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 12, 17, 36, 17, 159, DateTimeKind.Local).AddTicks(8326));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOfBirth",
                table: "Employee",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 13, 17, 21, 20, 175, DateTimeKind.Local).AddTicks(6638),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 12, 17, 36, 17, 161, DateTimeKind.Local).AddTicks(3048));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Employee",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 13, 17, 21, 20, 175, DateTimeKind.Local).AddTicks(5272),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 12, 17, 36, 17, 161, DateTimeKind.Local).AddTicks(1807));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "District",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 13, 17, 21, 20, 174, DateTimeKind.Local).AddTicks(5224),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 12, 17, 36, 17, 160, DateTimeKind.Local).AddTicks(3331));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateVaccination",
                table: "DetailVaccinationRegistration",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 13, 17, 21, 20, 182, DateTimeKind.Local).AddTicks(434),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 12, 17, 36, 17, 166, DateTimeKind.Local).AddTicks(8889));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "DetailVaccinationRegistration",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 13, 17, 21, 20, 181, DateTimeKind.Local).AddTicks(9513),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 12, 17, 36, 17, 166, DateTimeKind.Local).AddTicks(8055));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "DetailMedicalRecord",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 13, 17, 21, 20, 180, DateTimeKind.Local).AddTicks(5015),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 12, 17, 36, 17, 165, DateTimeKind.Local).AddTicks(6439));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOfBirth",
                table: "Customer",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 13, 17, 21, 20, 176, DateTimeKind.Local).AddTicks(9024),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 12, 17, 36, 17, 162, DateTimeKind.Local).AddTicks(3629));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Customer",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 13, 17, 21, 20, 176, DateTimeKind.Local).AddTicks(7947),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 12, 17, 36, 17, 162, DateTimeKind.Local).AddTicks(2777));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "City",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 13, 17, 21, 20, 174, DateTimeKind.Local).AddTicks(683),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 12, 17, 36, 17, 160, DateTimeKind.Local).AddTicks(605));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "CategoryVaccine",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 13, 17, 21, 20, 177, DateTimeKind.Local).AddTicks(4463),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 12, 17, 36, 17, 162, DateTimeKind.Local).AddTicks(8213));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "CategoryPosition",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 13, 17, 21, 20, 177, DateTimeKind.Local).AddTicks(2296),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 12, 17, 36, 17, 162, DateTimeKind.Local).AddTicks(6313));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NameCustomer",
                table: "VaccinationRegistration");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Ward",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 12, 17, 36, 17, 160, DateTimeKind.Local).AddTicks(7762),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 13, 17, 21, 20, 175, DateTimeKind.Local).AddTicks(828));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ManufacturingDate",
                table: "VaccineBatch",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 12, 17, 36, 17, 164, DateTimeKind.Local).AddTicks(7829),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 13, 17, 21, 20, 179, DateTimeKind.Local).AddTicks(5565));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ExpirationDate",
                table: "VaccineBatch",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 12, 17, 36, 17, 164, DateTimeKind.Local).AddTicks(8142),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 13, 17, 21, 20, 179, DateTimeKind.Local).AddTicks(5905));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "VaccineBatch",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 12, 17, 36, 17, 164, DateTimeKind.Local).AddTicks(6668),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 13, 17, 21, 20, 179, DateTimeKind.Local).AddTicks(4325));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Vaccine",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 12, 17, 36, 17, 164, DateTimeKind.Local).AddTicks(684),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 13, 17, 21, 20, 178, DateTimeKind.Local).AddTicks(7890));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "VaccinationRegistration",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 12, 17, 36, 17, 167, DateTimeKind.Local).AddTicks(6029),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 13, 17, 21, 20, 182, DateTimeKind.Local).AddTicks(7925));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "VaccinationCenter",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 12, 17, 36, 17, 163, DateTimeKind.Local).AddTicks(7356),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 13, 17, 21, 20, 178, DateTimeKind.Local).AddTicks(4287));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "User",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 12, 17, 36, 17, 159, DateTimeKind.Local).AddTicks(275),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 13, 17, 21, 20, 172, DateTimeKind.Local).AddTicks(7724));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Supplier",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 12, 17, 36, 17, 163, DateTimeKind.Local).AddTicks(4854),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 13, 17, 21, 20, 178, DateTimeKind.Local).AddTicks(1568));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "RefeshToken",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 12, 17, 36, 17, 158, DateTimeKind.Local).AddTicks(7583),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 13, 17, 21, 20, 172, DateTimeKind.Local).AddTicks(2692));

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "RefeshToken",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "98f39b9d_9",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldDefaultValue: "04a8e4c2_7");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "RecoveryToken",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 12, 17, 36, 17, 159, DateTimeKind.Local).AddTicks(5629),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 13, 17, 21, 20, 173, DateTimeKind.Local).AddTicks(5078));

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "RecoveryToken",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "9351c51b_a",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldDefaultValue: "b6295fcf_c");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "PriceVaccine",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 12, 17, 36, 17, 163, DateTimeKind.Local).AddTicks(2906),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 13, 17, 21, 20, 177, DateTimeKind.Local).AddTicks(9569));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "MedicalRecord",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 12, 17, 36, 17, 166, DateTimeKind.Local).AddTicks(6029),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 13, 17, 21, 20, 181, DateTimeKind.Local).AddTicks(7243));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "InjectionChart",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 12, 17, 36, 17, 163, DateTimeKind.Local).AddTicks(654),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 13, 17, 21, 20, 177, DateTimeKind.Local).AddTicks(7093));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Dob",
                table: "Information",
                type: "datetime2",
                maxLength: 15,
                nullable: false,
                defaultValue: new DateTime(2023, 12, 12, 17, 36, 17, 159, DateTimeKind.Local).AddTicks(9048),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldMaxLength: 15,
                oldDefaultValue: new DateTime(2023, 12, 13, 17, 21, 20, 173, DateTimeKind.Local).AddTicks(8950));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Information",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 12, 17, 36, 17, 159, DateTimeKind.Local).AddTicks(8326),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 13, 17, 21, 20, 173, DateTimeKind.Local).AddTicks(8183));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOfBirth",
                table: "Employee",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 12, 17, 36, 17, 161, DateTimeKind.Local).AddTicks(3048),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 13, 17, 21, 20, 175, DateTimeKind.Local).AddTicks(6638));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Employee",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 12, 17, 36, 17, 161, DateTimeKind.Local).AddTicks(1807),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 13, 17, 21, 20, 175, DateTimeKind.Local).AddTicks(5272));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "District",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 12, 17, 36, 17, 160, DateTimeKind.Local).AddTicks(3331),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 13, 17, 21, 20, 174, DateTimeKind.Local).AddTicks(5224));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateVaccination",
                table: "DetailVaccinationRegistration",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 12, 17, 36, 17, 166, DateTimeKind.Local).AddTicks(8889),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 13, 17, 21, 20, 182, DateTimeKind.Local).AddTicks(434));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "DetailVaccinationRegistration",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 12, 17, 36, 17, 166, DateTimeKind.Local).AddTicks(8055),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 13, 17, 21, 20, 181, DateTimeKind.Local).AddTicks(9513));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "DetailMedicalRecord",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 12, 17, 36, 17, 165, DateTimeKind.Local).AddTicks(6439),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 13, 17, 21, 20, 180, DateTimeKind.Local).AddTicks(5015));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOfBirth",
                table: "Customer",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 12, 17, 36, 17, 162, DateTimeKind.Local).AddTicks(3629),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 13, 17, 21, 20, 176, DateTimeKind.Local).AddTicks(9024));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Customer",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 12, 17, 36, 17, 162, DateTimeKind.Local).AddTicks(2777),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 13, 17, 21, 20, 176, DateTimeKind.Local).AddTicks(7947));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "City",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 12, 17, 36, 17, 160, DateTimeKind.Local).AddTicks(605),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 13, 17, 21, 20, 174, DateTimeKind.Local).AddTicks(683));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "CategoryVaccine",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 12, 17, 36, 17, 162, DateTimeKind.Local).AddTicks(8213),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 13, 17, 21, 20, 177, DateTimeKind.Local).AddTicks(4463));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "CategoryPosition",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 12, 17, 36, 17, 162, DateTimeKind.Local).AddTicks(6313),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 13, 17, 21, 20, 177, DateTimeKind.Local).AddTicks(2296));
        }
    }
}
