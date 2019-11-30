using CarlosTDD.Interfaces;
using CarlosTDD.Implementations;
using System.Collections.Generic;

namespace Testing.Fakes
{
    public class MockBankWithPositiveBalance : Bank
    {
        public MockBankWithPositiveBalance()
        {
            this.allUsers = new List<IAccount> { new StubUserWithPositiveBalance(111) };
            this.bankAccount.UpdateBalance(1000);
            this.SetTax(0.10);
        }
    }
}
