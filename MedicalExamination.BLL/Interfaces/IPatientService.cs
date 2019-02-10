using System.Collections.Generic;
using MedicalExamination.Entities;

namespace MedicalExamination.BLL
{
    /// <summary>
    /// Interface for <see cref="Patient"/> entity service implementation
    /// </summary>
    public interface IPatientService
    {
        IEnumerable<Patient> GetAllPatients();
        Patient GetPatient(int id);
        void CreatePatient(Patient patient);
        void UpdatePatient(Patient patient);
        void DeletePatient(Patient patient);
    }
}
