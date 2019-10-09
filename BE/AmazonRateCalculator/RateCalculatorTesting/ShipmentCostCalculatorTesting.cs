
using BusinessLogic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Model;
using System;

namespace BLTesting
{
    [TestClass]
    public class ShippingCalculator
    {
        [TestMethod]
        public void Calculate_ReturnsRightPrice_ForSingleUnderweightProduct()
        {
            Product myProduct1 = new Product();
            myProduct1.weight = 0.98;
            myProduct1.category = "Book";
            myProduct1.quantity = 1;

            Cart myCart = new Cart();
            myCart.productList.Add(myProduct1);

            ShippingOperation myOperation = new ShippingOperation();
            myOperation.name = "Standard";
            myOperation.oneTimeCharge = 2.99;
            myOperation.perOverweightSurcharge = 1.99;
            myOperation.setCategoryRates("Book", 3.99);

            ShipmentCostCalculator myCalculator = new ShipmentCostCalculator();
            double actualResult = myCalculator.Calculate(myCart, myOperation);
            double expectedResult = 6.98;

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void Calculate_ReturnsRightPrice_ForSingleOverweightProduct()
        {
            Product myProduct1 = new Product();
            myProduct1.weight = 1.5;
            myProduct1.category = "Book";
            myProduct1.quantity = 1;

            Cart myCart = new Cart();
            myCart.productList.Add(myProduct1);

            ShippingOperation myOperation = new ShippingOperation();
            myOperation.name = "Standard";
            myOperation.oneTimeCharge = 2.99;
            myOperation.perOverweightSurcharge = 1.99;
            myOperation.setCategoryRates("Book", 3.99);

            ShipmentCostCalculator myCalculator = new ShipmentCostCalculator();
            double actualResult = myCalculator.Calculate(myCart, myOperation);
            double expectedResult = 8.98;

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void Calculate_ReturnsRightPrice_ForFiveUnderweightProducts()
        {
            Product myProduct1 = new Product();
            myProduct1.weight = 0.98;
            myProduct1.category = "Book";
            myProduct1.quantity = 3;

            Cart myCart = new Cart();
            myCart.productList.Add(myProduct1);

            ShippingOperation myOperation = new ShippingOperation();
            myOperation.name = "Standard";
            myOperation.oneTimeCharge = 2.99;
            myOperation.perOverweightSurcharge = 1.99;
            myOperation.setCategoryRates("Book", 3.99);

            ShipmentCostCalculator myCalculator = new ShipmentCostCalculator();
            double actualResult = myCalculator.Calculate(myCart, myOperation);
            double expectedResult = 14.96;

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void Calculate_ReturnsRightPrice_ForSameFiveOverweightProducts()
        {
            Product myProduct1 = new Product();
            myProduct1.weight = 1.2;
            myProduct1.category = "Book";
            myProduct1.quantity = 5;

            Cart myCart = new Cart();
            myCart.productList.Add(myProduct1);

            ShippingOperation myOperation = new ShippingOperation();
            myOperation.name = "Standard";
            myOperation.oneTimeCharge = 2.99;
            myOperation.perOverweightSurcharge = 1.99;
            myOperation.setCategoryRates("Book", 3.99);

            ShipmentCostCalculator myCalculator = new ShipmentCostCalculator();
            double actualResult = myCalculator.Calculate(myCart, myOperation);
            double expectedResult = 32.89;

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void Calculate_ReturnsRightPrice_ForTwoDifferentProductsWithDifferentQuantities()
        {
            Product myProduct1 = new Product();
            myProduct1.weight = 0.980;
            myProduct1.category = "Book";
            myProduct1.quantity = 1;

            Product myProduct2 = new Product();
            myProduct2.weight = 0.500;
            myProduct2.category = "DVD";
            myProduct2.quantity = 2;

            Cart myCart = new Cart();
            myCart.productList.Add(myProduct1);
            myCart.productList.Add(myProduct2);

            ShippingOperation myOperation = new ShippingOperation();
            myOperation.name = "Standard";
            myOperation.oneTimeCharge = 2.99;
            myOperation.perOverweightSurcharge = 1.99;
            myOperation.setCategoryRates("Book", 3.99);
            myOperation.setCategoryRates("DVD", 2.99);

            ShipmentCostCalculator myCalculator = new ShipmentCostCalculator();
            double actualResult = myCalculator.Calculate(myCart, myOperation);
            double expectedResult = 12.96;

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void Calculate_ReturnsRightPrice_ForThreeOverweightAndFourUnderweightProducts()
        {
            Product myProduct1 = new Product();
            myProduct1.weight = 1.3;
            myProduct1.category = "Book";
            myProduct1.quantity = 3;

            Product myProduct2 = new Product();
            myProduct2.weight = 0.2;
            myProduct2.category = "DVD";
            myProduct2.quantity = 4;

            Cart myCart = new Cart();
            myCart.productList.Add(myProduct1);
            myCart.productList.Add(myProduct2);

            ShippingOperation myOperation = new ShippingOperation();
            myOperation.name = "Standard";
            myOperation.oneTimeCharge = 2.99;
            myOperation.perOverweightSurcharge = 1.99;
            myOperation.setCategoryRates("Book", 3.99);
            myOperation.setCategoryRates("DVD", 2.99);

            ShipmentCostCalculator myCalculator = new ShipmentCostCalculator();
            double actualResult = myCalculator.Calculate(myCart, myOperation);
            double expectedResult = 32.89;

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void Calculate_ReturnsRightPrice_ForTwoDifferentOverweightProducts()
        {
            Product myProduct1 = new Product();
            myProduct1.weight = 1.3;
            myProduct1.category = "Book";
            myProduct1.quantity = 3;

            Product myProduct2 = new Product();
            myProduct2.weight = 1.1;
            myProduct2.category = "DVD";
            myProduct2.quantity = 2;

            Cart myCart = new Cart();
            myCart.productList.Add(myProduct1);
            myCart.productList.Add(myProduct2);

            ShippingOperation myOperation = new ShippingOperation();
            myOperation.name = "Standard";
            myOperation.oneTimeCharge = 2.99;
            myOperation.perOverweightSurcharge = 1.99;
            myOperation.setCategoryRates("Book", 3.99);
            myOperation.setCategoryRates("DVD", 2.99);

            ShipmentCostCalculator myCalculator = new ShipmentCostCalculator();
            double actualResult = myCalculator.Calculate(myCart, myOperation);
            double expectedResult = 30.89;

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void Calculate_ReturnsRightPrice_ForFourDifferentUnderweightProducts()
        {
            Product myProduct1 = new Product();
            myProduct1.weight = 0.8;
            myProduct1.category = "Book";
            myProduct1.quantity = 3;

            Product myProduct2 = new Product();
            myProduct2.weight = 0.5;
            myProduct2.category = "DVD";
            myProduct2.quantity = 2;

            Product myProduct3 = new Product();
            myProduct3.weight = 0.9;
            myProduct3.category = "VHS";
            myProduct3.quantity = 4;

            Cart myCart = new Cart();
            myCart.productList.Add(myProduct1);
            myCart.productList.Add(myProduct2);
            myCart.productList.Add(myProduct3);

            ShippingOperation myOperation = new ShippingOperation();
            myOperation.name = "Standard";
            myOperation.oneTimeCharge = 2.99;
            myOperation.perOverweightSurcharge = 1.99;
            myOperation.setCategoryRates("Book", 3.99);
            myOperation.setCategoryRates("VHS", 3.99);
            myOperation.setCategoryRates("DVD", 2.99);

            ShipmentCostCalculator myCalculator = new ShipmentCostCalculator();
            double actualResult = myCalculator.Calculate(myCart, myOperation);
            double expectedResult = 36.91;

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void Calculate_ReturnsRightPrice_ForOneItemInACategoryWithPerPoundCharge()
        {
            Product myProduct1 = new Product();
            myProduct1.weight = 2.3;
            myProduct1.category = "Jewelry";
            myProduct1.quantity = 1;

            Cart myCart = new Cart();
            myCart.productList.Add(myProduct1);

            ShippingOperation myOperation = new ShippingOperation();
            myOperation.name = "Standard";
            myOperation.oneTimeCharge = 2.99;

            myOperation.setCategoryRates("Jewelry", 0, 1.99, false);

            ShipmentCostCalculator myCalculator = new ShipmentCostCalculator();
            double actualResult = myCalculator.Calculate(myCart, myOperation);
            double expectedResult = 8.97;

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void Calculate_ReturnsRightPrice_ForFiveItemsOfACategoryWithPerPoundCharge()
        {
            Product myProduct1 = new Product();
            myProduct1.weight = 4.2;
            myProduct1.category = "Tool";
            myProduct1.quantity = 5;

            Cart myCart = new Cart();
            myCart.productList.Add(myProduct1);

            ShippingOperation myOperation = new ShippingOperation();
            myOperation.name = "Standard";
            myOperation.oneTimeCharge = 2.99;
            myOperation.perOverweightSurcharge = 1.99;
            myOperation.setCategoryRates("Tool", 0, 1.99, false);

            ShipmentCostCalculator myCalculator = new ShipmentCostCalculator();
            double actualResult = myCalculator.Calculate(myCart, myOperation);
            double expectedResult = 52.74;

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void Calculate_ReturnsRightPrice_ForProductsWithAndWithoutPerPoundCharge()
        {
            Product myProduct1 = new Product();
            myProduct1.weight = 0.8;
            myProduct1.category = "Book";
            myProduct1.quantity = 2;

            Product myProduct2 = new Product();
            myProduct2.weight = 3.2;
            myProduct2.category = "Tool";
            myProduct2.quantity = 3;

            Cart myCart = new Cart();
            myCart.productList.Add(myProduct1);
            myCart.productList.Add(myProduct2);

            ShippingOperation myOperation = new ShippingOperation();
            myOperation.name = "Standard";
            myOperation.oneTimeCharge = 2.99;
            myOperation.perOverweightSurcharge = 1.99;
            myOperation.setCategoryRates("Book", 2.99, 0, true);
            myOperation.setCategoryRates("Tool", 0, 1.99, false);

            ShipmentCostCalculator myCalculator = new ShipmentCostCalculator();
            double actualResult = myCalculator.Calculate(myCart, myOperation);
            double expectedResult = 32.85;

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void Calculate_ThrowsException_ForAnItemWithNegativeQuantity()
        {
            Product myProduct1 = new Product();
            myProduct1.weight = 0.8;
            myProduct1.category = "Book";
            myProduct1.quantity = -3;

            Cart myCart = new Cart();
            myCart.productList.Add(myProduct1);

            ShippingOperation myOperation = new ShippingOperation();
            myOperation.name = "Standard";
            myOperation.oneTimeCharge = 2.99;
            myOperation.perOverweightSurcharge = 1.99;
            myOperation.setCategoryRates("Book", 3.99);

            ShipmentCostCalculator myCalculator = new ShipmentCostCalculator();

            var actualResponse = Assert.ThrowsException<ArgumentException>(() => myCalculator.Calculate(myCart, myOperation));
            string expectedMessage = $"Product from {myProduct1.category} has a negative quantity.";

            Assert.AreEqual(expectedMessage, actualResponse.Message);
        }

        [TestMethod]
        public void Calculate_ThrowsException_ForAnItemWithNegativeWeight()
        {
            Product myProduct1 = new Product();
            myProduct1.weight = -0.99;
            myProduct1.category = "Book";
            myProduct1.quantity = 2;

            Cart myCart = new Cart();
            myCart.productList.Add(myProduct1);

            ShippingOperation myOperation = new ShippingOperation();
            myOperation.name = "Standard";
            myOperation.oneTimeCharge = 2.99;
            myOperation.perOverweightSurcharge = 1.99;
            myOperation.setCategoryRates("Book", 3.99);

            ShipmentCostCalculator myCalculator = new ShipmentCostCalculator();

            var actualResponse = Assert.ThrowsException<ArgumentException>(() => myCalculator.Calculate(myCart, myOperation));
            string expectedMessage = $"Product from {myProduct1.category} has a negative weight.";

            Assert.AreEqual(expectedMessage, actualResponse.Message);
        }

        [TestMethod]
        public void Calculate_ThrowsException_ForAnOperationWithNegativeOneTimeCharge()
        {
            Product myProduct1 = new Product();
            myProduct1.weight = 0.3;
            myProduct1.category = "Book";
            myProduct1.quantity = 2;

            Cart myCart = new Cart();
            myCart.productList.Add(myProduct1);

            ShippingOperation myOperation = new ShippingOperation();
            myOperation.name = "Standard";
            myOperation.oneTimeCharge = -2.99;
            myOperation.perOverweightSurcharge = 1.99;
            myOperation.setCategoryRates("Book", 3.99);

            ShipmentCostCalculator myCalculator = new ShipmentCostCalculator();

            var actualResponse = Assert.ThrowsException<ArgumentException>(() => myCalculator.Calculate(myCart, myOperation));
            string expectedMessage = "Can't accept negative charge.";

            Assert.AreEqual(expectedMessage, actualResponse.Message);
        }

        [TestMethod]
        public void Calculate_ThrowsException_ForAnOperationWithNegativeOverweightSurcharge()
        {
            Product myProduct1 = new Product();
            myProduct1.weight = 0.3;
            myProduct1.category = "Book";
            myProduct1.quantity = 2;

            Cart myCart = new Cart();
            myCart.productList.Add(myProduct1);

            ShippingOperation myOperation = new ShippingOperation();
            myOperation.name = "Standard";
            myOperation.oneTimeCharge = 2.99;
            myOperation.perOverweightSurcharge = -1.99;
            myOperation.setCategoryRates("Book", 3.99);

            ShipmentCostCalculator myCalculator = new ShipmentCostCalculator();

            var actualResponse = Assert.ThrowsException<ArgumentException>(() => myCalculator.Calculate(myCart, myOperation));
            string expectedMessage = "Can't accept negative surcharge for overweight.";

            Assert.AreEqual(expectedMessage, actualResponse.Message);
        }
    }
}
