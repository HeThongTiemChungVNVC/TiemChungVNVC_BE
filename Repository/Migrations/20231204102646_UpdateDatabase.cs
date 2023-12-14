using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Repository.Migrations
{
    /// <inheritdoc />
    public partial class UpdateDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Ward",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 4, 17, 26, 46, 598, DateTimeKind.Local).AddTicks(7126),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 11, 25, 14, 22, 47, 873, DateTimeKind.Local).AddTicks(5690));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "User",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 4, 17, 26, 46, 596, DateTimeKind.Local).AddTicks(9303),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 11, 25, 14, 22, 47, 872, DateTimeKind.Local).AddTicks(1774));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "RefeshToken",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 4, 17, 26, 46, 596, DateTimeKind.Local).AddTicks(6460),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 11, 25, 14, 22, 47, 871, DateTimeKind.Local).AddTicks(9212));

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "RefeshToken",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "bb6302db_b",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldDefaultValue: "5819aa18_b");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "RecoveryToken",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 4, 17, 26, 46, 597, DateTimeKind.Local).AddTicks(4349),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 11, 25, 14, 22, 47, 872, DateTimeKind.Local).AddTicks(6142));

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "RecoveryToken",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "1657c5d6_a",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldDefaultValue: "26f3030f_0");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Dob",
                table: "Information",
                type: "datetime2",
                maxLength: 15,
                nullable: false,
                defaultValue: new DateTime(2023, 12, 4, 17, 26, 46, 597, DateTimeKind.Local).AddTicks(7815),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldMaxLength: 15,
                oldDefaultValue: new DateTime(2023, 11, 25, 14, 22, 47, 872, DateTimeKind.Local).AddTicks(9048));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Information",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 4, 17, 26, 46, 597, DateTimeKind.Local).AddTicks(7113),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 11, 25, 14, 22, 47, 872, DateTimeKind.Local).AddTicks(8467));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "District",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 4, 17, 26, 46, 598, DateTimeKind.Local).AddTicks(2222),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 11, 25, 14, 22, 47, 873, DateTimeKind.Local).AddTicks(2233));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "City",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 4, 17, 26, 46, 597, DateTimeKind.Local).AddTicks(9535),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 11, 25, 14, 22, 47, 873, DateTimeKind.Local).AddTicks(359));

            migrationBuilder.CreateTable(
                name: "CategoryPosition",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 12, 4, 17, 26, 46, 600, DateTimeKind.Local).AddTicks(2971)),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true, defaultValue: "admin")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryPosition", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CategoryVaccine",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 12, 4, 17, 26, 46, 600, DateTimeKind.Local).AddTicks(4943)),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true, defaultValue: "admin")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryVaccine", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 12, 4, 17, 26, 46, 600, DateTimeKind.Local).AddTicks(989)),
                    Gender = table.Column<bool>(type: "bit", maxLength: 10, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 12, 4, 17, 26, 46, 599, DateTimeKind.Local).AddTicks(9863)),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true, defaultValue: "admin")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Supplier",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    NameSupplier = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 12, 4, 17, 26, 46, 601, DateTimeKind.Local).AddTicks(4201)),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true, defaultValue: "admin")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Supplier", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "VaccinationCenter",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CenterName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OpenTime = table.Column<TimeSpan>(type: "time", nullable: false),
                    CloseTime = table.Column<TimeSpan>(type: "time", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 12, 4, 17, 26, 46, 601, DateTimeKind.Local).AddTicks(6904)),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true, defaultValue: "admin")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VaccinationCenter", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Employee",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    IdCategoryPosition = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Position = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 12, 4, 17, 26, 46, 599, DateTimeKind.Local).AddTicks(4151)),
                    Fk_employee_position = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 12, 4, 17, 26, 46, 599, DateTimeKind.Local).AddTicks(1132)),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true, defaultValue: "admin")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee", x => new { x.Id, x.IdCategoryPosition });
                    table.ForeignKey(
                        name: "FK_Employee_CategoryPosition_Fk_employee_position",
                        column: x => x.Fk_employee_position,
                        principalTable: "CategoryPosition",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Vaccine",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Prevention = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NameVaccine = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InjectionSite = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Condition = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdCategoryVaccine = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CategoryVaccineId = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 12, 4, 17, 26, 46, 601, DateTimeKind.Local).AddTicks(8966)),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true, defaultValue: "admin")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vaccine", x => x.Id);
                    table.ForeignKey(
                        name: "Fk_Category_Vaccine",
                        column: x => x.CategoryVaccineId,
                        principalTable: "CategoryVaccine",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "InjectionChart",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Doses = table.Column<int>(type: "int", nullable: false),
                    Interval = table.Column<int>(type: "int", nullable: false),
                    Reminder = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    IdVaccine = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 12, 4, 17, 26, 46, 600, DateTimeKind.Local).AddTicks(7539)),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true, defaultValue: "admin")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InjectionChart", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InjectionChart_Vaccine_IdVaccine",
                        column: x => x.IdVaccine,
                        principalTable: "Vaccine",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "VaccineBatch",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CodeBatch = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ManufacturingDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 12, 4, 17, 26, 46, 603, DateTimeKind.Local).AddTicks(760)),
                    ExpirationDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 12, 4, 17, 26, 46, 603, DateTimeKind.Local).AddTicks(1129)),
                    QuantityOfVaccine = table.Column<int>(type: "int", nullable: false),
                    IdVaccine = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    VaccineId = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    IdSupplier = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    SupplierId = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 12, 4, 17, 26, 46, 602, DateTimeKind.Local).AddTicks(9558)),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true, defaultValue: "admin")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VaccineBatch", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VaccineBatch_Vaccine_VaccineId",
                        column: x => x.VaccineId,
                        principalTable: "Vaccine",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_batch_supplier",
                        column: x => x.SupplierId,
                        principalTable: "Supplier",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PriceVaccine",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    IdVaccine = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CostPrice = table.Column<float>(type: "real", nullable: false),
                    RetailPrice = table.Column<float>(type: "real", nullable: false),
                    PreOrderPrice = table.Column<float>(type: "real", nullable: false),
                    IdVaccineBacth = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 12, 4, 17, 26, 46, 600, DateTimeKind.Local).AddTicks(9905)),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true, defaultValue: "admin")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PriceVaccine", x => new { x.Id, x.IdVaccine });
                    table.ForeignKey(
                        name: "FK_PriceVaccine_VaccineBatch_IdVaccineBacth",
                        column: x => x.IdVaccineBacth,
                        principalTable: "VaccineBatch",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PriceVaccine_Vaccine_IdVaccine",
                        column: x => x.IdVaccine,
                        principalTable: "Vaccine",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Employee_Fk_employee_position",
                table: "Employee",
                column: "Fk_employee_position");

            migrationBuilder.CreateIndex(
                name: "IX_InjectionChart_IdVaccine",
                table: "InjectionChart",
                column: "IdVaccine",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PriceVaccine_IdVaccine",
                table: "PriceVaccine",
                column: "IdVaccine",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PriceVaccine_IdVaccineBacth",
                table: "PriceVaccine",
                column: "IdVaccineBacth",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Vaccine_CategoryVaccineId",
                table: "Vaccine",
                column: "CategoryVaccineId");

            migrationBuilder.CreateIndex(
                name: "IX_VaccineBatch_SupplierId",
                table: "VaccineBatch",
                column: "SupplierId");

            migrationBuilder.CreateIndex(
                name: "IX_VaccineBatch_VaccineId",
                table: "VaccineBatch",
                column: "VaccineId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customer");

            migrationBuilder.DropTable(
                name: "Employee");

            migrationBuilder.DropTable(
                name: "InjectionChart");

            migrationBuilder.DropTable(
                name: "PriceVaccine");

            migrationBuilder.DropTable(
                name: "VaccinationCenter");

            migrationBuilder.DropTable(
                name: "CategoryPosition");

            migrationBuilder.DropTable(
                name: "VaccineBatch");

            migrationBuilder.DropTable(
                name: "Vaccine");

            migrationBuilder.DropTable(
                name: "Supplier");

            migrationBuilder.DropTable(
                name: "CategoryVaccine");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Ward",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 25, 14, 22, 47, 873, DateTimeKind.Local).AddTicks(5690),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 4, 17, 26, 46, 598, DateTimeKind.Local).AddTicks(7126));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "User",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 25, 14, 22, 47, 872, DateTimeKind.Local).AddTicks(1774),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 4, 17, 26, 46, 596, DateTimeKind.Local).AddTicks(9303));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "RefeshToken",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 25, 14, 22, 47, 871, DateTimeKind.Local).AddTicks(9212),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 4, 17, 26, 46, 596, DateTimeKind.Local).AddTicks(6460));

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "RefeshToken",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "5819aa18_b",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldDefaultValue: "bb6302db_b");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "RecoveryToken",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 25, 14, 22, 47, 872, DateTimeKind.Local).AddTicks(6142),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 4, 17, 26, 46, 597, DateTimeKind.Local).AddTicks(4349));

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "RecoveryToken",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "26f3030f_0",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldDefaultValue: "1657c5d6_a");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Dob",
                table: "Information",
                type: "datetime2",
                maxLength: 15,
                nullable: false,
                defaultValue: new DateTime(2023, 11, 25, 14, 22, 47, 872, DateTimeKind.Local).AddTicks(9048),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldMaxLength: 15,
                oldDefaultValue: new DateTime(2023, 12, 4, 17, 26, 46, 597, DateTimeKind.Local).AddTicks(7815));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Information",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 25, 14, 22, 47, 872, DateTimeKind.Local).AddTicks(8467),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 4, 17, 26, 46, 597, DateTimeKind.Local).AddTicks(7113));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "District",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 25, 14, 22, 47, 873, DateTimeKind.Local).AddTicks(2233),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 4, 17, 26, 46, 598, DateTimeKind.Local).AddTicks(2222));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "City",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 25, 14, 22, 47, 873, DateTimeKind.Local).AddTicks(359),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 4, 17, 26, 46, 597, DateTimeKind.Local).AddTicks(9535));
        }
    }
}
