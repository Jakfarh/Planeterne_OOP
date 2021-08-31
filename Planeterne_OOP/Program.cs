using System;
using System.Collections.Generic;

namespace Planeterne_OOP
{
    class Program
    {
        static void Main(string[] args)
        {

            Planeter Mercury = new Planeter();
            {
                Mercury.Navn = "Mercury";
                Mercury.Mass = 0.330;
                Mercury.Diameter = 4879;
                Mercury.Density = 5427;
                Mercury.Gravity = 3.7;
                Mercury.Rotation_period = 1407.6;
                Mercury.Length_of_day = 4222.6;
                Mercury.Distance_from_sun = 57.9;
                Mercury.Orbital_period = 88.0;
                Mercury.Orbital_velocity = 47.4;
                Mercury.Mean_temperature = 167;
                Mercury.Number_of_moons = 0;
                Mercury.Ring_system = false;
            }

            Planeter Venus = new Planeter();
            {
                Venus.Navn = "Venus";
                Venus.Mass = 4.87;
                Venus.Diameter = 12104;
                Venus.Density = 5243;
                Venus.Gravity = 8.9;
                Venus.Rotation_period = -5832.5;
                Venus.Length_of_day = 2802.0;
                Venus.Distance_from_sun = 108.2;
                Venus.Orbital_period = 224.7;
                Venus.Orbital_velocity = 35.0;
                Venus.Mean_temperature = 464;
                Venus.Number_of_moons = 0;
                Venus.Ring_system = false;
            }

            Planeter Earth = new Planeter();
            {
                Earth.Navn = "Earth";
                Earth.Mass = 5.97;
                Earth.Diameter = 12756;
                Earth.Density = 5514;
                Earth.Gravity = 9.8;
                Earth.Rotation_period = 23.9;
                Earth.Length_of_day = 24.7;
                Earth.Distance_from_sun = 149.6;
                Earth.Orbital_period = 365.2;
                Earth.Orbital_velocity = 29.8;
                Earth.Mean_temperature = 15;
                Earth.Number_of_moons = 1;
                Earth.Ring_system = false;
            }

            Planeter Mars = new Planeter();
            {
                Mars.Navn = "Mars";
                Mars.Mass = 0.642;
                Mars.Diameter = 6792;
                Mars.Density = 3933;
                Mars.Gravity = 3.7;
                Mars.Rotation_period = 24.6;
                Mars.Length_of_day = 24.7;
                Mars.Distance_from_sun = 227.9;
                Mars.Orbital_period = 687.0;
                Mars.Orbital_velocity = 24.1;
                Mars.Mean_temperature = -65;
                Mars.Number_of_moons = 2;
                Mars.Ring_system = false;
            }

            Planeter Jupiter = new Planeter();
            {
                Jupiter.Navn = "Jupiter";
                Jupiter.Mass = 1898;
                Jupiter.Diameter = 142984;
                Jupiter.Density = 1326;
                Jupiter.Gravity = 23.1;
                Jupiter.Rotation_period = 9.9;
                Jupiter.Length_of_day = 9.9;
                Jupiter.Distance_from_sun = 778.6;
                Jupiter.Orbital_period = 4331;
                Jupiter.Orbital_velocity = 13.1;
                Jupiter.Mean_temperature = -110;
                Jupiter.Number_of_moons = 67;
                Jupiter.Ring_system = true;
            }

            Planeter Saturn = new Planeter();
            {
                Saturn.Navn = "Saturn";
                Saturn.Mass = 568;
                Saturn.Diameter = 120536;
                Saturn.Density = 687;
                Saturn.Gravity = 9.0;
                Saturn.Rotation_period = 10.7;
                Saturn.Length_of_day = 10.7;
                Saturn.Distance_from_sun = 1433.5;
                Saturn.Orbital_period = 10747;
                Saturn.Orbital_velocity = 9.7;
                Saturn.Mean_temperature = -140;
                Saturn.Number_of_moons = 62;
                Saturn.Ring_system = true;
            }

            Planeter Uranus = new Planeter();
            {
                Uranus.Navn = "Uranus";
                Uranus.Mass = 86.8;
                Uranus.Diameter = 51118;
                Uranus.Density = 1271;
                Uranus.Gravity = 8.7;
                Uranus.Rotation_period = -17.2;
                Uranus.Length_of_day = 17.2;
                Uranus.Distance_from_sun = 2872.5;
                Uranus.Orbital_period = 30589;
                Uranus.Orbital_velocity = 6.8;
                Uranus.Mean_temperature = -195;
                Uranus.Number_of_moons = 27;
                Uranus.Ring_system = true;
            }

            Planeter Neptune = new Planeter();
            {
                Neptune.Navn = "Neptune";
                Neptune.Mass = 102;
                Neptune.Diameter = 49528;
                Neptune.Density = 1638;
                Neptune.Gravity = 11.0;
                Neptune.Rotation_period = 16.1;
                Neptune.Length_of_day = 16.1;
                Neptune.Distance_from_sun = 4495.1;
                Neptune.Orbital_period = 59800;
                Neptune.Orbital_velocity = 5.4;
                Neptune.Mean_temperature = -200;
                Neptune.Number_of_moons = 14;
                Neptune.Ring_system = true;
            }

            Planeter Pluto = new Planeter();
            {
                Pluto.Navn = "Pluto";
                Pluto.Mass = 0.0146;
                Pluto.Diameter = 2370;
                Pluto.Density = 2095;
                Pluto.Gravity = 0.7;
                Pluto.Rotation_period = -153.3;
                Pluto.Length_of_day = 153.3;
                Pluto.Distance_from_sun = 5906.4;
                Pluto.Orbital_period = 90560;
                Pluto.Orbital_velocity = 4.7;
                Pluto.Mean_temperature = -225;
                Pluto.Number_of_moons = 5;
                Pluto.Ring_system = false;
            }

            List<Planeter> Planetlist = new List<Planeter>();

            Planetlist.Add(Mercury);
            Planetlist.Add(Earth);
            Planetlist.Add(Mars);
            Planetlist.Add(Jupiter);
            Planetlist.Add(Saturn);
            Planetlist.Add(Uranus);
            Planetlist.Add(Neptune);
            Planetlist.Add(Pluto);

            foreach (Planeter Planet in Planetlist)
            {
                Console.WriteLine(Planet.Navn);
            }
            Console.WriteLine();
            Planetlist.Insert(1, Venus);

            foreach (Planeter Planet in Planetlist)
            {
                Console.WriteLine(Planet.Navn);
            }
            Console.WriteLine();

            Planetlist.Remove(Pluto);

            foreach (Planeter Planet in Planetlist)
            {
                Console.WriteLine(Planet.Navn);
            }
            Console.WriteLine();

            Planetlist.Add(Pluto);

            Console.WriteLine(Planetlist.Count);
        }
    }
}
