using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space_Invaders
{
    internal class Player
    {
        public string name { get; set; }
        public string score { get; set; }

        public Player(string name, string score)
        {
            this.name = name;
            this.score = score;
        }
    }
}
