using CABCustomer.Contract;
using CABCustomer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CABCustomer.Service
{
    public class CustomerService : ICustomerService
    {
        public List<Customer> GetCustomers()
        {
            List<Customer> customers = new List<Customer>();
            customers.Add(new Customer("Jesper", "Aaberg", "One Microsoft Way, Redmond WA 98052", "CAB Rocks!"));
            customers.Add(new Customer("Martin", "Bankov", "One Microsoft Way, Redmond WA 98052", "This is awesome"));
            customers.Add(new Customer("Shu", "Ito", "One Microsoft Way, Redmond WA 98052", "N/A"));
            customers.Add(new Customer("Kim", "Ralls", "One Microsoft Way, Redmond WA 98052", "N/A"));
            customers.Add(new Customer("John", "Kane", "One Microsoft Way, Redmond WA 98052", "N/A"));
            return customers;
        }
    }
}
