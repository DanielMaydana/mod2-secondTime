using CarlosTDD.Interfaces;
using CarlosTDD.Implementations;
using System.Collections.Generic;

namespace Testing.Fakes
{
    public class MockBankWithOnlyUser : Bank
    {
        public MockBankWithOnlyUser()
        {
            this.allUsers = new List<IAccount> { new UserAccount(111) };
        }

    }
}
