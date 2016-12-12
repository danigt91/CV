using System;
using System.Data.Entity;
using CV.Infraestructure.Data.Contract;
using Microsoft.AspNet.Identity.EntityFramework;
using CV.Domain.Data.Entity;

namespace CV.Infraestructure.Data
{
    public class CVContext : IdentityDbContext<IdentityUser>, IContext, IDisposable
    {

        public CVContext() : base("name=CVEntity")
        {

        }

        public DbSet<Usuario> Usuarios { get; set; }

        public static CVContext Create()
        {
            return new CVContext();
        }

    }
}
