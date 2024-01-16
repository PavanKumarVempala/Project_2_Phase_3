using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_1
{
    internal interface Team
    {
        void addPlayer(Player player);
        void removePlayer(int playerId);
        Player getPlayerById(int playerId);
        List<Player> getPlayerByName();
        List<Player> getAllPlayers();
    }
}
