using CABCustomer.Control.View;
using CABCustomer.Model;
using Microsoft.Practices.CompositeUI;
using Microsoft.Practices.CompositeUI.SmartParts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CABCustomer.Control
{
    public class CustomerWorkItem :WorkItem
    {
        CustomerListForm customerListForm;
        CustomerDetailForm customerDetailForm;

        protected override void OnRunStarted()
        {
            State["Customers"] = new List<Customer>();
            base.OnRunStarted();
            IWorkspace workSpace = Workspaces["MainWorkspace"];
            IWorkspace leftNavWorkSpace = Workspaces["LeftNavWorkspace"];
            customerListForm = this.SmartParts.AddNew<CustomerListForm>();
            customerDetailForm = this.SmartParts.AddNew<CustomerDetailForm>();
            leftNavWorkSpace.Show(customerListForm);
            workSpace.Show(customerDetailForm);
        }

        public void ShowCustomerDetails(Customer customer)
        {
            customerDetailForm.Customer = customer;
        }
    }
}
