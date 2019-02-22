using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AllianceDevTest;
using Newtonsoft.Json;

namespace Run
{
    class Program
    {
        static void Main(string[] args)
        {
            var address = new Address("test", "test", "test", "test");

            var customer = new Customer("custy", "cust", address);

            var company = new Company("company1", address);

            customer.Save();

            company.Save();

            customer.Find<Customer>(1);
        }
    }
}
