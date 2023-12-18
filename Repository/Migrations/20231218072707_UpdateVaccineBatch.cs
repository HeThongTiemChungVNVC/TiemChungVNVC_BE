using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Repository.Migrations
{
    /// <inheritdoc />
    public partial class UpdateVaccineBatch : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PriceVaccine_VaccineBatch_IdVaccineBacth",
                table: "PriceVaccine");

            migrationBuilder.DropIndex(
                name: "IX_PriceVaccine_IdVaccineBacth",
                table: "PriceVaccine");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "VaccineBatch",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 18, 14, 27, 7, 725, DateTimeKind.Local).AddTicks(3326),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 18, 4, 27, 46, 290, DateTimeKind.Local).AddTicks(7867));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ManufacturingDate",
                table: "VaccineBatch",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 18, 14, 27, 7, 725, DateTimeKind.Local).AddTicks(390),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 18, 4, 27, 46, 290, DateTimeKind.Local).AddTicks(3410));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ExpirationDate",
                table: "VaccineBatch",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 18, 14, 27, 7, 725, DateTimeKind.Local).AddTicks(751),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 18, 4, 27, 46, 290, DateTimeKind.Local).AddTicks(3690));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "VaccineBatch",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 18, 14, 27, 7, 724, DateTimeKind.Local).AddTicks(8939),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 18, 4, 27, 46, 290, DateTimeKind.Local).AddTicks(2422));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "Vaccine",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 18, 14, 27, 7, 724, DateTimeKind.Local).AddTicks(7303),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 18, 4, 27, 46, 290, DateTimeKind.Local).AddTicks(854));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Vaccine",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 18, 14, 27, 7, 724, DateTimeKind.Local).AddTicks(1690),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 18, 4, 27, 46, 289, DateTimeKind.Local).AddTicks(6011));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "VaccinationRegistration",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 18, 14, 27, 7, 728, DateTimeKind.Local).AddTicks(8430),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 18, 4, 27, 46, 293, DateTimeKind.Local).AddTicks(3642));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "VaccinationRegistration",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 18, 14, 27, 7, 727, DateTimeKind.Local).AddTicks(4665),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 18, 4, 27, 46, 292, DateTimeKind.Local).AddTicks(4296));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "VaccinationCenter",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 18, 14, 27, 7, 724, DateTimeKind.Local).AddTicks(155),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 18, 4, 27, 46, 289, DateTimeKind.Local).AddTicks(4804));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "VaccinationCenter",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 18, 14, 27, 7, 723, DateTimeKind.Local).AddTicks(7479),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 18, 4, 27, 46, 289, DateTimeKind.Local).AddTicks(2777));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "User",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 18, 14, 27, 7, 719, DateTimeKind.Local).AddTicks(3481),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 18, 4, 27, 46, 286, DateTimeKind.Local).AddTicks(866));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "User",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 18, 14, 27, 7, 719, DateTimeKind.Local).AddTicks(564),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 18, 4, 27, 46, 285, DateTimeKind.Local).AddTicks(8477));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "Supplier",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 18, 14, 27, 7, 723, DateTimeKind.Local).AddTicks(6045),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 18, 4, 27, 46, 289, DateTimeKind.Local).AddTicks(1703));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Supplier",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 18, 14, 27, 7, 723, DateTimeKind.Local).AddTicks(4130),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 18, 4, 27, 46, 289, DateTimeKind.Local).AddTicks(206));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "RefeshToken",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 18, 14, 27, 7, 718, DateTimeKind.Local).AddTicks(8998),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 18, 4, 27, 46, 285, DateTimeKind.Local).AddTicks(7158));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "RefeshToken",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 18, 14, 27, 7, 718, DateTimeKind.Local).AddTicks(6918),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 18, 4, 27, 46, 285, DateTimeKind.Local).AddTicks(5451));

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "RefeshToken",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "a174c8aa_7",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldDefaultValue: "259a4950_9");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "RecoveryToken",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 18, 14, 27, 7, 719, DateTimeKind.Local).AddTicks(9175),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 18, 4, 27, 46, 286, DateTimeKind.Local).AddTicks(5070));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "RecoveryToken",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 18, 14, 27, 7, 719, DateTimeKind.Local).AddTicks(7227),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 18, 4, 27, 46, 286, DateTimeKind.Local).AddTicks(3756));

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "RecoveryToken",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "8b7d516c_8",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldDefaultValue: "6f002573_6");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "PriceVaccine",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 18, 14, 27, 7, 723, DateTimeKind.Local).AddTicks(2568),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 18, 4, 27, 46, 288, DateTimeKind.Local).AddTicks(9149));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "PriceVaccine",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 18, 14, 27, 7, 722, DateTimeKind.Local).AddTicks(8479),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 18, 4, 27, 46, 288, DateTimeKind.Local).AddTicks(8401));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "MedicalRecord",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 18, 14, 27, 7, 726, DateTimeKind.Local).AddTicks(4222),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 18, 4, 27, 46, 291, DateTimeKind.Local).AddTicks(6158));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "MedicalRecord",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 18, 14, 27, 7, 726, DateTimeKind.Local).AddTicks(2835),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 18, 4, 27, 46, 291, DateTimeKind.Local).AddTicks(5255));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "InjectionChart",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 18, 14, 27, 7, 722, DateTimeKind.Local).AddTicks(6945),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 18, 4, 27, 46, 288, DateTimeKind.Local).AddTicks(7216));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "InjectionChart",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 18, 14, 27, 7, 722, DateTimeKind.Local).AddTicks(4233),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 18, 4, 27, 46, 288, DateTimeKind.Local).AddTicks(6152));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOfBirth",
                table: "Employee",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 18, 14, 27, 7, 720, DateTimeKind.Local).AddTicks(2749),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 18, 4, 27, 46, 286, DateTimeKind.Local).AddTicks(7928));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Employee",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 18, 14, 27, 7, 720, DateTimeKind.Local).AddTicks(1062),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 18, 4, 27, 46, 286, DateTimeKind.Local).AddTicks(6580));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "DetailVaccinationRegistration",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 18, 14, 27, 7, 727, DateTimeKind.Local).AddTicks(2647),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 18, 4, 27, 46, 292, DateTimeKind.Local).AddTicks(2885));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateVaccination",
                table: "DetailVaccinationRegistration",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 18, 14, 27, 7, 726, DateTimeKind.Local).AddTicks(8769),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 18, 4, 27, 46, 291, DateTimeKind.Local).AddTicks(9629));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "DetailVaccinationRegistration",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 18, 14, 27, 7, 726, DateTimeKind.Local).AddTicks(7888),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 18, 4, 27, 46, 291, DateTimeKind.Local).AddTicks(9160));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "DetailMedicalRecord",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 18, 14, 27, 7, 726, DateTimeKind.Local).AddTicks(979),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 18, 4, 27, 46, 291, DateTimeKind.Local).AddTicks(3854));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "DetailMedicalRecord",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 18, 14, 27, 7, 725, DateTimeKind.Local).AddTicks(5220),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 18, 4, 27, 46, 290, DateTimeKind.Local).AddTicks(9347));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "Customer",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 18, 14, 27, 7, 721, DateTimeKind.Local).AddTicks(6065),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 18, 4, 27, 46, 287, DateTimeKind.Local).AddTicks(8513));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOfBirth",
                table: "Customer",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 18, 14, 27, 7, 721, DateTimeKind.Local).AddTicks(3831),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 18, 4, 27, 46, 287, DateTimeKind.Local).AddTicks(6942));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Customer",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 18, 14, 27, 7, 721, DateTimeKind.Local).AddTicks(2711),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 18, 4, 27, 46, 287, DateTimeKind.Local).AddTicks(6242));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "CategoryVaccine",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 18, 14, 27, 7, 722, DateTimeKind.Local).AddTicks(2038),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 18, 4, 27, 46, 288, DateTimeKind.Local).AddTicks(4295));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "CategoryVaccine",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 18, 14, 27, 7, 722, DateTimeKind.Local).AddTicks(312),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 18, 4, 27, 46, 288, DateTimeKind.Local).AddTicks(2598));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "CategoryPosition",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 18, 14, 27, 7, 721, DateTimeKind.Local).AddTicks(8699),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 18, 4, 27, 46, 288, DateTimeKind.Local).AddTicks(417));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "CategoryPosition",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 18, 14, 27, 7, 721, DateTimeKind.Local).AddTicks(7519),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 18, 4, 27, 46, 287, DateTimeKind.Local).AddTicks(9711));

            migrationBuilder.CreateIndex(
                name: "IX_PriceVaccine_IdVaccineBacth",
                table: "PriceVaccine",
                column: "IdVaccineBacth");

            migrationBuilder.AddForeignKey(
                name: "fk_price_batch",
                table: "PriceVaccine",
                column: "IdVaccineBacth",
                principalTable: "VaccineBatch",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_price_batch",
                table: "PriceVaccine");

            migrationBuilder.DropIndex(
                name: "IX_PriceVaccine_IdVaccineBacth",
                table: "PriceVaccine");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "VaccineBatch",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 18, 4, 27, 46, 290, DateTimeKind.Local).AddTicks(7867),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 18, 14, 27, 7, 725, DateTimeKind.Local).AddTicks(3326));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ManufacturingDate",
                table: "VaccineBatch",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 18, 4, 27, 46, 290, DateTimeKind.Local).AddTicks(3410),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 18, 14, 27, 7, 725, DateTimeKind.Local).AddTicks(390));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ExpirationDate",
                table: "VaccineBatch",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 18, 4, 27, 46, 290, DateTimeKind.Local).AddTicks(3690),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 18, 14, 27, 7, 725, DateTimeKind.Local).AddTicks(751));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "VaccineBatch",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 18, 4, 27, 46, 290, DateTimeKind.Local).AddTicks(2422),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 18, 14, 27, 7, 724, DateTimeKind.Local).AddTicks(8939));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "Vaccine",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 18, 4, 27, 46, 290, DateTimeKind.Local).AddTicks(854),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 18, 14, 27, 7, 724, DateTimeKind.Local).AddTicks(7303));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Vaccine",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 18, 4, 27, 46, 289, DateTimeKind.Local).AddTicks(6011),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 18, 14, 27, 7, 724, DateTimeKind.Local).AddTicks(1690));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "VaccinationRegistration",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 18, 4, 27, 46, 293, DateTimeKind.Local).AddTicks(3642),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 18, 14, 27, 7, 728, DateTimeKind.Local).AddTicks(8430));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "VaccinationRegistration",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 18, 4, 27, 46, 292, DateTimeKind.Local).AddTicks(4296),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 18, 14, 27, 7, 727, DateTimeKind.Local).AddTicks(4665));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "VaccinationCenter",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 18, 4, 27, 46, 289, DateTimeKind.Local).AddTicks(4804),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 18, 14, 27, 7, 724, DateTimeKind.Local).AddTicks(155));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "VaccinationCenter",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 18, 4, 27, 46, 289, DateTimeKind.Local).AddTicks(2777),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 18, 14, 27, 7, 723, DateTimeKind.Local).AddTicks(7479));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "User",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 18, 4, 27, 46, 286, DateTimeKind.Local).AddTicks(866),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 18, 14, 27, 7, 719, DateTimeKind.Local).AddTicks(3481));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "User",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 18, 4, 27, 46, 285, DateTimeKind.Local).AddTicks(8477),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 18, 14, 27, 7, 719, DateTimeKind.Local).AddTicks(564));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "Supplier",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 18, 4, 27, 46, 289, DateTimeKind.Local).AddTicks(1703),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 18, 14, 27, 7, 723, DateTimeKind.Local).AddTicks(6045));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Supplier",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 18, 4, 27, 46, 289, DateTimeKind.Local).AddTicks(206),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 18, 14, 27, 7, 723, DateTimeKind.Local).AddTicks(4130));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "RefeshToken",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 18, 4, 27, 46, 285, DateTimeKind.Local).AddTicks(7158),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 18, 14, 27, 7, 718, DateTimeKind.Local).AddTicks(8998));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "RefeshToken",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 18, 4, 27, 46, 285, DateTimeKind.Local).AddTicks(5451),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 18, 14, 27, 7, 718, DateTimeKind.Local).AddTicks(6918));

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "RefeshToken",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "259a4950_9",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldDefaultValue: "a174c8aa_7");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "RecoveryToken",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 18, 4, 27, 46, 286, DateTimeKind.Local).AddTicks(5070),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 18, 14, 27, 7, 719, DateTimeKind.Local).AddTicks(9175));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "RecoveryToken",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 18, 4, 27, 46, 286, DateTimeKind.Local).AddTicks(3756),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 18, 14, 27, 7, 719, DateTimeKind.Local).AddTicks(7227));

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "RecoveryToken",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "6f002573_6",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldDefaultValue: "8b7d516c_8");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "PriceVaccine",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 18, 4, 27, 46, 288, DateTimeKind.Local).AddTicks(9149),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 18, 14, 27, 7, 723, DateTimeKind.Local).AddTicks(2568));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "PriceVaccine",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 18, 4, 27, 46, 288, DateTimeKind.Local).AddTicks(8401),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 18, 14, 27, 7, 722, DateTimeKind.Local).AddTicks(8479));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "MedicalRecord",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 18, 4, 27, 46, 291, DateTimeKind.Local).AddTicks(6158),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 18, 14, 27, 7, 726, DateTimeKind.Local).AddTicks(4222));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "MedicalRecord",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 18, 4, 27, 46, 291, DateTimeKind.Local).AddTicks(5255),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 18, 14, 27, 7, 726, DateTimeKind.Local).AddTicks(2835));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "InjectionChart",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 18, 4, 27, 46, 288, DateTimeKind.Local).AddTicks(7216),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 18, 14, 27, 7, 722, DateTimeKind.Local).AddTicks(6945));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "InjectionChart",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 18, 4, 27, 46, 288, DateTimeKind.Local).AddTicks(6152),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 18, 14, 27, 7, 722, DateTimeKind.Local).AddTicks(4233));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOfBirth",
                table: "Employee",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 18, 4, 27, 46, 286, DateTimeKind.Local).AddTicks(7928),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 18, 14, 27, 7, 720, DateTimeKind.Local).AddTicks(2749));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Employee",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 18, 4, 27, 46, 286, DateTimeKind.Local).AddTicks(6580),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 18, 14, 27, 7, 720, DateTimeKind.Local).AddTicks(1062));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "DetailVaccinationRegistration",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 18, 4, 27, 46, 292, DateTimeKind.Local).AddTicks(2885),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 18, 14, 27, 7, 727, DateTimeKind.Local).AddTicks(2647));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateVaccination",
                table: "DetailVaccinationRegistration",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 18, 4, 27, 46, 291, DateTimeKind.Local).AddTicks(9629),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 18, 14, 27, 7, 726, DateTimeKind.Local).AddTicks(8769));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "DetailVaccinationRegistration",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 18, 4, 27, 46, 291, DateTimeKind.Local).AddTicks(9160),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 18, 14, 27, 7, 726, DateTimeKind.Local).AddTicks(7888));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "DetailMedicalRecord",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 18, 4, 27, 46, 291, DateTimeKind.Local).AddTicks(3854),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 18, 14, 27, 7, 726, DateTimeKind.Local).AddTicks(979));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "DetailMedicalRecord",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 18, 4, 27, 46, 290, DateTimeKind.Local).AddTicks(9347),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 18, 14, 27, 7, 725, DateTimeKind.Local).AddTicks(5220));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "Customer",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 18, 4, 27, 46, 287, DateTimeKind.Local).AddTicks(8513),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 18, 14, 27, 7, 721, DateTimeKind.Local).AddTicks(6065));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOfBirth",
                table: "Customer",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 18, 4, 27, 46, 287, DateTimeKind.Local).AddTicks(6942),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 18, 14, 27, 7, 721, DateTimeKind.Local).AddTicks(3831));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Customer",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 18, 4, 27, 46, 287, DateTimeKind.Local).AddTicks(6242),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 18, 14, 27, 7, 721, DateTimeKind.Local).AddTicks(2711));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "CategoryVaccine",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 18, 4, 27, 46, 288, DateTimeKind.Local).AddTicks(4295),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 18, 14, 27, 7, 722, DateTimeKind.Local).AddTicks(2038));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "CategoryVaccine",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 18, 4, 27, 46, 288, DateTimeKind.Local).AddTicks(2598),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 18, 14, 27, 7, 722, DateTimeKind.Local).AddTicks(312));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "CategoryPosition",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 18, 4, 27, 46, 288, DateTimeKind.Local).AddTicks(417),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 18, 14, 27, 7, 721, DateTimeKind.Local).AddTicks(8699));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "CategoryPosition",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 18, 4, 27, 46, 287, DateTimeKind.Local).AddTicks(9711),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 18, 14, 27, 7, 721, DateTimeKind.Local).AddTicks(7519));

            migrationBuilder.CreateIndex(
                name: "IX_PriceVaccine_IdVaccineBacth",
                table: "PriceVaccine",
                column: "IdVaccineBacth",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_PriceVaccine_VaccineBatch_IdVaccineBacth",
                table: "PriceVaccine",
                column: "IdVaccineBacth",
                principalTable: "VaccineBatch",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
