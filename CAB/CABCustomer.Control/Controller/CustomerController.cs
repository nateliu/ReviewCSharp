using CABCustomer.Contract;
using CABCustomer.Model;
using Microsoft.Practices.CompositeUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CABCustomer.Control.Controller
{
    public class CustomerController: Microsoft.Practices.CompositeUI.Controller 
    {
        //public List<Customer> GetCustomers()
        //{
        //    List<Customer> customers = new List<Customer>();
        //    customers.Add(new Customer("Jesper", "Aaberg", "One Microsoft Way, Redmond WA 98052", "CAB Rocks!"));
        //    customers.Add(new Customer("Martin", "Bankov", "One Microsoft Way, Redmond WA 98052", "This is awesome"));
        //    customers.Add(new Customer("Shu", "Ito", "One Microsoft Way, Redmond WA 98052", "N/A"));
        //    customers.Add(new Customer("Kim", "Ralls", "One Microsoft Way, Redmond WA 98052", "N/A"));
        //    customers.Add(new Customer("John", "Kane", "One Microsoft Way, Redmond WA 98052", "N/A"));
        //    return customers;
        //}

        public void GetCustomers()
        {
            //customers.Add(new Customer("Jesper", "Aaberg", "One Microsoft Way, Redmond WA 98052", "CAB Rocks!"));
            //customers.Add(new Customer("Martin", "Bankov", "One Microsoft Way, Redmond WA 98052", "This is awesome"));
            //customers.Add(new Customer("Shu", "Ito", "One Microsoft Way, Redmond WA 98052", "N/A"));
            //customers.Add(new Customer("Kim", "Ralls", "One Microsoft Way, Redmond WA 98052", "N/A"));
            //customers.Add(new Customer("John", "Kane", "One Microsoft Way, Redmond WA 98052", "N/A"));
            customers.AddRange(service.GetCustomers());
        }

        public void ShowCustomerDetails(Customer customer)
        {
            customerWorkItem.ShowCustomerDetails(customer);
        }

        private CustomerWorkItem customerWorkItem;
        [ServiceDependency]
        public CustomerWorkItem CustomerWorkItem
        {
            set { customerWorkItem = value; }
        }

        [State("Customers")]
        public List<Customer> customers
        {
            get { return (List<Customer>)State["Customers"]; }
            set
            {
                try
                {
                    if ((value != null) && (State != null))
                    {
                        State["Customers"] = value;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + Environment.NewLine + ex.StackTrace);
                }
            }
        }

        private ICustomerService service;
        [ServiceDependency]
        public ICustomerService Service
        {
            set { service = value; }
        }
    }
}
