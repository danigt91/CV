using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;
using CV.CrossCutting.Service;
using CV.Infraestructure.Data.Entity;
using CV.Infraestructure.Data.Repository.Contract;
using System.Diagnostics;
using System.Data.Entity.Validation;
using System.Data.Entity.Infrastructure;
using CV.Infraestructure.Service.Implementation;

namespace CV.Infraestructure.Tests.Repository
{

    [TestClass]
    public class UsuarioRepositoryTest
    {

        private static IDataRepository<Usuario> _usuario;
        

        [AssemblyInitialize]
        public static void InjectMocks(TestContext context)
        {
            DependencyResolverService.Register();
            _usuario = DependencyResolverService.ResolveCustomType<IDataRepository<Usuario>>();
        }

        [TestMethod]
        public void GenerateContext()
        {
            DependencyResolverService.Register();
            _usuario = DependencyResolverService.ResolveCustomType<IDataRepository<Usuario>>();
        }

        [TestMethod]
        public void InjectionIsOK()
        {
            var x = _usuario.All().Count();
            Trace.WriteLine("Inyeccion de dependencias ok");
        }


        [TestMethod]
        public void AutoMapperEF6IsOK()
        {
            var x = _usuario.All();
            var auto = new AutoMapperEF6<Usuario, UsuarioDTOTest>();
            var xMap = auto.Map(x);

            Trace.WriteLine("Inyeccion de dependencias ok");
        }

        [Ignore]
        [TestMethod]
        public void CreateUserTest()
        {
            var nuevoUsuario = new Usuario()
            {
                UserName = "danigt91",
                Password = "QWERTY",
                ConfirmPassword = "QWERTY"
            };
            nuevoUsuario = _usuario.Create(nuevoUsuario);

            Trace.WriteLine("Usuario ID: " + nuevoUsuario.ID);

            Trace.WriteLine("Inyeccion de dependencias ok");
        }

        [TestMethod]
        [ExpectedException(typeof(DbEntityValidationException))]
        public void CreateUserFailPasswordTest()
        {
            var nuevoUsuario = new Usuario()
            {
                UserName = "danigt91",
                Password = "QWERTY",
                ConfirmPassword = "OTRA"
            };

            try
            {
                nuevoUsuario = _usuario.Create(nuevoUsuario);
            }
            catch (DbEntityValidationException e)
            {
                Trace.WriteLine(e.Message);

                foreach (var validationError in e.EntityValidationErrors)
                {
                    Trace.WriteLine(string.Join(", ", validationError.ValidationErrors.Select(x => "[" + x.PropertyName + "]: " + x.ErrorMessage)));
                }
                throw;
            }

            Trace.WriteLine("Usuario ID: " + nuevoUsuario.ID);

            Trace.WriteLine("Inyeccion de dependencias ok");
        }


        [TestMethod]
        [ExpectedException(typeof(DbEntityValidationException))]
        public void CreateUserUserNameFailTest()
        {
            var nuevoUsuario = new Usuario()
            {
                UserName = "danigt91",
                Password = "QWERTY",
                ConfirmPassword = "QWERTY"
            };

            try
            {
                nuevoUsuario = _usuario.Create(nuevoUsuario);
            }
            catch (DbEntityValidationException e)
            {
                Exception eDeep = e;
                Trace.WriteLine(eDeep.Message);
                while (eDeep.InnerException != null)
                {
                    eDeep = eDeep.InnerException;
                    Trace.WriteLine(eDeep.Message);
                }

                throw;
            }

            Trace.WriteLine("Usuario ID: " + nuevoUsuario.ID);

            Trace.WriteLine("Inyeccion de dependencias ok");
        }

        [TestMethod]
        public void GetUserOK()
        {
            Usuario match = new Usuario()
            {
                UserName = "danigt91",
                Password = "QWERTY"
            };

            var x = _usuario.All().Where(user => user.UserName == match.UserName && user.Password == match.Password);
            if (x.Any())
            {
                Trace.WriteLine("User OK");
            }
            else
            {
                throw new UnauthorizedAccessException("User dont exist or password dont match.");
            }            
        }

        [TestMethod]
        public void GetUserByExpressionOK()
        {
            var usuarios = _usuario.All();
            var auto = new AutoMapperEF6<Usuario, UsuarioDTOTest>();
            var xMap = auto.ByExpression(usuarios, expression => expression.UserName == "danigt91");

            Trace.WriteLine("Get User By Expression OK ok");
        }
    }
}
