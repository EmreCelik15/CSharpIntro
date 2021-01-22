using System;

namespace CSharpIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> name = new MyList<string>();
            name.AddList("Emre");
            name.AddList("Celik");
            name.AddList("27");
            name.AddList("EEM");
           
        }
    }
}
