using CV.Domain.DTO;
using CV.Domain.Service.Contract;
using CV.Infraestructure.Data.Entity;
using CV.Infraestructure.Data.Entity.Contract;
using CV.Infraestructure.Data.Repository.Contract;
using CV.Infraestructure.Service.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http.OData.Query;

namespace CV.Domain.Service.Implementation
{
    public abstract class DataService<TEntity, TDTO> : IODataQueryable<TDTO> where TEntity : EntityBase where TDTO : class
    {

        protected IAutoMapperEF6<TEntity, TDTO> _mapper;
        protected IDataRepository<TEntity> _entities;

        public DataService(IAutoMapperEF6<TEntity, TDTO> mapper, IDataRepository<TEntity> entities)
        {
            _mapper = mapper;
            _entities = entities;
        }
        
        public IEnumerable<TDTO> Query(ODataQueryOptions<TDTO> queryOptions)
        {
            var usuariosProjection = _mapper.ProjectIQueryable(_entities.All());
            var queried = queryOptions.ApplyTo(usuariosProjection);// as IQueryable<TDTO>;
            //var enumerable = (IEnumerable<TDTO>) queried;
            var enumerable = _mapper.MapNonGeneric(queried);
            return enumerable;
        }

    }
}
