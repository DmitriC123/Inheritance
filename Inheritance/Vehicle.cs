using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Vehicle
    {
        //Fields
        protected int seats;
        protected int carryingCapacity;
        protected string color;
        protected double movementSpeed;
        protected double distanceTraveled;

        //Properties
        public int Seats
        {
            get { return this.seats; }
        }
        public int CarryingCapacity
        {
            get { return this.carryingCapacity; }
        }
        public string Color
        {
            get { return this.color; }
            set { this.color = value; }
        }
        public double DistanceTraveled
        {
            get { return this.distanceTraveled; }
        }
        public double MovementSpeed
        {
            get { return this.movementSpeed; }
        }

        //Constructors
        public Vehicle()
        {

        }
        public Vehicle (int seats, int carryingCapacity, string color, double movementSpeed)
        {
            this.seats = seats;
            this.carryingCapacity = carryingCapacity;
            this.color = color;
            this.movementSpeed = movementSpeed;
            this.distanceTraveled = 0.0d;
        }

        //Methods
        //Have to add "virtual" in order to give permission for other classes to override methods
        public virtual void Move()
        {
            //distanceTraveled = distanceTraveled + movementSpeed;
            distanceTraveled += movementSpeed;

        }
        
        public virtual string GetDistanceTraveled()
        {
            return "Distance Travel: " + distanceTraveled + "\n";
        }
    }
}
