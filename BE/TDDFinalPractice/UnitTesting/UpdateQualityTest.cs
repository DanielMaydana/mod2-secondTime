using Microsoft.VisualStudio.TestTools.UnitTesting;
using Model;
using System;

namespace UnitTesting
{
    [TestClass]
    public class UpdateQualityTest
    {
        [TestMethod]
        public void UpdateQuality_WhenNormalHasCeroDaysLeft_ReturnsRightQuality()
        {
            int actualQuality = 4;
            string itemCategory = "Normal";
            int remainingDays = 0;

            Item myItem = new Item(itemCategory, actualQuality, remainingDays);

            QualityCalculator myQualityCalc = new QualityCalculator();
            int result = myQualityCalc.UpdateQuality(myItem);
            int expectedQuality = 2;

            Assert.AreEqual(expectedQuality, result);
        }

        [TestMethod]
        public void UpdateQuality_WhenNormalHasExcessiveQuality_ReturnsRightQuality()
        {
            int actualQuality = 61;
            string itemCategory = "Normal";
            int remainingDays = 0;

            Item myItem = new Item(itemCategory, actualQuality, remainingDays);

            QualityCalculator myQualityCalc = new QualityCalculator();
            var expectedException = Assert.ThrowsException<ArgumentException>(() => myQualityCalc.UpdateQuality(myItem));
            string expectedResult = "Quality can't excede 50 for this item";

            Assert.AreEqual(expectedResult, expectedException.Message);
        }

        [TestMethod]
        public void UpdateQuality_WhenAgedBrieHasTwoDaysLeft_ReturnsDecrementedQuality()
        {
            int actualQuality = 4;
            string itemCategory = "AgedBrie";
            int remainingDays = 2;

            Item myItem = new Item(itemCategory, actualQuality, remainingDays);

            QualityCalculator myQualityCalc = new QualityCalculator();
            int result = myQualityCalc.UpdateQuality(myItem);
            int expectedQuality = 5;

            Assert.AreEqual(expectedQuality, result);
        }

        [TestMethod]
        public void UpdateQuality_WhenSulfurasHasTwoDaysLeft_ReturnsSameQuality()
        {
            int actualQuality = 4;
            string itemCategory = "Sulfuras";
            int remainingDays = 2;

            Item myItem = new Item(itemCategory, actualQuality, remainingDays);

            QualityCalculator myQualityCalc = new QualityCalculator();
            int result = myQualityCalc.UpdateQuality(myItem);
            int expectedQuality = 4;

            Assert.AreEqual(expectedQuality, result);
        }

        [TestMethod]
        public void UpdateQuality_WhenBackstagePassHas23DaysLeft_ReturnsRightQuality()
        {
            int actualQuality = 10;
            string itemCategory = "BackstagePass";
            int remainingDays = 14;

            Item myItem = new Item(itemCategory, actualQuality, remainingDays);

            QualityCalculator myQualityCalc = new QualityCalculator();
            int result = myQualityCalc.UpdateQuality(myItem);
            int expectedQuality = 11;

            Assert.AreEqual(expectedQuality, result);
        }

        [TestMethod]
        public void UpdateQuality_WhenBackstagePassHas10DaysLeft_ReturnsRightQuality()
        {
            int actualQuality = 10;
            string itemCategory = "BackstagePass";
            int remainingDays = 10;

            Item myItem = new Item(itemCategory, actualQuality, remainingDays);

            QualityCalculator myQualityCalc = new QualityCalculator();
            int result = myQualityCalc.UpdateQuality(myItem);
            int expectedQuality = 20;

            Assert.AreEqual(expectedQuality, result);
        }

        [TestMethod]
        public void UpdateQuality_WhenBackstagePassHas8DaysLeft_ReturnsRightQuality()
        {
            int actualQuality = 10;
            string itemCategory = "BackstagePass";
            int remainingDays = 8;

            Item myItem = new Item(itemCategory, actualQuality, remainingDays);

            QualityCalculator myQualityCalc = new QualityCalculator();
            int result = myQualityCalc.UpdateQuality(myItem);
            int expectedQuality = 20;

            Assert.AreEqual(expectedQuality, result);
        }

        [TestMethod]
        public void UpdateQuality_WhenBackstagePassHas5DaysLeft_ReturnsRightQuality()
        {
            int actualQuality = 10;
            string itemCategory = "BackstagePass";
            int remainingDays = 5;

            Item myItem = new Item(itemCategory, actualQuality, remainingDays);

            QualityCalculator myQualityCalc = new QualityCalculator();
            int result = myQualityCalc.UpdateQuality(myItem);
            int expectedQuality = 30;

            Assert.AreEqual(expectedQuality, result);
        }

        [TestMethod]
        public void UpdateQuality_WhenBackstagePassHas4DaysLeft_ReturnsRightQuality()
        {
            int actualQuality = 10;
            string itemCategory = "BackstagePass";
            int remainingDays = 4;

            Item myItem = new Item(itemCategory, actualQuality, remainingDays);

            QualityCalculator myQualityCalc = new QualityCalculator();
            int result = myQualityCalc.UpdateQuality(myItem);
            int expectedQuality = 30;

            Assert.AreEqual(expectedQuality, result);
        }

        [TestMethod]
        public void UpdateQuality_WhenBackstagePassHas0DaysLeft_ReturnsRightQuality()
        {
            int actualQuality = 23;
            string itemCategory = "BackstagePass";
            int remainingDays = 0;

            Item myItem = new Item(itemCategory, actualQuality, remainingDays);

            QualityCalculator myQualityCalc = new QualityCalculator();
            int result = myQualityCalc.UpdateQuality(myItem);
            int expectedQuality = 23;

            Assert.AreEqual(expectedQuality, result);
        }

        [TestMethod]
        public void UpdateQuality_WhenConjuredHas0DaysLeft_ReturnsRightQuality()
        {
            int actualQuality = 30;
            string itemCategory = "Conjured";
            int remainingDays = 2;

            Item myItem = new Item(itemCategory, actualQuality, remainingDays);

            QualityCalculator myQualityCalc = new QualityCalculator();
            int result = myQualityCalc.UpdateQuality(myItem);
            int expectedQuality = 26;

            Assert.AreEqual(expectedQuality, result);
        }

        [TestMethod]
        public void UpdateQuality_WhenConjuredHas0DaysLeftAnd0Quality_ReturnsRightQuality()
        {
            int actualQuality = 0;
            string itemCategory = "Conjured";
            int remainingDays = 0;

            Item myItem = new Item(itemCategory, actualQuality, remainingDays);

            QualityCalculator myQualityCalc = new QualityCalculator();
            int result = myQualityCalc.UpdateQuality(myItem);
            int expectedQuality = 0;

            Assert.AreEqual(expectedQuality, result);
        }

        [TestMethod]
        public void UpdateQuality_WhenBackstagePassHasMaxQuality_ReturnsRightQuality()
        {
            int actualQuality = 50;
            string itemCategory = "BackstagePass";
            int remainingDays = 4;

            Item myItem = new Item(itemCategory, actualQuality, remainingDays);

            QualityCalculator myQualityCalc = new QualityCalculator();
            int result = myQualityCalc.UpdateQuality(myItem);
            int expectedQuality = 50;

            Assert.AreEqual(expectedQuality, result);
        }

        [TestMethod]
        public void UpdateQuality_WhenSulfurasHasExcessiveQuality_ThrowsException()
        {
            int actualQuality = 85;
            string itemCategory = "Sulfuras";
            int remainingDays = 4;

            Item myItem = new Item(itemCategory, actualQuality, remainingDays);

            QualityCalculator myQualityCalc = new QualityCalculator();
            var expectedException = Assert.ThrowsException<ArgumentException>(() => myQualityCalc.UpdateQuality(myItem));
            string expectedResult = "Quality can't excede 80 for this item";

            Assert.AreEqual(expectedResult, expectedException.Message);
        }

        [TestMethod]
        public void UpdateQuality_WhenAgedBrieHasLessThan0Quality_ThrowsException()
        {
            int actualQuality = -12;
            string itemCategory = "Sulfuras";
            int remainingDays = 4;

            Item myItem = new Item(itemCategory, actualQuality, remainingDays);

            QualityCalculator myQualityCalc = new QualityCalculator();
            var expectedException = Assert.ThrowsException<ArgumentException>(() => myQualityCalc.UpdateQuality(myItem));
            string expectedResult = "Quality can't be negative";

            Assert.AreEqual(expectedResult, expectedException.Message);
        }
    }
}