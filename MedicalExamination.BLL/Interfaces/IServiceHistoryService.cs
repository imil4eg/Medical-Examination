using System.Collections.Generic;
using MedicalExamination.Entities;

namespace MedicalExamination.BLL
{
    /// <summary>
    /// Interface for <see cref="ServiceResult"/> entity service implementation
    /// </summary>
    public interface IServiceResultService
    {
        IEnumerable<ServiceResult> GetAllServiceResults();
        ServiceResult GetServiceResult(int id);
        void CreateServiceResult(ServiceResult serviceResult);
        void UpdateServiceResult(ServiceResult serviceResult);
        void DeleteServiceResult(ServiceResult serviceResult);
    }
}
