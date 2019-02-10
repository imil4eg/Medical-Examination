using System.Collections.Generic;
using MedicalExamination.Entities;

namespace MedicalExamination.BLL
{
    /// <summary>
    /// Interface for <see cref="PatientDiagnosis"/> entity service implementation
    /// </summary>
    public interface IPatientDiagnosisService
    {
        IEnumerable<PatientDiagnosis> GetAllPatientDiagnoses();
        PatientDiagnosis GetPatientDiagnosis(int id);
        void CreatePatientDiagnosis(PatientDiagnosis patientDiagnosis);
        void UpdatePatientDiagnosis(PatientDiagnosis patientDiagnosis);
        void DeletePatientDiagnosis(PatientDiagnosis patientDiagnosis);
    }
}
