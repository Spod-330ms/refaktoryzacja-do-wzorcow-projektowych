using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactoringToDesignPatterns.CH01_CodeSmells.SolutionMS
{

    public class ShippingDetails
    {
        public string ShippingMethod { get; set; }
        public string Destination { get; set; }

        public decimal CalculateShippingCost(decimal amount)
        {
            if (this.ShippingMethod == "Air")
            {
                return amount * 0.2m;
            }
            else if (this.ShippingMethod == "Sea")
            {
                return amount * 0.1m;
            }
            return amount * 0.15m;
        }
    }

    public class Order
    {
        public ShippingDetails ShippingDetails { get; set; }
        public decimal Amount { get; set; }

        public decimal GetShippingCost()
        {
            return ShippingDetails.CalculateShippingCost(Amount);
        }
    }
}
