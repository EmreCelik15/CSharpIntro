using System;
using System.Collections.Generic;
using System.Text;

namespace GameIntro
{
    class CampaingManager : ICampaignManager
    {
        public void Add(ICampaign campaign)
        {
            Console.WriteLine(campaign.Name+" "+"isimli kampanya eklendi.");
        }

        public void Delete(ICampaign campaign)
        {
            Console.WriteLine(campaign.Name + " " + "isimli kampanya silindi.");
        }

        public void Update(ICampaign campaign)
        {
            Console.WriteLine(campaign.Name + " " + "isimli kampanya güncellendi.");
        }
    }
}
