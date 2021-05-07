using GameProject.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    class GameSellManager : IGameSellService
    {
        public void SellWithCampaign(Gamer gamer, Game game, Campaign campaign)
        {
            Console.WriteLine("Alıcı : "+gamer.FirstName + "\n"+
                game.Name + " " + game.Price + " Tl Yerine " +
                campaign.Name +" %" +campaign.Discount + " indirim ile " + 
                (game.Price - (game.Price*campaign.Discount/100)) +" Tl ye Alınmıştır"
                );
        }

        public void SellWithoutCampaign(Gamer gamer, Game game)
        {
            Console.WriteLine("Alıcı : "+gamer.FirstName + "\n" + game.Name + " " + game.Price + "Tl'ye Satın Alındı");
        }
    }
}
