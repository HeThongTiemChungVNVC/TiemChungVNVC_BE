using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Repository.Migrations
{
    /// <inheritdoc />
    public partial class init2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IdVaccine",
                table: "VaccineBatch");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Ward",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 6, 13, 57, 47, 122, DateTimeKind.Local).AddTicks(2441),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 6, 13, 56, 25, 678, DateTimeKind.Local).AddTicks(4937));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ManufacturingDate",
                table: "VaccineBatch",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 6, 13, 57, 47, 125, DateTimeKind.Local).AddTicks(7613),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 6, 13, 56, 25, 681, DateTimeKind.Local).AddTicks(8249));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ExpirationDate",
                table: "VaccineBatch",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 6, 13, 57, 47, 125, DateTimeKind.Local).AddTicks(7966),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 6, 13, 56, 25, 681, DateTimeKind.Local).AddTicks(8593));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "VaccineBatch",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 6, 13, 57, 47, 125, DateTimeKind.Local).AddTicks(6296),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 6, 13, 56, 25, 681, DateTimeKind.Local).AddTicks(7104));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Vaccine",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 6, 13, 57, 47, 125, DateTimeKind.Local).AddTicks(186),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 6, 13, 56, 25, 681, DateTimeKind.Local).AddTicks(1242));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "VaccinationCenter",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 6, 13, 57, 47, 124, DateTimeKind.Local).AddTicks(8257),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 6, 13, 56, 25, 680, DateTimeKind.Local).AddTicks(9130));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "User",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 6, 13, 57, 47, 120, DateTimeKind.Local).AddTicks(3490),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 6, 13, 56, 25, 676, DateTimeKind.Local).AddTicks(7883));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Supplier",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 6, 13, 57, 47, 124, DateTimeKind.Local).AddTicks(5380),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 6, 13, 56, 25, 680, DateTimeKind.Local).AddTicks(6671));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "RefeshToken",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 6, 13, 57, 47, 120, DateTimeKind.Local).AddTicks(908),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 6, 13, 56, 25, 676, DateTimeKind.Local).AddTicks(5241));

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "RefeshToken",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "22045ea6_6",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldDefaultValue: "7242b659_d");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "RecoveryToken",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 6, 13, 57, 47, 120, DateTimeKind.Local).AddTicks(8220),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 6, 13, 56, 25, 677, DateTimeKind.Local).AddTicks(3031));

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "RecoveryToken",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "0d49ec16_f",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldDefaultValue: "e7c5e374_4");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "PriceVaccine",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 6, 13, 57, 47, 124, DateTimeKind.Local).AddTicks(3531),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 6, 13, 56, 25, 680, DateTimeKind.Local).AddTicks(4909));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "InjectionChart",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 6, 13, 57, 47, 124, DateTimeKind.Local).AddTicks(1285),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 6, 13, 56, 25, 680, DateTimeKind.Local).AddTicks(2790));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Dob",
                table: "Information",
                type: "datetime2",
                maxLength: 15,
                nullable: false,
                defaultValue: new DateTime(2023, 12, 6, 13, 57, 47, 121, DateTimeKind.Local).AddTicks(1487),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldMaxLength: 15,
                oldDefaultValue: new DateTime(2023, 12, 6, 13, 56, 25, 677, DateTimeKind.Local).AddTicks(6294));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Information",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 6, 13, 57, 47, 121, DateTimeKind.Local).AddTicks(799),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 6, 13, 56, 25, 677, DateTimeKind.Local).AddTicks(5649));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOfBirth",
                table: "Employee",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 6, 13, 57, 47, 122, DateTimeKind.Local).AddTicks(9959),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 6, 13, 56, 25, 679, DateTimeKind.Local).AddTicks(1323));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Employee",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 6, 13, 57, 47, 122, DateTimeKind.Local).AddTicks(7158),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 6, 13, 56, 25, 678, DateTimeKind.Local).AddTicks(8636));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "District",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 6, 13, 57, 47, 121, DateTimeKind.Local).AddTicks(5618),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 6, 13, 56, 25, 678, DateTimeKind.Local).AddTicks(650));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOfBirth",
                table: "Customer",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 6, 13, 57, 47, 123, DateTimeKind.Local).AddTicks(5459),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 6, 13, 56, 25, 679, DateTimeKind.Local).AddTicks(6741));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Customer",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 6, 13, 57, 47, 123, DateTimeKind.Local).AddTicks(4446),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 6, 13, 56, 25, 679, DateTimeKind.Local).AddTicks(5501));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "City",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 6, 13, 57, 47, 121, DateTimeKind.Local).AddTicks(3066),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 6, 13, 56, 25, 677, DateTimeKind.Local).AddTicks(7918));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "CategoryVaccine",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 6, 13, 57, 47, 123, DateTimeKind.Local).AddTicks(8620),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 6, 13, 56, 25, 680, DateTimeKind.Local).AddTicks(188));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "CategoryPosition",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 6, 13, 57, 47, 123, DateTimeKind.Local).AddTicks(6672),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 6, 13, 56, 25, 679, DateTimeKind.Local).AddTicks(8281));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Ward",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 6, 13, 56, 25, 678, DateTimeKind.Local).AddTicks(4937),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 6, 13, 57, 47, 122, DateTimeKind.Local).AddTicks(2441));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ManufacturingDate",
                table: "VaccineBatch",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 6, 13, 56, 25, 681, DateTimeKind.Local).AddTicks(8249),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 6, 13, 57, 47, 125, DateTimeKind.Local).AddTicks(7613));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ExpirationDate",
                table: "VaccineBatch",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 6, 13, 56, 25, 681, DateTimeKind.Local).AddTicks(8593),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 6, 13, 57, 47, 125, DateTimeKind.Local).AddTicks(7966));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "VaccineBatch",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 6, 13, 56, 25, 681, DateTimeKind.Local).AddTicks(7104),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 6, 13, 57, 47, 125, DateTimeKind.Local).AddTicks(6296));

            migrationBuilder.AddColumn<string>(
                name: "IdVaccine",
                table: "VaccineBatch",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Vaccine",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 6, 13, 56, 25, 681, DateTimeKind.Local).AddTicks(1242),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 6, 13, 57, 47, 125, DateTimeKind.Local).AddTicks(186));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "VaccinationCenter",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 6, 13, 56, 25, 680, DateTimeKind.Local).AddTicks(9130),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 6, 13, 57, 47, 124, DateTimeKind.Local).AddTicks(8257));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "User",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 6, 13, 56, 25, 676, DateTimeKind.Local).AddTicks(7883),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 6, 13, 57, 47, 120, DateTimeKind.Local).AddTicks(3490));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Supplier",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 6, 13, 56, 25, 680, DateTimeKind.Local).AddTicks(6671),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 6, 13, 57, 47, 124, DateTimeKind.Local).AddTicks(5380));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "RefeshToken",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 6, 13, 56, 25, 676, DateTimeKind.Local).AddTicks(5241),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 6, 13, 57, 47, 120, DateTimeKind.Local).AddTicks(908));

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "RefeshToken",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "7242b659_d",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldDefaultValue: "22045ea6_6");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "RecoveryToken",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 6, 13, 56, 25, 677, DateTimeKind.Local).AddTicks(3031),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 6, 13, 57, 47, 120, DateTimeKind.Local).AddTicks(8220));

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "RecoveryToken",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "e7c5e374_4",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldDefaultValue: "0d49ec16_f");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "PriceVaccine",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 6, 13, 56, 25, 680, DateTimeKind.Local).AddTicks(4909),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 6, 13, 57, 47, 124, DateTimeKind.Local).AddTicks(3531));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "InjectionChart",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 6, 13, 56, 25, 680, DateTimeKind.Local).AddTicks(2790),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 6, 13, 57, 47, 124, DateTimeKind.Local).AddTicks(1285));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Dob",
                table: "Information",
                type: "datetime2",
                maxLength: 15,
                nullable: false,
                defaultValue: new DateTime(2023, 12, 6, 13, 56, 25, 677, DateTimeKind.Local).AddTicks(6294),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldMaxLength: 15,
                oldDefaultValue: new DateTime(2023, 12, 6, 13, 57, 47, 121, DateTimeKind.Local).AddTicks(1487));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Information",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 6, 13, 56, 25, 677, DateTimeKind.Local).AddTicks(5649),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 6, 13, 57, 47, 121, DateTimeKind.Local).AddTicks(799));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOfBirth",
                table: "Employee",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 6, 13, 56, 25, 679, DateTimeKind.Local).AddTicks(1323),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 6, 13, 57, 47, 122, DateTimeKind.Local).AddTicks(9959));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Employee",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 6, 13, 56, 25, 678, DateTimeKind.Local).AddTicks(8636),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 6, 13, 57, 47, 122, DateTimeKind.Local).AddTicks(7158));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "District",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 6, 13, 56, 25, 678, DateTimeKind.Local).AddTicks(650),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 6, 13, 57, 47, 121, DateTimeKind.Local).AddTicks(5618));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOfBirth",
                table: "Customer",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 6, 13, 56, 25, 679, DateTimeKind.Local).AddTicks(6741),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 6, 13, 57, 47, 123, DateTimeKind.Local).AddTicks(5459));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Customer",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 6, 13, 56, 25, 679, DateTimeKind.Local).AddTicks(5501),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 6, 13, 57, 47, 123, DateTimeKind.Local).AddTicks(4446));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "City",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 6, 13, 56, 25, 677, DateTimeKind.Local).AddTicks(7918),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 6, 13, 57, 47, 121, DateTimeKind.Local).AddTicks(3066));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "CategoryVaccine",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 6, 13, 56, 25, 680, DateTimeKind.Local).AddTicks(188),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 6, 13, 57, 47, 123, DateTimeKind.Local).AddTicks(8620));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "CategoryPosition",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 6, 13, 56, 25, 679, DateTimeKind.Local).AddTicks(8281),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 6, 13, 57, 47, 123, DateTimeKind.Local).AddTicks(6672));
        }
    }
}
