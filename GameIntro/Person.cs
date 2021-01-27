using System;
using System.Collections.Generic;
using System.Text;

namespace GameIntro
{
    public class Person : IPerson
    {
        public long Id { get ; set ; }
        public string Name { get ; set ; }
        public string Surname { get ; set ; }
    }
}
