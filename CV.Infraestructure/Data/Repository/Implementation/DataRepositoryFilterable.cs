using CV.Infraestructure.Data.Contract;
using CV.Infraestructure.Data.Entity.Contract;
using CV.Infraestructure.Data.Repository.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace CV.Infraestructure.Data.Repository.Implementation
{
    class DataRepositoryFilterable<T, V> : DataRepository<T>, IFilterable<T, IDataRepository<T>> where T:EntityBase
    {

        private IUnitOfWork<IContext> _context
        {
            get; set;
        }

        public DataRepositoryFilterable(IUnitOfWork<IContext> context) : base(context)
        {
        }

        public IQueryable<T> ByExpression(Expression<Func<T, bool>> expression)
        {
            return Set().Where(expression);
        }

        public IQueryable<T> ByExpressions(IList<Expression<Func<T, bool>>> expressions)
        {
            IQueryable<T> query = Set();
            expressions.ToList().ForEach(expression => query = query.Where(expression));
            return query;
        }
    }
}
