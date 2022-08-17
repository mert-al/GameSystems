using GameSystem.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSystem.Abstract
{
    interface IGamerCheckService
    {
        bool CheckGamerIfRealPErson(Gamer gamer);
    }
}
