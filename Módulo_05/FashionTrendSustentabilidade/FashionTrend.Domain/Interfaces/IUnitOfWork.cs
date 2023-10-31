﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionTrend.Domain.Interfaces
{
    public interface IUnitOfWork
    {
       public Task Commit(CancellationToken cancellationToken);
    }
}
