using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using CV.Infraestructure.Data.Contract;
using CV.Domain.Data.Entity;

namespace CV.Infraestructure.Data.Persistence.Contract
{
    public interface IUnitOfWork<TContext> : IDisposable where TContext : IContext
    {

        void Save();

        DbSet<TEntity> Set<TEntity>() where TEntity : EntityBase;

        DbEntityEntry Entry(object entity);

    }
}
