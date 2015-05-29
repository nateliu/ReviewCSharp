using CABCustomer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CABCustomer.Contract
{
    public interface ICustomerService
    {
        List<Customer> GetCustomers();
    }
}
