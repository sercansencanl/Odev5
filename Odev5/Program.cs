using System;
using System.Collections.Generic;

namespace Odev5
{
    class Program
    {
        static void Main(string[] args)
        {
            //oyuncuyu sisteme ekleyen kod
            IGamerManager gamerManager = new GamerManager();


            Gamer gamer = new Gamer();

            gamer.FirstName = "Sercan";
            gamer.LastName = "Şencanlı";
            gamer.NationaltyId = "05601561456";
            gamer.DateOfBrith = new DateTime(2004, 1, 4);

            gamerManager.Add(gamer);



            //oyunu ve kampanyayı sisteme ekleyen kod

            IManager gameManager = new GameManager();

            IManager campaignManager = new CampaignManager();

          

            List<IManager> managers = new List<IManager>() { gameManager,campaignManager };

            SystemManager systemManager = new SystemManager();

            //systemManager.AddToSystemForList(managers);



          

            Game game = new Game();

            game.GameName = "Metin99";
            game.GamePrice = 50;

            Campaign campaign = new Campaign();
            campaign.CampaignName = "Açılışa Özel";
            campaign.DiscountRate = 50;

            SalesManager salesManager = new SalesManager();

            //kampanyasız satış alış
            //salesManager.SaleToGame(gamer,game);


            //kampanyalı satış alış
            //salesManager.SaleToGameWithCampaign(gamer,game,campaign);



            Console.ReadLine();
        }
    }
}
