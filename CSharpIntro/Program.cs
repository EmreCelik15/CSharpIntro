using System;

namespace CSharpIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer() { Adi = "Emre", SoyAdi = "Çelik", Maas = 4000 };
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            Console.WriteLine("*******************");
            customerManager.Delete(customer1);
        }
    }
}
