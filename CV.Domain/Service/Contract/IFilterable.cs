using CV.Domain.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CV.Domain.Service.Contract
{
    public interface IFilterable<T, V> where T:EntityBase where V:class
    {

        IEnumerable<V> ByExpression(IQueryable<T> entities, Expression<Func<V, bool>> expression);
        IEnumerable<V> ByExpressions(IQueryable<T> entities, IList<Expression<Func<V, bool>>> expressions);

    }
}
