using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http.OData.Query;

namespace CV.Domain.Service.Contract
{
    public interface IODataQueryable<T> where T : class
    {

        IQueryable<T> Query(ODataQueryOptions<T> queryOptions);

    }
}
