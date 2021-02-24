using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo
{
    public class SalesServices : ISalesServices
    {
        public void Sales(Game game, Gamer gamer)
        {
            Console.WriteLine(gamer.UserName + " isimli oyuncu " + game.GameName + 
                "isimli oyunu satın aldı");
        }

        public void SaleswithCampaign(Game game, Gamer gamer, Campaign campaign)
        {
            onsole.WriteLine(gamer.UserName + " isimli oyuncu " + game.GameName +
                 "isimli oyunu kampanya fiyatı ile satın aldı");
        }
    }
}
