using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Gamer gamer1 = new Gamer();
            gamer1.Id = 1;
            gamer1.UserName = "enesturkmen";
            gamer1.BirthYear = 1998;
            gamer1.LastName = "TUERKMEN";
            gamer1.FirstName = "ENES";
            
            GamerManager gamerManager = new GamerManager(new NewValidationManager());
            gamerManager.Add(gamer1);

            Game game1 = new Game();
            game1.GameName = "GTA 5";
            game1.GameId = 1;

            GameManager gameManager = new GameManager();
            gameManager.AddGame(game1);
            
            Campaign campaign1 = new Campaign();
            campaign1.CampaignId = 1;
            campaign1.CampaignName = "Winter Campaigns!";

            
            Order order1 = new Order();
            order1.orderName = "ORDER1";
            order1.orderId = 1;

            OrderManager orderManager = new OrderManager();
            orderManager.OrderWithCampaign(order1, campaign1, game1);
        }
    }
}