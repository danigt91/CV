using System;
using System.Data.Entity;
using System.Linq;
using CV.Infraestructure.Data.Contract;
using CV.Infraestructure.Data.Entity.Contract;
using CV.Infraestructure.Data.Repository.Contract;

namespace CV.Infraestructure.Data.Repository.Implementation
{
    public class DataRepository<TEntity> : IDataRepository<TEntity> where TEntity : EntityBase
    {
        private IUnitOfWork<IContext> _context
        {
            get; set;
        }

        public DataRepository(IUnitOfWork<IContext> context)
        {
            _context = context;
        }

        public DbSet<TEntity> Set()
        {
            return _context.Set<TEntity>();
        }

        public IQueryable<TEntity> All()
        {
            return Set().AsQueryable();
        }

        public TEntity Find(Guid id)
        {
            return Set().Find(id);
        }

        public TEntity Create(TEntity entity)
        {
            _context.Entry(entity).Cast<TEntity>().State = EntityState.Added;
            _context.Save();
            return entity;
        }

        public TEntity Update(TEntity entity)
        {
            _context.Entry(entity).Cast<TEntity>().State = EntityState.Modified;
            _context.Save();
            return entity;
        }

        public TEntity Remove(TEntity entity)
        {
            _context.Entry(entity).Cast<TEntity>().State = EntityState.Deleted;
            _context.Save();
            return entity;
        }


    }
}
