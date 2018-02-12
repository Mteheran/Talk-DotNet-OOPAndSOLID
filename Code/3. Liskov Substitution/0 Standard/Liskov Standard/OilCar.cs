namespace Liskov_Standard
{
    using System;

    public class OilCar : IVehicle
    {
        public void Accelerate()
        {
            Console.WriteLine("Acelerating Oil Car");
        }

        public void StartEngine()
        {
            Console.WriteLine("Starting Oil Engine");
        }
    }
}
