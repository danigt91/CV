using Microsoft.Practices.Unity;
using CV.Infraestructure.Data;
using CV.Infraestructure.Data.Contract;
using CV.Infraestructure.Data.Entity;
using CV.Infraestructure.Data.Entity.Contract;
using CV.Infraestructure.Data.Repository;
using CV.Infraestructure.Data.Repository.Contract;
using CV.Infraestructure.Data.Repository.Implementation;

namespace CV.CrossCutting.IoC
{
    class PrincipalContainer : UnityContainer
    {

        public PrincipalContainer() : base()
        {

            InfraestructureInjection();

        }

        private void InfraestructureInjection()
        {
            /* Arquitectura */
            this.RegisterType<IContext, CVContext>();
            this.RegisterType<IUnitOfWork<IContext>, UnitOfWork>();

            /* Repositorio de entidades */
            this.RegisterType(typeof(IDataRepository<>), typeof(DataRepository<>));
        }

    }
}
