using System;
using System.Collections.Generic;
using System.Text;

namespace AllianceDevTest
{
    public class Customer : Record
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Address Address { get; set; }

        public Customer(string firstName, string lastName, Address address)
        {
            FirstName = firstName;

            LastName = lastName;

            Address = address;

        }

    }
}
