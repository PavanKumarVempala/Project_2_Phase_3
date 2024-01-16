using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FastPace_CricketAcademy team = new FastPace_CricketAcademy();

            while (true)
            {
                Console.WriteLine("Choose an option:");
                Console.WriteLine("1. Add Player");
                Console.WriteLine("2. Remove Player");
                Console.WriteLine("3. Get Player by Id");
                Console.WriteLine("4. Get Players by Name");
                Console.WriteLine("5. Get All Players");
                Console.WriteLine("6. Exit");

                if (int.TryParse(Console.ReadLine(), out int choice))
                {
                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("Enter Player Id:");
                            int playerId = int.Parse(Console.ReadLine());

                            Console.WriteLine("Enter Player Name:");
                            string playerName = Console.ReadLine();

                            Console.WriteLine("Enter Player Age:");
                            int playerAge = int.Parse(Console.ReadLine());

                            team.AddPlayer(new Player { id = playerId, name = playerName, age = playerAge });
                            break;

                        case 2:
                            Console.WriteLine("Enter Player Id to remove:");
                            int playerIdToRemove = int.Parse(Console.ReadLine());

                            team.RemovePlayer(playerIdToRemove);
                            break;

                        case 3:
                            Console.WriteLine("Enter Player Id to get details:");
                            int playerIdToGet = int.Parse(Console.ReadLine());

                            Player playerById = team.getPlayerById(playerIdToGet);
                            if (playerById != null)
                            {
                                Console.WriteLine($"Player Found: Id: {playerById.id}, Name: {playerById.name}, Age: {playerById.age}");
                            }
                            else
                            {
                                Console.WriteLine("Player not found.");
                            }
                            break;

                        case 4:
                            Console.WriteLine("Enter Player Name to get details:");
                            string playerNameToGet = Console.ReadLine();

                            List<Player> playersByName = team.getPlayersByName(playerNameToGet);
                            if (playersByName.Count > 0)
                            {
                                Console.WriteLine($"Players Found with name '{playerNameToGet}':");
                                foreach (Player player in playersByName)
                                {
                                    Console.WriteLine($"Id: {player.id}, Name: {player.name}, Age: {player.age}");
                                }
                            }
                            else
                            {
                                Console.WriteLine($"No players found with name '{playerNameToGet}'.");
                            }
                            break;

                        case 5:
                            List<Player> allPlayers = team.getAllPlayers();
                            Console.WriteLine("All Players:");
                            foreach (Player player in allPlayers)
                            {
                                Console.WriteLine($"Id: {player.id}, Name: {player.name}, Age: {player.age}");
                            }
                            break;

                        case 6:
                            Console.WriteLine("Exiting the program.");
                            Environment.Exit(0);
                            break;

                        default:
                            Console.WriteLine("Invalid choice. Please choose correct option.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }

                Console.WriteLine();
            }
        }
    }
}