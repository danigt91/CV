using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;

namespace CV.Domain.Helper
{
    public static class AutoMapperOData<T> where T : class
    {

        static MapperConfiguration Config = new MapperConfiguration(cfg =>
            cfg.CreateMap<T, T>()
        );

        public static IQueryable<T> ResolveMap(IQueryable v){
            return v.ProjectToQueryable<T>(Config);
        }

    }
}
