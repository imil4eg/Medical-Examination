using MedicalExamination.Entities;

namespace MedicalExamination.DAL
{
    /// <summary>
    /// Repository for <see cref="DiagnosisType"/>
    /// </summary>
    public sealed class DiagnosisTypeRepository : GenericRepository<DiagnosisType>
    {
        public DiagnosisTypeRepository(MedicalExaminationContext context) : base(context)
        {
        }
    }
}
