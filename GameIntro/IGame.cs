using System;
using System.Collections.Generic;
using System.Text;

namespace GameIntro
{
    public interface IGame
    {
        string Name { get; set; }
        int Price { get; set; }
    }
}
