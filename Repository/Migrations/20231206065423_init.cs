using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Repository.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PriceVaccine_Vaccine_VaccineId",
                table: "PriceVaccine");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PriceVaccine",
                table: "PriceVaccine");

            migrationBuilder.DropIndex(
                name: "IX_PriceVaccine_VaccineId",
                table: "PriceVaccine");

            migrationBuilder.DropColumn(
                name: "IdVaccine",
                table: "PriceVaccine");

            migrationBuilder.DropColumn(
                name: "VaccineId",
                table: "PriceVaccine");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Ward",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 6, 13, 54, 23, 407, DateTimeKind.Local).AddTicks(1982),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 4, 17, 34, 27, 436, DateTimeKind.Local).AddTicks(6912));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ManufacturingDate",
                table: "VaccineBatch",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 6, 13, 54, 23, 410, DateTimeKind.Local).AddTicks(9417),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 4, 17, 34, 27, 440, DateTimeKind.Local).AddTicks(8716));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ExpirationDate",
                table: "VaccineBatch",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 6, 13, 54, 23, 410, DateTimeKind.Local).AddTicks(9757),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 4, 17, 34, 27, 440, DateTimeKind.Local).AddTicks(9131));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "VaccineBatch",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 6, 13, 54, 23, 410, DateTimeKind.Local).AddTicks(8264),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 4, 17, 34, 27, 440, DateTimeKind.Local).AddTicks(7237));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Vaccine",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 6, 13, 54, 23, 410, DateTimeKind.Local).AddTicks(2172),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 4, 17, 34, 27, 439, DateTimeKind.Local).AddTicks(9885));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "VaccinationCenter",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 6, 13, 54, 23, 410, DateTimeKind.Local).AddTicks(150),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 4, 17, 34, 27, 439, DateTimeKind.Local).AddTicks(7586));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "User",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 6, 13, 54, 23, 405, DateTimeKind.Local).AddTicks(5069),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 4, 17, 34, 27, 434, DateTimeKind.Local).AddTicks(5313));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Supplier",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 6, 13, 54, 23, 409, DateTimeKind.Local).AddTicks(7440),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 4, 17, 34, 27, 439, DateTimeKind.Local).AddTicks(4566));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "RefeshToken",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 6, 13, 54, 23, 405, DateTimeKind.Local).AddTicks(2267),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 4, 17, 34, 27, 434, DateTimeKind.Local).AddTicks(1554));

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "RefeshToken",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "68d3eb11_a",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldDefaultValue: "5c32b50e_1");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "RecoveryToken",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 6, 13, 54, 23, 405, DateTimeKind.Local).AddTicks(9975),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 4, 17, 34, 27, 435, DateTimeKind.Local).AddTicks(2621));

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "RecoveryToken",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "80abf92e_8",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldDefaultValue: "dcb3b568_e");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "PriceVaccine",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 6, 13, 54, 23, 409, DateTimeKind.Local).AddTicks(5548),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 4, 17, 34, 27, 438, DateTimeKind.Local).AddTicks(9990));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "InjectionChart",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 6, 13, 54, 23, 409, DateTimeKind.Local).AddTicks(3251),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 4, 17, 34, 27, 438, DateTimeKind.Local).AddTicks(7116));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Dob",
                table: "Information",
                type: "datetime2",
                maxLength: 15,
                nullable: false,
                defaultValue: new DateTime(2023, 12, 6, 13, 54, 23, 406, DateTimeKind.Local).AddTicks(3280),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldMaxLength: 15,
                oldDefaultValue: new DateTime(2023, 12, 4, 17, 34, 27, 435, DateTimeKind.Local).AddTicks(6985));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Information",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 6, 13, 54, 23, 406, DateTimeKind.Local).AddTicks(2636),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 4, 17, 34, 27, 435, DateTimeKind.Local).AddTicks(6190));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOfBirth",
                table: "Employee",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 6, 13, 54, 23, 407, DateTimeKind.Local).AddTicks(8446),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 4, 17, 34, 27, 437, DateTimeKind.Local).AddTicks(4521));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Employee",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 6, 13, 54, 23, 407, DateTimeKind.Local).AddTicks(5845),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 4, 17, 34, 27, 437, DateTimeKind.Local).AddTicks(1430));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "District",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 6, 13, 54, 23, 406, DateTimeKind.Local).AddTicks(7515),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 4, 17, 34, 27, 436, DateTimeKind.Local).AddTicks(1919));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOfBirth",
                table: "Customer",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 6, 13, 54, 23, 408, DateTimeKind.Local).AddTicks(5347),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 4, 17, 34, 27, 438, DateTimeKind.Local).AddTicks(690));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Customer",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 6, 13, 54, 23, 408, DateTimeKind.Local).AddTicks(3421),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 4, 17, 34, 27, 437, DateTimeKind.Local).AddTicks(9652));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "City",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 6, 13, 54, 23, 406, DateTimeKind.Local).AddTicks(4932),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 4, 17, 34, 27, 435, DateTimeKind.Local).AddTicks(8857));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "CategoryVaccine",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 6, 13, 54, 23, 409, DateTimeKind.Local).AddTicks(490),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 4, 17, 34, 27, 438, DateTimeKind.Local).AddTicks(4115));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "CategoryPosition",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 6, 13, 54, 23, 408, DateTimeKind.Local).AddTicks(7692),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 4, 17, 34, 27, 438, DateTimeKind.Local).AddTicks(1992));

            migrationBuilder.AddPrimaryKey(
                name: "PK_PriceVaccine",
                table: "PriceVaccine",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_PriceVaccine",
                table: "PriceVaccine");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Ward",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 4, 17, 34, 27, 436, DateTimeKind.Local).AddTicks(6912),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 6, 13, 54, 23, 407, DateTimeKind.Local).AddTicks(1982));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ManufacturingDate",
                table: "VaccineBatch",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 4, 17, 34, 27, 440, DateTimeKind.Local).AddTicks(8716),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 6, 13, 54, 23, 410, DateTimeKind.Local).AddTicks(9417));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ExpirationDate",
                table: "VaccineBatch",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 4, 17, 34, 27, 440, DateTimeKind.Local).AddTicks(9131),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 6, 13, 54, 23, 410, DateTimeKind.Local).AddTicks(9757));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "VaccineBatch",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 4, 17, 34, 27, 440, DateTimeKind.Local).AddTicks(7237),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 6, 13, 54, 23, 410, DateTimeKind.Local).AddTicks(8264));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Vaccine",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 4, 17, 34, 27, 439, DateTimeKind.Local).AddTicks(9885),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 6, 13, 54, 23, 410, DateTimeKind.Local).AddTicks(2172));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "VaccinationCenter",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 4, 17, 34, 27, 439, DateTimeKind.Local).AddTicks(7586),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 6, 13, 54, 23, 410, DateTimeKind.Local).AddTicks(150));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "User",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 4, 17, 34, 27, 434, DateTimeKind.Local).AddTicks(5313),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 6, 13, 54, 23, 405, DateTimeKind.Local).AddTicks(5069));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Supplier",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 4, 17, 34, 27, 439, DateTimeKind.Local).AddTicks(4566),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 6, 13, 54, 23, 409, DateTimeKind.Local).AddTicks(7440));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "RefeshToken",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 4, 17, 34, 27, 434, DateTimeKind.Local).AddTicks(1554),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 6, 13, 54, 23, 405, DateTimeKind.Local).AddTicks(2267));

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "RefeshToken",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "5c32b50e_1",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldDefaultValue: "68d3eb11_a");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "RecoveryToken",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 4, 17, 34, 27, 435, DateTimeKind.Local).AddTicks(2621),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 6, 13, 54, 23, 405, DateTimeKind.Local).AddTicks(9975));

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "RecoveryToken",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "dcb3b568_e",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldDefaultValue: "80abf92e_8");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "PriceVaccine",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 4, 17, 34, 27, 438, DateTimeKind.Local).AddTicks(9990),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 6, 13, 54, 23, 409, DateTimeKind.Local).AddTicks(5548));

            migrationBuilder.AddColumn<string>(
                name: "IdVaccine",
                table: "PriceVaccine",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "VaccineId",
                table: "PriceVaccine",
                type: "nvarchar(50)",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "InjectionChart",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 4, 17, 34, 27, 438, DateTimeKind.Local).AddTicks(7116),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 6, 13, 54, 23, 409, DateTimeKind.Local).AddTicks(3251));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Dob",
                table: "Information",
                type: "datetime2",
                maxLength: 15,
                nullable: false,
                defaultValue: new DateTime(2023, 12, 4, 17, 34, 27, 435, DateTimeKind.Local).AddTicks(6985),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldMaxLength: 15,
                oldDefaultValue: new DateTime(2023, 12, 6, 13, 54, 23, 406, DateTimeKind.Local).AddTicks(3280));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Information",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 4, 17, 34, 27, 435, DateTimeKind.Local).AddTicks(6190),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 6, 13, 54, 23, 406, DateTimeKind.Local).AddTicks(2636));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOfBirth",
                table: "Employee",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 4, 17, 34, 27, 437, DateTimeKind.Local).AddTicks(4521),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 6, 13, 54, 23, 407, DateTimeKind.Local).AddTicks(8446));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Employee",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 4, 17, 34, 27, 437, DateTimeKind.Local).AddTicks(1430),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 6, 13, 54, 23, 407, DateTimeKind.Local).AddTicks(5845));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "District",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 4, 17, 34, 27, 436, DateTimeKind.Local).AddTicks(1919),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 6, 13, 54, 23, 406, DateTimeKind.Local).AddTicks(7515));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOfBirth",
                table: "Customer",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 4, 17, 34, 27, 438, DateTimeKind.Local).AddTicks(690),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 6, 13, 54, 23, 408, DateTimeKind.Local).AddTicks(5347));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Customer",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 4, 17, 34, 27, 437, DateTimeKind.Local).AddTicks(9652),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 6, 13, 54, 23, 408, DateTimeKind.Local).AddTicks(3421));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "City",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 4, 17, 34, 27, 435, DateTimeKind.Local).AddTicks(8857),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 6, 13, 54, 23, 406, DateTimeKind.Local).AddTicks(4932));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "CategoryVaccine",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 4, 17, 34, 27, 438, DateTimeKind.Local).AddTicks(4115),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 6, 13, 54, 23, 409, DateTimeKind.Local).AddTicks(490));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "CategoryPosition",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 4, 17, 34, 27, 438, DateTimeKind.Local).AddTicks(1992),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 6, 13, 54, 23, 408, DateTimeKind.Local).AddTicks(7692));

            migrationBuilder.AddPrimaryKey(
                name: "PK_PriceVaccine",
                table: "PriceVaccine",
                columns: new[] { "Id", "IdVaccine" });

            migrationBuilder.CreateIndex(
                name: "IX_PriceVaccine_VaccineId",
                table: "PriceVaccine",
                column: "VaccineId");

            migrationBuilder.AddForeignKey(
                name: "FK_PriceVaccine_Vaccine_VaccineId",
                table: "PriceVaccine",
                column: "VaccineId",
                principalTable: "Vaccine",
                principalColumn: "Id");
        }
    }
}
