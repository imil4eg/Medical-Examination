using System.Collections.Generic;
using MedicalExamination.DAL;
using MedicalExamination.Entities;

namespace MedicalExamination.BLL
{
    public sealed class PatientService : IPatientService
    {
        private readonly IGenericRepository<Patient> _patientRepository;

        public PatientService(IGenericRepository<Patient> patientRepository)
        {
            _patientRepository = patientRepository;
        }

        public IEnumerable<Patient> GetAllPatients()
        {
            return _patientRepository.GetAll();
        }

        public Patient GetPatient(int id)
        {
             return _patientRepository.GetById(id);
        }

        public void CreatePatient(Patient patient)
        {
            _patientRepository.Insert(patient);
        }

        public void UpdatePatient(Patient patient)
        {
            _patientRepository.Update(patient);
        }

        public void DeletePatient(Patient patient)
        {
            _patientRepository.Delete(patient);
        }
    }
}
