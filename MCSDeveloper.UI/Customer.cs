using System;
using System.Collections;

namespace MCSDeveloper
{
    public class Customer 
    {
        public int CustomerId { get; set; }
        public string Name { get; set; }

        public Customer(int customerId, string name)
        {
            CustomerId = customerId;
            Name = name;
        }

        public Customer()
        {
            CustomerId = 17019;
            Name = "Developer";
        }
    }
}
