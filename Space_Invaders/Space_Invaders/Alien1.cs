using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space_Invaders
{
    internal class Alien1 : GamePiece
    {
        public Alien1(int id, string image, int[] location, int life, int[] size) : base(id, image, location, life, size)
        {
        }
    }
}
