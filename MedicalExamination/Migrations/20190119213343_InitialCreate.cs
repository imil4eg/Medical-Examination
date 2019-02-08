using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MedicalExamination.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DiagnosTypes",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DiagnosTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DiaseOutcomeTypes",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DiaseOutcomeTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ExaminationResultTypes",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExaminationResultTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "InsuranceCompanyTypes",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InsuranceCompanyTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PassportIssuePlaceTypes",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PassportIssuePlaceTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PositionTypes",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PositionTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    NormalizedName = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ServiceTypes",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServiceTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    NormalizedUserName = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    NormalizedEmail = table.Column<string>(nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    UserName = table.Column<string>(nullable: false),
                    Password = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Persons",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    LastName = table.Column<string>(nullable: false),
                    FirstName = table.Column<string>(nullable: false),
                    MiddleName = table.Column<string>(nullable: true),
                    Gender = table.Column<int>(nullable: false),
                    BirthDate = table.Column<DateTime>(nullable: false),
                    INN = table.Column<string>(nullable: true),
                    SNILS = table.Column<string>(nullable: true),
                    PassportNumber = table.Column<string>(nullable: true),
                    PassportSeries = table.Column<string>(nullable: true),
                    PassportIssueDate = table.Column<DateTime>(nullable: false),
                    PassportIssuePlaceId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Persons", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Persons_PassportIssuePlaceTypes_PassportIssuePlaceId",
                        column: x => x.PassportIssuePlaceId,
                        principalTable: "PassportIssuePlaceTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProvideServices",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    PositionId = table.Column<Guid>(nullable: false),
                    ServiceId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProvideServices", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProvideServices_PositionTypes_PositionId",
                        column: x => x.PositionId,
                        principalTable: "PositionTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProvideServices_ServiceTypes_ServiceId",
                        column: x => x.ServiceId,
                        principalTable: "ServiceTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Doctors",
                columns: table => new
                {
                    PersonId = table.Column<int>(nullable: false),
                    UserId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Doctors", x => x.PersonId);
                    table.ForeignKey(
                        name: "FK_Doctors_Persons_PersonId",
                        column: x => x.PersonId,
                        principalTable: "Persons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Doctors_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Patients",
                columns: table => new
                {
                    PersonId = table.Column<int>(nullable: false),
                    InsuranceNumber = table.Column<string>(nullable: false),
                    InsuranceCompanyId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patients", x => x.PersonId);
                    table.ForeignKey(
                        name: "FK_Patients_InsuranceCompanyTypes_InsuranceCompanyId",
                        column: x => x.InsuranceCompanyId,
                        principalTable: "InsuranceCompanyTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Patients_Persons_PersonId",
                        column: x => x.PersonId,
                        principalTable: "Persons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Positions",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    DoctorId = table.Column<int>(nullable: false),
                    PositionId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Positions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Positions_Doctors_DoctorId",
                        column: x => x.DoctorId,
                        principalTable: "Doctors",
                        principalColumn: "PersonId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Positions_PositionTypes_PositionId",
                        column: x => x.PositionId,
                        principalTable: "PositionTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Appointments",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    DoctorId = table.Column<int>(nullable: false),
                    PatientId = table.Column<int>(nullable: false),
                    DiaseOutcomeId = table.Column<Guid>(nullable: false),
                    ExaminationResultId = table.Column<Guid>(nullable: false),
                    EndDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Appointments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Appointments_DiaseOutcomeTypes_DiaseOutcomeId",
                        column: x => x.DiaseOutcomeId,
                        principalTable: "DiaseOutcomeTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Appointments_Doctors_DoctorId",
                        column: x => x.DoctorId,
                        principalTable: "Doctors",
                        principalColumn: "PersonId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Appointments_ExaminationResultTypes_ExaminationResultId",
                        column: x => x.ExaminationResultId,
                        principalTable: "ExaminationResultTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Appointments_Patients_PatientId",
                        column: x => x.PatientId,
                        principalTable: "Patients",
                        principalColumn: "PersonId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ServiceHistories",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    DoctorId = table.Column<int>(nullable: false),
                    PatientId = table.Column<int>(nullable: false),
                    ServiceTypeId = table.Column<Guid>(nullable: false),
                    Result = table.Column<string>(nullable: true),
                    TubeNumber = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServiceHistories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ServiceHistories_Doctors_DoctorId",
                        column: x => x.DoctorId,
                        principalTable: "Doctors",
                        principalColumn: "PersonId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ServiceHistories_Patients_PatientId",
                        column: x => x.PatientId,
                        principalTable: "Patients",
                        principalColumn: "PersonId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ServiceHistories_ServiceTypes_ServiceTypeId",
                        column: x => x.ServiceTypeId,
                        principalTable: "ServiceTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PatientDiagnoses",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    AppointmentId = table.Column<Guid>(nullable: false),
                    DiagnosId = table.Column<Guid>(nullable: false),
                    IsMain = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PatientDiagnoses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PatientDiagnoses_Appointments_AppointmentId",
                        column: x => x.AppointmentId,
                        principalTable: "Appointments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PatientDiagnoses_DiagnosTypes_DiagnosId",
                        column: x => x.DiagnosId,
                        principalTable: "DiagnosTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_DiaseOutcomeId",
                table: "Appointments",
                column: "DiaseOutcomeId");

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_DoctorId",
                table: "Appointments",
                column: "DoctorId");

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_ExaminationResultId",
                table: "Appointments",
                column: "ExaminationResultId");

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_PatientId",
                table: "Appointments",
                column: "PatientId");

            migrationBuilder.CreateIndex(
                name: "IX_Doctors_UserId",
                table: "Doctors",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_PatientDiagnoses_AppointmentId",
                table: "PatientDiagnoses",
                column: "AppointmentId");

            migrationBuilder.CreateIndex(
                name: "IX_PatientDiagnoses_DiagnosId",
                table: "PatientDiagnoses",
                column: "DiagnosId");

            migrationBuilder.CreateIndex(
                name: "IX_Patients_InsuranceCompanyId",
                table: "Patients",
                column: "InsuranceCompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Persons_PassportIssuePlaceId",
                table: "Persons",
                column: "PassportIssuePlaceId");

            migrationBuilder.CreateIndex(
                name: "IX_Positions_DoctorId",
                table: "Positions",
                column: "DoctorId");

            migrationBuilder.CreateIndex(
                name: "IX_Positions_PositionId",
                table: "Positions",
                column: "PositionId");

            migrationBuilder.CreateIndex(
                name: "IX_ProvideServices_PositionId",
                table: "ProvideServices",
                column: "PositionId");

            migrationBuilder.CreateIndex(
                name: "IX_ProvideServices_ServiceId",
                table: "ProvideServices",
                column: "ServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceHistories_DoctorId",
                table: "ServiceHistories",
                column: "DoctorId");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceHistories_PatientId",
                table: "ServiceHistories",
                column: "PatientId");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceHistories_ServiceTypeId",
                table: "ServiceHistories",
                column: "ServiceTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PatientDiagnoses");

            migrationBuilder.DropTable(
                name: "Positions");

            migrationBuilder.DropTable(
                name: "ProvideServices");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "ServiceHistories");

            migrationBuilder.DropTable(
                name: "Appointments");

            migrationBuilder.DropTable(
                name: "DiagnosTypes");

            migrationBuilder.DropTable(
                name: "PositionTypes");

            migrationBuilder.DropTable(
                name: "ServiceTypes");

            migrationBuilder.DropTable(
                name: "DiaseOutcomeTypes");

            migrationBuilder.DropTable(
                name: "Doctors");

            migrationBuilder.DropTable(
                name: "ExaminationResultTypes");

            migrationBuilder.DropTable(
                name: "Patients");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "InsuranceCompanyTypes");

            migrationBuilder.DropTable(
                name: "Persons");

            migrationBuilder.DropTable(
                name: "PassportIssuePlaceTypes");
        }
    }
}
