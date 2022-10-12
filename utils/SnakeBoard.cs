using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace JeuxSerpent.utils
{
    public class SnakeBoard
    {
        private int mapLength { get; set; }
        private List<Player> players { get; set; }
        bool isGameFinished { get; set; }

        public SnakeBoard(int length, List<Player> players)
        {
            this.mapLength = length;
            this.players = players;
            this.isGameFinished = false;
        } 
        
        public void startGame()
        {
            while (!isGameFinished)
                foreach (Player player in players)
                {
                    player.drawDice();
                    if (CheckIfPlayerWin())
                        break;
                }
        }
                      
        private bool CheckIfPlayerWin()
        {
            foreach (Player player in players)
                if (player.position == mapLength)
                    return HandleWinnerPlayer(player);
            return false;
        }

        private bool HandleWinnerPlayer(Player player)
        {
            this.isGameFinished = true;
            Console.WriteLine("Le joueur " + player.name + " a gagné la partie !");
            return true;
        }
        
        
    }
}
