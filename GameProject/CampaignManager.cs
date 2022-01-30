using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    internal class CampaignManager : ICampaignService
    {
        ICampaignService _campaignService;

        public CampaignManager(ICampaignService campaignService)
        {
            _campaignService = campaignService;
        }

        public void AddCampaign(Gamer gamer, Campaign campaign)
        {
            Console.WriteLine(gamer.UserName + "purchased game with " + campaign.CampaignName);
        }


        public void RemoveCampaign(Gamer gamer, Campaign campaign)
        {
            Console.WriteLine(gamer.UserName + "removed game with " + campaign.CampaignName);
        }


        public void UpdateCampaign(Gamer gamer, Campaign campaign)
        {
            Console.WriteLine(gamer.UserName + "updated purchase game with " + campaign.CampaignName);
        }
    }
}
