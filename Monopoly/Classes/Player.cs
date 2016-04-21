using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly.Classes
{
    public class Player
    {
        public string Name;
        public int Cash;
        public int Turn;
        public int Position;
        public List<Property> Properties = new List<Property>();

        public Player(string name)
        {
            Name = name;
            Cash = 1500;
            Position = 1;
        }
    }
}
