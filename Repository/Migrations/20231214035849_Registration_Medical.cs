using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Repository.Migrations
{
    /// <inheritdoc />
    public partial class Registration_Medical : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_details_customer",
                table: "DetailMedicalRecord");

            migrationBuilder.DropForeignKey(
                name: "FK_detailsregis_customer",
                table: "DetailVaccinationRegistration");

            migrationBuilder.DropIndex(
                name: "IX_DetailVaccinationRegistration_IdCustomer",
                table: "DetailVaccinationRegistration");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DetailMedicalRecord",
                table: "DetailMedicalRecord");

            migrationBuilder.DropIndex(
                name: "IX_DetailMedicalRecord_IdCustomer",
                table: "DetailMedicalRecord");

            migrationBuilder.DropColumn(
                name: "IdCustomer",
                table: "DetailVaccinationRegistration");

            migrationBuilder.DropColumn(
                name: "IdCustomer",
                table: "DetailMedicalRecord");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "Ward",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 10, 58, 49, 472, DateTimeKind.Local).AddTicks(2851),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 10, 36, 22, 924, DateTimeKind.Local).AddTicks(5838));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Ward",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 10, 58, 49, 471, DateTimeKind.Local).AddTicks(9670),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 10, 36, 22, 924, DateTimeKind.Local).AddTicks(2283));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "VaccineBatch",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 10, 58, 49, 483, DateTimeKind.Local).AddTicks(6566),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 10, 36, 22, 931, DateTimeKind.Local).AddTicks(1795));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ManufacturingDate",
                table: "VaccineBatch",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 10, 58, 49, 482, DateTimeKind.Local).AddTicks(8567),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 10, 36, 22, 929, DateTimeKind.Local).AddTicks(6907));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ExpirationDate",
                table: "VaccineBatch",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 10, 58, 49, 482, DateTimeKind.Local).AddTicks(8920),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 10, 36, 22, 929, DateTimeKind.Local).AddTicks(7324));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "VaccineBatch",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 10, 58, 49, 482, DateTimeKind.Local).AddTicks(7013),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 10, 36, 22, 929, DateTimeKind.Local).AddTicks(5235));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "Vaccine",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 10, 58, 49, 482, DateTimeKind.Local).AddTicks(5335),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 10, 36, 22, 929, DateTimeKind.Local).AddTicks(3522));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Vaccine",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 10, 58, 49, 481, DateTimeKind.Local).AddTicks(9501),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 10, 36, 22, 928, DateTimeKind.Local).AddTicks(7281));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "VaccinationRegistration",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 10, 58, 49, 486, DateTimeKind.Local).AddTicks(9522),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 10, 36, 22, 934, DateTimeKind.Local).AddTicks(6107));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "VaccinationRegistration",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 10, 58, 49, 485, DateTimeKind.Local).AddTicks(9516),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 10, 36, 22, 933, DateTimeKind.Local).AddTicks(8816));

            migrationBuilder.AddColumn<string>(
                name: "IdCustomer",
                table: "VaccinationRegistration",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "VaccinationCenter",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 10, 58, 49, 481, DateTimeKind.Local).AddTicks(7885),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 10, 36, 22, 928, DateTimeKind.Local).AddTicks(5555));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "VaccinationCenter",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 10, 58, 49, 481, DateTimeKind.Local).AddTicks(4472),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 10, 36, 22, 928, DateTimeKind.Local).AddTicks(2519));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "User",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 10, 58, 49, 469, DateTimeKind.Local).AddTicks(9059),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 10, 36, 22, 916, DateTimeKind.Local).AddTicks(3334));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "User",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 10, 58, 49, 469, DateTimeKind.Local).AddTicks(5967),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 10, 36, 22, 915, DateTimeKind.Local).AddTicks(9596));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "Supplier",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 10, 58, 49, 481, DateTimeKind.Local).AddTicks(2927),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 10, 36, 22, 928, DateTimeKind.Local).AddTicks(901));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Supplier",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 10, 58, 49, 481, DateTimeKind.Local).AddTicks(952),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 10, 36, 22, 927, DateTimeKind.Local).AddTicks(8783));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "RefeshToken",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 10, 58, 49, 469, DateTimeKind.Local).AddTicks(4124),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 10, 36, 22, 915, DateTimeKind.Local).AddTicks(6163));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "RefeshToken",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 10, 58, 49, 469, DateTimeKind.Local).AddTicks(2038),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 10, 36, 22, 915, DateTimeKind.Local).AddTicks(1430));

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "RefeshToken",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "4e2da279_e",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldDefaultValue: "1baa9167_f");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "RecoveryToken",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 10, 58, 49, 470, DateTimeKind.Local).AddTicks(4993),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 10, 36, 22, 916, DateTimeKind.Local).AddTicks(9944));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "RecoveryToken",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 10, 58, 49, 470, DateTimeKind.Local).AddTicks(3017),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 10, 36, 22, 916, DateTimeKind.Local).AddTicks(7581));

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "RecoveryToken",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "93a84d75_4",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldDefaultValue: "de323766_4");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "PriceVaccine",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 10, 58, 49, 480, DateTimeKind.Local).AddTicks(9383),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 10, 36, 22, 927, DateTimeKind.Local).AddTicks(7152));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "PriceVaccine",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 10, 58, 49, 480, DateTimeKind.Local).AddTicks(8110),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 10, 36, 22, 927, DateTimeKind.Local).AddTicks(5820));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "MedicalRecord",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 10, 58, 49, 484, DateTimeKind.Local).AddTicks(8239),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 10, 36, 22, 932, DateTimeKind.Local).AddTicks(7747));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "MedicalRecord",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 10, 58, 49, 484, DateTimeKind.Local).AddTicks(6783),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 10, 36, 22, 932, DateTimeKind.Local).AddTicks(6536));

            migrationBuilder.AddColumn<string>(
                name: "IdCustomer",
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
                defaultValue: new DateTime(2023, 12, 14, 10, 58, 49, 480, DateTimeKind.Local).AddTicks(6457),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 10, 36, 22, 927, DateTimeKind.Local).AddTicks(4220));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "InjectionChart",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 10, 58, 49, 480, DateTimeKind.Local).AddTicks(4825),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 10, 36, 22, 927, DateTimeKind.Local).AddTicks(2264));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "Information",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 10, 58, 49, 470, DateTimeKind.Local).AddTicks(9107),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 10, 36, 22, 917, DateTimeKind.Local).AddTicks(4033));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Dob",
                table: "Information",
                type: "datetime2",
                maxLength: 15,
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 10, 58, 49, 470, DateTimeKind.Local).AddTicks(8154),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldMaxLength: 15,
                oldDefaultValue: new DateTime(2023, 12, 14, 10, 36, 22, 917, DateTimeKind.Local).AddTicks(3024));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Information",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 10, 58, 49, 470, DateTimeKind.Local).AddTicks(6579),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 10, 36, 22, 917, DateTimeKind.Local).AddTicks(1966));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOfBirth",
                table: "Employee",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 10, 58, 49, 472, DateTimeKind.Local).AddTicks(6239),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 10, 36, 22, 925, DateTimeKind.Local).AddTicks(75));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Employee",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 10, 58, 49, 472, DateTimeKind.Local).AddTicks(4740),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 10, 36, 22, 924, DateTimeKind.Local).AddTicks(8101));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "District",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 10, 58, 49, 471, DateTimeKind.Local).AddTicks(8037),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 10, 36, 22, 924, DateTimeKind.Local).AddTicks(161));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "District",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 10, 58, 49, 471, DateTimeKind.Local).AddTicks(4121),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 10, 36, 22, 923, DateTimeKind.Local).AddTicks(4968));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "DetailVaccinationRegistration",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 10, 58, 49, 485, DateTimeKind.Local).AddTicks(6846),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 10, 36, 22, 933, DateTimeKind.Local).AddTicks(7046));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateVaccination",
                table: "DetailVaccinationRegistration",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 10, 58, 49, 485, DateTimeKind.Local).AddTicks(3068),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 10, 36, 22, 933, DateTimeKind.Local).AddTicks(454));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "DetailVaccinationRegistration",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 10, 58, 49, 485, DateTimeKind.Local).AddTicks(2129),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 10, 36, 22, 932, DateTimeKind.Local).AddTicks(9456));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "DetailMedicalRecord",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 10, 58, 49, 484, DateTimeKind.Local).AddTicks(4765),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 10, 36, 22, 932, DateTimeKind.Local).AddTicks(4715));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "DetailMedicalRecord",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 10, 58, 49, 483, DateTimeKind.Local).AddTicks(8703),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 10, 36, 22, 931, DateTimeKind.Local).AddTicks(4142));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "Customer",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 10, 58, 49, 473, DateTimeKind.Local).AddTicks(9312),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 10, 36, 22, 926, DateTimeKind.Local).AddTicks(4146));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOfBirth",
                table: "Customer",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 10, 58, 49, 473, DateTimeKind.Local).AddTicks(6703),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 10, 36, 22, 926, DateTimeKind.Local).AddTicks(1989));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Customer",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 10, 58, 49, 473, DateTimeKind.Local).AddTicks(5581),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 10, 36, 22, 926, DateTimeKind.Local).AddTicks(656));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "City",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 10, 58, 49, 471, DateTimeKind.Local).AddTicks(2371),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 10, 36, 22, 917, DateTimeKind.Local).AddTicks(7669));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "City",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 10, 58, 49, 471, DateTimeKind.Local).AddTicks(590),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 10, 36, 22, 917, DateTimeKind.Local).AddTicks(5669));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "CategoryVaccine",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 10, 58, 49, 480, DateTimeKind.Local).AddTicks(3183),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 10, 36, 22, 927, DateTimeKind.Local).AddTicks(406));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "CategoryVaccine",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 10, 58, 49, 480, DateTimeKind.Local).AddTicks(903),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 10, 36, 22, 926, DateTimeKind.Local).AddTicks(8629));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "CategoryPosition",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 10, 58, 49, 474, DateTimeKind.Local).AddTicks(1496),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 10, 36, 22, 926, DateTimeKind.Local).AddTicks(6494));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "CategoryPosition",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 10, 58, 49, 474, DateTimeKind.Local).AddTicks(878),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 10, 36, 22, 926, DateTimeKind.Local).AddTicks(5811));

            migrationBuilder.AddPrimaryKey(
                name: "PK_DetailMedicalRecord",
                table: "DetailMedicalRecord",
                columns: new[] { "Id", "IdMedicalRecord" });

            migrationBuilder.CreateIndex(
                name: "IX_VaccinationRegistration_IdCustomer",
                table: "VaccinationRegistration",
                column: "IdCustomer");

            migrationBuilder.CreateIndex(
                name: "IX_MedicalRecord_IdCustomer",
                table: "MedicalRecord",
                column: "IdCustomer");

            migrationBuilder.AddForeignKey(
                name: "FK_Medicals_Customer",
                table: "MedicalRecord",
                column: "IdCustomer",
                principalTable: "Customer",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_registration_Customer",
                table: "VaccinationRegistration",
                column: "IdCustomer",
                principalTable: "Customer",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Medicals_Customer",
                table: "MedicalRecord");

            migrationBuilder.DropForeignKey(
                name: "FK_registration_Customer",
                table: "VaccinationRegistration");

            migrationBuilder.DropIndex(
                name: "IX_VaccinationRegistration_IdCustomer",
                table: "VaccinationRegistration");

            migrationBuilder.DropIndex(
                name: "IX_MedicalRecord_IdCustomer",
                table: "MedicalRecord");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DetailMedicalRecord",
                table: "DetailMedicalRecord");

            migrationBuilder.DropColumn(
                name: "IdCustomer",
                table: "VaccinationRegistration");

            migrationBuilder.DropColumn(
                name: "IdCustomer",
                table: "MedicalRecord");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "Ward",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 10, 36, 22, 924, DateTimeKind.Local).AddTicks(5838),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 10, 58, 49, 472, DateTimeKind.Local).AddTicks(2851));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Ward",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 10, 36, 22, 924, DateTimeKind.Local).AddTicks(2283),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 10, 58, 49, 471, DateTimeKind.Local).AddTicks(9670));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "VaccineBatch",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 10, 36, 22, 931, DateTimeKind.Local).AddTicks(1795),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 10, 58, 49, 483, DateTimeKind.Local).AddTicks(6566));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ManufacturingDate",
                table: "VaccineBatch",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 10, 36, 22, 929, DateTimeKind.Local).AddTicks(6907),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 10, 58, 49, 482, DateTimeKind.Local).AddTicks(8567));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ExpirationDate",
                table: "VaccineBatch",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 10, 36, 22, 929, DateTimeKind.Local).AddTicks(7324),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 10, 58, 49, 482, DateTimeKind.Local).AddTicks(8920));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "VaccineBatch",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 10, 36, 22, 929, DateTimeKind.Local).AddTicks(5235),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 10, 58, 49, 482, DateTimeKind.Local).AddTicks(7013));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "Vaccine",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 10, 36, 22, 929, DateTimeKind.Local).AddTicks(3522),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 10, 58, 49, 482, DateTimeKind.Local).AddTicks(5335));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Vaccine",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 10, 36, 22, 928, DateTimeKind.Local).AddTicks(7281),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 10, 58, 49, 481, DateTimeKind.Local).AddTicks(9501));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "VaccinationRegistration",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 10, 36, 22, 934, DateTimeKind.Local).AddTicks(6107),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 10, 58, 49, 486, DateTimeKind.Local).AddTicks(9522));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "VaccinationRegistration",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 10, 36, 22, 933, DateTimeKind.Local).AddTicks(8816),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 10, 58, 49, 485, DateTimeKind.Local).AddTicks(9516));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "VaccinationCenter",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 10, 36, 22, 928, DateTimeKind.Local).AddTicks(5555),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 10, 58, 49, 481, DateTimeKind.Local).AddTicks(7885));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "VaccinationCenter",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 10, 36, 22, 928, DateTimeKind.Local).AddTicks(2519),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 10, 58, 49, 481, DateTimeKind.Local).AddTicks(4472));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "User",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 10, 36, 22, 916, DateTimeKind.Local).AddTicks(3334),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 10, 58, 49, 469, DateTimeKind.Local).AddTicks(9059));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "User",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 10, 36, 22, 915, DateTimeKind.Local).AddTicks(9596),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 10, 58, 49, 469, DateTimeKind.Local).AddTicks(5967));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "Supplier",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 10, 36, 22, 928, DateTimeKind.Local).AddTicks(901),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 10, 58, 49, 481, DateTimeKind.Local).AddTicks(2927));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Supplier",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 10, 36, 22, 927, DateTimeKind.Local).AddTicks(8783),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 10, 58, 49, 481, DateTimeKind.Local).AddTicks(952));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "RefeshToken",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 10, 36, 22, 915, DateTimeKind.Local).AddTicks(6163),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 10, 58, 49, 469, DateTimeKind.Local).AddTicks(4124));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "RefeshToken",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 10, 36, 22, 915, DateTimeKind.Local).AddTicks(1430),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 10, 58, 49, 469, DateTimeKind.Local).AddTicks(2038));

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "RefeshToken",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "1baa9167_f",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldDefaultValue: "4e2da279_e");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "RecoveryToken",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 10, 36, 22, 916, DateTimeKind.Local).AddTicks(9944),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 10, 58, 49, 470, DateTimeKind.Local).AddTicks(4993));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "RecoveryToken",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 10, 36, 22, 916, DateTimeKind.Local).AddTicks(7581),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 10, 58, 49, 470, DateTimeKind.Local).AddTicks(3017));

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "RecoveryToken",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "de323766_4",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldDefaultValue: "93a84d75_4");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "PriceVaccine",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 10, 36, 22, 927, DateTimeKind.Local).AddTicks(7152),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 10, 58, 49, 480, DateTimeKind.Local).AddTicks(9383));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "PriceVaccine",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 10, 36, 22, 927, DateTimeKind.Local).AddTicks(5820),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 10, 58, 49, 480, DateTimeKind.Local).AddTicks(8110));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "MedicalRecord",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 10, 36, 22, 932, DateTimeKind.Local).AddTicks(7747),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 10, 58, 49, 484, DateTimeKind.Local).AddTicks(8239));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "MedicalRecord",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 10, 36, 22, 932, DateTimeKind.Local).AddTicks(6536),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 10, 58, 49, 484, DateTimeKind.Local).AddTicks(6783));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "InjectionChart",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 10, 36, 22, 927, DateTimeKind.Local).AddTicks(4220),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 10, 58, 49, 480, DateTimeKind.Local).AddTicks(6457));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "InjectionChart",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 10, 36, 22, 927, DateTimeKind.Local).AddTicks(2264),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 10, 58, 49, 480, DateTimeKind.Local).AddTicks(4825));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "Information",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 10, 36, 22, 917, DateTimeKind.Local).AddTicks(4033),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 10, 58, 49, 470, DateTimeKind.Local).AddTicks(9107));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Dob",
                table: "Information",
                type: "datetime2",
                maxLength: 15,
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 10, 36, 22, 917, DateTimeKind.Local).AddTicks(3024),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldMaxLength: 15,
                oldDefaultValue: new DateTime(2023, 12, 14, 10, 58, 49, 470, DateTimeKind.Local).AddTicks(8154));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Information",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 10, 36, 22, 917, DateTimeKind.Local).AddTicks(1966),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 10, 58, 49, 470, DateTimeKind.Local).AddTicks(6579));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOfBirth",
                table: "Employee",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 10, 36, 22, 925, DateTimeKind.Local).AddTicks(75),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 10, 58, 49, 472, DateTimeKind.Local).AddTicks(6239));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Employee",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 10, 36, 22, 924, DateTimeKind.Local).AddTicks(8101),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 10, 58, 49, 472, DateTimeKind.Local).AddTicks(4740));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "District",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 10, 36, 22, 924, DateTimeKind.Local).AddTicks(161),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 10, 58, 49, 471, DateTimeKind.Local).AddTicks(8037));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "District",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 10, 36, 22, 923, DateTimeKind.Local).AddTicks(4968),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 10, 58, 49, 471, DateTimeKind.Local).AddTicks(4121));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "DetailVaccinationRegistration",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 10, 36, 22, 933, DateTimeKind.Local).AddTicks(7046),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 10, 58, 49, 485, DateTimeKind.Local).AddTicks(6846));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateVaccination",
                table: "DetailVaccinationRegistration",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 10, 36, 22, 933, DateTimeKind.Local).AddTicks(454),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 10, 58, 49, 485, DateTimeKind.Local).AddTicks(3068));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "DetailVaccinationRegistration",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 10, 36, 22, 932, DateTimeKind.Local).AddTicks(9456),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 10, 58, 49, 485, DateTimeKind.Local).AddTicks(2129));

            migrationBuilder.AddColumn<string>(
                name: "IdCustomer",
                table: "DetailVaccinationRegistration",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "DetailMedicalRecord",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 10, 36, 22, 932, DateTimeKind.Local).AddTicks(4715),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 10, 58, 49, 484, DateTimeKind.Local).AddTicks(4765));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "DetailMedicalRecord",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 10, 36, 22, 931, DateTimeKind.Local).AddTicks(4142),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 10, 58, 49, 483, DateTimeKind.Local).AddTicks(8703));

            migrationBuilder.AddColumn<string>(
                name: "IdCustomer",
                table: "DetailMedicalRecord",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "Customer",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 10, 36, 22, 926, DateTimeKind.Local).AddTicks(4146),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 10, 58, 49, 473, DateTimeKind.Local).AddTicks(9312));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOfBirth",
                table: "Customer",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 10, 36, 22, 926, DateTimeKind.Local).AddTicks(1989),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 10, 58, 49, 473, DateTimeKind.Local).AddTicks(6703));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Customer",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 10, 36, 22, 926, DateTimeKind.Local).AddTicks(656),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 10, 58, 49, 473, DateTimeKind.Local).AddTicks(5581));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "City",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 10, 36, 22, 917, DateTimeKind.Local).AddTicks(7669),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 10, 58, 49, 471, DateTimeKind.Local).AddTicks(2371));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "City",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 10, 36, 22, 917, DateTimeKind.Local).AddTicks(5669),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 10, 58, 49, 471, DateTimeKind.Local).AddTicks(590));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "CategoryVaccine",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 10, 36, 22, 927, DateTimeKind.Local).AddTicks(406),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 10, 58, 49, 480, DateTimeKind.Local).AddTicks(3183));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "CategoryVaccine",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 10, 36, 22, 926, DateTimeKind.Local).AddTicks(8629),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 10, 58, 49, 480, DateTimeKind.Local).AddTicks(903));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "CategoryPosition",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 10, 36, 22, 926, DateTimeKind.Local).AddTicks(6494),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 10, 58, 49, 474, DateTimeKind.Local).AddTicks(1496));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "CategoryPosition",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 10, 36, 22, 926, DateTimeKind.Local).AddTicks(5811),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 10, 58, 49, 474, DateTimeKind.Local).AddTicks(878));

            migrationBuilder.AddPrimaryKey(
                name: "PK_DetailMedicalRecord",
                table: "DetailMedicalRecord",
                columns: new[] { "Id", "IdCustomer", "IdMedicalRecord" });

            migrationBuilder.CreateIndex(
                name: "IX_DetailVaccinationRegistration_IdCustomer",
                table: "DetailVaccinationRegistration",
                column: "IdCustomer");

            migrationBuilder.CreateIndex(
                name: "IX_DetailMedicalRecord_IdCustomer",
                table: "DetailMedicalRecord",
                column: "IdCustomer");

            migrationBuilder.AddForeignKey(
                name: "FK_details_customer",
                table: "DetailMedicalRecord",
                column: "IdCustomer",
                principalTable: "Customer",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_detailsregis_customer",
                table: "DetailVaccinationRegistration",
                column: "IdCustomer",
                principalTable: "Customer",
                principalColumn: "Id");
        }
    }
}
