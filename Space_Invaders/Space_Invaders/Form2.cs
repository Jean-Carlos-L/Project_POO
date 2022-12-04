using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Space_Invaders
{
    public partial class Form2 : Form
    {
        private PictureBox PBnave = new PictureBox();
        Nave nave = new(1, "nave.gif", 300, GamePiece.CustomLocation(2, 550), GamePiece.CustomSize(100, 100));
        private List<PictureBox> listLifes = new List<PictureBox>();
        public Form2()
        {
            InitializeComponent();
            GeneratorAlien1();
            GeneratorAlien2();
            GeneratorAlien3();
            GeneratorNave();
            AddListLifes();
        }

        public void GeneratorAlien1()
        {
            for (int i = 0; i < 6; i++)
            {
                Alien1 alien1 = new(i, "alien_1.gif", 100, GamePiece.CustomLocation(i, 250), GamePiece.CustomSize(80, 80));
                GamePiece.listAliens.Add(alien1);
                Controls.Add(alien1.CreatePiece());
                alien1.CreateTimer();
            }
        }

        public void GeneratorAlien2()
        {
            for (int i = 0; i < 6; i++)
            {
                Alien2 alien2 = new(i, "alien_2.gif", 100, GamePiece.CustomLocation(i, 150), GamePiece.CustomSize(80, 80));
                GamePiece.listAliens.Add(alien2);
                Controls.Add(alien2.CreatePiece());
                alien2.CreateTimer();
            }
        }

        public void GeneratorAlien3()
        {
            for (int i = 0; i < 6; i++)
            {
                Alien3 alien3 = new(i, "alien_3.gif", 100, GamePiece.CustomLocation(i, 50), GamePiece.CustomSize(80, 80));
                GamePiece.listAliens.Add(alien3);
                Controls.Add(alien3.CreatePiece());
                alien3.CreateTimer();
            }
        }

        public void GeneratorNave()
        {
            Nave nave = new(1, "nave.gif", 300, GamePiece.CustomLocation(2, 550), GamePiece.CustomSize(100, 100));
            PBnave = nave.CreatePiece();
            Controls.Add(PBnave);
        }

        private void GeneratorShot()
        {
            int[] locationShot = new int[2];
            locationShot[0] = PBnave.Location.X + 35;
            locationShot[1] = 520;
            Shot shot = new(10, "shot.png", locationShot, GamePiece.CustomSize(32, 32), true, listLifes, this);
            Controls.Add(shot.CreateShot(label1, label2, PBnave));
        }

        private void AddListLifes()
        {
            listLifes.Add(vida1);
            listLifes.Add(vida2);
            listLifes.Add(vida3);
        }

        private void GenerarShotAlien()
        {
            int[] posicionDisparo = new int[2];
            posicionDisparo[0] = new Random().Next(150, 950);
            posicionDisparo[1] = 120;
            Shot shot = new Shot(10, "shot_alien.png", posicionDisparo, GamePiece.CustomSize(32, 32), false, listLifes, this);
            Controls.Add(shot.CreateShot(label1, label2, PBnave));
        }

        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    nave.MoveNave("left", PBnave, nave);
                    break;
                case Keys.Right:
                    nave.MoveNave("right", PBnave, nave);
                    break;
                case Keys.Space:
                    GeneratorShot();
                    break;
            }
        }

        private void Form2_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case 'a':
                    nave.MoveNave("left", PBnave, nave);
                    break;
                case 'd':
                    nave.MoveNave("right", PBnave, nave);
                    break;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            GenerarShotAlien();
        }
    }
}
