using System.Collections.Generic;
using MedicalExamination.Entities;

namespace MedicalExamination.BLL
{
    /// <summary>
    /// Interface for <see cref="ProvideService"/> entity service implementation
    /// </summary>
    public interface IProvideServiceService
    {
        IEnumerable<ProvideService> GetAllProvideServices();
        ProvideService GetProvideService(int id);
        void CreateProvideService(ProvideService provideService);
        void UpdateProvideService(ProvideService provideService);
        void DeleteProvideService(ProvideService provideService);
    }
}
