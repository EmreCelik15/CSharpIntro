using System;
using System.Collections.Generic;
using System.Text;

namespace GameIntro
{
    interface ICampaignManager
    {
        void Add(ICampaign campaign);
        void Delete(ICampaign campaign);
        void Update(ICampaign campaign);
    }
}
