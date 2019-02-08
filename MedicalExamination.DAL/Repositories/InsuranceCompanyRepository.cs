using MedicalExamination.Entities;

namespace MedicalExamination.DAL
{
    /// <summary>
    /// Repository for <see cref="InsuranceCompanyType"/>
    /// </summary>
    public sealed class InsuranceCompanyRepository : GenericRepository<InsuranceCompanyType>
    {
        public InsuranceCompanyRepository(MedicalExaminationContext context, IUnitOfWork unitOfWork) : base(context, unitOfWork)
        {
        }
    }
}
