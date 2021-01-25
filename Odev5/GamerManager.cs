using System;
using System.Collections.Generic;
using System.Text;

namespace Odev5
{
    class GamerManager: IGamerManager
    {
      private GamerCheckManager _gamerCheckManager= new GamerCheckManager();
        public void Add(Gamer gamer)
        {
            if (_gamerCheckManager.CheckIfRealPerson(gamer))
            {
                Console.WriteLine("Oyuncu Sisteme Eklendi");
            }

            else
            {
                Console.WriteLine("Oyununcunun Kimlik Bilgileri Uymadı");
            }
          
        }

        public void Delete()
        {
            Console.WriteLine("Oyuncu Sistemden Çıkartıldı");
        }

        public void Update()
        {
            Console.WriteLine("Oyuncu Verileri Güncellendi");
        }
    }
}
