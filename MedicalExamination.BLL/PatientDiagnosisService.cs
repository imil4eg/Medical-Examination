using System;
using System.Collections.Generic;
using System.Linq;
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

        public IEnumerable<PatientDiagnosis> GetAllPatientDiagnosis()
        {
            return _patientDiagnosisRepository.GetAll();
        }

        public IEnumerable<PatientDiagnosis> GetAllAppointmentDiagnosis(Guid appointmentId)
        {
            return _patientDiagnosisRepository.GetAll().Where(pd => pd.AppointmentId == appointmentId);
        }

        public PatientDiagnosis GetPatientDiagnosis(Guid id)
        {
            return _patientDiagnosisRepository.GetById(id);
        }

        public void CreatePatientDiagnosis(PatientDiagnosisModel patientDiagnosisModel)
        {
            var patientDiagnosis =
                SimpleMapper.Mapper.Map<PatientDiagnosisModel, PatientDiagnosis>(patientDiagnosisModel);

            _patientDiagnosisRepository.Insert(patientDiagnosis);
        }

        public void UpdatePatientDiagnosis(PatientDiagnosisModel patientDiagnosisModel)
        {
            var patientDiagnosis =
                SimpleMapper.Mapper.Map<PatientDiagnosisModel, PatientDiagnosis>(patientDiagnosisModel);

            _patientDiagnosisRepository.Update(patientDiagnosis);
        }

        public void DeletePatientDiagnosis(PatientDiagnosisModel patientDiagnosisModel)
        {
            var patientDiagnosis =
                SimpleMapper.Mapper.Map<PatientDiagnosisModel, PatientDiagnosis>(patientDiagnosisModel);

            _patientDiagnosisRepository.Delete(patientDiagnosis);
        }
    }
}
