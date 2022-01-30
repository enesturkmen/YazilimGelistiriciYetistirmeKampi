using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    internal class OrderManager : IOrderService
    {

        public void CancelOrder(Order order, Game game)
        {
            Console.WriteLine(game.GameName + " order " + order.orderId + " successfully cancelled.");
        }

        public void Order(Order order, Game game)
        {
            Console.WriteLine(game.GameName + " order " + order.orderId + " successfully ordered.");
        }

        public void OrderWithCampaign(Order order, Campaign campaign, Game game)
        {
            Console.WriteLine(game.GameName + " game " + order.orderId + " ordered with " + campaign.CampaignName);
        }

        public void UpdateOrder(Order order, Game game)
        {
            Console.WriteLine(game.GameName + " order " + order.orderId + " successfully updated.");
        }
    }
}
