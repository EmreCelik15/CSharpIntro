using System;
using System.Collections.Generic;
using System.Text;

namespace GameIntro
{
    public interface IPerson
    {
        long Id { get; set; }
        string Name { get; set; }
        string Surname { get; set; }
    }
}
