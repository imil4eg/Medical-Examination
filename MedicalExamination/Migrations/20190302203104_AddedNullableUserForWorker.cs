using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MedicalExamination.Migrations
{
    public partial class AddedNullableUserForWorker : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ServiceHistories_Appointments_AppointmentId",
                table: "ServiceHistories");

            migrationBuilder.DropForeignKey(
                name: "FK_ServiceHistories_ServiceTypes_ServiceTypeId",
                table: "ServiceHistories");

            migrationBuilder.DropForeignKey(
                name: "FK_Workers_AspNetUsers_UserId",
                table: "Workers");

            migrationBuilder.DropIndex(
                name: "IX_Workers_UserId",
                table: "Workers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ServiceHistories",
                table: "ServiceHistories");

            migrationBuilder.RenameTable(
                name: "ServiceHistories",
                newName: "ServiceResults");

            migrationBuilder.RenameIndex(
                name: "IX_ServiceHistories_ServiceTypeId",
                table: "ServiceResults",
                newName: "IX_ServiceResults_ServiceTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_ServiceHistories_AppointmentId",
                table: "ServiceResults",
                newName: "IX_ServiceResults_AppointmentId");

            migrationBuilder.AlterColumn<Guid>(
                name: "UserId",
                table: "Workers",
                nullable: true,
                oldClrType: typeof(Guid));

            migrationBuilder.AddPrimaryKey(
                name: "PK_ServiceResults",
                table: "ServiceResults",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Workers_UserId",
                table: "Workers",
                column: "UserId",
                unique: true,
                filter: "[UserId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_ServiceResults_Appointments_AppointmentId",
                table: "ServiceResults",
                column: "AppointmentId",
                principalTable: "Appointments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ServiceResults_ServiceTypes_ServiceTypeId",
                table: "ServiceResults",
                column: "ServiceTypeId",
                principalTable: "ServiceTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Workers_AspNetUsers_UserId",
                table: "Workers",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ServiceResults_Appointments_AppointmentId",
                table: "ServiceResults");

            migrationBuilder.DropForeignKey(
                name: "FK_ServiceResults_ServiceTypes_ServiceTypeId",
                table: "ServiceResults");

            migrationBuilder.DropForeignKey(
                name: "FK_Workers_AspNetUsers_UserId",
                table: "Workers");

            migrationBuilder.DropIndex(
                name: "IX_Workers_UserId",
                table: "Workers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ServiceResults",
                table: "ServiceResults");

            migrationBuilder.RenameTable(
                name: "ServiceResults",
                newName: "ServiceHistories");

            migrationBuilder.RenameIndex(
                name: "IX_ServiceResults_ServiceTypeId",
                table: "ServiceHistories",
                newName: "IX_ServiceHistories_ServiceTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_ServiceResults_AppointmentId",
                table: "ServiceHistories",
                newName: "IX_ServiceHistories_AppointmentId");

            migrationBuilder.AlterColumn<Guid>(
                name: "UserId",
                table: "Workers",
                nullable: false,
                oldClrType: typeof(Guid),
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_ServiceHistories",
                table: "ServiceHistories",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Workers_UserId",
                table: "Workers",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_ServiceHistories_Appointments_AppointmentId",
                table: "ServiceHistories",
                column: "AppointmentId",
                principalTable: "Appointments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ServiceHistories_ServiceTypes_ServiceTypeId",
                table: "ServiceHistories",
                column: "ServiceTypeId",
                principalTable: "ServiceTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Workers_AspNetUsers_UserId",
                table: "Workers",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
