using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Vehicle baseVehicle = new Vehicle(4, 2000, "Green", 55.0d);

            baseVehicle.Move();
            
            //Checking to make sure vehicle moves

            baseVehicle.Move();
            Console.WriteLine(baseVehicle.DistanceTraveled);
            Console.WriteLine();

            //Defining the Automobile and moving it
            Automobile herbie = new Automobile(4, 13, 2, 4, 1500, "white", 88.0d);
            herbie.Move();
            Console.WriteLine("Automobile " + herbie.GetDistanceTraveled());
            Console.WriteLine();

            Boat boaty = new Boat(2, 500, "Red", 88.0d, .9d);
            boaty.Move();
            Console.WriteLine("Boaty " + boaty.GetDistanceTraveled());
            Console.WriteLine();

            Aircraft aircraft1 = new Aircraft(70, 100000, "Grey", 600.0d);
            aircraft1.Move();
            aircraft1.Move();
            Console.WriteLine("Aircraft traveled: " + aircraft1.GetDistanceTraveled());
            
        }
    }
}
