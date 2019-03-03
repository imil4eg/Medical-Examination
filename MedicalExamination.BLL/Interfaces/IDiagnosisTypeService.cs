using System;
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
        DiagnosisType GetDiagnoseType(Guid id);
        void CreateDiagnoseType(DiagnosisTypeModel diagnoseTypeModel);
        void UpdateDiagnoseType(DiagnosisTypeModel diagnoseTypeModel);
        void DeleteDiagnoseType(DiagnosisTypeModel diagnoseTypeModel);
    }
}
