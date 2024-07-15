namespace CarShippingCostCalculator
{
    public class ShippingCostCalculator
    {
        private const double BaseRatePerMile = 0.5;
        private const double WeightRatePerPound = 0.1;
        private const double ExpressMultiplier = 1.5;

        public double CalculateShippingCost(ShippingCostInput input)
        {
            double baseCost = input.Distance * BaseRatePerMile;
            double weightCost = input.CarWeight * WeightRatePerPound;

            double totalCost = baseCost + weightCost;

            if (input.ShippingMethod.Equals("Express", System.StringComparison.OrdinalIgnoreCase))
            {
                totalCost *= ExpressMultiplier;
            }

            return totalCost;
        }
    }
}
