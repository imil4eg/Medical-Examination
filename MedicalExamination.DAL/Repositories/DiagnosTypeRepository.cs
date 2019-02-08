using MedicalExamination.Entities;

namespace MedicalExamination.DAL
{
    /// <summary>
    /// Repository for <see cref="DiagnosType"/>
    /// </summary>
    public sealed class DiagnosTypeRepository : GenericRepository<DiagnosType>
    {
        public DiagnosTypeRepository(MedicalExaminationContext context, IUnitOfWork unitOfWork) : base(context, unitOfWork)
        {
        }
    }
}
