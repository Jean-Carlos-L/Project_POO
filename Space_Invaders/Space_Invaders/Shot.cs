using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space_Invaders
{
    internal class Shot
    {
        private string basePath = Environment.CurrentDirectory;
        private const string relativePath = "../../../assets/img/";
        public int damage { get; set; }
        public string image { get; set; }

        public Shot(int damage, string image)
        {
            this.damage = damage;
            this.image = Path.GetFullPath(relativePath + image, basePath); ;
        }
    }
}
