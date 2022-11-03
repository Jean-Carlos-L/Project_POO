using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space_Invaders
{
    internal class GamePiece
    {
        public int id { get; set; }
        public string image { get; set; }
        public int[] location { get; set; }
        public int life { get; set; }
        public int[] size { get; set; }

        public GamePiece(int id, string image, int[] location, int life, int[] size)
        {
            this.id = id;
            this.image = image;
            this.location = location;
            this.life = life;
            this.size = size;
        }
    }
}
