using System.Collections.Generic;
using MedicalExamination.DAL;
using MedicalExamination.Entities;

namespace MedicalExamination.BLL
{
    public sealed class PatientService : IPatientService
    {
        private readonly IGenericRepository<Patient> _patientRepository;
        private readonly IGenericRepository<Person> _personRepository;

        public PatientService(IGenericRepository<Patient> patientRepository, IGenericRepository<Person> personRepository)
        {
            _patientRepository = patientRepository;
            _personRepository = personRepository;
        }

        public IEnumerable<Patient> GetAllPatients()
        {
            return _patientRepository.GetAll();
        }

        public Patient GetPatient(int id)
        {
             return _patientRepository.GetById(id);
        }

        public void CreatePatient(PatientModel patientModel)
        {
            var person = SimpleMapper.Mapper.Map<PersonModel, Person>(patientModel.Person);
            person = _personRepository.Insert(person);

            var patient = SimpleMapper.Mapper.Map<PatientModel, Patient>(patientModel);
            patient.PersonId = person.Id;
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
