using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    internal interface IOrderService
    {
        void Order(Order order, Game game);
        void CancelOrder(Order order, Game game);
        void UpdateOrder(Order order, Game game);
        void OrderWithCampaign(Order order, Campaign campaign, Game game);

    }
}
