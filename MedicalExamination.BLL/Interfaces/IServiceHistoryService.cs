using System.Collections.Generic;
using MedicalExamination.Entities;

namespace MedicalExamination.BLL
{
    /// <summary>
    /// Interface for <see cref="ServiceHistory"/> entity service implementation
    /// </summary>
    public interface IServiceHistoryService
    {
        IEnumerable<ServiceHistory> GetAllServiceHistories();
        ServiceHistory GetServiceHistory(int id);
        void CreateServiceHistory(ServiceHistory serviceHistory);
        void UpdateServiceHistory(ServiceHistory serviceHistory);
        void DeleteServiceHistory(ServiceHistory serviceHistory);
    }
}
