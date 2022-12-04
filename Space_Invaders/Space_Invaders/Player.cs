using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space_Invaders
{
    internal class Player
    {
        //Clase Player para registrar el nombre y el puntaje del jugador.
        public string name { get; set; }
        public string score { get; set; }

        public Player(string name, string score)
        {
            this.name = name;
            this.score = score;
        }
    }
}
