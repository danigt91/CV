using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace CV.Infraestructure.Data.Contract
{
    public interface IContext : IDisposable
    {

        int SaveChanges();

        DbSet Set(Type t);

        DbSet<T> Set<T>() where T : class;

        DbEntityEntry Entry(object entity);

        DbEntityEntry<TEntity> Entry<TEntity>(TEntity entity) where TEntity : class;

    }
}
