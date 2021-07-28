using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace MCSDeveloper
{
    public class Person : IPerson
    {
        public int Id { get; set; }
        public string Name { get; set; }
       
        public Person()
        {
            Id = 17019;
            Name = "Developer";
        } 
        public Person(int id, string name)
        {
            Id = id;
            Name = name;
        }
        private static List<Person> List
        {
            get
            {
                return new List<Person>()
                {
                    new(14, "Tom"),
                    new(11, "Smith"),
                    new(8, "Rose"),
                    new(6, "Alex"),
                    new(2, "Beatrice"),
                    new(5, "Carr"),
                    new(1, "Davis"),
                };
            }
            
        }
        public IEnumerable<Person> GetData()
        {
            return List;
        }
    }


}
