using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpIntro
{
     class CustomerManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine(customer.Adi+ " "+ "Added");
        }
        public void Delete(Customer customer)
        {
            Console.WriteLine(customer.Adi + " " + "Deleted");
        }

    }
}
