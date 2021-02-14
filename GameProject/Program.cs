using GameProject.Concrete;
using GameProject.Entities;
using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            Gamer gamer1 = new Gamer()
            {
                Id = 1,
                FirstName = "Onur",
                LastName = "Yıldız",
                IdentityNumber = "68413561",
                BirthYear = 1992

            };
            Gamer gamer2 = new Gamer()
            {
                Id = 2,
                FirstName = "Muharrem",
                LastName = "Kehribar",
                IdentityNumber = "56398635",
                BirthYear = 1998
            };
            gamerManager.Add(gamer1);
            Game game1 = new Game() { GameName = "AGE OF 2", GameId = 1, GamePrice = 50, Discount = 15};
            Game game2 = new Game() { GameName = "DESPERADOS 2", GameId = 2, GamePrice = 25, Discount = 10 };
            Game game3 = new Game() { GameName = "THE GODFATHER", GameId = 3, GamePrice = 10, Discount = 3 };

            Campaign campaign1 = new Campaign() { CampaingId = 1, CampaingName = "New Year Campaign", DiscountRate = 20 };
            Campaign campaign2 = new Campaign() { CampaingId = 2, CampaingName = "Spring Campaign", DiscountRate = 15 };

            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(campaign1);
            campaignManager.Add(campaign2);

            SalesManager salesManager = new SalesManager();
            salesManager.Sales(gamer1, game2);
            salesManager.CampaignSales(game2, gamer1, campaign2);

        }
    }
}
