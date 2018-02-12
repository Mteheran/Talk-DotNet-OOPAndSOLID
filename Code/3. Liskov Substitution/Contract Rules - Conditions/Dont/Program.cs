using System;

namespace Dont
{
    class Program
    {
        static void Main(string[] args)
        {
            //Preconditions
            var shippingStrategy = new ShippingStrategy();
            var result = shippingStrategy.CalculateShippingCost(2, -1);
            Console.WriteLine($"You have to pay {result} dollars");

            Console.ReadLine();

            //Postconditions
            if (result <= 0) Console.WriteLine("OMG it's free!!");

            Console.ReadLine();
        }
    }
}
