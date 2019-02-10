using MedicalExamination.Entities;

namespace MedicalExamination.DAL
{
    /// <summary>
    /// Repository for <see cref="DiagnosisType"/>
    /// </summary>
    public sealed class DiagnosesTypeRepository : GenericRepository<DiagnosisType>
    {
        public DiagnosesTypeRepository(MedicalExaminationContext context) : base(context)
        {
        }
    }
}
