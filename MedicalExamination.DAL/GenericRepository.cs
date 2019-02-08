using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace MedicalExamination.DAL
{
    /// <summary>
    /// Generic repository
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    public abstract class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        /// <summary>
        /// DataBase Context
        /// </summary>
        private readonly MedicalExaminationContext _context;

        /// <summary>
        /// Entity 
        /// </summary>
        private readonly DbSet<TEntity> _entities;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="context"></param>
        /// <param name="unitOfWork"></param>
        protected GenericRepository(MedicalExaminationContext context, IUnitOfWork unitOfWork)
        {
            unitOfWork.Register(this);
            this._context = context;
            this._entities = context.Set<TEntity>();
        }

        /// <summary>
        /// Gets all values of entity
        /// </summary>
        /// <returns></returns>
        public IEnumerable<TEntity> GetAll()
        {
            return _entities.AsEnumerable();
        }

        /// <summary>
        /// Gets value by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public TEntity GetById(int id)
        {
            return _entities.Find(id);
        }

        /// <summary>
        /// Insert item into
        /// </summary>
        /// <param name="entity"></param>
        public void Insert(TEntity entity)
        {
            _entities.Add(entity);
        }

        /// <summary>
        /// Updates item
        /// </summary>
        /// <param name="entity"></param>
        public void Update(TEntity entity)
        {
            _entities.Update(entity);
        }

        /// <summary>
        /// Deletes item
        /// </summary>
        /// <param name="entity"></param>
        public void Delete(TEntity entity)
        {
            _entities.Remove(entity);
        }

        /// <summary>
        /// Saves changes
        /// </summary>
        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}
