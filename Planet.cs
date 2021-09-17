using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galactica_Opgave_Kasper
{
    class Planet : SpaceObjects
    {

        public double Diameter { get; set; } //Meter

        public double RotationPeriod { get; set; } //Timer

        public double RevolutionPeriod { get; set; } //Dage        

        public List<Moon> MoonList = new List<Moon>();

        public PlanetType Type { get; set; }

        double Distance(Moon moon)
        {         
            return Math.Sqrt(Math.Pow(moon.position.X - position.X, 2) + Math.Pow(moon.position.Y - position.Y, 2));
            //(x2 - x1)²+(y2 - y1)²)
        }
    }


}
