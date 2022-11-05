using Microsoft.VisualBasic;
using System.Reflection;

namespace Space_Invaders
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            GeneratorAlien1();
            GeneratorAlien2();
            GeneratorAlien3();
        }

        public void GeneratorAlien1()
        {
            for(int i = 0; i < 5; i++)
            {
                Alien1 alien1 = new (i, "alien_1.gif", CustomLocation(i, 350), 100, CustomSize(80, 80));
                Controls.Add(alien1.CreatePiece());
            }
        }

        public void GeneratorAlien2()
        {
            for (int i = 0; i < 5; i++)
            {
            
                Alien2 alien2 = new(i, "alien_2.gif", CustomLocation(i, 200), 200, CustomSize(80, 80));
                Controls.Add(alien2.CreatePiece());
            }
        }

        public void GeneratorAlien3()
        {
            for (int i = 0; i < 5; i++)
            {
                Alien3 alien3 = new (i, "alien_3.gif", CustomLocation(i, 50), 100, CustomSize(80, 80));
                Controls.Add(alien3.CreatePiece());
            }
        }

        private static int[] CustomSize(int width, int height)
        {
            int[] size = new int[2];
            size[0] = width;
            size[1] = height;

            return size;
        }

        private static int[] CustomLocation(int index, int y)
        {
            int[] location = new int[2];
            location[0] = (index + 1) * 200;
            location[1] = y;

            return location;
        }


    }
}