using System;
using System.Collections.Generic;

namespace Model
{
    public class QualityCalculator
    {
        private Dictionary<string, int> maxQualityChart;

        private const int stepPerDay = 1;
        private const int minQuality = 0;
        private const int maxQuality = 50;

        public QualityCalculator()
        {
            maxQualityChart = new Dictionary<string, int>
            {
                { "Normal", maxQuality },
                { "AgedBrie", maxQuality },
                { "Sulfuras", 80},
                { "BackstagePass", maxQuality },
                { "Conjured", maxQuality },
            };
        }

        public int UpdateQuality(Item myItem)
        {
            ValidateOriginalQualityBoundaries(myItem);

            int result = 0;

            switch (myItem.Category)
            {
                case "Normal":
                    result = CalculateForNormalItem(myItem);
                    break;
                case "AgedBrie":
                    result = CalculateForAgedBrie(myItem);
                    break;
                case "Sulfuras":
                    result = CalculateForSulfuras(myItem);
                    break;
                case "BackstagePass":
                    result = CalculateForBackstagePass(myItem);
                    break;
                case "Conjured":
                    result = CalculateForConjured(myItem);
                    break;
            }

            return AdjustQuality(myItem, result);
        }
        private void ValidateOriginalQualityBoundaries(Item myItem)
        {
            ValidateMinQuality(myItem);
            ValidateMaxQuality(myItem);
        }

        private void ValidateMaxQuality(Item myItem)
        {
            if (myItem.Category != "Sulfuras" && myItem.Quality > maxQuality) throw new ArgumentException($"Quality can't excede {maxQualityChart[myItem.Category]} for this item");
            if (myItem.Quality > maxQualityChart[myItem.Category]) throw new ArgumentException($"Quality can't excede {maxQualityChart[myItem.Category]} for this item");
        }

        private void ValidateMinQuality(Item myItem)
        {
            if (myItem.Quality < minQuality) throw new ArgumentException($"Quality can't be negative");
        }

        private int AdjustQuality(Item myItem, int result)
        {
            if (result > maxQualityChart[myItem.Category]) return maxQualityChart[myItem.Category];
            if (result < minQuality) return minQuality;

            return result;
        }

        int CalculateForConjured(Item myItem)
        {
            int decrementRate = 4;

            return myItem.Quality - stepPerDay * decrementRate;
        }

        int CalculateForNormalItem(Item myItem)
        {
            int decrementRate = 1;

            if (myItem.SellIn == 0) decrementRate = 2;

            return myItem.Quality - stepPerDay * decrementRate;
        }

        private int CalculateForAgedBrie(Item myItem)
        {
            int decrementRate = 1;
            return myItem.Quality + stepPerDay * decrementRate;
        }

        private int CalculateForBackstagePass(Item myItem)
        {
            if (myItem.SellIn > 5 && myItem.SellIn <= 10) return myItem.Quality * 2;
            else if (myItem.SellIn > 0 && myItem.SellIn <= 5) return myItem.Quality * 3;
            else if (myItem.SellIn == 0) return myItem.Quality * 1;

            return myItem.Quality + stepPerDay;
        }

        private int CalculateForSulfuras(Item myItem)
        {
            return myItem.Quality;
        }
    }
}
