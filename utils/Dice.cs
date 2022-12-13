using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame.utils
{
    public static class Dice
    {
        private static Random random = new Random();


        public static int draw()
        {
            return random.Next(1, 6);
        }
    }
}
