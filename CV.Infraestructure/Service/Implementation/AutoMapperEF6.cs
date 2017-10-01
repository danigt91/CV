using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using CV.Infraestructure.Data.Entity.Contract;
using CV.Infraestructure.Data.Repository;
using CV.Infraestructure.Service.Contract;
using System.Linq.Expressions;

namespace CV.Infraestructure.Service.Implementation
{
    public class AutoMapperEF6<T, V> : IAutoMapperEF6<T, V>, IFilterable<T, V> where T : EntityBase where V: class
    {

        static MapperConfiguration Config = new MapperConfiguration(cfg => 
            {
                cfg.CreateMap<T, V>();
                cfg.CreateMap<V, V>();
            }
        );

        public IEnumerable<V> Map(IQueryable<T> entity)
        {
            return entity.ProjectToList<V>(Config);
        }

        public V Map(T entity)
        {
            return new T[] { entity }.AsQueryable().ProjectToFirst<V>(Config);
        }

        public IQueryable<V> ProjectIQueryable(IQueryable<T> entities)
        {
            return entities
                .ProjectToQueryable<V>(Config);
        }

        public IEnumerable<V> ByExpression(IQueryable<T> entities, Expression<Func<V, bool>> expression)
        {
            return entities
                .ProjectToQueryable<V>(Config)
                .Where(expression)
                .AsEnumerable();
        }

        public IEnumerable<V> ByExpressions(IQueryable<T> entities, IList<Expression<Func<V, bool>>> expressions)
        {
            var query = entities.ProjectToQueryable<V>(Config);
            expressions.ToList().ForEach(expression => query = query.Where(expression));
            return query.AsEnumerable();
        }

        public IEnumerable<V> MapNonGeneric(IQueryable query)
        {
            return query.ProjectToList<V>(Config);
        }
        
    }
}
