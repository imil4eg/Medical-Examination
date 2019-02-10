using MedicalExamination.Entities;

namespace MedicalExamination.DAL
{
    /// <summary>
    /// Repository for <see cref="Doctor"/>
    /// </summary>
    public sealed class DoctorRepository : GenericRepository<Doctor>
    {
        public DoctorRepository(MedicalExaminationContext context) : base(context)
        {
        }
    }
}
