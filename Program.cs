using GameProject.Entites;
using GameProject.Methods;
using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager1 = new GamerManager(new UserValidationManager());
            Gamer gamer1 = new Gamer() { Id = 1, BirthYear = 1999, FirstName = "Ahmet", LastName = "Özgüven", IdentityNumber = 1231231231 };
            GamerManager gamerManager2 = new GamerManager(new UserValidationManager());
            Gamer gamer2 = new Gamer() { Id = 2, BirthYear = 2002, FirstName = "Mehmet", LastName = "Yıldırım", IdentityNumber = 1231231232 };

            Game game1 = new Game() { Id = 5, GameName = "CS GO", GamePrice = 35 };
            Game game2 = new Game() { Id = 6, GameName = "ETS 2", GamePrice = 30 };
            Game game3 = new Game() { Id = 7, GameName = "Battlefield 1", GamePrice = 120 };


            Campaign campaign1 = new Campaign() { CampaignName = "A Kampanyası", DiscountRate = 3, NewDiscountRate = 5, CampaignId = 1 };
            Campaign campaign2 = new Campaign() { CampaignName = "B Kampanyası", DiscountRate = 8, NewDiscountRate = 14, CampaignId = 2 };


            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(campaign1);
            campaignManager.Add(campaign2);
            campaignManager.Update(campaign1);
            campaignManager.Update(campaign2);
            campaignManager.Delete(campaign1);
            campaignManager.Delete(campaign2);

            SalesManager salesManager = new SalesManager();
            salesManager.Sales(game2, gamer1);
            salesManager.CampaignSales(game3, gamer2, campaign1);


        }
    }
   
}

