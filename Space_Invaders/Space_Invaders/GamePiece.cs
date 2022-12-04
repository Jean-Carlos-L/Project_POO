using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Space_Invaders
{
    internal class GamePiece
    {
        public static System.Timers.Timer timer = new System.Timers.Timer();
        bool mov = true;
        int iLocation = 0;
        private string basePath = Environment.CurrentDirectory;
        private const string relativePath = "../../../assets/img/";

        public static List<GamePiece> listAliens = new List<GamePiece>();
        public static int contador = 0;

        public int id { get; set; }
        public string image { get; set; }
        public int life { get; set; }
        public int[] location { get; set; }
        public int[] size { get; set; }

        public PictureBox pictureBox = new();


        public GamePiece(int id, string image, int life, int[] location, int[] size)
        {
            this.id = id;
            this.image = Path.GetFullPath(relativePath + image, basePath);
            this.life = life;
            this.location = location;
            this.size = size;
        }

        public PictureBox CreatePiece()
        {
            pictureBox.Image = Image.FromFile(image);
            pictureBox.Location = new Point(location[0], location[1]);
            pictureBox.Size = new Size(size[0], size[1]);
            return pictureBox;
        }

        public static int[] CustomSize(int width, int height)
        {
            int[] size = new int[2];
            size[0] = width;
            size[1] = height;

            return size;
        }

        public static int[] CustomLocation(int index, int y)
        {
            int[] location = new int[2];
            location[0] = index * 110 + 350;
            location[1] = y;

            return location;
        }

        private void MoveEvent(Object source, ElapsedEventArgs e)
        {
            Move(pictureBox.Location.X, pictureBox.Location.Y);
        }

        private void Move(int index, int y)
        {
            int[] location1 = new int[2];

            if (mov)
            {
                if(iLocation == 6)
                {
                    mov = false;
                }
                location1[0] = index + 20;
                location1[1] = y;
                iLocation += 1;
            }
            else
            {
                if(iLocation == -13)
                {
                    mov = true;
                }
                location1[0] = index - 20;
                location1[1] = y;
                iLocation -= 1;
            }

            pictureBox.Location = new Point(location1[0], location1[1]);
        }

        public void CreateTimer()
        {
            timer = new(500);
            timer.Elapsed += MoveEvent;
            timer.AutoReset = true;
            timer.Enabled = true;
        }

    }
}
