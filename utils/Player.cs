using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame.utils
{
    public class Player
    {
        public string name { get;set; }
        public int position { get; set; }

        public Player (string name)
        {
            this.name = name;
        }

        public void drawDice()
        {
            int dice = Dice.draw();
            Console.WriteLine("Le joueur " + name + " a fait " + dice);
            position += dice;
            Console.WriteLine("Le joueur " + name + " est sur la case " + position);
        }

    }
}
