using System;

namespace CarShippingCostCalculator
{
    public class ShippingCostInput
    {
        public string CarMake { get; set; }
        public string CarModel { get; set; }
        public double CarWeight { get; set; } // In pounds
        public double Distance { get; set; } // In miles
        public string ShippingMethod { get; set; }
    }
}
