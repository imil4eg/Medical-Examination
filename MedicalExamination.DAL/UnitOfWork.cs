using System.Collections.Generic;

namespace MedicalExamination.DAL
{
    /// <summary>
    /// Unit Of Work class
    /// </summary>
    public sealed class UnitOfWork : IUnitOfWork
    {
        /// <summary>
        /// Container of repositories
        /// </summary>
        private readonly Dictionary<string, IRepository> _repositories;

        /// <summary>
        /// Default Constructor
        /// </summary>
        public UnitOfWork()
        {
            _repositories = new Dictionary<string, IRepository>();
        }
        
        /// <summary>
        /// Registers repository
        /// </summary>
        /// <param name="repository"></param>
        public void Register(IRepository repository)
        {
            _repositories.Add(repository.GetType().Name, repository);
        }
    }
}
