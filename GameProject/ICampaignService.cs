﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    internal interface ICampaignService
    {
        void AddCampaign(Gamer gamer, Campaign campaign);
        void RemoveCampaign(Gamer gamer, Campaign campaign);
        void UpdateCampaign(Gamer gamer, Campaign campaign);
    }
}
