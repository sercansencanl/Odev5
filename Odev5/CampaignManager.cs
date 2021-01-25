using System;
using System.Collections.Generic;
using System.Text;

namespace Odev5
{
    class CampaignManager: IManager
    {

        public void Add()
        {
            Console.WriteLine("Kampanya Sisteme Eklendi");
        }

        public void Delete()
        {
            Console.WriteLine("Kampanya Sistemden Silindi");
        }

        public void Update()
        {
            Console.WriteLine("Kampanya Verileri Güncellendi");
        }


    }
}
