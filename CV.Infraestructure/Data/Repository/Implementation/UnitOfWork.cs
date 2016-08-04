using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using CV.Infraestructure.Data.Contract;
using CV.Infraestructure.Data.Entity.Contract;
using CV.Infraestructure.Data.Repository.Contract;

namespace CV.Infraestructure.Data.Repository.Implementation
{
    public class UnitOfWork : IUnitOfWork<IContext>
    {

        private IContext _context;

        public UnitOfWork(IContext context)
        {
            _context = context;
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public DbSet<TEntity> Set<TEntity>() where TEntity : EntityBase
        {
            return _context.Set<TEntity>();
        }

        public DbEntityEntry Entry(object entity)
        {
            return _context.Entry(entity);
        }


        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

    }
}
