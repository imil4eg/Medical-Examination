using MedicalExamination.Entities;

namespace MedicalExamination.DAL
{
    /// <summary>
    /// Repository for <see cref="ServiceHistory"/>
    /// </summary>
    public sealed class ServiceHistoryRepository : GenericRepository<ServiceHistory>
    {
        public ServiceHistoryRepository(MedicalExaminationContext context) : base(context)
        {
        }
    }
}
