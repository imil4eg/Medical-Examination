using MedicalExamination.Entities;

namespace MedicalExamination.DAL
{
    /// <summary>
    /// Repository for <see cref="ExaminationResultType"/>
    /// </summary>
    public sealed class ExaminationResultTypeRepostiory : GenericRepository<ExaminationResultType>
    {
        public ExaminationResultTypeRepostiory(MedicalExaminationContext context, IUnitOfWork unitOfWork) : base(context, unitOfWork)
        {
        }
    }
}
