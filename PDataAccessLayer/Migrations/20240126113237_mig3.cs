using Microsoft.EntityFrameworkCore.Migrations;

namespace PDataAccessLayer.Migrations
{
    public partial class mig3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MedicineInfos_Receipts_ReceiptId",
                table: "MedicineInfos");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientInfos_Receipts_ReceiptId",
                table: "PatientInfos");

            migrationBuilder.DropIndex(
                name: "IX_PatientInfos_ReceiptId",
                table: "PatientInfos");

            migrationBuilder.DropIndex(
                name: "IX_MedicineInfos_ReceiptId",
                table: "MedicineInfos");

            migrationBuilder.DropColumn(
                name: "ReceiptId",
                table: "PatientInfos");

            migrationBuilder.DropColumn(
                name: "ReceiptId",
                table: "MedicineInfos");

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
                name: "ReceiptId",
                table: "PatientInfos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ReceiptId",
                table: "MedicineInfos",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_PatientInfos_ReceiptId",
                table: "PatientInfos",
                column: "ReceiptId");

            migrationBuilder.CreateIndex(
                name: "IX_MedicineInfos_ReceiptId",
                table: "MedicineInfos",
                column: "ReceiptId");

            migrationBuilder.AddForeignKey(
                name: "FK_MedicineInfos_Receipts_ReceiptId",
                table: "MedicineInfos",
                column: "ReceiptId",
                principalTable: "Receipts",
                principalColumn: "ReceiptId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientInfos_Receipts_ReceiptId",
                table: "PatientInfos",
                column: "ReceiptId",
                principalTable: "Receipts",
                principalColumn: "ReceiptId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
