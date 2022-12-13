using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using JeuxSerpent.utils;

namespace SnakeGame.utils
{
    public class GameLoop
    {
        private List<Player> players { get; set; }
        bool isGameFinished { get; set; }

        public GameLoop(List<Player> players)
        {
            this.players = players;
            isGameFinished = false;
        }

        public void startGame()
        {

            while (!isGameFinished)
            {
                foreach (Player player in players)
                {
                    player.drawDice();
                    Console.ReadLine();

                    //Cases cases = new Cases();
                    //cases.casePiege();

                    if (player.position == 50)
                    {
                        Console.WriteLine("Le joueur " + player.name + " a gagné");
                        isGameFinished = true;
                    }

                    if (player.position == 37)
                    {
                        int dice = Dice.draw();
                        Console.WriteLine("Vous êtes tombé sur une case piège !");
                        Console.WriteLine("Vous allez reculer de " + dice  + " cases");
                        Console.ReadLine();
                        player.position -= dice;
                    }


                }
            }
        }

        private bool CheckIfPlayerWin(Player player)
        {
            return player.position == 50;
        }
        
        public void setWinner(Player player)
        {
            isGameFinished = true;
            Console.WriteLine(player.name + " a gagné la partie");
        }





    }
}
