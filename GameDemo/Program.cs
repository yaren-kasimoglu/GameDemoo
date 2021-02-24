using System;

namespace GameDemo
{
    class Program
    {
        static void Main(string[] args)
        { 
            //Oyuncular
            Gamer gamer = new Gamer();
            gamer.UserIdNo = 1;
            gamer.UserName = "Yaren";
            gamer.Gmail = "yagmurryaren.35@gmail.com";

            Gamer gamer2 = new Gamer();
            gamer2.UserIdNo = 2;
            gamer2.UserName = "Furkan";
            gamer2.Gmail = "mercann.furkan@gmail.com";

            //Oyunlar

            Game game = new Game();
            game.GameId = 1212;
            game.GameName = "CSGO";
            game.GamePrice = 50;

            Game game2 = new Game();
            game2.GameId = 1313;
            game2.GameName = "FIFA19";
            game2.GamePrice = 100;

            Campaign campaign1 = new Campaign();
            campaign1.CampaignId = 0;
            campaign1.CampaignName = "Season Discount";
            campaign1.Discount = 10;


            SalesServices salesServices = new SalesServices();
            salesServices.Sales(game, gamer);
            salesServices.SaleswithCampaign(game2, gamer2, campaign1);


        }
    }
}
