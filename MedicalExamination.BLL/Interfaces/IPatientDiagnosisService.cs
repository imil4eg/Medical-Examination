using System;
using System.Collections.Generic;
using MedicalExamination.Entities;

namespace MedicalExamination.BLL
{
    /// <summary>
    /// Interface for <see cref="PatientDiagnosis"/> entity service implementation
    /// </summary>
    public interface IPatientDiagnosisService
    {
        IEnumerable<PatientDiagnosis> GetAllPatientDiagnosis();
        IEnumerable<PatientDiagnosis> GetAllAppointmentDiagnosis(Guid appointmentId);
        PatientDiagnosis GetPatientDiagnosis(Guid id);
        void CreatePatientDiagnosis(PatientDiagnosisModel patientDiagnosisModel);
        void UpdatePatientDiagnosis(PatientDiagnosisModel patientDiagnosisModel);
        void DeletePatientDiagnosis(PatientDiagnosisModel patientDiagnosisModel);
    }
}
