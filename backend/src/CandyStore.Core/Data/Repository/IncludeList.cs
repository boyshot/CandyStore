using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace CandyStore.Core.Data.Repository
{
    public class IncludeList<T> : List<Expression<Func<T, object>>>
    {
        public IncludeList(params Expression<Func<T, object>>[] expressions)
        {
            AddRange(expressions);
        }
    }
}
