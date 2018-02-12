using System;
using System.Diagnostics.Contracts;

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
            Contract.Requires<ArgumentOutOfRangeException>(packageWeightInKilograms > decimal.Zero, "Package weight must be positive and non-zero");
            Contract.Requires<ArgumentOutOfRangeException>(packageDimensionsInInches > decimal.Zero, "Package dimensions must be positive and non-zero");
            Contract.Ensures(Contract.Result<decimal>() > 0m);

            var cost = packageDimensionsInInches * packageWeightInKilograms;
            cost = cost * FlatRate;
            cost += 20;

            return cost;
        }
    }
}
