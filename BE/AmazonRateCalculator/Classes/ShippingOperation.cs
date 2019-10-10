using System;
using System.Collections.Generic;

namespace Model
{
    public class ShippingOperation
    {
        public string name { get; set; }
        public double oneTimeCharge { get; set; }
        public double perOverweightSurcharge { get; set; }
        private List<Tuple<List<string>, double, double, bool>> perCategoryChargeChart;
        public bool alreadySetted { get; private set; }

        public ShippingOperation()
        {
            perCategoryChargeChart = new List<Tuple<List<string>, double, double, bool>>();
            perOverweightSurcharge = 0;
            oneTimeCharge = 0;
            name = "";
        }

        public void SetCategoryRates(string singleCategory, double perItemCharge, double perPoundCharge = 0, bool surchargeApplies = true)
        {
            List<string> singleCategoryList = new List<string> { singleCategory };
            SetCategoryRates(singleCategoryList, perItemCharge, perPoundCharge, surchargeApplies);
        }

        public void SetCategoryRates(List<string> category, double perItemCharge, double perPoundCharge = 0, bool surchargeApplies = true)
        {
            perCategoryChargeChart.Add(new Tuple<List<string>, double, double, bool>(category, perItemCharge, perPoundCharge, surchargeApplies));
            alreadySetted = true;
        }

        public double GetPerItemCharge(string categoryToFind)
        {
            double perItemCharge = FindCategoryInChart(categoryToFind).Item1;
            return perItemCharge;
        }

        public double GetPerPoundCharge(string categoryToFind)
        {
            double perPoundCharge = FindCategoryInChart(categoryToFind).Item2;
            return perPoundCharge;
        }

        public bool GetOverchargeApplicability(string categoryToFind)
        {
            bool surchargeApplies = FindCategoryInChart(categoryToFind).Item3;
            return surchargeApplies;
        }

        private Tuple<double, double, bool> FindCategoryInChart(string categoryToFind)
        {
            Tuple<double, double, bool> categoryFound;

            foreach (var category in perCategoryChargeChart)
            {
                foreach (var categoryItem in category.Item1)
                {
                    if (categoryItem == categoryToFind)
                    {
                        categoryFound = new Tuple<double, double, bool>(category.Item2, category.Item3, category.Item4);
                        return categoryFound;
                    }
                }
            }

            throw new ArgumentException("The category for one of the items wasn't found");
        }
    }
}
