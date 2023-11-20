using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labor10
{
    public enum Position
    {
        kapus, vedo, center, tamado
    }
    class Player
    {
        string name;
        Position position;

        public Player(string name, Position position)
        {
            this.name = name;
            this.position = position;
        }

        public Position Position { get { return position; } }

        public override string ToString()
        {
            return this.name + " - " + this.position.ToString();
        }
    }
}
