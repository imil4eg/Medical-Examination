using MedicalExamination.Entities;
using Microsoft.EntityFrameworkCore;

namespace MedicalExamination.DAL
{
    /// <summary>
    /// DataBase Context
    /// </summary>
    public sealed class MedicalExaminationContext : DbContext
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="options"></param>
        public MedicalExaminationContext(DbContextOptions<MedicalExaminationContext> options) : base(options)
        {

        }

        public DbSet<ApplicationUser> Users { get; set; }
        public DbSet<ApplicationRole> Roles { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<DiagnosType> DiagnosTypes { get; set; }
        public DbSet<DiaseOutcomeType> DiaseOutcomeTypes { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<ExaminationResultTypeRepostiory> ExaminationResultTypes { get; set; }
        public DbSet<InsuranceCompanyType> InsuranceCompanyTypes { get; set; }
        public DbSet<PassportIssuePlaceType> PassportIssuePlaceTypes { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<PatientDiagnos> PatientDiagnoses { get; set; }
        public DbSet<Person> Persons { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<PositionType> PositionTypes { get; set; }
        public DbSet<ProvideService> ProvideServices { get; set; }
        public DbSet<ServiceType> ServiceTypes { get; set; }
        public DbSet<ServiceHistory> ServiceHistories { get; set; }
    }
}
