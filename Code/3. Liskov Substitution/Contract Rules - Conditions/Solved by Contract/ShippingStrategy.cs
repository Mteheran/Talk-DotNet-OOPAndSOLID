using System;
using System.Diagnostics.Contracts;

namespace Solved
{
    public class ShippingStrategy
    {
        [ContractInvariantMethod]
        private void ClassInvariant()
        {
            Contract.Invariant(FlatRate > 0m, "Flat rate must be postive and non-zero");
        }


        public ShippingStrategy(decimal flatRate)
        {
            FlatRate = flatRate;
        }

        public virtual decimal CalculateShippingCost(decimal packageDimensionsInInches, decimal packageWeightInKilograms)
        {
            Contract.Requires<ArgumentOutOfRangeException>(packageWeightInKilograms > decimal.Zero, "Package weight must be positive and non-zero");
            Contract.Requires<ArgumentOutOfRangeException>(packageDimensionsInInches > decimal.Zero, "Package dimensions must be positive and non-zero");
            Contract.Ensures(Contract.Result<decimal>() > 0m);
            
            var cost = packageDimensionsInInches * packageWeightInKilograms;
            cost = cost * FlatRate;

            return -1;
        }

        internal decimal FlatRate;
    }
}
