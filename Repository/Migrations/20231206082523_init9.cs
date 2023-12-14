using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Repository.Migrations
{
    /// <inheritdoc />
    public partial class init9 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DtoDetailVaccinationRegistration_Customer_CustomerId",
                table: "DtoDetailVaccinationRegistration");

            migrationBuilder.DropForeignKey(
                name: "FK_DtoDetailVaccinationRegistration_DtoVaccinationRegistration_VaccinationRegistrationId",
                table: "DtoDetailVaccinationRegistration");

            migrationBuilder.DropForeignKey(
                name: "FK_DtoVaccinationRegistration_InjectionChart_IdInjectionChart",
                table: "DtoVaccinationRegistration");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DtoVaccinationRegistration",
                table: "DtoVaccinationRegistration");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DtoDetailVaccinationRegistration",
                table: "DtoDetailVaccinationRegistration");

            migrationBuilder.DropIndex(
                name: "IX_DtoDetailVaccinationRegistration_CustomerId",
                table: "DtoDetailVaccinationRegistration");

            migrationBuilder.DropIndex(
                name: "IX_DtoDetailVaccinationRegistration_VaccinationRegistrationId",
                table: "DtoDetailVaccinationRegistration");

            migrationBuilder.DropColumn(
                name: "CustomerId",
                table: "DtoDetailVaccinationRegistration");

            migrationBuilder.DropColumn(
                name: "VaccinationRegistrationId",
                table: "DtoDetailVaccinationRegistration");

            migrationBuilder.RenameTable(
                name: "DtoVaccinationRegistration",
                newName: "VaccinationRegistration");

            migrationBuilder.RenameTable(
                name: "DtoDetailVaccinationRegistration",
                newName: "DetailVaccinationRegistration");

            migrationBuilder.RenameIndex(
                name: "IX_DtoVaccinationRegistration_IdInjectionChart",
                table: "VaccinationRegistration",
                newName: "IX_VaccinationRegistration_IdInjectionChart");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Ward",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 6, 15, 25, 23, 194, DateTimeKind.Local).AddTicks(9453),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 6, 15, 22, 25, 209, DateTimeKind.Local).AddTicks(7462));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ManufacturingDate",
                table: "VaccineBatch",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 6, 15, 25, 23, 200, DateTimeKind.Local).AddTicks(1403),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 6, 15, 22, 25, 214, DateTimeKind.Local).AddTicks(4923));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ExpirationDate",
                table: "VaccineBatch",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 6, 15, 25, 23, 200, DateTimeKind.Local).AddTicks(1754),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 6, 15, 22, 25, 214, DateTimeKind.Local).AddTicks(5314));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "VaccineBatch",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 6, 15, 25, 23, 200, DateTimeKind.Local).AddTicks(229),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 6, 15, 22, 25, 214, DateTimeKind.Local).AddTicks(3757));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Vaccine",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 6, 15, 25, 23, 199, DateTimeKind.Local).AddTicks(3634),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 6, 15, 22, 25, 213, DateTimeKind.Local).AddTicks(7904));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "VaccinationCenter",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 6, 15, 25, 23, 199, DateTimeKind.Local).AddTicks(1437),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 6, 15, 22, 25, 213, DateTimeKind.Local).AddTicks(5802));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "User",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 6, 15, 25, 23, 193, DateTimeKind.Local).AddTicks(1082),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 6, 15, 22, 25, 208, DateTimeKind.Local).AddTicks(510));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Supplier",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 6, 15, 25, 23, 198, DateTimeKind.Local).AddTicks(8820),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 6, 15, 22, 25, 213, DateTimeKind.Local).AddTicks(3251));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "RefeshToken",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 6, 15, 25, 23, 192, DateTimeKind.Local).AddTicks(8173),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 6, 15, 22, 25, 207, DateTimeKind.Local).AddTicks(7772));

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "RefeshToken",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "8b493907_d",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldDefaultValue: "1fde0b0f_c");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "RecoveryToken",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 6, 15, 25, 23, 193, DateTimeKind.Local).AddTicks(6151),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 6, 15, 22, 25, 208, DateTimeKind.Local).AddTicks(5328));

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "RecoveryToken",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "537fda96_d",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldDefaultValue: "4f95f756_c");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "PriceVaccine",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 6, 15, 25, 23, 198, DateTimeKind.Local).AddTicks(6655),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 6, 15, 22, 25, 213, DateTimeKind.Local).AddTicks(1342));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "MedicalRecord",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 6, 15, 25, 23, 201, DateTimeKind.Local).AddTicks(5817),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 6, 15, 22, 25, 216, DateTimeKind.Local).AddTicks(817));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "InjectionChart",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 6, 15, 25, 23, 197, DateTimeKind.Local).AddTicks(6314),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 6, 15, 22, 25, 212, DateTimeKind.Local).AddTicks(508));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Dob",
                table: "Information",
                type: "datetime2",
                maxLength: 15,
                nullable: false,
                defaultValue: new DateTime(2023, 12, 6, 15, 25, 23, 193, DateTimeKind.Local).AddTicks(9577),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldMaxLength: 15,
                oldDefaultValue: new DateTime(2023, 12, 6, 15, 22, 25, 208, DateTimeKind.Local).AddTicks(8686));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Information",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 6, 15, 25, 23, 193, DateTimeKind.Local).AddTicks(8894),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 6, 15, 22, 25, 208, DateTimeKind.Local).AddTicks(8000));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOfBirth",
                table: "Employee",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 6, 15, 25, 23, 195, DateTimeKind.Local).AddTicks(9178),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 6, 15, 22, 25, 210, DateTimeKind.Local).AddTicks(4372));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Employee",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 6, 15, 25, 23, 195, DateTimeKind.Local).AddTicks(5849),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 6, 15, 22, 25, 210, DateTimeKind.Local).AddTicks(1330));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "District",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 6, 15, 25, 23, 194, DateTimeKind.Local).AddTicks(3809),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 6, 15, 22, 25, 209, DateTimeKind.Local).AddTicks(3014));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "DetailMedicalRecord",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 6, 15, 25, 23, 200, DateTimeKind.Local).AddTicks(6192),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 6, 15, 22, 25, 215, DateTimeKind.Local).AddTicks(1315));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOfBirth",
                table: "Customer",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 6, 15, 25, 23, 196, DateTimeKind.Local).AddTicks(9168),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 6, 15, 22, 25, 211, DateTimeKind.Local).AddTicks(3621));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Customer",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 6, 15, 25, 23, 196, DateTimeKind.Local).AddTicks(8301),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 6, 15, 22, 25, 211, DateTimeKind.Local).AddTicks(2816));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "City",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 6, 15, 25, 23, 194, DateTimeKind.Local).AddTicks(1169),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 6, 15, 22, 25, 209, DateTimeKind.Local).AddTicks(214));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "CategoryVaccine",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 6, 15, 25, 23, 197, DateTimeKind.Local).AddTicks(3740),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 6, 15, 22, 25, 211, DateTimeKind.Local).AddTicks(8003));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "CategoryPosition",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 6, 15, 25, 23, 197, DateTimeKind.Local).AddTicks(1883),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 6, 15, 22, 25, 211, DateTimeKind.Local).AddTicks(6209));

            migrationBuilder.AlterColumn<bool>(
                name: "IsDeleted",
                table: "VaccinationRegistration",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "VaccinationRegistration",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 6, 15, 25, 23, 202, DateTimeKind.Local).AddTicks(5158),
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "VaccinationRegistration",
                type: "nvarchar(max)",
                nullable: true,
                defaultValue: "admin",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "VaccinationRegistration",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<bool>(
                name: "IsDeleted",
                table: "DetailVaccinationRegistration",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<string>(
                name: "IdVaccinationRegistration",
                table: "DetailVaccinationRegistration",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "IdCustomer",
                table: "DetailVaccinationRegistration",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateVaccinated",
                table: "DetailVaccinationRegistration",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 6, 15, 25, 23, 201, DateTimeKind.Local).AddTicks(8771),
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "DetailVaccinationRegistration",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 6, 15, 25, 23, 201, DateTimeKind.Local).AddTicks(7929),
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "DetailVaccinationRegistration",
                type: "nvarchar(max)",
                nullable: true,
                defaultValue: "admin",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "DetailVaccinationRegistration",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_VaccinationRegistration",
                table: "VaccinationRegistration",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DetailVaccinationRegistration",
                table: "DetailVaccinationRegistration",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_DetailVaccinationRegistration_IdCustomer",
                table: "DetailVaccinationRegistration",
                column: "IdCustomer");

            migrationBuilder.CreateIndex(
                name: "IX_DetailVaccinationRegistration_IdVaccinationRegistration",
                table: "DetailVaccinationRegistration",
                column: "IdVaccinationRegistration");

            migrationBuilder.AddForeignKey(
                name: "FK_details_vaccinationRegistration",
                table: "DetailVaccinationRegistration",
                column: "IdVaccinationRegistration",
                principalTable: "VaccinationRegistration",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_detailsregis_customer",
                table: "DetailVaccinationRegistration",
                column: "IdCustomer",
                principalTable: "Customer",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_VaccinationRegistration_InjectionChart_IdInjectionChart",
                table: "VaccinationRegistration",
                column: "IdInjectionChart",
                principalTable: "InjectionChart",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_details_vaccinationRegistration",
                table: "DetailVaccinationRegistration");

            migrationBuilder.DropForeignKey(
                name: "FK_detailsregis_customer",
                table: "DetailVaccinationRegistration");

            migrationBuilder.DropForeignKey(
                name: "FK_VaccinationRegistration_InjectionChart_IdInjectionChart",
                table: "VaccinationRegistration");

            migrationBuilder.DropPrimaryKey(
                name: "PK_VaccinationRegistration",
                table: "VaccinationRegistration");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DetailVaccinationRegistration",
                table: "DetailVaccinationRegistration");

            migrationBuilder.DropIndex(
                name: "IX_DetailVaccinationRegistration_IdCustomer",
                table: "DetailVaccinationRegistration");

            migrationBuilder.DropIndex(
                name: "IX_DetailVaccinationRegistration_IdVaccinationRegistration",
                table: "DetailVaccinationRegistration");

            migrationBuilder.RenameTable(
                name: "VaccinationRegistration",
                newName: "DtoVaccinationRegistration");

            migrationBuilder.RenameTable(
                name: "DetailVaccinationRegistration",
                newName: "DtoDetailVaccinationRegistration");

            migrationBuilder.RenameIndex(
                name: "IX_VaccinationRegistration_IdInjectionChart",
                table: "DtoVaccinationRegistration",
                newName: "IX_DtoVaccinationRegistration_IdInjectionChart");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Ward",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 6, 15, 22, 25, 209, DateTimeKind.Local).AddTicks(7462),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 6, 15, 25, 23, 194, DateTimeKind.Local).AddTicks(9453));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ManufacturingDate",
                table: "VaccineBatch",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 6, 15, 22, 25, 214, DateTimeKind.Local).AddTicks(4923),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 6, 15, 25, 23, 200, DateTimeKind.Local).AddTicks(1403));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ExpirationDate",
                table: "VaccineBatch",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 6, 15, 22, 25, 214, DateTimeKind.Local).AddTicks(5314),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 6, 15, 25, 23, 200, DateTimeKind.Local).AddTicks(1754));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "VaccineBatch",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 6, 15, 22, 25, 214, DateTimeKind.Local).AddTicks(3757),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 6, 15, 25, 23, 200, DateTimeKind.Local).AddTicks(229));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Vaccine",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 6, 15, 22, 25, 213, DateTimeKind.Local).AddTicks(7904),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 6, 15, 25, 23, 199, DateTimeKind.Local).AddTicks(3634));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "VaccinationCenter",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 6, 15, 22, 25, 213, DateTimeKind.Local).AddTicks(5802),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 6, 15, 25, 23, 199, DateTimeKind.Local).AddTicks(1437));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "User",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 6, 15, 22, 25, 208, DateTimeKind.Local).AddTicks(510),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 6, 15, 25, 23, 193, DateTimeKind.Local).AddTicks(1082));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Supplier",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 6, 15, 22, 25, 213, DateTimeKind.Local).AddTicks(3251),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 6, 15, 25, 23, 198, DateTimeKind.Local).AddTicks(8820));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "RefeshToken",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 6, 15, 22, 25, 207, DateTimeKind.Local).AddTicks(7772),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 6, 15, 25, 23, 192, DateTimeKind.Local).AddTicks(8173));

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "RefeshToken",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "1fde0b0f_c",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldDefaultValue: "8b493907_d");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "RecoveryToken",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 6, 15, 22, 25, 208, DateTimeKind.Local).AddTicks(5328),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 6, 15, 25, 23, 193, DateTimeKind.Local).AddTicks(6151));

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "RecoveryToken",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "4f95f756_c",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldDefaultValue: "537fda96_d");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "PriceVaccine",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 6, 15, 22, 25, 213, DateTimeKind.Local).AddTicks(1342),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 6, 15, 25, 23, 198, DateTimeKind.Local).AddTicks(6655));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "MedicalRecord",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 6, 15, 22, 25, 216, DateTimeKind.Local).AddTicks(817),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 6, 15, 25, 23, 201, DateTimeKind.Local).AddTicks(5817));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "InjectionChart",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 6, 15, 22, 25, 212, DateTimeKind.Local).AddTicks(508),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 6, 15, 25, 23, 197, DateTimeKind.Local).AddTicks(6314));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Dob",
                table: "Information",
                type: "datetime2",
                maxLength: 15,
                nullable: false,
                defaultValue: new DateTime(2023, 12, 6, 15, 22, 25, 208, DateTimeKind.Local).AddTicks(8686),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldMaxLength: 15,
                oldDefaultValue: new DateTime(2023, 12, 6, 15, 25, 23, 193, DateTimeKind.Local).AddTicks(9577));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Information",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 6, 15, 22, 25, 208, DateTimeKind.Local).AddTicks(8000),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 6, 15, 25, 23, 193, DateTimeKind.Local).AddTicks(8894));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOfBirth",
                table: "Employee",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 6, 15, 22, 25, 210, DateTimeKind.Local).AddTicks(4372),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 6, 15, 25, 23, 195, DateTimeKind.Local).AddTicks(9178));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Employee",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 6, 15, 22, 25, 210, DateTimeKind.Local).AddTicks(1330),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 6, 15, 25, 23, 195, DateTimeKind.Local).AddTicks(5849));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "District",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 6, 15, 22, 25, 209, DateTimeKind.Local).AddTicks(3014),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 6, 15, 25, 23, 194, DateTimeKind.Local).AddTicks(3809));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "DetailMedicalRecord",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 6, 15, 22, 25, 215, DateTimeKind.Local).AddTicks(1315),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 6, 15, 25, 23, 200, DateTimeKind.Local).AddTicks(6192));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOfBirth",
                table: "Customer",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 6, 15, 22, 25, 211, DateTimeKind.Local).AddTicks(3621),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 6, 15, 25, 23, 196, DateTimeKind.Local).AddTicks(9168));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Customer",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 6, 15, 22, 25, 211, DateTimeKind.Local).AddTicks(2816),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 6, 15, 25, 23, 196, DateTimeKind.Local).AddTicks(8301));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "City",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 6, 15, 22, 25, 209, DateTimeKind.Local).AddTicks(214),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 6, 15, 25, 23, 194, DateTimeKind.Local).AddTicks(1169));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "CategoryVaccine",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 6, 15, 22, 25, 211, DateTimeKind.Local).AddTicks(8003),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 6, 15, 25, 23, 197, DateTimeKind.Local).AddTicks(3740));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "CategoryPosition",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 6, 15, 22, 25, 211, DateTimeKind.Local).AddTicks(6209),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 6, 15, 25, 23, 197, DateTimeKind.Local).AddTicks(1883));

            migrationBuilder.AlterColumn<bool>(
                name: "IsDeleted",
                table: "DtoVaccinationRegistration",
                type: "bit",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: false);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "DtoVaccinationRegistration",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 6, 15, 25, 23, 202, DateTimeKind.Local).AddTicks(5158));

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "DtoVaccinationRegistration",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true,
                oldDefaultValue: "admin");

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "DtoVaccinationRegistration",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<bool>(
                name: "IsDeleted",
                table: "DtoDetailVaccinationRegistration",
                type: "bit",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: false);

            migrationBuilder.AlterColumn<string>(
                name: "IdVaccinationRegistration",
                table: "DtoDetailVaccinationRegistration",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "IdCustomer",
                table: "DtoDetailVaccinationRegistration",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateVaccinated",
                table: "DtoDetailVaccinationRegistration",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 6, 15, 25, 23, 201, DateTimeKind.Local).AddTicks(8771));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "DtoDetailVaccinationRegistration",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 6, 15, 25, 23, 201, DateTimeKind.Local).AddTicks(7929));

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "DtoDetailVaccinationRegistration",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true,
                oldDefaultValue: "admin");

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "DtoDetailVaccinationRegistration",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AddColumn<string>(
                name: "CustomerId",
                table: "DtoDetailVaccinationRegistration",
                type: "nvarchar(50)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "VaccinationRegistrationId",
                table: "DtoDetailVaccinationRegistration",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_DtoVaccinationRegistration",
                table: "DtoVaccinationRegistration",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DtoDetailVaccinationRegistration",
                table: "DtoDetailVaccinationRegistration",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_DtoDetailVaccinationRegistration_CustomerId",
                table: "DtoDetailVaccinationRegistration",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_DtoDetailVaccinationRegistration_VaccinationRegistrationId",
                table: "DtoDetailVaccinationRegistration",
                column: "VaccinationRegistrationId");

            migrationBuilder.AddForeignKey(
                name: "FK_DtoDetailVaccinationRegistration_Customer_CustomerId",
                table: "DtoDetailVaccinationRegistration",
                column: "CustomerId",
                principalTable: "Customer",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DtoDetailVaccinationRegistration_DtoVaccinationRegistration_VaccinationRegistrationId",
                table: "DtoDetailVaccinationRegistration",
                column: "VaccinationRegistrationId",
                principalTable: "DtoVaccinationRegistration",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_DtoVaccinationRegistration_InjectionChart_IdInjectionChart",
                table: "DtoVaccinationRegistration",
                column: "IdInjectionChart",
                principalTable: "InjectionChart",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
