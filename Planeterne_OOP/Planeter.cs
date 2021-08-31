using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planeterne_OOP
{
    public class Planeter
    {
        private string navn;
        private double mass;
        private double diameter;
        private double density;
        private double gravity;
        private double rotation_period;
        private double length_of_day;
        private double distance_from_sun;
        private double orbital_period;
        private double orbital_velocity;
        private int mean_temperature;
        private int number_of_moons;
        private bool ring_system;

        public string Navn
        {
            get
            {
                return this.navn;
            }
            set
            {
                this.navn = value;
            }
        }
        public double Mass
        {
            get
            {
                return this.mass;
            }
            set
            {
                this.mass = value;
            }
        }
        public double Diameter
        {
            get
            {
                return this.diameter;
            }
            set
            {
                this.diameter = value;
            }
        }
        public double Density
        {
            get
            {
                return this.density;
            }
            set
            {
                this.density = value;
            }
        }
        public double Gravity
        {
            get
            {
                return this.gravity;
            }
            set
            {
                this.gravity = value;
            }
        }
        public double Rotation_period
        {
            get
            {
                return this.rotation_period;
            }
            set
            {
                this.rotation_period = value;
            }
        }
        public double Length_of_day
        {
            get
            {
                return this.length_of_day;
            }
            set
            {
                this.length_of_day = value;
            }
        }
        public double Distance_from_sun
        {
            get
            {
                return this.distance_from_sun;
            }
            set
            {
                this.distance_from_sun = value;
            }
        }
        public double Orbital_period
        {
            get
            {
                return this.orbital_period;
            }
            set
            {
                this.orbital_period = value;
            }
        }
        public double Orbital_velocity
        {
            get
            {
                return this.orbital_velocity;
            }
            set
            {
                this.orbital_velocity = value;
            }
        }
        public int Mean_temperature
        {
            get
            {
                return this.mean_temperature;
            }
            set
            {
                this.mean_temperature = value;
            }
        }
        public int Number_of_moons
        {
            get
            {
                return this.number_of_moons;
            }
            set
            {
                this.number_of_moons = value;
            }
        }
        public bool Ring_system
        {
            get
            {
                return this.ring_system;
            }
            set
            {
                this.ring_system = value;
            }
        }
    }
}
