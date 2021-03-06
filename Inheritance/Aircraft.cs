﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Aircraft : Vehicle
    {
        private double altitude;

        //Constructor
        public Aircraft(int seats, int carryingCapacity, string color, double movementSpeed)
        {
            this.seats = seats;
            this.carryingCapacity = carryingCapacity;
            this.color = color;
            this.movementSpeed = movementSpeed;

            this.altitude = 0.0d;
        }

        public override void Move()
        {
            altitude += 10000.0d;
            base.Move();
        }
        public override string GetDistanceTraveled()
        { 
            return "Altitude: " + altitude + "\n" + base.GetDistanceTraveled();
        }
    }
}
