using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CV.Infraestructure.Data.Entity.Contract;
using System.Linq.Expressions;

namespace CV.Infraestructure.Service.Contract
{
    public interface IAutoMapperEF6<T, V> where T : EntityBase
    {


        V Map(T entity);

        IEnumerable<V> Map(IQueryable<T> entity);

        IQueryable<V> ProjectIQueryable(IQueryable<T> entities);

        IEnumerable<V> ByExpression(IQueryable<T> entities, Expression<Func<V, bool>> expression);

        IEnumerable<V> ByExpressions(IQueryable<T> entities, IList<Expression<Func<V, bool>>> expressions);

        IEnumerable<V> MapNonGeneric(IQueryable query);

    }
}
