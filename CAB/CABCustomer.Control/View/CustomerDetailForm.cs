using CABCustomer.Model;
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
    public partial class CustomerDetailForm : UserControl
    {
        public CustomerDetailForm()
        {
            InitializeComponent();
        }

        private Customer customer;
        public Customer Customer
        {
            get { return customer; }
            set
            {
                if (this.customer != value)
                {
                    customer = value;
                    this.customerBindingSource.Clear();
                    this.customerBindingSource.Add(value);
                }
            }
        }
    }
}
