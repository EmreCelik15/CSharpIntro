using System;
using System.Collections.Generic;
using System.Text;

namespace GameIntro
{
    public interface ISale
    {
        void SaleStatement(IPerson person,IGame game,ICampaign campaign);
    }
}
