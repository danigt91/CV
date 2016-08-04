using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CV.Infraestructure.Data.Entity.Contract
{
    public abstract class EntityBase : IIdentificable, IObjectWithState, IDisposable
    {

        public EntityBase()
        {
            ID = Guid.NewGuid();
            State = State.Added;
        }

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid ID
        {
            get; set;
        }

        [NotMapped]
        public State State
        {
            get; set;
        }

        public virtual void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        ~EntityBase()
        {
            Dispose();
        }

    }
}
