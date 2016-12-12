using System;
using System.Data.Entity;
using System.Linq;
using CV.Domain.Data.Entity;

namespace CV.Domain.Data.Repository
{
    public interface IDataRepository<TEntity> where TEntity : EntityBase
    {

        DbSet<TEntity> Set();

        IQueryable<TEntity> All();

        TEntity Find(Guid id);

        TEntity Create(TEntity entity);

        TEntity Update(TEntity entity);

        TEntity Remove(TEntity entity);

    }
}
