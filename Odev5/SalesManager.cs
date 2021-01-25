using System;
using System.Collections.Generic;
using System.Text;

namespace Odev5
{
    class SalesManager
    {

        public void SaleToGame(Gamer gamer,Game game)

        {
            Console.WriteLine(game.GamePrice+" Tl Fiyatındaki "+game.GameName+" İsimli  Oyun "+gamer.FirstName+" İsimli Oyuncu Tarafından Satın Alındı " );
        
        
        
        
        }

        public void SaleToGameWithCampaign(Gamer gamer,Game game,Campaign campaign)
        {

            Console.WriteLine(game.GamePrice + " Tl Fiyatındaki " + game.GameName + " İsimli  Oyun " + gamer.FirstName + " İsimli Oyuncu Tarafından "+campaign.CampaignName+" Kampanyası Sayesinde %"+campaign.DiscountRate+" İndirim İle Satın Alındı");



        }



    }
}
