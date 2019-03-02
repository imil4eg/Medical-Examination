using System.Collections.Generic;
using MedicalExamination.DAL;
using MedicalExamination.Entities;

namespace MedicalExamination.BLL
{
    public sealed class ServiceHistoryService : IServiceHistoryService
    {
        private readonly IGenericRepository<ServiceResult> _serviceHistoryRepository;

        public ServiceHistoryService(IGenericRepository<ServiceResult> serviceHistoryRepository)
        {
            _serviceHistoryRepository = serviceHistoryRepository;
        }

        public IEnumerable<ServiceResult> GetAllServiceHistories()
        {
            return _serviceHistoryRepository.GetAll();
        }

        public ServiceResult GetServiceHistory(int id)
        {
            return _serviceHistoryRepository.GetById(id);
        }

        public void CreateServiceHistory(ServiceResult serviceHistory)
        {
            _serviceHistoryRepository.Insert(serviceHistory);
        }

        public void UpdateServiceHistory(ServiceResult serviceHistory)
        {
            _serviceHistoryRepository.Update(serviceHistory);
        }

        public void DeleteServiceHistory(ServiceResult serviceHistory)
        {
            _serviceHistoryRepository.Delete(serviceHistory);
        }
    }
}
