using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galactica_Opgave_Kasper
{
    class Star : SpaceObjects
    {
        public double Temperature { get; set; }

        public List<Planet> PlanetList = new List<Planet>();

        public Startype Type { get; set; }

        
       

    }
}

