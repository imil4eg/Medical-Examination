using System.Collections.Generic;
using MedicalExamination.DAL;
using MedicalExamination.Entities;

namespace MedicalExamination.BLL
{
    public sealed class DiseaseOutcomeTypeService : IDiseaseOutcomeTypeService
    {
        private readonly IGenericRepository<DiseaseOutcomeType> _diseaseOutcomeTypeRepository;

        public DiseaseOutcomeTypeService(IGenericRepository<DiseaseOutcomeType> diseaseOutcomeTypeRepository)
        {
            _diseaseOutcomeTypeRepository = diseaseOutcomeTypeRepository;
        }

        public IEnumerable<DiseaseOutcomeType> GetAllDiseaseOutcomeTypes()
        {
            return _diseaseOutcomeTypeRepository.GetAll();
        }

        public DiseaseOutcomeType GetDiseaseOutcomeType(int id)
        {
            return _diseaseOutcomeTypeRepository.GetById(id);
        }

        public void CreateDiseaseOutcomeType(DiseaseOutcomeType diseaseOutcomeType)
        {
            _diseaseOutcomeTypeRepository.Insert(diseaseOutcomeType);
        }

        public void UpdateDiseaseOutcomeType(DiseaseOutcomeType diseaseOutcomeType)
        {
            _diseaseOutcomeTypeRepository.Update(diseaseOutcomeType);
        }

        public void DeleteDiseaseOutcomeType(DiseaseOutcomeType diseaseOutcomeType)
        {
            _diseaseOutcomeTypeRepository.Delete(diseaseOutcomeType);
        }
    }
}
