using System.Collections.Generic;
using MedicalExamination.DAL;
using MedicalExamination.Entities;

namespace MedicalExamination.BLL
{
    public sealed class ServiceTypeService : IServiceTypeService
    {
        private readonly IGenericRepository<ServiceType> _serviceTypeRepository;

        public ServiceTypeService(IGenericRepository<ServiceType> serviceTypeRepository)
        {
            _serviceTypeRepository = serviceTypeRepository;
        }

        public IEnumerable<ServiceType> GetAllAServiceTypes()
        {
            return _serviceTypeRepository.GetAll();
        }

        public ServiceType GetServiceType(int id)
        {
            return _serviceTypeRepository.GetById(id);
        }

        public void CreateServiceType(ServiceType serviceType)
        {
            _serviceTypeRepository.Insert(serviceType);
        }

        public void UpdateServiceType(ServiceType serviceHistory)
        {
            _serviceTypeRepository.Update(serviceHistory);
        }

        public void DeleteServiceType(ServiceType serviceHistory)
        {
            _serviceTypeRepository.Delete(serviceHistory);
        }
    }
}
