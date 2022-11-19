using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;


namespace Space_Invaders
{
    internal class Shot
    {
        private  System.Timers.Timer timer;

        private string basePath = Environment.CurrentDirectory;
        private const string relativePath = "../../../assets/img/";
        public int damage { get; set; }
        public string image { get; set; }
        public int[] location { get; set; }
        public int[] size { get; set; }

        private PictureBox pictureBox { get; set; }

        Label label1;
        Label label2;

        public Shot(int damage, string image, int[] location, int[] size)
        {
            this.damage = damage;
            this.image = Path.GetFullPath(relativePath + image, basePath);
            this.location = location;
            this.size = size;
        }

        public PictureBox CreateShot(Label label1, Label label2)
        {
            pictureBox = new PictureBox();
            pictureBox.Image = Image.FromFile(image);
            pictureBox.Location = new Point(location[0], location[1]);
            pictureBox.Size = new Size(size[0], size[1]);
            pictureBox.Enabled = false;
            this.label1 = label1;
            this.label2 = label2;
            this.CreateTimer();
            return pictureBox;
        }

        private void Shoot()
        {
           pictureBox.Location = new Point(pictureBox.Location.X, pictureBox.Location.Y - 10);
        }

        private void ShootEvent(Object source, ElapsedEventArgs e)
        {
            if(pictureBox.Location.Y > 50)
            {
                Shoot();
            }
            else
            {
                label2.Text = "Paro Timer";
                timer.Stop();
            }
        }

        private void CreateTimer()
        {
            timer = new(50);
            timer.Elapsed += ShootEvent;
            timer.AutoReset = true;
            timer.Enabled = true;
        }
    }
}
