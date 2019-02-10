using System.Collections.Generic;
using MedicalExamination.Entities;

namespace MedicalExamination.BLL
{
    /// <summary>
    /// Interface for <see cref="ServiceType"/> entity service implementation
    /// </summary>
    public interface IServiceTypeService
    {
        IEnumerable<ServiceType> GetAllAServiceTypes();
        ServiceType GetServiceType(int id);
        void CreateServiceType(ServiceType serviceType);
        void UpdateServiceType(ServiceType serviceHistory);
        void DeleteServiceType(ServiceType serviceHistory);
    }
}
