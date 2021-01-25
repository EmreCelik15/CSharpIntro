using System;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Diagnosing New Customers
            Customer customer1 = new Customer() { Id = 15, Name = "Emre", Salary = 4000 };
            Customer customer2 = new Customer() { Id = 40, Name = "Ali", Salary = 5000 };

            CustomerManager customerManager = new CustomerManager();
            //Diagnosing New List
            Customer[] customer = new Customer[] { customer1, customer2 };
            //Adding Customer
            customerManager.Add(customer1);
            //Deleting Customer
            customerManager.Delete(customer2);
            //Displaying All Customers
            customerManager.CustomerList(customer);


        }
    }
}
