using HwGame.Abstract;
using HwGame.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace HwGame.Concrete
{
    class CampaignManager : ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " added" );
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " deleted");
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " updated");
        }
    }
}
