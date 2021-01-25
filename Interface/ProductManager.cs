using System;
using System.Collections.Generic;
using System.Text;

namespace Interface
{
    class ProductManager : ICustomer
    {
        public void Add()
        {
            Console.WriteLine("Yeni ürün eklendi");
        }

        public void Delete()
        {
            Console.WriteLine("Bir ürün silindi");
        }

        public void Update()
        {
            Console.WriteLine("Bir ürün güncellendi");
        }
    }
}
