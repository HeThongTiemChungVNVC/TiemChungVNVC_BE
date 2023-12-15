using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Repository.Migrations
{
    /// <inheritdoc />
    public partial class UpdateEmployeeTB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "Ward",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 15, 16, 17, 14, 753, DateTimeKind.Local).AddTicks(9069),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 10, 58, 49, 472, DateTimeKind.Local).AddTicks(2851));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Ward",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 15, 16, 17, 14, 753, DateTimeKind.Local).AddTicks(6436),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 10, 58, 49, 471, DateTimeKind.Local).AddTicks(9670));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "VaccineBatch",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 15, 16, 17, 14, 759, DateTimeKind.Local).AddTicks(727),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 10, 58, 49, 483, DateTimeKind.Local).AddTicks(6566));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ManufacturingDate",
                table: "VaccineBatch",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 15, 16, 17, 14, 758, DateTimeKind.Local).AddTicks(2910),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 10, 58, 49, 482, DateTimeKind.Local).AddTicks(8567));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ExpirationDate",
                table: "VaccineBatch",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 15, 16, 17, 14, 758, DateTimeKind.Local).AddTicks(3221),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 10, 58, 49, 482, DateTimeKind.Local).AddTicks(8920));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "VaccineBatch",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 15, 16, 17, 14, 758, DateTimeKind.Local).AddTicks(1549),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 10, 58, 49, 482, DateTimeKind.Local).AddTicks(7013));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "Vaccine",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 15, 16, 17, 14, 757, DateTimeKind.Local).AddTicks(9905),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 10, 58, 49, 482, DateTimeKind.Local).AddTicks(5335));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Vaccine",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 15, 16, 17, 14, 757, DateTimeKind.Local).AddTicks(5411),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 10, 58, 49, 481, DateTimeKind.Local).AddTicks(9501));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "VaccinationRegistration",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 15, 16, 17, 14, 761, DateTimeKind.Local).AddTicks(9135),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 10, 58, 49, 486, DateTimeKind.Local).AddTicks(9522));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "VaccinationRegistration",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 15, 16, 17, 14, 761, DateTimeKind.Local).AddTicks(328),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 10, 58, 49, 485, DateTimeKind.Local).AddTicks(9516));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "VaccinationCenter",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 15, 16, 17, 14, 757, DateTimeKind.Local).AddTicks(4052),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 10, 58, 49, 481, DateTimeKind.Local).AddTicks(7885));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "VaccinationCenter",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 15, 16, 17, 14, 757, DateTimeKind.Local).AddTicks(1377),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 10, 58, 49, 481, DateTimeKind.Local).AddTicks(4472));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "User",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 15, 16, 17, 14, 752, DateTimeKind.Local).AddTicks(1908),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 10, 58, 49, 469, DateTimeKind.Local).AddTicks(9059));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "User",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 15, 16, 17, 14, 751, DateTimeKind.Local).AddTicks(9937),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 10, 58, 49, 469, DateTimeKind.Local).AddTicks(5967));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "Supplier",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 15, 16, 17, 14, 757, DateTimeKind.Local).AddTicks(256),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 10, 58, 49, 481, DateTimeKind.Local).AddTicks(2927));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Supplier",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 15, 16, 17, 14, 756, DateTimeKind.Local).AddTicks(8368),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 10, 58, 49, 481, DateTimeKind.Local).AddTicks(952));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "RefeshToken",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 15, 16, 17, 14, 751, DateTimeKind.Local).AddTicks(8743),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 10, 58, 49, 469, DateTimeKind.Local).AddTicks(4124));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "RefeshToken",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 15, 16, 17, 14, 751, DateTimeKind.Local).AddTicks(7212),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 10, 58, 49, 469, DateTimeKind.Local).AddTicks(2038));

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "RefeshToken",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "f2a574b3_3",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldDefaultValue: "4e2da279_e");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "RecoveryToken",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 15, 16, 17, 14, 752, DateTimeKind.Local).AddTicks(6160),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 10, 58, 49, 470, DateTimeKind.Local).AddTicks(4993));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "RecoveryToken",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 15, 16, 17, 14, 752, DateTimeKind.Local).AddTicks(4844),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 10, 58, 49, 470, DateTimeKind.Local).AddTicks(3017));

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "RecoveryToken",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "0731091c_7",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldDefaultValue: "93a84d75_4");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "PriceVaccine",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 15, 16, 17, 14, 756, DateTimeKind.Local).AddTicks(7225),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 10, 58, 49, 480, DateTimeKind.Local).AddTicks(9383));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "PriceVaccine",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 15, 16, 17, 14, 756, DateTimeKind.Local).AddTicks(6404),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 10, 58, 49, 480, DateTimeKind.Local).AddTicks(8110));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "MedicalRecord",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 15, 16, 17, 14, 760, DateTimeKind.Local).AddTicks(1595),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 10, 58, 49, 484, DateTimeKind.Local).AddTicks(8239));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "MedicalRecord",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 15, 16, 17, 14, 760, DateTimeKind.Local).AddTicks(621),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 10, 58, 49, 484, DateTimeKind.Local).AddTicks(6783));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "InjectionChart",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 15, 16, 17, 14, 756, DateTimeKind.Local).AddTicks(4513),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 10, 58, 49, 480, DateTimeKind.Local).AddTicks(6457));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "InjectionChart",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 15, 16, 17, 14, 756, DateTimeKind.Local).AddTicks(3422),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 10, 58, 49, 480, DateTimeKind.Local).AddTicks(4825));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "Information",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 15, 16, 17, 14, 752, DateTimeKind.Local).AddTicks(8363),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 10, 58, 49, 470, DateTimeKind.Local).AddTicks(9107));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Dob",
                table: "Information",
                type: "datetime2",
                maxLength: 15,
                nullable: false,
                defaultValue: new DateTime(2023, 12, 15, 16, 17, 14, 752, DateTimeKind.Local).AddTicks(7891),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldMaxLength: 15,
                oldDefaultValue: new DateTime(2023, 12, 14, 10, 58, 49, 470, DateTimeKind.Local).AddTicks(8154));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Information",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 15, 16, 17, 14, 752, DateTimeKind.Local).AddTicks(7426),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 10, 58, 49, 470, DateTimeKind.Local).AddTicks(6579));

            migrationBuilder.AlterColumn<bool>(
                name: "Gender",
                table: "Employee",
                type: "bit",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOfBirth",
                table: "Employee",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 15, 16, 17, 14, 754, DateTimeKind.Local).AddTicks(1725),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 10, 58, 49, 472, DateTimeKind.Local).AddTicks(6239));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Employee",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 15, 16, 17, 14, 754, DateTimeKind.Local).AddTicks(736),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 10, 58, 49, 472, DateTimeKind.Local).AddTicks(4740));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "District",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 15, 16, 17, 14, 753, DateTimeKind.Local).AddTicks(5018),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 10, 58, 49, 471, DateTimeKind.Local).AddTicks(8037));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "District",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 15, 16, 17, 14, 753, DateTimeKind.Local).AddTicks(2149),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 10, 58, 49, 471, DateTimeKind.Local).AddTicks(4121));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "DetailVaccinationRegistration",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 15, 16, 17, 14, 760, DateTimeKind.Local).AddTicks(8773),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 10, 58, 49, 485, DateTimeKind.Local).AddTicks(6846));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateVaccination",
                table: "DetailVaccinationRegistration",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 15, 16, 17, 14, 760, DateTimeKind.Local).AddTicks(5358),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 10, 58, 49, 485, DateTimeKind.Local).AddTicks(3068));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "DetailVaccinationRegistration",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 15, 16, 17, 14, 760, DateTimeKind.Local).AddTicks(4816),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 10, 58, 49, 485, DateTimeKind.Local).AddTicks(2129));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "DetailMedicalRecord",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 15, 16, 17, 14, 759, DateTimeKind.Local).AddTicks(7848),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 10, 58, 49, 484, DateTimeKind.Local).AddTicks(4765));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "DetailMedicalRecord",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 15, 16, 17, 14, 759, DateTimeKind.Local).AddTicks(2784),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 10, 58, 49, 483, DateTimeKind.Local).AddTicks(8703));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "Customer",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 15, 16, 17, 14, 755, DateTimeKind.Local).AddTicks(3249),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 10, 58, 49, 473, DateTimeKind.Local).AddTicks(9312));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOfBirth",
                table: "Customer",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 15, 16, 17, 14, 755, DateTimeKind.Local).AddTicks(1120),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 10, 58, 49, 473, DateTimeKind.Local).AddTicks(6703));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Customer",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 15, 16, 17, 14, 755, DateTimeKind.Local).AddTicks(458),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 10, 58, 49, 473, DateTimeKind.Local).AddTicks(5581));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "City",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 15, 16, 17, 14, 753, DateTimeKind.Local).AddTicks(709),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 10, 58, 49, 471, DateTimeKind.Local).AddTicks(2371));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "City",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 15, 16, 17, 14, 752, DateTimeKind.Local).AddTicks(9416),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 10, 58, 49, 471, DateTimeKind.Local).AddTicks(590));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "CategoryVaccine",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 15, 16, 17, 14, 756, DateTimeKind.Local).AddTicks(330),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 10, 58, 49, 480, DateTimeKind.Local).AddTicks(3183));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "CategoryVaccine",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 15, 16, 17, 14, 755, DateTimeKind.Local).AddTicks(8336),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 10, 58, 49, 480, DateTimeKind.Local).AddTicks(903));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "CategoryPosition",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 15, 16, 17, 14, 755, DateTimeKind.Local).AddTicks(6163),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 10, 58, 49, 474, DateTimeKind.Local).AddTicks(1496));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "CategoryPosition",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 15, 16, 17, 14, 755, DateTimeKind.Local).AddTicks(5717),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 10, 58, 49, 474, DateTimeKind.Local).AddTicks(878));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "Ward",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 10, 58, 49, 472, DateTimeKind.Local).AddTicks(2851),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 15, 16, 17, 14, 753, DateTimeKind.Local).AddTicks(9069));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Ward",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 10, 58, 49, 471, DateTimeKind.Local).AddTicks(9670),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 15, 16, 17, 14, 753, DateTimeKind.Local).AddTicks(6436));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "VaccineBatch",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 10, 58, 49, 483, DateTimeKind.Local).AddTicks(6566),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 15, 16, 17, 14, 759, DateTimeKind.Local).AddTicks(727));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ManufacturingDate",
                table: "VaccineBatch",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 10, 58, 49, 482, DateTimeKind.Local).AddTicks(8567),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 15, 16, 17, 14, 758, DateTimeKind.Local).AddTicks(2910));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ExpirationDate",
                table: "VaccineBatch",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 10, 58, 49, 482, DateTimeKind.Local).AddTicks(8920),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 15, 16, 17, 14, 758, DateTimeKind.Local).AddTicks(3221));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "VaccineBatch",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 10, 58, 49, 482, DateTimeKind.Local).AddTicks(7013),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 15, 16, 17, 14, 758, DateTimeKind.Local).AddTicks(1549));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "Vaccine",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 10, 58, 49, 482, DateTimeKind.Local).AddTicks(5335),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 15, 16, 17, 14, 757, DateTimeKind.Local).AddTicks(9905));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Vaccine",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 10, 58, 49, 481, DateTimeKind.Local).AddTicks(9501),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 15, 16, 17, 14, 757, DateTimeKind.Local).AddTicks(5411));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "VaccinationRegistration",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 10, 58, 49, 486, DateTimeKind.Local).AddTicks(9522),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 15, 16, 17, 14, 761, DateTimeKind.Local).AddTicks(9135));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "VaccinationRegistration",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 10, 58, 49, 485, DateTimeKind.Local).AddTicks(9516),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 15, 16, 17, 14, 761, DateTimeKind.Local).AddTicks(328));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "VaccinationCenter",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 10, 58, 49, 481, DateTimeKind.Local).AddTicks(7885),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 15, 16, 17, 14, 757, DateTimeKind.Local).AddTicks(4052));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "VaccinationCenter",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 10, 58, 49, 481, DateTimeKind.Local).AddTicks(4472),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 15, 16, 17, 14, 757, DateTimeKind.Local).AddTicks(1377));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "User",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 10, 58, 49, 469, DateTimeKind.Local).AddTicks(9059),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 15, 16, 17, 14, 752, DateTimeKind.Local).AddTicks(1908));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "User",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 10, 58, 49, 469, DateTimeKind.Local).AddTicks(5967),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 15, 16, 17, 14, 751, DateTimeKind.Local).AddTicks(9937));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "Supplier",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 10, 58, 49, 481, DateTimeKind.Local).AddTicks(2927),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 15, 16, 17, 14, 757, DateTimeKind.Local).AddTicks(256));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Supplier",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 10, 58, 49, 481, DateTimeKind.Local).AddTicks(952),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 15, 16, 17, 14, 756, DateTimeKind.Local).AddTicks(8368));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "RefeshToken",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 10, 58, 49, 469, DateTimeKind.Local).AddTicks(4124),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 15, 16, 17, 14, 751, DateTimeKind.Local).AddTicks(8743));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "RefeshToken",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 10, 58, 49, 469, DateTimeKind.Local).AddTicks(2038),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 15, 16, 17, 14, 751, DateTimeKind.Local).AddTicks(7212));

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
                oldDefaultValue: "f2a574b3_3");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "RecoveryToken",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 10, 58, 49, 470, DateTimeKind.Local).AddTicks(4993),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 15, 16, 17, 14, 752, DateTimeKind.Local).AddTicks(6160));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "RecoveryToken",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 10, 58, 49, 470, DateTimeKind.Local).AddTicks(3017),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 15, 16, 17, 14, 752, DateTimeKind.Local).AddTicks(4844));

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
                oldDefaultValue: "0731091c_7");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "PriceVaccine",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 10, 58, 49, 480, DateTimeKind.Local).AddTicks(9383),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 15, 16, 17, 14, 756, DateTimeKind.Local).AddTicks(7225));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "PriceVaccine",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 10, 58, 49, 480, DateTimeKind.Local).AddTicks(8110),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 15, 16, 17, 14, 756, DateTimeKind.Local).AddTicks(6404));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "MedicalRecord",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 10, 58, 49, 484, DateTimeKind.Local).AddTicks(8239),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 15, 16, 17, 14, 760, DateTimeKind.Local).AddTicks(1595));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "MedicalRecord",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 10, 58, 49, 484, DateTimeKind.Local).AddTicks(6783),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 15, 16, 17, 14, 760, DateTimeKind.Local).AddTicks(621));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "InjectionChart",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 10, 58, 49, 480, DateTimeKind.Local).AddTicks(6457),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 15, 16, 17, 14, 756, DateTimeKind.Local).AddTicks(4513));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "InjectionChart",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 10, 58, 49, 480, DateTimeKind.Local).AddTicks(4825),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 15, 16, 17, 14, 756, DateTimeKind.Local).AddTicks(3422));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "Information",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 10, 58, 49, 470, DateTimeKind.Local).AddTicks(9107),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 15, 16, 17, 14, 752, DateTimeKind.Local).AddTicks(8363));

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
                oldDefaultValue: new DateTime(2023, 12, 15, 16, 17, 14, 752, DateTimeKind.Local).AddTicks(7891));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Information",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 10, 58, 49, 470, DateTimeKind.Local).AddTicks(6579),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 15, 16, 17, 14, 752, DateTimeKind.Local).AddTicks(7426));

            migrationBuilder.AlterColumn<string>(
                name: "Gender",
                table: "Employee",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOfBirth",
                table: "Employee",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 10, 58, 49, 472, DateTimeKind.Local).AddTicks(6239),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 15, 16, 17, 14, 754, DateTimeKind.Local).AddTicks(1725));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Employee",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 10, 58, 49, 472, DateTimeKind.Local).AddTicks(4740),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 15, 16, 17, 14, 754, DateTimeKind.Local).AddTicks(736));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "District",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 10, 58, 49, 471, DateTimeKind.Local).AddTicks(8037),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 15, 16, 17, 14, 753, DateTimeKind.Local).AddTicks(5018));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "District",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 10, 58, 49, 471, DateTimeKind.Local).AddTicks(4121),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 15, 16, 17, 14, 753, DateTimeKind.Local).AddTicks(2149));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "DetailVaccinationRegistration",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 10, 58, 49, 485, DateTimeKind.Local).AddTicks(6846),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 15, 16, 17, 14, 760, DateTimeKind.Local).AddTicks(8773));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateVaccination",
                table: "DetailVaccinationRegistration",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 10, 58, 49, 485, DateTimeKind.Local).AddTicks(3068),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 15, 16, 17, 14, 760, DateTimeKind.Local).AddTicks(5358));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "DetailVaccinationRegistration",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 10, 58, 49, 485, DateTimeKind.Local).AddTicks(2129),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 15, 16, 17, 14, 760, DateTimeKind.Local).AddTicks(4816));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "DetailMedicalRecord",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 10, 58, 49, 484, DateTimeKind.Local).AddTicks(4765),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 15, 16, 17, 14, 759, DateTimeKind.Local).AddTicks(7848));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "DetailMedicalRecord",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 10, 58, 49, 483, DateTimeKind.Local).AddTicks(8703),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 15, 16, 17, 14, 759, DateTimeKind.Local).AddTicks(2784));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "Customer",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 10, 58, 49, 473, DateTimeKind.Local).AddTicks(9312),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 15, 16, 17, 14, 755, DateTimeKind.Local).AddTicks(3249));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOfBirth",
                table: "Customer",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 10, 58, 49, 473, DateTimeKind.Local).AddTicks(6703),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 15, 16, 17, 14, 755, DateTimeKind.Local).AddTicks(1120));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Customer",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 10, 58, 49, 473, DateTimeKind.Local).AddTicks(5581),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 15, 16, 17, 14, 755, DateTimeKind.Local).AddTicks(458));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "City",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 10, 58, 49, 471, DateTimeKind.Local).AddTicks(2371),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 15, 16, 17, 14, 753, DateTimeKind.Local).AddTicks(709));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "City",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 10, 58, 49, 471, DateTimeKind.Local).AddTicks(590),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 15, 16, 17, 14, 752, DateTimeKind.Local).AddTicks(9416));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "CategoryVaccine",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 10, 58, 49, 480, DateTimeKind.Local).AddTicks(3183),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 15, 16, 17, 14, 756, DateTimeKind.Local).AddTicks(330));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "CategoryVaccine",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 10, 58, 49, 480, DateTimeKind.Local).AddTicks(903),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 15, 16, 17, 14, 755, DateTimeKind.Local).AddTicks(8336));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "CategoryPosition",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 10, 58, 49, 474, DateTimeKind.Local).AddTicks(1496),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 15, 16, 17, 14, 755, DateTimeKind.Local).AddTicks(6163));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "CategoryPosition",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 10, 58, 49, 474, DateTimeKind.Local).AddTicks(878),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 15, 16, 17, 14, 755, DateTimeKind.Local).AddTicks(5717));
        }
    }
}
