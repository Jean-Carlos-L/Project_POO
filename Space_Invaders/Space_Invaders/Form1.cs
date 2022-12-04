using Microsoft.VisualBasic;
using System.Reflection;
using System.Timers;

namespace Space_Invaders
{
    public partial class Form1 : Form
    {
        // Formulario principal donde se mostrará el inicio del juego.
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //si el jugador da click en el button se dará inicio al juego.
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }
    }
}
