using GameSystem.Abstract;
using GameSystem.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSystem.Concrete
{
    class GamerManager : IGamerService
    {
        IGamerCheckManager gamerCheckManager;
        private object _gamerCheckService;

        public void Add(Gamer gamer)
        {
            if (_gamerCheckService.CheckGamerIfRealPerson == true)
            {
                Console.WriteLine();
            }
            
            else
            {
                Console.WriteLine();
            }
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Registration has been  deleted");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Registration has been Updated");
        }
    }
}
