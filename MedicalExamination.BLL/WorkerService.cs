using System.Collections.Generic;
using MedicalExamination.DAL;
using MedicalExamination.Entities;

namespace MedicalExamination.BLL
{
    public sealed class WorkerService : IWorkerService
    {
        private readonly IGenericRepository<Worker> _workerRepository;

        public WorkerService(IGenericRepository<Worker> workerRepository)
        {
            _workerRepository = workerRepository;
        }
 
        public IEnumerable<Worker> GetAllWorkers()
        {
            return _workerRepository.GetAll();
        }

        public Worker GetWorker(int id)
        {
            return _workerRepository.GetById(id);
        }

        public void CreateWorker(Worker worker)
        {
            _workerRepository.Insert(worker);
        }

        public void UpdateWorker(Worker worker)
        {
            _workerRepository.Update(worker);
        }

        public void DeleteWorker(Worker worker)
        {
            _workerRepository.Delete(worker);
        }
    }
}
