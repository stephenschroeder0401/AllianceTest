using System;
using System.Collections.Generic;
using System.Text;

namespace AllianceDevTest
{
    public class Company : Record
    {
        public string CompanyName { get; set; }

        public Address Address { get; set; }

        public Company(string companyName, Address address)
        {
            CompanyName = companyName;

            Address = address;
        }
    }
}
