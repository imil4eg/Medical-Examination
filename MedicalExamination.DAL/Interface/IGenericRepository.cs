using System.Collections.Generic;

namespace MedicalExamination.DAL
{
    /// <summary>
    /// Generic repository interface
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    public interface IGenericRepository<TEntity> : IRepository where TEntity : class
    {
        IEnumerable<TEntity> GetAll();
        TEntity GetById(int id);
        void Insert(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);
    }
}
