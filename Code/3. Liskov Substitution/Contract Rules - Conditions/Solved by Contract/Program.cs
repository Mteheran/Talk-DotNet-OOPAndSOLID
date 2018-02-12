using System;

namespace Solved
{
    class Program
    {
        static void Main(string[] args)
        {
            //Conditions
            var shippingStrategy = new ShippingStrategy(-1);

            try
            {
                var result = shippingStrategy.CalculateShippingCost(2, -1);
                Console.WriteLine($"You have to pay {result} dollars");
            }
            catch (ArgumentOutOfRangeException outOfRangeException)
            {
                Console.WriteLine(outOfRangeException.Message);
            }

            Console.ReadLine();
        }
    }
}
