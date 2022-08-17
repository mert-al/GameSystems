using GameSystem.Abstract;
using GameSystem.Adapters;
using GameSystem.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSystem.Concrete
{
    class GamerCheckManager : IGamerCheckService
    {
        IGamerCheckService _gamerCheckService;
        public bool CheckGamerIfRealPErson(Gamer gamer)
        {
            _gamerCheckService = new MernisServiceAdapter();
            return _gamerCheckService.CheckGamerIfRealPErson(gamer);
        }
    }
}
