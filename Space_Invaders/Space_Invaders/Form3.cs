using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Space_Invaders
{
    public partial class Form3 : Form
    {
        //Formulario que mostará la pantalla al ganar o perder.
        public Form3()
        {
            InitializeComponent();
        }

        private void btnGoMenu_Click(object sender, EventArgs e)
        {
            //Evento para cerrar este formulario al dar click en el botón
            Close();
        }
    }
}
