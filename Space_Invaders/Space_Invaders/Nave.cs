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
        /*Creamos esta clase para inicializar la pieza nave en la cual*/
        public Nave(int id, string image, int life, int[] location, int[] size) : base(id, image, life, location,  size)
        {
        }

        public void MoveNave(string direction, PictureBox pictureBox, Nave nave)
        {
            //Método para validar el rango de movimiento que tendrá la nave.
            switch (direction)
            {
                //En caso de que se presione la tecla izquierda (<-)
                case "left":
                    //Válidamos si la posición de la nave es mayor a 100px en el eje X
                    if(pictureBox.Location.X > 100)
                    {
                        //si es verdadera la válidación entonces se moverá hacía la izquierda 10 pixeles cada vez que se presione la tecla
                        pictureBox.Location = new Point(pictureBox.Location.X - 10, pictureBox.Location.Y);
                    }
                    break;
                //En caso de que se presione la tecla flecha derecha (->)
                case "right":
                //Válidamos si la posición de la nave es mayor a 950px en el eje X
                    if(pictureBox.Location.X < 950)
                    {
                        //si es verdadera la válidación entonces se moverá hacía la derecha 10 pixeles cada vez que se presione la tecla
                        pictureBox.Location = new Point(pictureBox.Location.X + 10, pictureBox.Location.Y);
                    }
                    break;
            }

        }
    }
}
