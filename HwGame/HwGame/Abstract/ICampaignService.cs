using HwGame.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace HwGame.Abstract
{
    interface ICampaignService
    {
        void Add(Campaign campaign);
        void Delete(Campaign campaign);
        void Update(Campaign campaign);
    }
}
