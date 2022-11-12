using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Space_Invaders
{
    internal class Nave : GamePiece
    {
        public Nave(int id, string image, int life, int[] location, int[] size) : base(id, image, life, location,  size)
        {
        }

        public void MoveNave(string direction, PictureBox pictureBox, Nave nave)
        {
            switch (direction)
            {
                case "left":
                    if(pictureBox.Location.X > 100)
                    {
                        pictureBox.Location = new Point(pictureBox.Location.X - 10, pictureBox.Location.Y);
                    }
                    break;
                case "right":
                    if(pictureBox.Location.X < 950)
                    {
                        pictureBox.Location = new Point(pictureBox.Location.X + 10, pictureBox.Location.Y);
                    }
                    break;
            }

        }
    }
}
