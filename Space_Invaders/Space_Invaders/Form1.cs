using Microsoft.VisualBasic;
using System.Reflection;
using System.Timers;

namespace Space_Invaders
{
    public partial class Form1 : Form
    {
        PictureBox PBnave;
        Nave nave;
        public Form1()
        {
            InitializeComponent();
            GeneratorAlien1();
            GeneratorAlien2();
            GeneratorAlien3();
            GeneratorNave();
        }

        public void GeneratorAlien1()
        {
            for(int i = 0; i < 6; i++)
            {
                Alien1 alien1 = new (i, "alien_1.gif", 100, GamePiece.CustomLocation(i, 300), GamePiece.CustomSize(80, 80));
                alien1.CreateTimer();
                Controls.Add(alien1.CreatePiece());
            }
        }

        public void GeneratorAlien2()
        {
            for (int i = 0; i < 6; i++)
            {
                Alien2 alien2 = new(i, "alien_2.gif", 100, GamePiece.CustomLocation(i, 200), GamePiece.CustomSize(80, 80));
                alien2.CreateTimer();
                Controls.Add(alien2.CreatePiece());
            }
        }

        public void GeneratorAlien3()
        {
            for (int i = 0; i < 6; i++)
            {
                Alien3 alien3 = new(i, "alien_3.gif", 100, GamePiece.CustomLocation(i, 100), GamePiece.CustomSize(80, 80));
                alien3.CreateTimer();
                Controls.Add(alien3.CreatePiece());
            }
        }

        public void GeneratorNave()
        {
            nave = new(1, "nave.gif", 300, GamePiece.CustomLocation(2, 550), GamePiece.CustomSize(100, 100));
            PBnave = nave.CreatePiece();
            Controls.Add(PBnave);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    nave.MoveNave("left", PBnave, nave);
                    break;
                case Keys.Right:
                    nave.MoveNave("right", PBnave, nave);
                    break;
            }
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}