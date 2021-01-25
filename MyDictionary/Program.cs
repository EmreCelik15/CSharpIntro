using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> myDictionary = new MyDictionary<int, string>();
            myDictionary.Add(15, "Emre");
            myDictionary.Add(25, "Celik");
            
        }
    }
}
