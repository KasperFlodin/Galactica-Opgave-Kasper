using System;
using System.Collections.Generic;
using System.ComponentModel;
using static Galactica_Opgave_Kasper.SpaceObjects;

namespace Galactica_Opgave_Kasper
{
    class Program
    {        
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Program p = new Program();
            
            Star s = p.AddPlanet();
            p.ShowAllPlanets(s.PlanetList);       
        }

        public  void ShowAllPlanets(List<Planet> Planetlist)
        {
            Console.WriteLine("\n SHOW ALL Planets ");
            foreach (var Planet in Planetlist)
            {
                Console.WriteLine("");
                foreach (PropertyDescriptor descriptor in TypeDescriptor.GetProperties(Planet))
                {
                    string name = descriptor.Name;
                    object value = descriptor.GetValue(Planet);
                    Console.WriteLine($"{name}: {value}");
                }

            }
        }

        public Star AddPlanet()
        {
            
            Star Sun = new Star();
            Sun = new Star()
            {
                id = 1,
                Name = "Sun",
                position = new SpaceObjects.Position() { X = 0, Y = 0 },
                Temperature = 15009684,
                Type = SpaceObjects.Startype.YellowDwarf,

            };

            Planet Mercury = new Planet()
            {
                id = 1,
                Name = "Mercury",
                position = new SpaceObjects.Position() { X = 20, Y = 50 },
                Type = SpaceObjects.PlanetType.Giant,
                Diameter = 270000,
                RotationPeriod = 25,
                RevolutionPeriod = 2,                
            }; 
            Sun.PlanetList.Add(Mercury);

            Planet Venus = new Planet()
            {
                id = 2,
                Name = "Venus",
                position = new SpaceObjects.Position() { X = 40, Y = 90 },
                Type = SpaceObjects.PlanetType.Gas_Giant,
                Diameter = 3300000,
                RotationPeriod = 210,
                RevolutionPeriod = 36
            };
            Sun.PlanetList.Add(Venus);

            Planet Earth = new Planet()
            {
                id = 3,
                Name = "Earth",
                position = new SpaceObjects.Position() { X = 66, Y = 621 },
                Type = SpaceObjects.PlanetType.Terrestial,
                Diameter = 154000,
                RotationPeriod = 290,
                RevolutionPeriod = 40
            };
            Sun.PlanetList.Add(Earth);

            Planet Mars = new Planet()
            {
                id = 4,
                Name = "Mars",
                position = new SpaceObjects.Position() { X = 100, Y = 120 },
                Type = SpaceObjects.PlanetType.Giant,
                Diameter = 710000,
                RotationPeriod = 300,
                RevolutionPeriod = 51
            };
            Sun.PlanetList.Add(Earth);

            Planet Jupiter = new Planet()
            {
                id = 5,
                Name = "Jupiter",
                position = new SpaceObjects.Position() { X = 55, Y = 130 },
                Type = SpaceObjects.PlanetType.Gas_Giant,
                Diameter = 440000,
                RotationPeriod = 270,
                RevolutionPeriod = 24
            };
            Sun.PlanetList.Add(Jupiter);

            Planet Saturn = new Planet()
            {
                id = 6,
                Name = "Saturn",
                position = new SpaceObjects.Position() { X = 130, Y = 190 },
                Type = SpaceObjects.PlanetType.Terrestial,
                Diameter = 820000,
                RotationPeriod = 280,
                RevolutionPeriod = 45
            };
            Sun.PlanetList.Add(Saturn);

            Planet Uranus = new Planet()
            {
                id = 7,
                Name = "Uranus",
                position = new SpaceObjects.Position() { X = 200, Y = 290 },
                Type = SpaceObjects.PlanetType.Dwarf,
                Diameter = 330000,
                RotationPeriod = 410,
                RevolutionPeriod = 10
            };
            Sun.PlanetList.Add(Uranus);

            Moon Luna = new Moon()
            {
                id = 1,
                Name = "Luna",
                position = new SpaceObjects.Position() { X = 10, Y = 15 },
                Type = SpaceObjects.PlanetType.Terrestial,
                Diameter = 9000,
                RotationPeriod = 20,
                RevolutionPeriod = 18,
                Orbiting = Earth
            };
            Earth.MoonList.Add(Luna);

            Moon Titan = new Moon()
            {
                id = 2,
                Name = "Titan",
                position = new SpaceObjects.Position() { X = 135, Y = 195 },
                Type = SpaceObjects.PlanetType.Terrestial,
                Diameter = 2570,
                RotationPeriod = 400,
                RevolutionPeriod = 16,
                Orbiting = Saturn
            };
            Saturn.MoonList.Add(Titan);

            Moon Phobos = new Moon()
            {
                id = 3,
                Name = "Phobos",
                position = new SpaceObjects.Position() { X = 105, Y = 125 },
                Type = SpaceObjects.PlanetType.Terrestial,
                Diameter = 13000,
                RotationPeriod = 34,
                RevolutionPeriod = 26,
                Orbiting = Mars
            };
            Mars.MoonList.Add(Phobos);

            Moon Europe = new Moon()
            {
                id = 4,
                Name = "Europe",
                position = new SpaceObjects.Position() { X = 60, Y = 135 },
                Type = SpaceObjects.PlanetType.Terrestial,
                Diameter = 1500,
                RotationPeriod = 25,
                RevolutionPeriod = 23,
                Orbiting = Jupiter
            };
            Jupiter.MoonList.Add(Europe);

            Moon Deimos = new Moon()
            {
                id = 5,
                Name = "Deimos",
                position = new SpaceObjects.Position() { X = 110, Y = 125 },
                Type = SpaceObjects.PlanetType.Terrestial,
                Diameter = 9000,
                RotationPeriod = 50,
                RevolutionPeriod = 32,
                Orbiting = Mars
            };
            Mars.MoonList.Add(Deimos);

            Moon Ganymedes = new Moon()
            {
                id = 6,
                Name = "Ganymedes",
                position = new SpaceObjects.Position() { X = 60, Y = 135 },
                Type = SpaceObjects.PlanetType.Terrestial,
                Diameter = 5200,
                RotationPeriod = 170,
                RevolutionPeriod = 11,
                Orbiting = Jupiter
            };
            Jupiter.MoonList.Add(Ganymedes);

            Moon Io = new Moon()
            {
                id = 7,
                Name = "Io",
                position = new SpaceObjects.Position() { X = 58, Y = 132 },
                Type = SpaceObjects.PlanetType.Terrestial,
                Diameter = 9000,
                RotationPeriod = 20,
                RevolutionPeriod = 18,
                Orbiting = Jupiter
            };
            Jupiter.MoonList.Add(Io);

            Moon Mimas = new Moon()
            {
                id = 8,
                Name = "Mimas",
                position = new SpaceObjects.Position() { X = 134, Y = 195 },
                Type = SpaceObjects.PlanetType.Terrestial,
                Diameter = 6000,
                RotationPeriod = 22,
                RevolutionPeriod = 27,
                Orbiting = Saturn
            };
            Saturn.MoonList.Add(Mimas);

            return Sun;
        }
    }
}
