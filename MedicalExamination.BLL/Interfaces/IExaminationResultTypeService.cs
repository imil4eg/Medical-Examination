using System.Collections.Generic;
using MedicalExamination.Entities;

namespace MedicalExamination.BLL
{
    /// <summary>
    /// Interface for <see cref="ExaminationResultType"/> entity service implementation
    /// </summary>
    public interface IExaminationResultTypeService
    {
        IEnumerable<ExaminationResultType> GetAllExaminationResultTypes();
        ExaminationResultType GetExaminationResultType(int id);
        void CreateExaminationResultType(ExaminationResultType examinationResultType);
        void UpdateExaminationResultType(ExaminationResultType examinationResultType);
        void DeleteExaminationResultType(ExaminationResultType examinationResultType);
    }
}
