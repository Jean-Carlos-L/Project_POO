using Microsoft.VisualBasic;
using System.Reflection;

namespace Space_Invaders
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            pictureBoxCreate();
        }

        public void pictureBoxCreate()
        {
            string basePath = Environment.CurrentDirectory;
            string relativePath = "../../../assets/img/nave.gif";
            string finalPath = Path.GetFullPath(relativePath, basePath);
            PictureBox pictureImage = new PictureBox();
            pictureImage.Image = Image.FromFile(finalPath);
            pictureImage.Location = new System.Drawing.Point(100, 100);
            pictureImage.Size = new System.Drawing.Size(100, 100);
            Controls.Add(pictureImage);
            System.Diagnostics.Debug.WriteLine(finalPath);
        }
        
        
    }
}