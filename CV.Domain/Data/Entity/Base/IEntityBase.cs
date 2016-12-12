﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CV.Domain.Data.Entity
{
    public interface IEntityBase : IIdentificable, IObjectWithState, IDisposable
    {

    }
}
