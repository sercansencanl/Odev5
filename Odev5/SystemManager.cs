using System;
using System.Collections.Generic;
using System.Text;

namespace Odev5
{
    class SystemManager
    {

        public void AddToSystem(IManager manager)

        {
            manager.Add();
        
        
        
        }

        public void DeleteToSystem(IManager manager)

        {
            manager.Delete();



        }



        public void UpdateToSystem(IManager manager)

        {
            manager.Update();



        }

        //birden fazla veriyi kaydetmek için list ile kodları tekrar yazıcam

        public void AddToSystemForList(List<IManager> entities)
        {
            foreach (var entity in entities)
            {
                entity.Add();
            }
        
        
        }


        public void DeleteToSystemForList(List<IManager> entities)
        {
            foreach (var entity in entities)
            {
                entity.Delete();
            }


        }

        public void UpdateToSystemForList(List<IManager> entities)
        {
            foreach (var entity in entities)
            {
                entity.Update();
            }


        }

    }
}
