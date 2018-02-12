namespace Liskov_Standard
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class ElectricCar : IVehicle
    {
        public void Accelerate()
        {
            Console.WriteLine("Acelerating Electric Car");
        }

        public void StartEngine()
        {
            Console.WriteLine("Starting Electric Engine");
        }
    }
}
