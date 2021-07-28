using System.Collections;
using System.Collections.Generic;

namespace MCSDeveloper
{
    public class MyGenericClassHelper<TEntity> where TEntity : notnull
    {
        public delegate TEntity ResolveAnyType(TEntity arg);
    }
}
