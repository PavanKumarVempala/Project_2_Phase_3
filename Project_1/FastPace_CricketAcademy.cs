using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_1
{
    public class FastPace_CricketAcademy
    {
        private List<Player> playerList;
        public FastPace_CricketAcademy()
        {
            playerList = new List<Player>();
        }
        public void AddPlayer(Player player)
        {
            if (playerList.Count < 11)
            {
                playerList.Add(player);
                Console.WriteLine("Player {0} added to the team", player.name);
            }
            else
            {
                Console.WriteLine("Cannot add player because the team already have 11 players");
            }
        }
        public void RemovePlayer(int playerId)
        {
            Player playerToBeRemoved = playerList.FirstOrDefault(p => p.id == playerId);
            if (playerToBeRemoved != null)
            {
                playerList.Remove(playerToBeRemoved);
                Console.WriteLine("Player {0} is removed from team", playerToBeRemoved.name);
            }
            else
            {
                Console.WriteLine("Cannot find the player with Id {0}", playerId);
            }
        }
        public Player getPlayerById(int playerId)
        {
            return playerList.FirstOrDefault(p => p.id == playerId);
        }
        public List<Player> getPlayersByName(string playerName)
        {
            return playerList.Where(p => p.name.Equals(playerName, StringComparison.OrdinalIgnoreCase)).ToList();
        }
        public List<Player> getAllPlayers()
        {
            return playerList.ToList();
        }
    }
}