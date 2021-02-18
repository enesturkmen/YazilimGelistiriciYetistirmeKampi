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
            IGamerService gamer1 = new GamerManager(new UserValidationManager());
            gamer1.Add(new Gamers
            {
                GamerId = 1,
                GamerFirstName = "ENES",
                GamerLastName = "TURKMEN",
                GamerTcNo = 123456789, //dogru bilgiye sahip gamer = 12345678901
                YearOfBirth = 1997
            });
            Console.WriteLine("----------------------------");
            
            GameManager game1 = new GameManager();
            game1.Add(new Games
            {
                GameId = 101,
                GameName = "GTA 5",
                Price = 180,
                UnitsInStock = 50
            });
            Console.WriteLine("----------------------------");
            
            ICampaignService campaign1 = new CampaignManager();
            campaign1.Add(new Campaign
            {
                CampaignId = 101,
                CampaignName = "Winter season!"
            });
            Console.WriteLine("----------------------------");
            
            ISalesService sales = new GameSaleManager(new GameManager());
            //sales.Sale(game1);
        }
    }
}
