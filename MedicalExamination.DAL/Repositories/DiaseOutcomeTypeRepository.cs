using MedicalExamination.Entities;

namespace MedicalExamination.DAL
{
    /// <summary>
    /// Repository for <see cref="DiaseOutcomeType"/>
    /// </summary>
    public sealed class DiaseOutcomeTypeRepository : GenericRepository<DiaseOutcomeType>
    {
        public DiaseOutcomeTypeRepository(MedicalExaminationContext context, IUnitOfWork unitOfWork) : base(context, unitOfWork)
        {
        }
    }
}
