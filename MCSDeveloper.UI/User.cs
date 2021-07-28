using System;
using System.Collections.Generic;
using System.Linq;

namespace MCSDeveloper
{
    public class User : IUser
    {
        public int UserId { get; set; }
        public string Username { get; set; }
        private readonly List<User> _listOfUsers;
        public User(string username)
        {
            Username = username;
        }
        public User()
        {
            _listOfUsers = new(Users);
        }
        private static IEnumerable<User> Users
        {
            get
            {
                return new List<User>()
                {
                    new(1, "Sam"),
                    new(2, "Alex"),
                    new(3, "Rose"),

                };
            }
        }

        //public Func<IEnumerable<User>, bool> FuncQueries
        //{
        //    get
        //    {
        //       return FuncQueries.Invoke(Users);
        //    }
        //}

        public User(int userId, string username)
        {
            UserId = userId;
            Username = username;
        }
        public IEnumerable<User> GetListOfUsers()
        {
            return _listOfUsers.ToList();
        }

        public IQueryable<User> Queries()
        {
            return _listOfUsers.AsQueryable();
        }
    }
}
