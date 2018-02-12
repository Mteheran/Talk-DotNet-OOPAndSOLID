namespace Dont
{
    public class ShippingStrategy
    {
        internal decimal FlatRate = 10;
        
        public decimal CalculateShippingCost(decimal packageDimensionsInInches, decimal weightInKilograms)
        {
            decimal cost = packageDimensionsInInches * weightInKilograms;
            //FlatRate = 0;
            cost = cost * FlatRate;


            return cost;
        }
    }
}
