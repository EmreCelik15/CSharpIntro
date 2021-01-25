using System;
using System.Collections.Generic;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();
            person1.Id = 4;
            person1.Name = "Emre";
            Person person2 = new Person();
            person2.Id = 4;
            person2.Name ="Celik";
            Person[] person = new Person[] { person1, person2 };
            foreach (var persons in person)
            {
                Console.WriteLine(persons.Id+" "+persons.Name);
            }
        }
    }
}
