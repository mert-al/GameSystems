using GameSystem.Abstract;
using GameSystem.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSystem.Concrete
{
    class CampaingManager : ICampaingService
    {
        public void Add(Campaing campaing)
        {
            Console.WriteLine("A new campaign has been added");
        }

        public void Delete(Campaing campaing)
        {
            Console.WriteLine("The campaign has been deleted");
        }

        public void Update(Campaing campaing)
        {
            Console.WriteLine("The campaign has been Updated"); 
        }
    }
}
