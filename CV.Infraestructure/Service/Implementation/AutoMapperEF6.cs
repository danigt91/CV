using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using CV.Infraestructure.Data.Entity.Contract;
using CV.Infraestructure.Data.Repository;
using CV.Infraestructure.Service.Contract;

namespace CV.Infraestructure.Service.Implementation
{
    public class AutoMapperEF6<T, V> : IAutoMapperEF6<T, V> where T : EntityBase
    {
        
        static MapperConfiguration Config = new MapperConfiguration(cfg =>
            cfg.CreateMap<T, V>()
        );

        public IEnumerable<V> Map(IQueryable<T> entity)
        {
            return entity.ProjectToList<V>(Config);
        }

        public V Map(T entity)
        {
            return new T[] { entity }.AsQueryable().ProjectToFirst<V>(Config);
        }
    }
}
