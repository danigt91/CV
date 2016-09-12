using System;
using System.Data.Entity;
using CV.Infraestructure.Data.Contract;
using CV.Infraestructure.Data.Entity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace CV.Infraestructure.Data
{
    public class CVContext : IdentityDbContext, IContext, IDisposable
    {

        public CVContext() : base("CVEntity")
        {

        }

        public DbSet<Usuario> Usuarios { get; set; }

    }
}
