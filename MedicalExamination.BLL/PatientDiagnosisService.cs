using System.Collections.Generic;
using MedicalExamination.DAL;
using MedicalExamination.Entities;

namespace MedicalExamination.BLL
{
    public sealed class PatientDiagnosisService : IPatientDiagnosisService
    {
        private readonly IGenericRepository<PatientDiagnosis> _patientDiagnosisRepository;

        public PatientDiagnosisService(IGenericRepository<PatientDiagnosis> patientDiagnosisRepository)
        {
            _patientDiagnosisRepository = patientDiagnosisRepository;
        }

        public IEnumerable<PatientDiagnosis> GetAllPatientDiagnoses()
        {
            return _patientDiagnosisRepository.GetAll();
        }

        public PatientDiagnosis GetPatientDiagnosis(int id)
        {
            return _patientDiagnosisRepository.GetById(id);
        }

        public void CreatePatientDiagnosis(PatientDiagnosis patientDiagnosis)
        {
            _patientDiagnosisRepository.Insert(patientDiagnosis);
        }

        public void UpdatePatientDiagnosis(PatientDiagnosis patientDiagnosis)
        {
            _patientDiagnosisRepository.Update(patientDiagnosis);
        }

        public void DeletePatientDiagnosis(PatientDiagnosis patientDiagnosis)
        {
            _patientDiagnosisRepository.Delete(patientDiagnosis);
        }
    }
}
