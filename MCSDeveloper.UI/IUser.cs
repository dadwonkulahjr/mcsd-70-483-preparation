using System;
using System.Collections.Generic;
using System.Linq;

namespace MCSDeveloper
{
    public interface IUser
    {
        IEnumerable<User> GetListOfUsers();
        IQueryable<User> Queries();
        Func<IEnumerable<User>, bool> FuncQueries { get; }
    }
}
