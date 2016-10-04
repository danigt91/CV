using CV.Infraestructure.Data.Entity.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CV.Infraestructure.Data.Repository.Contract
{
    public interface IFilterable<T, K> where T:EntityBase where K:IDataRepository<T>
    {

        IQueryable<T> ByExpression(Expression<Func<T, bool>> expression);
        IQueryable<T> ByExpressions(IList<Expression<Func<T, bool>>> expressions);

    }
}
