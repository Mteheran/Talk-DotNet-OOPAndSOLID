using System;

namespace Solved
{
    public class ShippingStrategy
    {
        private decimal flatRate;
        protected decimal FlatRate
        {
            get => flatRate;
            set
            {
                if (value <= decimal.Zero)
                    throw new ArgumentOutOfRangeException("value", "Flat rate must be positive and non-zero");

                flatRate = value;
            }
        }


        public ShippingStrategy(decimal flatRate)
        {
            if (flatRate <= decimal.Zero)
                throw new ArgumentOutOfRangeException(nameof(flatRate), "Flat rate must be positive and non-zero");

            FlatRate = flatRate;
        }

        public virtual decimal CalculateShippingCost(decimal packageDimensionsInInches, decimal packageWeightInKilograms)
        {
            if (packageWeightInKilograms <= decimal.Zero)
                throw new ArgumentOutOfRangeException(nameof(packageWeightInKilograms), "Package weight must be positive and non-zero");

            if (packageDimensionsInInches <= decimal.Zero)
                throw new ArgumentOutOfRangeException(nameof(packageDimensionsInInches), "Package dimensions must be positive and non-zero");

            var cost = packageDimensionsInInches * packageWeightInKilograms;
            cost = cost * FlatRate;

            if (cost <= decimal.Zero)
                throw new ArgumentOutOfRangeException("return", "The return value is out of range");

            return cost;
        }
    }
}
