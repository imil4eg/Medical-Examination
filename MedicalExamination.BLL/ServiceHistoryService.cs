using System.Collections.Generic;
using MedicalExamination.DAL;
using MedicalExamination.Entities;

namespace MedicalExamination.BLL
{
    public sealed class ServiceHistoryService : IServiceHistoryService
    {
        private readonly IGenericRepository<ServiceHistory> _serviceHistoryRepository;

        public ServiceHistoryService(IGenericRepository<ServiceHistory> serviceHistoryRepository)
        {
            _serviceHistoryRepository = serviceHistoryRepository;
        }

        public IEnumerable<ServiceHistory> GetAllServiceHistories()
        {
            return _serviceHistoryRepository.GetAll();
        }

        public ServiceHistory GetServiceHistory(int id)
        {
            return _serviceHistoryRepository.GetById(id);
        }

        public void CreateServiceHistory(ServiceHistory serviceHistory)
        {
            _serviceHistoryRepository.Insert(serviceHistory);
        }

        public void UpdateServiceHistory(ServiceHistory serviceHistory)
        {
            _serviceHistoryRepository.Update(serviceHistory);
        }

        public void DeleteServiceHistory(ServiceHistory serviceHistory)
        {
            _serviceHistoryRepository.Delete(serviceHistory);
        }
    }
}
