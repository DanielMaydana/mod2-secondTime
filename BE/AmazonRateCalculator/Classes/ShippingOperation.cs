using System;
using System.Collections.Generic;

namespace Model
{
    public class ShippingOperation
    {
        public string name { get; set; }
        public double oneTimeCharge { get; set; }
        public double perOverweightSurcharge { get; set; }
        private Dictionary<string, Tuple<double, double, bool>> perCategoryChargeChart;
        public ShippingOperation()
        {
            perCategoryChargeChart = new Dictionary<string, Tuple<double, double, bool>>();
            perOverweightSurcharge = 0;
            oneTimeCharge = 0;
            name = "";
        }

        public void setCategoryRates(string categoryName, double perItemCharge, double perPoundCharge = 0, bool surchargeApplies = true)
        {
            perCategoryChargeChart.Add(categoryName, new Tuple<double, double, bool>(perItemCharge, perPoundCharge, surchargeApplies));
        }

        public double GetPerItemCharge(string categoryName)
        {
            double perItemCharge = perCategoryChargeChart[categoryName].Item1;
            return perItemCharge;
        }

        public double GetPerPoundCharge(string categoryName)
        {
            double perPoundCharge = perCategoryChargeChart[categoryName].Item2;
            return perPoundCharge;
        }

        public bool GetOverchargeApplicability(string categoryName)
        {
            bool surchargeApplies = perCategoryChargeChart[categoryName].Item3;
            return surchargeApplies;
        }
    }
}
