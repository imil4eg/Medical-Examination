using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MedicalExamination.Migrations
{
    public partial class DiaseOutcomeTypeRefactor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Appointments_DiseaseOutcomeTypes_DiseaseOutcomeId",
                table: "Appointments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DiseaseOutcomeTypes",
                table: "DiseaseOutcomeTypes");

            migrationBuilder.DropIndex(
                name: "IX_Appointments_DiseaseOutcomeId",
                table: "Appointments");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "DiseaseOutcomeTypes");

            migrationBuilder.DropColumn(
                name: "DiseaseOutcomeId",
                table: "Appointments");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "DiseaseOutcomeTypes",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AddColumn<Guid>(
                name: "AppointmentId",
                table: "DiseaseOutcomeTypes",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddPrimaryKey(
                name: "PK_DiseaseOutcomeTypes",
                table: "DiseaseOutcomeTypes",
                column: "AppointmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_DiseaseOutcomeTypes_Appointments_AppointmentId",
                table: "DiseaseOutcomeTypes",
                column: "AppointmentId",
                principalTable: "Appointments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DiseaseOutcomeTypes_Appointments_AppointmentId",
                table: "DiseaseOutcomeTypes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DiseaseOutcomeTypes",
                table: "DiseaseOutcomeTypes");

            migrationBuilder.DropColumn(
                name: "AppointmentId",
                table: "DiseaseOutcomeTypes");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "DiseaseOutcomeTypes",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "Id",
                table: "DiseaseOutcomeTypes",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "DiseaseOutcomeId",
                table: "Appointments",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddPrimaryKey(
                name: "PK_DiseaseOutcomeTypes",
                table: "DiseaseOutcomeTypes",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_DiseaseOutcomeId",
                table: "Appointments",
                column: "DiseaseOutcomeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Appointments_DiseaseOutcomeTypes_DiseaseOutcomeId",
                table: "Appointments",
                column: "DiseaseOutcomeId",
                principalTable: "DiseaseOutcomeTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
