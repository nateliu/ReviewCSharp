using Microsoft.Practices.CompositeUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CABCustomer.Control
{
    public class CustomerModule :ModuleInit
    {
        private WorkItem mainWorkItem;

        [ServiceDependency]
        public WorkItem MainWorkItem
        {
            set { mainWorkItem = value; }
        }

        public override void Load()
        {
            base.Load();
            CustomerWorkItem customerWorkItem = mainWorkItem.Items.AddNew<CustomerWorkItem>();
            customerWorkItem.Run();
        }
    }
}
