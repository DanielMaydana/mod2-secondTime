using CarlosTDD.Interfaces;
using CarlosTDD.Implementations;
using System.Collections.Generic;

namespace Testing.Fakes
{
    public class MockBankWithPositiveBalanceUser : Bank
    {
        public MockBankWithPositiveBalanceUser()
        {
            this.allUsers.Add(new UserAccount(id: 111));
            this.CreditUser(id: 111, 500);
            this.SetTax(0.1);
        }
    }
}
