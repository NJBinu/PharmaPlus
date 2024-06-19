using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MedicineApp.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "MedicineType",
                table: "Medicines",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "MedicineName",
                table: "Medicines",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "Medicines",
                keyColumn: "MedicineId",
                keyValue: 1,
                columns: new[] { "MedicineName", "MedicineType" },
                values: new object[] { "Tylenol", "Flu and Fever" });

            migrationBuilder.UpdateData(
                table: "Medicines",
                keyColumn: "MedicineId",
                keyValue: 2,
                columns: new[] { "MedicineName", "MedicineType", "Price", "StockQuantity" },
                values: new object[] { "Advil", "Headaches", 13.0m, 29 });

            migrationBuilder.InsertData(
                table: "Medicines",
                columns: new[] { "MedicineId", "MedicineName", "MedicineType", "Price", "StockQuantity" },
                values: new object[,]
                {
                    { 3, "Xylel", "Skin", 15.0m, 120 },
                    { 4, "CapB", "Bones", 30.0m, 130 },
                    { 5, "Adderal", "Stomach Pain", 12.0m, 340 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "MedicineId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "MedicineId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "MedicineId",
                keyValue: 5);

            migrationBuilder.AlterColumn<string>(
                name: "MedicineType",
                table: "Medicines",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "MedicineName",
                table: "Medicines",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.UpdateData(
                table: "Medicines",
                keyColumn: "MedicineId",
                keyValue: 1,
                columns: new[] { "MedicineName", "MedicineType" },
                values: new object[] { "Medicine A", "Type1" });

            migrationBuilder.UpdateData(
                table: "Medicines",
                keyColumn: "MedicineId",
                keyValue: 2,
                columns: new[] { "MedicineName", "MedicineType", "Price", "StockQuantity" },
                values: new object[] { "Medicine B", "Type2", 15.0m, 150 });
        }
    }
}
