using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CV.Domain.Data.Entity
{
    public abstract class EntityBase : IEntityBase
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
