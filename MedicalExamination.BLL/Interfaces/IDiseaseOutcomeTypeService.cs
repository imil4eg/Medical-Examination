using System.Collections.Generic;
using MedicalExamination.Entities;

namespace MedicalExamination.BLL
{
    /// <summary>
    /// Interface for <see cref="DiseaseOutcomeType"/> entity service implementation
    /// </summary>
    public interface IDiseaseOutcomeTypeService
    {
        IEnumerable<DiseaseOutcomeType> GetAllDiseaseOutcomeTypes();
        DiseaseOutcomeType GetDiseaseOutcomeType(int id);
        void CreateDiseaseOutcomeType(DiseaseOutcomeType diseaseOutcomeType);
        void UpdateDiseaseOutcomeType(DiseaseOutcomeType diseaseOutcomeType);
        void DeleteDiseaseOutcomeType(DiseaseOutcomeType diseaseOutcomeType);
    }
}
