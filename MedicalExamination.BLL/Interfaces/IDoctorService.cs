using System.Collections.Generic;
using MedicalExamination.Entities;

namespace MedicalExamination.BLL
{
    /// <summary>
    /// Interface for <see cref="Doctor"/> entity service implementation
    /// </summary>
    public interface IDoctorService
    {
        IEnumerable<Doctor> GetAllDoctors();
        Doctor GetDoctor(int id);
        void CreateDoctor(Doctor doctor);
        void UpdateDoctor(Doctor doctor);
        void DeleteDoctor(Doctor doctor);
    }
}
