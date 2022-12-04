using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;


namespace Space_Invaders
{
    //Clase Shot, la cual será para crear el disparo y los métodos de tanto el disparo del jugador como el de los aliens.
    internal class Shot
    {
        //Instanciamos el timer.
        private System.Timers.Timer timer = new System.Timers.Timer();
        //Instanciamos la ruta donde se encuentra la imagen del disparo.
        private string basePath = Environment.CurrentDirectory;
        private const string relativePath = "../../../assets/img/";
        
        public int damage { get; set; }
        public string image { get; set; }
        public int[] location { get; set; }
        public int[] size { get; set; }
        private bool typePiece { get; set; }
        private PictureBox pictureBox { get; set; }
        private Label label1 { get; set; }
        private Label label2 { get; set; }
        private PictureBox PBnave { get; set; }
        private List<PictureBox> listLifes { get; set; }

        private Form2 form2;

        public Shot(int damage, string image, int[] location, int[] size, bool typePiece, List<PictureBox> listLifes, Form2 form2)
        {
            this.damage = damage;
            this.image = Path.GetFullPath(relativePath + image, basePath);
            this.location = location;
            this.size = size;
            this.typePiece = typePiece;
            this.label1 = new Label();
            this.label2 = new Label();
            this.pictureBox = new PictureBox();
            this.PBnave = new PictureBox();
            this.listLifes = listLifes;
            this.form2 = form2;
        }

        public PictureBox CreateShot(Label label1, Label label2, PictureBox PBnave)
        {
            //Método para crear el PictureBox del shot (disparo).
            pictureBox.Image = Image.FromFile(image);
            pictureBox.Location = new Point(location[0], location[1]);
            pictureBox.Size = new Size(size[0], size[1]);
            pictureBox.Enabled = false;
            this.label1 = label1;
            this.label2 = label2;
            this.PBnave = PBnave;
            this.CreateTimer();
            return pictureBox;
        }

        private void Shoot()
        {
            //Método para 
            if (typePiece)
            {
               pictureBox.Location = new Point(pictureBox.Location.X, pictureBox.Location.Y - 10);
               KillAlien();
            }
            else
            {
                pictureBox.Location = new Point(pictureBox.Location.X, pictureBox.Location.Y + 10);
                KillPlayer();
            }
        }

        private void ShootEvent(Object source, ElapsedEventArgs e)
        {
            if(pictureBox.Location.Y > 0)
            {
                Shoot();
            }
            else
            {
                pictureBox.Visible = false;
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

        private void KillAlien()
        {
            //Método en el cual se validará si el disparo del jugador ha matado un alien.
            foreach(GamePiece alien in GamePiece.listAliens)
            {
                label2.Text = GamePiece.contador.ToString();
                if(pictureBox.Bounds.IntersectsWith(alien.pictureBox.Bounds))
                {
                    if(GamePiece.contador < GamePiece.listAliens.Count - 1)
                    {

                        //form2.Controls.Remove(pictureBox);
                        //pictureBox.Dispose();
                        pictureBox.Visible = false;
                        pictureBox.Location = new Point(0, 800);

                        //form2.Controls.Remove(alien.pictureBox);
                        //alien.pictureBox.Dispose();
                        alien.pictureBox.Visible = false;
                        alien.pictureBox.Location = new Point(0, 0);
                       

                        GamePiece.contador += 1;
                    }
                    else
                    {

                        // Eliminacion del disparo del form
                        //form2.Controls.Remove(pictureBox);
                        pictureBox.Visible = false;
                        pictureBox.Location = new Point(0, 800);


                        // Eliminacion del alien del form
                        alien.pictureBox.Visible = false;
                        alien.pictureBox.Location = new Point(0, 0);
                        form2.Close();

                        // Genera el form ganador
                        GeneratorNewForm3("img_win.jpg");

                        // Limpia la lista y el contador
                        GamePiece.listAliens.Clear();
                        GamePiece.contador = 0;
                    }

                    timer.Stop();
                }
            }

            if(pictureBox.Location.Y < -1)
            {
                timer.Stop();
            }
        }

        private void KillPlayer()
        {
            //Método en el cual se validará si el disparo del alien ha matado al jugador.
            if (pictureBox.Bounds.IntersectsWith(PBnave.Bounds))
            {
                //Se validará las vidas que tiene el jugador el cual tendrá 3 vidas y al perder las 3.
                if (listLifes[0].Visible == true)
                {
                    listLifes[0].Visible = false;
                }
                else if (listLifes[1].Visible == true)
                {
                    listLifes[1].Visible = false;
                }
                else if (listLifes[2].Visible == true)
                {
                    listLifes[2].Visible = false;
                    //Al perder las 3 vidas se esconderá la interfaz del juego y le mostrará una interfaz que informará que perdió
                    form2.Visible = false;
                    
                    GeneratorNewForm3("img_lose.jpg");
                    GamePiece.contador = 0;
                    //Limpia la lista de los aliens.
                    GamePiece.listAliens.Clear();
                }
                pictureBox.Location = new Point(0, 0);
                pictureBox.Visible = false;
                timer.Stop();
            }
            
            if(pictureBox.Location.Y > 800)
            {
                pictureBox.Location = new Point(0, 0);
                pictureBox.Visible = false;
                //dentendrá el contador.
                timer.Stop();

            }
        }

        private void GeneratorNewForm3(string result)
        {
            //Método en el cuál se creará la interfaz donde se le informará que el jugador perdió
            Form3 form = new Form3();
            form.BackgroundImage = Image.FromFile(Path.GetFullPath(relativePath + result, basePath));
            form.ShowDialog();
            form2.Close();
        }
    }
}
