using System;
using System.Collections.Generic;
using System.Text;

namespace Interface
{
    class PersonManager : ICustomer
    {
        public void Add()
        {
            Console.WriteLine("Yeni Çalışan eklendi");
        }

        public void Delete()
        {
            Console.WriteLine("Çalışanınız silindi");
        }

        public void Update()
        {
            Console.WriteLine("Bir çalışan güncellendi");
        }
    }
}
