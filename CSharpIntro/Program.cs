using System;

namespace CSharpIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product() { Id = 265, Name = "Pen", Unit = 50 };
            Product product2 = new Product() { Id = 265, Name = "Eraser", Unit = 21 };
            Product product3 = new Product() { Id = 785, Name = "Notebook", Unit = 12 };
            Product[] products = new Product[3] { product1, product2, product3 };
            //Using for loop display items
            for (int i = 0; i < products.Length; i++)
            {
                Console.Write(products[i].Id+" ");
                
                Console.Write(products[i].Name+" ");
               
                Console.Write(products[i].Unit+" ");
                Console.WriteLine();

            }
            Console.WriteLine("                   ");
            Console.WriteLine("******************");
            //Using foreach loop display items
            foreach (var product in products)
            {
                Console.Write(product.Id+" ");
                Console.Write(product.Name + " ");

                Console.Write(product.Unit + " ");
                Console.WriteLine();
            }
            Console.WriteLine(" ");
            Console.WriteLine("********");
            //using while loop display items
            int length = 0;
            while (length<products.Length)
            {
                Console.Write(products[length].Id + " ");

                Console.Write(products[length].Name + " ");

                Console.Write(products[length].Unit + " ");
                Console.WriteLine();
                length++;

            }
        }
    }
}
