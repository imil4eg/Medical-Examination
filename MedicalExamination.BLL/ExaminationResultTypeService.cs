using System.Collections.Generic;
using MedicalExamination.DAL;
using MedicalExamination.Entities;

namespace MedicalExamination.BLL
{
    public sealed class ExaminationResultTypeService : IExaminationResultTypeService
    {
        private readonly IGenericRepository<ExaminationResultType> _examinationResultTypeRepository;

        public ExaminationResultTypeService(IGenericRepository<ExaminationResultType> examinationResultTypeRepository)
        {
            _examinationResultTypeRepository = examinationResultTypeRepository;
        }

        public IEnumerable<ExaminationResultType> GetAllExaminationResultTypes()
        {
            return _examinationResultTypeRepository.GetAll();
        }

        public ExaminationResultType GetExaminationResultType(int id)
        {
            return _examinationResultTypeRepository.GetById(id);
        }

        public void CreateExaminationResultType(ExaminationResultType examinationResultType)
        {
            _examinationResultTypeRepository.Insert(examinationResultType);
        }

        public void UpdateExaminationResultType(ExaminationResultType examinationResultType)
        {
            _examinationResultTypeRepository.Update(examinationResultType);
        }

        public void DeleteExaminationResultType(ExaminationResultType examinationResultType)
        {
            _examinationResultTypeRepository.Delete(examinationResultType);
        }
    }
}
