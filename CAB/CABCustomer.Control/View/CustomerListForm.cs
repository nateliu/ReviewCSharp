using CABCustomer.Control.Controller;
using CABCustomer.Model;
using Microsoft.Practices.CompositeUI;
using Microsoft.Practices.ObjectBuilder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CABCustomer.Control.View
{
    public partial class CustomerListForm : UserControl
    {
        public CustomerListForm()
        {
            InitializeComponent();
        }

        private CustomerController controller;
        [CreateNew]
        public CustomerController Controller
        {
            set { controller = value; }
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            //customerList.DataSource = controller.GetCustomers();
            controller.GetCustomers();
            customerList.DataSource = customers;
            customerList.DisplayMember = "FullName";
            customerList.SelectedIndexChanged += new EventHandler(customerList_SelectedIndexChanged);
            customerList.SelectedIndex = 1;
        }

        private void customerList_SelectedIndexChanged(object sender, EventArgs e)
        {
            controller.ShowCustomerDetails((Customer)this.customerList.SelectedValue);
        }

        private List<Customer> customers = null;
        [State]
        public List<Customer> Customers
        {
            set { customers = value; }
        }
    }
}
