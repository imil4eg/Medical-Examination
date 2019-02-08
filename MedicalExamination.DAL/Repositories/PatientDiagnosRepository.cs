using MedicalExamination.Entities;

namespace MedicalExamination.DAL
{
    /// <summary>
    /// Repository for <see cref="PatientDiagnos"/>
    /// </summary>
    public sealed class PatientDiagnosRepository : GenericRepository<PatientDiagnos>
    {
        public PatientDiagnosRepository(MedicalExaminationContext context, IUnitOfWork unitOfWork) : base(context, unitOfWork)
        {
        }
    }
}
