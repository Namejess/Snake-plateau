using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuxSerpent.utils
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
            int number = Dice.draw();
            position += number;
            if (position > 50) position = 25;
            Console.WriteLine(name + " a jeté son dès et à obtenu le score de " + number + " sa position est de " + position);
        }

    }
}
