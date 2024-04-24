using Microsoft.EntityFrameworkCore.Migrations;

namespace PDataAccessLayer.Migrations
{
    public partial class mig13 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Receipts_MedicineInfos_MedicineInfoId",
                table: "Receipts");

            migrationBuilder.DropForeignKey(
                name: "FK_Receipts_PatientInfos_PatientInfoId",
                table: "Receipts");

            migrationBuilder.DropIndex(
                name: "IX_Receipts_MedicineInfoId",
                table: "Receipts");

            migrationBuilder.DropIndex(
                name: "IX_Receipts_PatientInfoId",
                table: "Receipts");

            migrationBuilder.DropColumn(
                name: "MedicineInfoId",
                table: "Receipts");

            migrationBuilder.DropColumn(
                name: "PatientInfoId",
                table: "Receipts");

            migrationBuilder.AddColumn<int>(
                name: "MedicineInfoMedicineBarcode",
                table: "Receipts",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PatientInfoPatientId",
                table: "Receipts",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Receipts_MedicineInfoMedicineBarcode",
                table: "Receipts",
                column: "MedicineInfoMedicineBarcode");

            migrationBuilder.CreateIndex(
                name: "IX_Receipts_PatientInfoPatientId",
                table: "Receipts",
                column: "PatientInfoPatientId");

            migrationBuilder.AddForeignKey(
                name: "FK_Receipts_MedicineInfos_MedicineInfoMedicineBarcode",
                table: "Receipts",
                column: "MedicineInfoMedicineBarcode",
                principalTable: "MedicineInfos",
                principalColumn: "MedicineBarcode",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Receipts_PatientInfos_PatientInfoPatientId",
                table: "Receipts",
                column: "PatientInfoPatientId",
                principalTable: "PatientInfos",
                principalColumn: "PatientId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Receipts_MedicineInfos_MedicineInfoMedicineBarcode",
                table: "Receipts");

            migrationBuilder.DropForeignKey(
                name: "FK_Receipts_PatientInfos_PatientInfoPatientId",
                table: "Receipts");

            migrationBuilder.DropIndex(
                name: "IX_Receipts_MedicineInfoMedicineBarcode",
                table: "Receipts");

            migrationBuilder.DropIndex(
                name: "IX_Receipts_PatientInfoPatientId",
                table: "Receipts");

            migrationBuilder.DropColumn(
                name: "MedicineInfoMedicineBarcode",
                table: "Receipts");

            migrationBuilder.DropColumn(
                name: "PatientInfoPatientId",
                table: "Receipts");

            migrationBuilder.AddColumn<int>(
                name: "MedicineInfoId",
                table: "Receipts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PatientInfoId",
                table: "Receipts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Receipts_MedicineInfoId",
                table: "Receipts",
                column: "MedicineInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_Receipts_PatientInfoId",
                table: "Receipts",
                column: "PatientInfoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Receipts_MedicineInfos_MedicineInfoId",
                table: "Receipts",
                column: "MedicineInfoId",
                principalTable: "MedicineInfos",
                principalColumn: "MedicineBarcode",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Receipts_PatientInfos_PatientInfoId",
                table: "Receipts",
                column: "PatientInfoId",
                principalTable: "PatientInfos",
                principalColumn: "PatientId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
