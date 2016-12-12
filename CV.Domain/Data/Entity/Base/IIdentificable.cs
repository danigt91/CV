using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CV.Domain.Data.Entity
{
    public interface IIdentificable
    {

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        Guid ID { get; set; }

    }
}
