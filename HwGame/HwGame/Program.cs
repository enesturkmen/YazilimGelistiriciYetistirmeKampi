using HwGame.Abstract;
using HwGame.Concrete;
using HwGame.Entities;
using System;

namespace HwGame
{
    class Program
    {
        static void Main(string[] args)
        {
            ISystemService game1 = new GameManager();
            game1.Add(new Entities.Platform { GameId = 101, GameName = "GTA 5",
                UnitsInStock = 50, Price = 100 });
            game1.Delete(new Entities.Platform
            {
                GameId = 101,
                GameName = "GTA 5",
                UnitsInStock = 0
            });
            game1.Update(new Entities.Platform
            {
                GameId = 101,
                GameName = "GTA 5",
                UnitsInStock = 100,
                Price = 75
            });
            Console.WriteLine("---------------------------");
            ISystemService campaign1 = new CampaignManager();
            campaign1.Add(new Entities.Platform { CampaignId = 101, CampaignName = "Winter campaigns" });
            //campaign1.Add(new Entities.Platform { CampaignId = 102, CampaignName = "Spring campaigns " });
            campaign1.Delete(new Entities.Platform { CampaignId = 101, CampaignName = "Winter campaigns" });
            campaign1.Update(new Entities.Platform { CampaignId = 101, CampaignName = "Winter campaigns" });
            Console.WriteLine("---------------------------");

            ISystemService gamer1 = new GamerManager();
            gamer1.Add(new Platform
            {
                GamerId = 1001,
                GamerFirstName = "Enes",
                GamerLastName = "Turkmen",
                GamerTcNo = "12345678901",
                DateOfBirth = new DateTime(1997, 11, 1)
            });
            gamer1.Delete(new Platform
            {
                GamerId = 1001,
                GamerFirstName = "Enes",
                GamerLastName = "Turkmen",
                GamerTcNo = "12345678901",
                DateOfBirth = new DateTime(1997, 11, 1)
            });
            gamer1.Update(new Platform
            {
                GamerId = 1001,
                GamerFirstName = "Enes",
                GamerLastName = "Turkmen",
                GamerTcNo = "12345678901",
                DateOfBirth = new DateTime(1997, 11, 1)
            });
            Console.WriteLine("---------------------------");

            ISalesService sales = new GameSaleManager();
            sales.Sale();



        }
    }
}
