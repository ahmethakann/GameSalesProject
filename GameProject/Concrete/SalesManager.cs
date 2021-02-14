using GameProject.Entites;
using GameProject.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Methods
{
    class SalesManager : ISalesService
    {
        public void CampaignSales(Game game, Gamer gamer, Campaign campaign)
        {
            Console.WriteLine(gamer.FirstName + " kullanıcısı " + campaign.CampaignName + " ile " + game.GameName + " oyununu aldı.");
        }

        public void Sales(Game game, Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + "  kullanıcısı " + game.GameName + " oyununu aldı.");
        }
    }
}
