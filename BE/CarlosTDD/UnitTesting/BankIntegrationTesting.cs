using Microsoft.VisualStudio.TestTools.UnitTesting;
using CarlosTDD.Implementations;
using Testing.Fakes;
using System;

namespace Testing
{
    [TestClass]
    public class IntegrationTesting
    {
        [TestMethod]
        public void GetBalanceFromAUser_ReturnsDefaultUsersBalance_WhenUsedBankWithSingleUser()
        {
            var myBank = new MockBankWithOnlyUser();

            var expectedUserBalance = 0D;
            var actualUserBalance = myBank.GetAccountBalance(id: 111);

            Assert.AreEqual(expectedUserBalance, actualUserBalance);
        }

        [TestMethod]
        public void GetBalanceFromAUser_ReturnsBalance_WhenUserHasBeenPreviouslyRegistered()
        {
            var myBank = new MockBankWithPositiveBalanceUser();

            var expectedUserBalance = 500D;
            var actualUserBalance = myBank.GetAccountBalance(id: 111);

            Assert.AreEqual(expectedUserBalance, actualUserBalance);
        }

        [TestMethod]
        public void CreditUser_ReturnsTrue_WhenCreditedToAUserInABankWith10PercentTax()
        {
            var myBank = new MockBankWithTax();

            var operationState = myBank.CreditUser(id: 111, ammount: 150D);

            Assert.IsTrue(operationState);
        }

        [TestMethod]
        public void CreditUser_ReturnsFalse_WhenTheCreditedUserDoesNotExist()
        {
            var myBank = new MockBankWithTax();

            var thrownException = Assert.ThrowsException<ArgumentException>(() => myBank.CreditUser(id: 999, ammount: 150D));
            var expectedMessage = "The account with the id '999' was not found.";

            Assert.AreEqual(expectedMessage, thrownException.Message);
        }

        [TestMethod]
        public void GetBalanceFromAUser_ReturnsBankBalance_WhenAUserIsCreditedInABankWith10PercentTax()
        {
            var myBank = new MockBankWithTax();
            myBank.CreditUser(id: 111, ammount: 150D);

            var expectedBalance = 15D;
            var actualBalance = myBank.GetBalance();

            Assert.AreEqual(expectedBalance, actualBalance);
        }

        [TestMethod]
        public void GetBalanceFromAUser_ReturnsUpdatedUsersBalance_WhenAUserIsCreditedInABankWith10PercentTax()
        {
            var myBank = new MockBankWithTax();
            myBank.CreditUser(id: 111, ammount: 150D);

            var expectedBalance = 135D;
            var actualBalance = myBank.GetAccountBalance(id: 111);

            Assert.AreEqual(expectedBalance, actualBalance);
        }

        [TestMethod]
        public void GetBalanceFromAUser_ReturnsUpdatedUsersBalance_WhenAPositiveBalanceAccountIsAddedToTheBankAndCredited()
        {
            var myBank = new Bank();
            myBank.SetTax(0.1);
            myBank.AddAccount(new StubUserWithPositiveBalance(111));
            myBank.CreditUser(id: 111, ammount: 150D);

            var expectedBalance = 635D;
            var actualBalance = myBank.GetAccountBalance(id: 111);

            Assert.AreEqual(expectedBalance, actualBalance);
        }


        [TestMethod]
        public void GetBalanceFromAUser_ReturnsUpdatedUsersBalance_WhenAUserIsDebitedInABankWithNoTax()
        {
            var myBank = new Bank();
            myBank.AddAccount(new StubUserWithPositiveBalance(id: 111));
            myBank.DebitUser(id: 111, ammount: 50D);

            var actualBalance = myBank.GetAccountBalance(id: 111);
            var expectedBalance = 450;

            Assert.AreEqual(expectedBalance, actualBalance);
        }

        [TestMethod]
        public void GetBalanceFromAUser_ReturnsUpdatedUsersBalance_WhenAUserIsDebitedInABankWith10PercentTax()
        {
            var myBank = new MockBankWithPositiveBalanceUser();
            myBank.DebitUser(111, 50D);

            var actualBalance = myBank.GetAccountBalance(id: 111);
            var expectedBalance = 445D;

            Assert.AreEqual(expectedBalance, actualBalance);
        }

        [TestMethod]
        public void DebitUser_ThrowsException_WhenAUserIsDebitedAnAmmountGreaterThanHisBalance()
        {
            var myBank = new MockBankWithOnlyUser();

            var actualException = Assert.ThrowsException<ArgumentException>(() => myBank.DebitUser(id: 111, ammount: 50D));
            var expectedMessage = "The ammount to debit '50' is greater than the balance of the account '111'.";

            Assert.AreEqual(expectedMessage, actualException.Message);
        }

        [TestMethod]
        public void GetBalanceFromTheBank_ReturnsDefaultBankBalance_WhenBankIsInstiantiated()
        {
            var myBank = new Bank();

            var actualBalance = myBank.GetBalance();
            var expectedBalance = 0D;

            Assert.AreEqual(expectedBalance, actualBalance);
        }

        [TestMethod]
        public void GetBalanceFromTheBank_ReturnsUpdatedBankBalance_WhenUserAccountIsCredited()
        {
            var myBank = new MockBankWithTax();
            myBank.AddAccount(new StubUserWithPositiveBalance(id: 111));
            myBank.CreditUser(id: 111, ammount: 100D);

            var actualBalance = myBank.GetBalance();
            var expectedBalance = 10D;

            Assert.AreEqual(expectedBalance, actualBalance);
        }

        [TestMethod]
        public void GetBalanceFromTheBank_ReturnsUpdatedBankBalance_WhenUserAccountIsDebited()
        {
            var myBank = new MockBankWithPositiveBalance();
            myBank.DebitUser(id: 111, ammount: 100D);

            var actualBalance = myBank.GetBalance();
            var expectedBalance = 1010D;

            Assert.AreEqual(expectedBalance, actualBalance);
        }

        [TestMethod]
        public void CreditUser_ThrowsAnException_WhenAmmountIsNegative()
        {
            var myBank = new MockBankWithOnlyUser();

            var actualException = Assert.ThrowsException<ArgumentException>(() => myBank.CreditUser(id: 111, ammount: -100D));
            var expectedMessage = "The negative ammount '-100' couldn't be processed for the account '111'.";

            Assert.AreEqual(expectedMessage, actualException.Message);
        }
    }
}
