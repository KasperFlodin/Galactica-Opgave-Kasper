using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galactica_Opgave_Kasper
{
    abstract class SpaceObjects
    {
        public int id { get; set; }
        public string Name { get; set; }
        public Position position { get; set; }

        public enum Startype { YellowDwarf, White, BlueNeutron, RedGiant}

        public enum PlanetType { Terrestial, Giant, Dwarf, Gas_Giant }

        public class Position
        {
            public int X { get; set; }
            public int Y { get; set; }

            public override string ToString()
            {
                return $"({X},{Y})";
            }

        }
    }
    

}
