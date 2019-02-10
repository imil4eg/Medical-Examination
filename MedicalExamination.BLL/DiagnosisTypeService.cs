using System.Collections.Generic;
using MedicalExamination.DAL;
using MedicalExamination.Entities;

namespace MedicalExamination.BLL
{
    public sealed class DiagnosisTypeService: IDiagnosisTypeService
    {
        private readonly IGenericRepository<DiagnosisType> _diagnosisTypeServiceRepository;

        public DiagnosisTypeService(IGenericRepository<DiagnosisType> diagnosisTypeServiceRepository)
        {
            _diagnosisTypeServiceRepository = diagnosisTypeServiceRepository;
        }

        public IEnumerable<DiagnosisType> GetAllDiagnoseTypes()
        {
            return _diagnosisTypeServiceRepository.GetAll();
        }

        public DiagnosisType GetDiagnoseType(int id)
        {
            return _diagnosisTypeServiceRepository.GetById(id);
        }

        public void CreateDiagnoseType(DiagnosisType diagnosisType)
        {
            _diagnosisTypeServiceRepository.Insert(diagnosisType);
        }

        public void UpdateDiagnoseType(DiagnosisType diagnosisType)
        {
            _diagnosisTypeServiceRepository.Update(diagnosisType);
        }

        public void DeleteDiagnoseType(DiagnosisType diagnosisType)
        {
            _diagnosisTypeServiceRepository.Delete(diagnosisType);
        }
    }
}
