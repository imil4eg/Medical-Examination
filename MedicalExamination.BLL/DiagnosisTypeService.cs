using System;
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

        public DiagnosisType GetDiagnoseType(Guid id)
        {
            return _diagnosisTypeServiceRepository.GetById(id);
        }

        public void CreateDiagnoseType(DiagnosisTypeModel diagnosisTypeModel)
        {
            var diagnosisType = SimpleMapper.Mapper.Map<DiagnosisTypeModel, DiagnosisType>(diagnosisTypeModel);

            _diagnosisTypeServiceRepository.Insert(diagnosisType);
        }

        public void UpdateDiagnoseType(DiagnosisTypeModel diagnosisTypeModel)
        {
            var diagnosisType = SimpleMapper.Mapper.Map<DiagnosisTypeModel, DiagnosisType>(diagnosisTypeModel);

            _diagnosisTypeServiceRepository.Update(diagnosisType);
        }

        public void DeleteDiagnoseType(DiagnosisTypeModel diagnosisTypeModel)
        {
            var diagnosisType = SimpleMapper.Mapper.Map<DiagnosisTypeModel, DiagnosisType>(diagnosisTypeModel);

            _diagnosisTypeServiceRepository.Delete(diagnosisType);
        }
    }
}
