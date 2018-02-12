namespace Liskov_Standard
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            IVehicle vehicle = new ElectricCar(); // ElectricCar
            Drive(vehicle);

            Console.ReadLine();
        }

        static void Drive(IVehicle vechicle)
        {
            vechicle.StartEngine();
            vechicle.Accelerate();
        }
    }
}
