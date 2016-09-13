using System;
using System.Data.Entity;
using CV.Infraestructure.Data.Contract;
using CV.Infraestructure.Data.Entity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace CV.Infraestructure.Data
{
    public class CVContext : IdentityDbContext<IdentityUser>, IContext, IDisposable
    {

        public CVContext() : base("name=DefaultConnection", throwIfV1Schema: false)
        {

        }

        public static IdentityDbContext<IdentityUser> Create()
        {
            return new CVContext();
        }

        public DbSet<Usuario> Usuarios { get; set; }

    }
}
