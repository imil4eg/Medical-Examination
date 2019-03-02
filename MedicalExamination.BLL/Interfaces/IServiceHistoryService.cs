using System.Collections.Generic;
using MedicalExamination.Entities;

namespace MedicalExamination.BLL
{
    /// <summary>
    /// Interface for <see cref="ServiceResult"/> entity service implementation
    /// </summary>
    public interface IServiceHistoryService
    {
        IEnumerable<ServiceResult> GetAllServiceHistories();
        ServiceResult GetServiceHistory(int id);
        void CreateServiceHistory(ServiceResult serviceHistory);
        void UpdateServiceHistory(ServiceResult serviceHistory);
        void DeleteServiceHistory(ServiceResult serviceHistory);
    }
}
