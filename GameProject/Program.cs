using GameProject.Concrete;
using System;
using System.Collections.Generic;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            Gamer gamer1 = new Gamer();
            gamer1.Id = 1;
            gamer1.FirstName = "Tolga";
            gamer1.LastName = "Sözbir";
            gamer1.BirthYear = 1996;
            gamer1.IdentityNumber = 12345;
            gamerManager.Add(gamer1);

            CampaignManager campaignManager = new CampaignManager();
            Campaign campaign1 = new Campaign();
            campaign1.Id = 1;
            campaign1.Name = "Black Friday";
            campaign1.Discount = 30;
            campaignManager.Add(campaign1);


            GameManager gameManager = new GameManager();
            Game game1 = new Game();
            game1.Id = 1;
            game1.Name = "The Witcher 3: Wild Hunt";
            game1.Price = 60;

            Game game2 = new Game();
            game2.Id = 2;
            game2.Name = "frostpunk";
            game2.Price = 50;

            List<Game> games = new List<Game>{ game1,game2 };
            Console.WriteLine("Oyun Listesi");
            gameManager.GameList(games);

            Console.WriteLine();
            GameSellManager gameSellManager = new GameSellManager();
            gameSellManager.SellWithCampaign(gamer1, game1, campaign1);
            Console.WriteLine();
            gameSellManager.SellWithoutCampaign(gamer1, game2);

        }
    }
}
