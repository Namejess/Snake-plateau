using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuxSerpent.utils
{
    public static class Dice
    {
        private static Random random = new Random();
        private static int numberOfFace { get; set; }

        public static int draw()
        {
            return random.Next(1, 7);
        }
    }
}
