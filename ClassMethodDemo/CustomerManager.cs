using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodDemo
{
    class CustomerManager
    {
        //Diagnosing Add Operation
        public void Add(Customer customer)
        {
            Console.WriteLine(customer.Id+" "+customer.Name+" "+customer.Salary+" "+"Added");
        }
        //Diagnosing Delete Operation
        public void Delete(Customer customer)
        {
            Console.WriteLine(customer.Id +" "+ customer.Name +" "+ customer.Salary + " " + "Deleted"); 
        }
        //Diagnosing List Operation
        public void CustomerList(Customer[] customer)
        {
            foreach (var customers in customer)
            {
                Console.WriteLine(customers.Id+" "+customers.Name+" "+customers.Salary);
            }   
        }
    }
}
