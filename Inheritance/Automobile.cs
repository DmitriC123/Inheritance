using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Automobile : Vehicle
    {
        //Fields
        private int numberOfwheels;
        private float wheelSize;
        private int numberOfDoors;

        //Properties
        public int NumberOfWheels
        {
            get { return this.numberOfwheels; }
        }
        public float WheelSize
        {
            get { return this.wheelSize; }
        }
        public int NumberOfDoors
        {
            get { return this.numberOfDoors; }
        }

        public Automobile(int numberOfWheels, float wheelSize, int numberOfDoors, int seats, int carryingCapacity, string color, double movementSpeed) 
        {
            //these fields are in the Automobile class
            this.numberOfDoors = numberOfDoors;
            this.numberOfwheels = numberOfWheels;
            this.seats = seats;

            this.wheelSize = wheelSize;
            this.color = color;
            this.movementSpeed = movementSpeed;
            this.carryingCapacity = carryingCapacity;
        }
    }
}
