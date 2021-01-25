using System;
using System.Collections.Generic;
using System.Text;

namespace Odev5
{
    class GameManager: IManager
    {
        public void Add()
        {
            Console.WriteLine("Oyun Sisteme Eklendi");
        }

        public void Delete()
        {
            Console.WriteLine("Oyun Sistemden Silindi");
        }

        public void Update()
        {
            Console.WriteLine("Oyun Verileri Güncellendi");
        }
    }
}
