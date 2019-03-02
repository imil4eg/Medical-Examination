using System.Collections.Generic;
using MedicalExamination.DAL;
using MedicalExamination.Entities;

namespace MedicalExamination.BLL
{
    public sealed class ServiceResultService : IServiceResultService
    {
        private readonly IGenericRepository<ServiceResult> _serviceResultRepository;

        public ServiceResultService(IGenericRepository<ServiceResult> serviceResultRepository)
        {
            _serviceResultRepository = serviceResultRepository;
        }

        public IEnumerable<ServiceResult> GetAllServiceResults()
        {
            return _serviceResultRepository.GetAll();
        }

        public ServiceResult GetServiceResult(int id)
        {
            return _serviceResultRepository.GetById(id);
        }

        public void CreateServiceResult(ServiceResult serviceHistory)
        {
            _serviceResultRepository.Insert(serviceHistory);
        }

        public void UpdateServiceResult(ServiceResult serviceHistory)
        {
            _serviceResultRepository.Update(serviceHistory);
        }

        public void DeleteServiceResult(ServiceResult serviceHistory)
        {
            _serviceResultRepository.Delete(serviceHistory);
        }
    }
}
