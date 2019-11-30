using CarlosTDD.Interfaces;
using CarlosTDD.Implementations;
using System.Collections.Generic;

namespace Testing.Fakes
{
    public class MockBankWithTax : Bank
    {
        public MockBankWithTax()
        {
            this.allUsers = new List<IAccount> { new UserAccount(111) };
            this.tax = 0.1F;
        }
    }
}
