using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space_Invaders
{
    internal class GamePiece
    {
        private string basePath = Environment.CurrentDirectory;
        private const string relativePath = "../../../assets/img/";
        public int id { get; set; }
        public string image { get; set; }
        public int[] location { get; set; }
        public int life { get; set; }
        public int[] size { get; set; }

        public GamePiece(int id, string image, int[] location, int life, int[] size)
        {
            this.id = id;
            this.image = Path.GetFullPath(relativePath + image, basePath);
            this.location = location;
            this.life = life;
            this.size = size;
        }

        public PictureBox CreatePiece()
        {
            PictureBox pictureBox = new ();
            pictureBox.Image = Image.FromFile(image);
            pictureBox.Location = new System.Drawing.Point(location[0], location[1]);
            pictureBox.Size = new System.Drawing.Size(size[0], size[1]);

            return pictureBox;
        }

    }
}
