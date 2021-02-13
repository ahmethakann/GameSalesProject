using GameProject.Entites;
using GameProject.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Methods
{
    class CampaignManager : ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine("Kampanyadan faydalandın : " + campaign.CampaignName + " İndirim Oranı: " + campaign.DiscountRate + '\n');
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " kampanya silindi." + '\n');
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine("Kampanya güncellendi! : " + campaign.CampaignName + " İndirim Oranı : " + campaign.NewDiscountRate + '\n');
        }
    }
}
