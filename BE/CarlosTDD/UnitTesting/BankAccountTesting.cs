using Microsoft.VisualStudio.TestTools.UnitTesting;
using CarlosTDD.Interfaces;
using CarlosTDD.Implementations;
using UnitTesting.Mocks;


namespace UnitTesting
{
    [TestClass]
    public class IntegrationTesting
    {
        [TestMethod]
        public void GetBalance_ReturnsDefaultUsersBalance_WhenUsedBankWithSingleUser()
        {
            var mockObj = new MockBankWithOnlyUser();
            var mockUser = mockObj.GetAccount(111);

            var expectedUserBalance = 0D;
            var actualUserBalance = mockUser.GetBalance();

            Assert.AreEqual(expectedUserBalance, actualUserBalance);
        }

        [TestMethod]
        public void GetBalance_ReturnsTrue_WhenCreditedToAUserInABankWith10Percent()
        {
            var mockObj = new MockBankWithTax();

            var operationState = mockObj.CreditUser(id: 111, ammount: 150D);

            Assert.IsTrue(operationState);
        }

        [TestMethod]
        public void CreditUser_ReturnsFalse_WhenTheCreditedUserDoesNotExist()
        {
            var mockObj = new MockBankWithTax();

            var operationState = mockObj.CreditUser(id: 999, ammount: 150D);

            Assert.IsFalse(operationState);
        }

        [TestMethod]
        public void GetBalance_ReturnsBankBalance_WhenAUserIsCreditedInABankWith10PercentAsTax()
        {
            var mockObj = new MockBankWithTax();
            mockObj.CreditUser(id: 111, ammount: 150D);

            var expectedBalance = 15D;
            var actualBalance = mockObj.GetBalance();

            Assert.AreEqual(expectedBalance, actualBalance);
        }

        [TestMethod]
        public void GetBalance_ReturnsUpdatedUsersBalance_WhenAUserIsCreditedInABankWith10Percent()
        {
            var mockObj = new MockBankWithTax();
            mockObj.CreditUser(id: 111, ammount: 150D);

            var expectedBalance = 135D;
            var actualBalance = mockObj.GetAccount(111).GetBalance();

            Assert.AreEqual(expectedBalance, actualBalance);
        }

        [TestMethod]
        public void GetBalance_ReturnsUpdatedUsersBalance_WhenAUserIsDebitedInABankWith10Percent()
        {
            var mockObj = new MockBankWithTax();
            mockObj.CreditUser(id: 111, ammount: 150D);

            var expectedBalance = 135D;
            var actualBalance = mockObj.GetAccount(111).GetBalance();

            Assert.AreEqual(expectedBalance, actualBalance);
        }
    }
}
