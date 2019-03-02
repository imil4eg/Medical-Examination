using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MedicalExamination.Migrations
{
    public partial class RenameOfEntityServiceHistoryToServiceResult : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ServiceHistories_Patients_PatientId",
                table: "ServiceHistories");

            migrationBuilder.DropForeignKey(
                name: "FK_ServiceHistories_Workers_WorkerId",
                table: "ServiceHistories");

            migrationBuilder.DropIndex(
                name: "IX_ServiceHistories_PatientId",
                table: "ServiceHistories");

            migrationBuilder.DropIndex(
                name: "IX_ServiceHistories_WorkerId",
                table: "ServiceHistories");

            migrationBuilder.DropColumn(
                name: "PatientId",
                table: "ServiceHistories");

            migrationBuilder.DropColumn(
                name: "WorkerId",
                table: "ServiceHistories");

            migrationBuilder.AddColumn<Guid>(
                name: "AppointmentId",
                table: "ServiceHistories",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_ServiceHistories_AppointmentId",
                table: "ServiceHistories",
                column: "AppointmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_ServiceHistories_Appointments_AppointmentId",
                table: "ServiceHistories",
                column: "AppointmentId",
                principalTable: "Appointments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ServiceHistories_Appointments_AppointmentId",
                table: "ServiceHistories");

            migrationBuilder.DropIndex(
                name: "IX_ServiceHistories_AppointmentId",
                table: "ServiceHistories");

            migrationBuilder.DropColumn(
                name: "AppointmentId",
                table: "ServiceHistories");

            migrationBuilder.AddColumn<int>(
                name: "PatientId",
                table: "ServiceHistories",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "WorkerId",
                table: "ServiceHistories",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_ServiceHistories_PatientId",
                table: "ServiceHistories",
                column: "PatientId");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceHistories_WorkerId",
                table: "ServiceHistories",
                column: "WorkerId");

            migrationBuilder.AddForeignKey(
                name: "FK_ServiceHistories_Patients_PatientId",
                table: "ServiceHistories",
                column: "PatientId",
                principalTable: "Patients",
                principalColumn: "PersonId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ServiceHistories_Workers_WorkerId",
                table: "ServiceHistories",
                column: "WorkerId",
                principalTable: "Workers",
                principalColumn: "PersonId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
