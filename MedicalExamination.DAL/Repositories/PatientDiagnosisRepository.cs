using MedicalExamination.Entities;

namespace MedicalExamination.DAL
{
    /// <summary>
    /// Repository for <see cref="PatientDiagnosis"/>
    /// </summary>
    public sealed class PatientDiagnosisRepository : GenericRepository<PatientDiagnosis>
    {
        public PatientDiagnosisRepository(MedicalExaminationContext context) : base(context)
        {
        }
    }
}
