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

            }
        }
    }
}
