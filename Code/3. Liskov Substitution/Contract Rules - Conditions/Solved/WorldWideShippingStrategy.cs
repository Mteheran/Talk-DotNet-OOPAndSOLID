using System;

namespace Solved
{
    public class WorldWideShippingStrategy : ShippingStrategy
    {
        public WorldWideShippingStrategy(decimal flatRate)
            : base(flatRate)
        {

        }

        public override decimal CalculateShippingCost(decimal packageDimensionsInInches, decimal packageWeightInKilograms)
        {
            if (packageWeightInKilograms <= decimal.Zero)
                throw new ArgumentOutOfRangeException(nameof(packageWeightInKilograms), "Package weight must be positive and non-zero");

            if (packageDimensionsInInches <= decimal.Zero)
                throw new ArgumentOutOfRangeException(nameof(packageDimensionsInInches), "Package dimensions must be positive and non-zero");

            var cost = packageDimensionsInInches * packageWeightInKilograms;
            cost = cost * FlatRate;
            cost += 20;

            if (cost <= decimal.Zero)
                throw new ArgumentOutOfRangeException("return", "The return value is out of range");

            return cost;
        }
    }
}
