using Microsoft.EntityFrameworkCore.Migrations;

namespace PDataAccessLayer.Migrations
{
    public partial class mig2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MedicineId",
                table: "Receipts");

            migrationBuilder.DropColumn(
                name: "PatientId",
                table: "Receipts");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MedicineId",
                table: "Receipts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PatientId",
                table: "Receipts",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
