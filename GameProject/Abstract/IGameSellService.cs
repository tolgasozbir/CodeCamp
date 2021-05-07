using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Abstract
{
    interface IGameSellService
    {
        void SellWithoutCampaign(Gamer gamer, Game game);
        void SellWithCampaign(Gamer gamer, Game game, Campaign campaign);
    }
}
