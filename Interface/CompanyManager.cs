using System;
using System.Collections.Generic;
using System.Text;

namespace Interface
{
    class CompanyManager
    {
        public void Add(ICustomer customer)
        {
            customer.Add();
        }
        public void Delete(ICustomer customer)
        {
            customer.Delete();
        }
        public void Update(ICustomer customer)
        {
            customer.Update();
        }
    }
}
