using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Repository.Migrations
{
    /// <inheritdoc />
    public partial class UpdateVaccineBatch2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                defaultValue: new DateTime(2023, 12, 18, 14, 30, 9, 655, DateTimeKind.Local).AddTicks(7394),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 18, 14, 27, 7, 725, DateTimeKind.Local).AddTicks(3326));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ManufacturingDate",
                table: "VaccineBatch",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 18, 14, 30, 9, 655, DateTimeKind.Local).AddTicks(1536),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 18, 14, 27, 7, 725, DateTimeKind.Local).AddTicks(390));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ExpirationDate",
                table: "VaccineBatch",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 18, 14, 30, 9, 655, DateTimeKind.Local).AddTicks(1944),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 18, 14, 27, 7, 725, DateTimeKind.Local).AddTicks(751));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "VaccineBatch",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 18, 14, 30, 9, 655, DateTimeKind.Local).AddTicks(157),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 18, 14, 27, 7, 724, DateTimeKind.Local).AddTicks(8939));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "Vaccine",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 18, 14, 30, 9, 654, DateTimeKind.Local).AddTicks(8435),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 18, 14, 27, 7, 724, DateTimeKind.Local).AddTicks(7303));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Vaccine",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 18, 14, 30, 9, 654, DateTimeKind.Local).AddTicks(2804),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 18, 14, 27, 7, 724, DateTimeKind.Local).AddTicks(1690));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "VaccinationRegistration",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 18, 14, 30, 9, 659, DateTimeKind.Local).AddTicks(4054),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 18, 14, 27, 7, 728, DateTimeKind.Local).AddTicks(8430));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "VaccinationRegistration",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 18, 14, 30, 9, 657, DateTimeKind.Local).AddTicks(9851),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 18, 14, 27, 7, 727, DateTimeKind.Local).AddTicks(4665));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "VaccinationCenter",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 18, 14, 30, 9, 654, DateTimeKind.Local).AddTicks(1213),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 18, 14, 27, 7, 724, DateTimeKind.Local).AddTicks(155));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "VaccinationCenter",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 18, 14, 30, 9, 653, DateTimeKind.Local).AddTicks(8516),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 18, 14, 27, 7, 723, DateTimeKind.Local).AddTicks(7479));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "User",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 18, 14, 30, 9, 649, DateTimeKind.Local).AddTicks(7564),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 18, 14, 27, 7, 719, DateTimeKind.Local).AddTicks(3481));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "User",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 18, 14, 30, 9, 649, DateTimeKind.Local).AddTicks(4603),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 18, 14, 27, 7, 719, DateTimeKind.Local).AddTicks(564));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "Supplier",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 18, 14, 30, 9, 653, DateTimeKind.Local).AddTicks(7022),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 18, 14, 27, 7, 723, DateTimeKind.Local).AddTicks(6045));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Supplier",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 18, 14, 30, 9, 653, DateTimeKind.Local).AddTicks(5058),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 18, 14, 27, 7, 723, DateTimeKind.Local).AddTicks(4130));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "RefeshToken",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 18, 14, 30, 9, 649, DateTimeKind.Local).AddTicks(3083),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 18, 14, 27, 7, 718, DateTimeKind.Local).AddTicks(8998));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "RefeshToken",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 18, 14, 30, 9, 649, DateTimeKind.Local).AddTicks(943),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 18, 14, 27, 7, 718, DateTimeKind.Local).AddTicks(6918));

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
                oldDefaultValue: "a174c8aa_7");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "RecoveryToken",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 18, 14, 30, 9, 650, DateTimeKind.Local).AddTicks(3265),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 18, 14, 27, 7, 719, DateTimeKind.Local).AddTicks(9175));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "RecoveryToken",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 18, 14, 30, 9, 650, DateTimeKind.Local).AddTicks(1255),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 18, 14, 27, 7, 719, DateTimeKind.Local).AddTicks(7227));

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
                oldDefaultValue: "8b7d516c_8");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "PriceVaccine",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 18, 14, 30, 9, 653, DateTimeKind.Local).AddTicks(3611),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 18, 14, 27, 7, 723, DateTimeKind.Local).AddTicks(2568));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "PriceVaccine",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 18, 14, 30, 9, 653, DateTimeKind.Local).AddTicks(2401),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 18, 14, 27, 7, 722, DateTimeKind.Local).AddTicks(8479));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "MedicalRecord",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 18, 14, 30, 9, 656, DateTimeKind.Local).AddTicks(8933),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 18, 14, 27, 7, 726, DateTimeKind.Local).AddTicks(4222));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "MedicalRecord",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 18, 14, 30, 9, 656, DateTimeKind.Local).AddTicks(7552),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 18, 14, 27, 7, 726, DateTimeKind.Local).AddTicks(2835));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "InjectionChart",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 18, 14, 30, 9, 653, DateTimeKind.Local).AddTicks(782),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 18, 14, 27, 7, 722, DateTimeKind.Local).AddTicks(6945));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "InjectionChart",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 18, 14, 30, 9, 652, DateTimeKind.Local).AddTicks(9238),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 18, 14, 27, 7, 722, DateTimeKind.Local).AddTicks(4233));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOfBirth",
                table: "Employee",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 18, 14, 30, 9, 650, DateTimeKind.Local).AddTicks(8001),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 18, 14, 27, 7, 720, DateTimeKind.Local).AddTicks(2749));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Employee",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 18, 14, 30, 9, 650, DateTimeKind.Local).AddTicks(5858),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 18, 14, 27, 7, 720, DateTimeKind.Local).AddTicks(1062));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "DetailVaccinationRegistration",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 18, 14, 30, 9, 657, DateTimeKind.Local).AddTicks(8025),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 18, 14, 27, 7, 727, DateTimeKind.Local).AddTicks(2647));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateVaccination",
                table: "DetailVaccinationRegistration",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 18, 14, 30, 9, 657, DateTimeKind.Local).AddTicks(4108),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 18, 14, 27, 7, 726, DateTimeKind.Local).AddTicks(8769));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "DetailVaccinationRegistration",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 18, 14, 30, 9, 657, DateTimeKind.Local).AddTicks(3152),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 18, 14, 27, 7, 726, DateTimeKind.Local).AddTicks(7888));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "DetailMedicalRecord",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 18, 14, 30, 9, 656, DateTimeKind.Local).AddTicks(5513),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 18, 14, 27, 7, 726, DateTimeKind.Local).AddTicks(979));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "DetailMedicalRecord",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 18, 14, 30, 9, 655, DateTimeKind.Local).AddTicks(9272),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 18, 14, 27, 7, 725, DateTimeKind.Local).AddTicks(5220));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "Customer",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 18, 14, 30, 9, 652, DateTimeKind.Local).AddTicks(1514),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 18, 14, 27, 7, 721, DateTimeKind.Local).AddTicks(6065));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOfBirth",
                table: "Customer",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 18, 14, 30, 9, 651, DateTimeKind.Local).AddTicks(9264),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 18, 14, 27, 7, 721, DateTimeKind.Local).AddTicks(3831));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Customer",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 18, 14, 30, 9, 651, DateTimeKind.Local).AddTicks(8149),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 18, 14, 27, 7, 721, DateTimeKind.Local).AddTicks(2711));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "CategoryVaccine",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 18, 14, 30, 9, 652, DateTimeKind.Local).AddTicks(7634),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 18, 14, 27, 7, 722, DateTimeKind.Local).AddTicks(2038));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "CategoryVaccine",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 18, 14, 30, 9, 652, DateTimeKind.Local).AddTicks(5906),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 18, 14, 27, 7, 722, DateTimeKind.Local).AddTicks(312));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "CategoryPosition",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 18, 14, 30, 9, 652, DateTimeKind.Local).AddTicks(4186),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 18, 14, 27, 7, 721, DateTimeKind.Local).AddTicks(8699));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "CategoryPosition",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 18, 14, 30, 9, 652, DateTimeKind.Local).AddTicks(3001),
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                oldDefaultValue: new DateTime(2023, 12, 18, 14, 30, 9, 655, DateTimeKind.Local).AddTicks(7394));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ManufacturingDate",
                table: "VaccineBatch",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 18, 14, 27, 7, 725, DateTimeKind.Local).AddTicks(390),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 18, 14, 30, 9, 655, DateTimeKind.Local).AddTicks(1536));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ExpirationDate",
                table: "VaccineBatch",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 18, 14, 27, 7, 725, DateTimeKind.Local).AddTicks(751),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 18, 14, 30, 9, 655, DateTimeKind.Local).AddTicks(1944));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "VaccineBatch",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 18, 14, 27, 7, 724, DateTimeKind.Local).AddTicks(8939),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 18, 14, 30, 9, 655, DateTimeKind.Local).AddTicks(157));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "Vaccine",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 18, 14, 27, 7, 724, DateTimeKind.Local).AddTicks(7303),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 18, 14, 30, 9, 654, DateTimeKind.Local).AddTicks(8435));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Vaccine",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 18, 14, 27, 7, 724, DateTimeKind.Local).AddTicks(1690),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 18, 14, 30, 9, 654, DateTimeKind.Local).AddTicks(2804));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "VaccinationRegistration",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 18, 14, 27, 7, 728, DateTimeKind.Local).AddTicks(8430),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 18, 14, 30, 9, 659, DateTimeKind.Local).AddTicks(4054));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "VaccinationRegistration",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 18, 14, 27, 7, 727, DateTimeKind.Local).AddTicks(4665),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 18, 14, 30, 9, 657, DateTimeKind.Local).AddTicks(9851));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "VaccinationCenter",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 18, 14, 27, 7, 724, DateTimeKind.Local).AddTicks(155),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 18, 14, 30, 9, 654, DateTimeKind.Local).AddTicks(1213));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "VaccinationCenter",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 18, 14, 27, 7, 723, DateTimeKind.Local).AddTicks(7479),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 18, 14, 30, 9, 653, DateTimeKind.Local).AddTicks(8516));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "User",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 18, 14, 27, 7, 719, DateTimeKind.Local).AddTicks(3481),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 18, 14, 30, 9, 649, DateTimeKind.Local).AddTicks(7564));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "User",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 18, 14, 27, 7, 719, DateTimeKind.Local).AddTicks(564),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 18, 14, 30, 9, 649, DateTimeKind.Local).AddTicks(4603));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "Supplier",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 18, 14, 27, 7, 723, DateTimeKind.Local).AddTicks(6045),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 18, 14, 30, 9, 653, DateTimeKind.Local).AddTicks(7022));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Supplier",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 18, 14, 27, 7, 723, DateTimeKind.Local).AddTicks(4130),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 18, 14, 30, 9, 653, DateTimeKind.Local).AddTicks(5058));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "RefeshToken",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 18, 14, 27, 7, 718, DateTimeKind.Local).AddTicks(8998),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 18, 14, 30, 9, 649, DateTimeKind.Local).AddTicks(3083));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "RefeshToken",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 18, 14, 27, 7, 718, DateTimeKind.Local).AddTicks(6918),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 18, 14, 30, 9, 649, DateTimeKind.Local).AddTicks(943));

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
                oldDefaultValue: "66ccc48f_4");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "RecoveryToken",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 18, 14, 27, 7, 719, DateTimeKind.Local).AddTicks(9175),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 18, 14, 30, 9, 650, DateTimeKind.Local).AddTicks(3265));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "RecoveryToken",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 18, 14, 27, 7, 719, DateTimeKind.Local).AddTicks(7227),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 18, 14, 30, 9, 650, DateTimeKind.Local).AddTicks(1255));

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
                oldDefaultValue: "dcb0ebe2_9");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "PriceVaccine",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 18, 14, 27, 7, 723, DateTimeKind.Local).AddTicks(2568),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 18, 14, 30, 9, 653, DateTimeKind.Local).AddTicks(3611));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "PriceVaccine",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 18, 14, 27, 7, 722, DateTimeKind.Local).AddTicks(8479),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 18, 14, 30, 9, 653, DateTimeKind.Local).AddTicks(2401));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "MedicalRecord",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 18, 14, 27, 7, 726, DateTimeKind.Local).AddTicks(4222),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 18, 14, 30, 9, 656, DateTimeKind.Local).AddTicks(8933));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "MedicalRecord",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 18, 14, 27, 7, 726, DateTimeKind.Local).AddTicks(2835),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 18, 14, 30, 9, 656, DateTimeKind.Local).AddTicks(7552));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "InjectionChart",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 18, 14, 27, 7, 722, DateTimeKind.Local).AddTicks(6945),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 18, 14, 30, 9, 653, DateTimeKind.Local).AddTicks(782));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "InjectionChart",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 18, 14, 27, 7, 722, DateTimeKind.Local).AddTicks(4233),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 18, 14, 30, 9, 652, DateTimeKind.Local).AddTicks(9238));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOfBirth",
                table: "Employee",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 18, 14, 27, 7, 720, DateTimeKind.Local).AddTicks(2749),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 18, 14, 30, 9, 650, DateTimeKind.Local).AddTicks(8001));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Employee",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 18, 14, 27, 7, 720, DateTimeKind.Local).AddTicks(1062),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 18, 14, 30, 9, 650, DateTimeKind.Local).AddTicks(5858));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "DetailVaccinationRegistration",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 18, 14, 27, 7, 727, DateTimeKind.Local).AddTicks(2647),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 18, 14, 30, 9, 657, DateTimeKind.Local).AddTicks(8025));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateVaccination",
                table: "DetailVaccinationRegistration",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 18, 14, 27, 7, 726, DateTimeKind.Local).AddTicks(8769),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 18, 14, 30, 9, 657, DateTimeKind.Local).AddTicks(4108));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "DetailVaccinationRegistration",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 18, 14, 27, 7, 726, DateTimeKind.Local).AddTicks(7888),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 18, 14, 30, 9, 657, DateTimeKind.Local).AddTicks(3152));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "DetailMedicalRecord",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 18, 14, 27, 7, 726, DateTimeKind.Local).AddTicks(979),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 18, 14, 30, 9, 656, DateTimeKind.Local).AddTicks(5513));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "DetailMedicalRecord",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 18, 14, 27, 7, 725, DateTimeKind.Local).AddTicks(5220),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 18, 14, 30, 9, 655, DateTimeKind.Local).AddTicks(9272));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "Customer",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 18, 14, 27, 7, 721, DateTimeKind.Local).AddTicks(6065),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 18, 14, 30, 9, 652, DateTimeKind.Local).AddTicks(1514));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOfBirth",
                table: "Customer",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 18, 14, 27, 7, 721, DateTimeKind.Local).AddTicks(3831),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 18, 14, 30, 9, 651, DateTimeKind.Local).AddTicks(9264));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Customer",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 18, 14, 27, 7, 721, DateTimeKind.Local).AddTicks(2711),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 18, 14, 30, 9, 651, DateTimeKind.Local).AddTicks(8149));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "CategoryVaccine",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 18, 14, 27, 7, 722, DateTimeKind.Local).AddTicks(2038),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 18, 14, 30, 9, 652, DateTimeKind.Local).AddTicks(7634));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "CategoryVaccine",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 18, 14, 27, 7, 722, DateTimeKind.Local).AddTicks(312),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 18, 14, 30, 9, 652, DateTimeKind.Local).AddTicks(5906));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "CategoryPosition",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 18, 14, 27, 7, 721, DateTimeKind.Local).AddTicks(8699),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 18, 14, 30, 9, 652, DateTimeKind.Local).AddTicks(4186));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "CategoryPosition",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 18, 14, 27, 7, 721, DateTimeKind.Local).AddTicks(7519),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 18, 14, 30, 9, 652, DateTimeKind.Local).AddTicks(3001));

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
    }
}
