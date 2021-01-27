using System;
using System.Collections.Generic;
using System.Text;

namespace GameIntro
{
    interface IPersonManager
    {
        void Add(IPerson person);
        void Delete(IPerson person);
        void Update(IPerson person);
    }
}
