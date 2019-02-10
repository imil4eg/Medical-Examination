using System.Collections.Generic;
using MedicalExamination.DAL;
using MedicalExamination.Entities;

namespace MedicalExamination.BLL
{
    public sealed class ProvideServiceService : IProvideServiceService
    {
        private readonly IGenericRepository<ProvideService> _provideServiceRepository;

        public ProvideServiceService(IGenericRepository<ProvideService> provideServiceRepository)
        {
            _provideServiceRepository = provideServiceRepository;
        }

        public IEnumerable<ProvideService> GetAllProvideServices()
        {
            return _provideServiceRepository.GetAll();
        }

        public ProvideService GetProvideService(int id)
        {
            return _provideServiceRepository.GetById(id);
        }

        public void CreateProvideService(ProvideService provideService)
        {
            _provideServiceRepository.Insert(provideService);
        }

        public void UpdateProvideService(ProvideService provideService)
        {
            _provideServiceRepository.Update(provideService);
        }

        public void DeleteProvideService(ProvideService provideService)
        {
            _provideServiceRepository.Delete(provideService);
        }
    }
}
