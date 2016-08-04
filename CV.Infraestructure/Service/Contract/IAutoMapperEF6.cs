using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CV.Infraestructure.Data.Entity.Contract;

namespace CV.Infraestructure.Service.Contract
{
    public interface IAutoMapperEF6<T, V> where T : EntityBase
    {


        V Map(T entity);

        IEnumerable<V> Map(IQueryable<T> entity);


    }
}
