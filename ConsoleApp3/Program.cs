using System;

namespace InterfaceApp
{
    // Define the interface
    interface IMovable
    {
        void Move();
    }

    // Class implementing IMovable - Car
    class Car : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Car is moving");
        }
    }

    // Class implementing IMovable - Bicycle
    class Bicycle : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Bicycle is moving");
        }
    }

    // Main program
    class Program
    {
        static void Main(string[] args)
        {
            IMovable myCar = new Car();
            IMovable myBicycle = new Bicycle();

            myCar.Move();       // Outputs: Car is moving
            myBicycle.Move();   // Outputs: Bicycle is moving

            Console.WriteLine("\nPress Enter to exit...");
            Console.ReadLine();
        }
    }
}
