using Model;
using System;
using System.Collections.Generic;

namespace BusinessLogic
{
    public class ShipmentCostCalculator
    {
        double weightLimit = 1;
        public double Calculate(Cart cart, ShippingOperation operation)
        {
            double perItemSubtotal = 0;

            ValidateProductList(cart.productList);
            ValidateOperation(operation);

            foreach (Product prod in cart.productList)
            {
                double weightSurcharge = CalculateWeightSurcharge(prod, operation);
                double costPerQuantity = CalculatePerQuantityCharge(prod, operation);
                double costPerPound = CalculatePerPoundCharge(prod, operation);
                perItemSubtotal += weightSurcharge + costPerQuantity + costPerPound;
            }

            perItemSubtotal += operation.oneTimeCharge;

            return RoundUp(perItemSubtotal);
        }

        private double CalculateWeightSurcharge(Product product, ShippingOperation operation)
        {
            double excess = product.weight - weightLimit;
            bool overchargeApplicability = operation.GetOverchargeApplicability(product.category);

            if (excess > 0 && overchargeApplicability)
            {
                return Math.Ceiling(excess) * operation.perOverweightSurcharge * product.quantity;
            }
            else
            {
                return 0;
            }
        }

        private double CalculatePerQuantityCharge(Product prod, ShippingOperation operation)
        {
            return operation.GetPerItemCharge(prod.category) * prod.quantity;
        }

        private double CalculatePerPoundCharge(Product prod, ShippingOperation operation)
        {
            return operation.GetPerPoundCharge(prod.category) * Math.Ceiling(prod.quantity * prod.weight);
        }

        private static double RoundUp(double input, int places = 2)
        {
            double multiplier = Math.Pow(10, Convert.ToDouble(places));
            return Math.Ceiling(input * multiplier) / multiplier;
        }

        private void ValidateProductList(List<Product> productList)
        {
            foreach (Product prod in productList)
            {
                if (prod.quantity < 1) throw new ArgumentException($"Product from {prod.category} has a negative quantity.");
                if (prod.weight <= 0) throw new ArgumentException($"Product from {prod.category} has a negative weight.");
            }
        }

        private void ValidateOperation(ShippingOperation operation)
        {
            if (operation.oneTimeCharge < 0) throw new ArgumentException("Can't accept negative charge.");
            if (operation.perOverweightSurcharge < 0) throw new ArgumentException("Can't accept negative surcharge for overweight.");
        }
    }
}
