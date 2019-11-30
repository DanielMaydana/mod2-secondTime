using Microsoft.VisualStudio.TestTools.UnitTesting;
using CarlosTDD.Implementations;
using Testing.Fakes;
using System;

namespace Testing
{
    [TestClass]
    public class UserAccountUnitTesting
    {
        [TestMethod]
        public void GetBalance_ReturnsDefaultBalance_AfterAUserAccountIsInstantiated()
        {
            var myUser = new UserAccount(id: 141);

            var expectedUserBalance = 0D;
            var actualUserBalance = myUser.GetBalance();

            Assert.AreEqual(expectedUserBalance, actualUserBalance);
        }

        [TestMethod]
        public void GetBalance_ReturnsUpdatedBalance_AfterAUserAccountIsUpdatedForTheFirstTime()
        {
            var myUser = new UserAccount(id: 141);
            myUser.UpdateBalance(500D);

            var expectedUserBalance = 500D;
            var actualUserBalance = myUser.GetBalance();

            Assert.AreEqual(expectedUserBalance, actualUserBalance);
        }

        [TestMethod]
        public void GetBalance_ReturnsBalance_AfterAUserAccountIsUpdatedWithAPositiveAmmount()
        {
            var myUser = new UserAccount(id: 141);
            myUser.UpdateBalance(500);

            var expectedUserBalance = 500D;
            var actualUserBalance = myUser.GetBalance();

            Assert.AreEqual(expectedUserBalance, actualUserBalance);
        }

        [TestMethod]
        public void GetBalance_ReturnsBalance_AfterAUserAccountIsUpdatedWithANegativeAmmount()
        {
            var myUser = new StubUserWithPositiveBalance(id: 141);
            myUser.UpdateBalance(-400);

            var expectedUserBalance = 100D;
            var actualUserBalance = myUser.GetBalance();

            Assert.AreEqual(expectedUserBalance, actualUserBalance);
        }

        [TestMethod]
        public void GetBalance_ThrowsAExceptionWithThe111Code_WhenTheAmmountUpdatedIsGreaterThanTheBalance()
        {
            var myUser = new StubUserWithPositiveBalance(id: 141);

            var expectedExceptionCode = "111";
            var actualException = Assert.ThrowsException<ArgumentException>(() => myUser.UpdateBalance(-600));

            Assert.AreEqual(expectedExceptionCode, actualException.Message);
        }
    }
}