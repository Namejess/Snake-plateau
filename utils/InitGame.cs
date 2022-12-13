using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SnakeGame.utils;

namespace JeuxSerpent.utils
{
    internal class InitGame
    {
        public static void initGame()
        {
            List<Player> players = askAllPlayersInformation();
            GameLoop loop = new GameLoop(players);
            loop.startGame();
        }

        private static List<Player> askAllPlayersInformation()
        {
            List<Player> players = new List<Player>();
            int playerCount = askPlayerNumbers();
            for (int i = 0; i < playerCount; i++)
                players.Add(askOnePlayerInformation(i));
            return players;
        }

        private static Player askOnePlayerInformation(int numberPlayer)
        {
            Console.WriteLine("Joueur " + (numberPlayer + 1) + " :");
            Console.WriteLine("Quel est votre nom ?");
            string name = Console.ReadLine();
            return new Player(name);
        }

        private static int askPlayerNumbers()
        {
            Console.WriteLine("Combien de joueur êtes-vous ?");
            return Convert.ToInt32(Console.ReadLine());
        }
    }
}
