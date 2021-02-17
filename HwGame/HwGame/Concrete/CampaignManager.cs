using HwGame.Abstract;
using HwGame.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace HwGame.Concrete
{
    public class CampaignManager : ISystemService
    {
        public void Add(Platform campaign)
        {
            Console.WriteLine(campaign.CampaignName + " added" );
        }

        public void Delete(Platform campaign)
        {
            Console.WriteLine(campaign.CampaignName + " deleted");
        }

        public void Update(Platform campaign)
        {
            Console.WriteLine(campaign.CampaignName + " updated");
        }
    }
}
