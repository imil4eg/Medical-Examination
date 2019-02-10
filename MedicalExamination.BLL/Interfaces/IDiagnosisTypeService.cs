using System.Collections.Generic;
using MedicalExamination.Entities;

namespace MedicalExamination.BLL
{
    /// <summary>
    /// Interface for <see cref="DiagnosisType"/> entity service implementation
    /// </summary>
    public interface IDiagnosisTypeService
    {
        IEnumerable<DiagnosisType> GetAllDiagnoseTypes();
        DiagnosisType GetDiagnoseType(int id);
        void CreateDiagnoseType(DiagnosisType diagnoseType);
        void UpdateDiagnoseType(DiagnosisType diagnoseType);
        void DeleteDiagnoseType(DiagnosisType diagnoseType);
    }
}
