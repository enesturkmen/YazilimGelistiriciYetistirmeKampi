using System;
using System.Collections.Generic;
using System.Text;

namespace HwGame.Entities
{
    public class Platform
    {
        public int GameId { get; set; }
        public string GameName { get; set; }
        public int UnitsInStock { get; set; }
        public double Price { get; set; }   //Games
        public int GamerId { get; set; }
        public string GamerFirstName { get; set; }
        public string GamerLastName { get; set; }
        public string GamerTcNo { get; set; }
        public DateTime DateOfBirth { get; set; }   //Gamers
        public string SoldGameName { get; set; }
        public string GamerName { get; set; }   //GameSales
        public int CampaignId { get; set; }
        public string CampaignName { get; set; }//Campaign
    }
}
