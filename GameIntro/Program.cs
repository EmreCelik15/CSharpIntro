using System;

namespace GameIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            IPerson person1 = new Person { Id = 55555555555, Name = "Emre", Surname = "Çelik" };
            IPerson person2 = new Person { Id = 65445, Name = "Ali", Surname = "Çelik" };

            ICampaign campaing1 = new Campaign { Name = "Weekend", Ratio = 40 };
            ICampaign campaign2 = new Campaign { Name = "NewYear", Ratio = 25 };

            IGame game1 = new Game { Name = "CsGo", Price = 400 };
            IGame game2 = new Game { Name = "Fortnite", Price = 300 };

            PersonManager personManager1 = new PersonManager();
            PersonManager personManager2 = new PersonManager();
            Console.WriteLine("******************");
            personManager1.Add(person1);
            personManager2.Add(person2);
            Console.WriteLine("********************");
            Sale sale = new Sale();
            sale.SaleStatement(person1, game1, campaing1);
            sale.SaleStatement(person2, game2, campaign2);
        }
    }
}
