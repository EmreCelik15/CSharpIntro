using System;
using System.Collections.Generic;
using System.Text;

namespace GameIntro
{
    public interface IValidateService
    {
        bool Validate(IPerson person);
    }
}
