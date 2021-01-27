using System;
using System.Collections.Generic;
using System.Text;

namespace GameIntro
{
    class Sale : ISale
    {
        public void SaleStatement(IPerson person, IGame game, ICampaign campaign)
        {
            Console.WriteLine(person.Name+" "+ "isimli kişi,"+" "+campaign.Name+" "+"isimli kampanyada %"+" "+campaign.Ratio+" "+"indirim kazanarak " +
                game.Name+" "+"isimli oyunu "+game.Price+" "+"TL'ye almıştır.");
        }
    }
}
