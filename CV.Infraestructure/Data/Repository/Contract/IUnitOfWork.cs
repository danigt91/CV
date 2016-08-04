using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using CV.Infraestructure.Data.Contract;
using CV.Infraestructure.Data.Entity.Contract;

namespace CV.Infraestructure.Data.Repository.Contract
{
    public interface IUnitOfWork<TContext> : IDisposable where TContext : IContext
    {

        void Save();

        DbSet<TEntity> Set<TEntity>() where TEntity : EntityBase;

        DbEntityEntry Entry(object entity);

    }
}
