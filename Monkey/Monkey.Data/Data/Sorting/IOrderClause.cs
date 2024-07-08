﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Monkey.Data.Data.Sorting
{
    public interface IOrderClause<TEntity>
    {
        Expression<Func<TEntity, object>> Expression { get; }
        bool IsAscending { get; }
    }
}
