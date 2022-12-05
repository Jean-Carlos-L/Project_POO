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
        //Clase padre para las piezas del juego como alien1, alien2, alien3 y la nave.
        public static System.Timers.Timer timer = new System.Timers.Timer();

        //Creamos variables auxiliares, una para validar los movimientos y otras como contadores
        bool mov = true;
        int iLocation = 0;
        public static int contador = 0;
        
        //Instanciamos los valores y direcciones que necesitamos para traer nuestra imagen.
        private string basePath = Environment.CurrentDirectory;
        private const string relativePath = "../../../assets/img/";

        //Creamos una lista que contiene objetos de GamePiece
        public static List<GamePiece> listAliens = new List<GamePiece>();
        

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
            //Metodo para instanciar y crear los PictureBox que solicitemos.
            pictureBox.Image = Image.FromFile(image);
            pictureBox.Location = new Point(location[0], location[1]);
            pictureBox.Size = new Size(size[0], size[1]);
            return pictureBox;
        }

        public static int[] CustomSize(int width, int height)
        {
            //Método para instanciar el array del Size (tamaño) para los pictureBox
            int[] size = new int[2];
            size[0] = width;
            size[1] = height;

            return size;
        }

        public static int[] CustomLocation(int index, int y)
        {
            //Método para instanciar el array de la Location (Posición) para los pictureBox
            int[] location = new int[2];
            location[0] = index * 110 + 350;
            location[1] = y;

            return location;
        }

        private void MoveEvent(Object source, ElapsedEventArgs e)
        {
            //Evento que realizará el movimiento de la pictureBox de las clases alien1, alien2 y alien3.
            Move(pictureBox.Location.X, pictureBox.Location.Y);
        }

       
        private void Move(int index, int y)
        {
            //Método para validar el movimiento de las clases alien
            
            //Creamos un array de tamaño dos para almacenar el X y Y de la location
            int[] location1 = new int[2];
            //Validamos si nuestra variable mov es true o false
            if (mov)
            {
                //Si es verdadero, primero valida si el contador ha llegado a 6, sino mueve hacia la derecha
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
                //Si es falso. primero válida si el contador ha llegado a -13, sino se mueve a la izquierda
                if(iLocation == -13)
                {
                    mov = true;
                }
                location1[0] = index - 20;
                location1[1] = y;
                iLocation -= 1;
            }

            //Devolvemos la posición almacenada en el array Location1[]
            pictureBox.Location = new Point(location1[0], location1[1]);
        }

        public void CreateTimer()
        {
            //Método para crear el timer el cuál será asignado para el movimiento de los aliens
            timer = new(500);
            timer.Elapsed += MoveEvent;
            timer.AutoReset = true;
            timer.Enabled = true;
        }

    }
}

