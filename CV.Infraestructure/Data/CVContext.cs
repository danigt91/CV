using System;
using System.Data.Entity;
using CV.Infraestructure.Data.Contract;
using CV.Infraestructure.Data.Entity;

namespace CV.Infraestructure.Data
{
    public class CVContext : DbContext, IContext, IDisposable
    {

        public DbSet<Usuario> Usuarios { get; set; }

    }
}
