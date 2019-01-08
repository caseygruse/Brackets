using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brackets
{
    class Bowler
    {
        public string Name { get; set; }

        public int Game1 { get; set; }

        public int Game2 { get; set; }

        public int Game3 { get; set; }

        public Bowler(string name, int game1, int game2, int game3)
        {
            this.Name = name;
            this.Game1 = game1;
            this.Game2 = game2;
            this.Game3 = game3;
        }
        public override string ToString()
        {
            return Name + "";
        }
    }
    
}
