using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space_Invaders
{
    internal class Alien3 : GamePiece
    {
        public Alien3(int id, string image, int life, int[] location, int[] size) : base(id, image, life, location, size)
        {
        }
    }
}
