using CarlosTDD.Interfaces;
using CarlosTDD.Implementations;
using System.Collections.Generic;

namespace Testing.Fakes
{
    public class StubUserWithPositiveBalance : UserAccount
    {
        public StubUserWithPositiveBalance(int id) : base(id)
        {
            this.balance = 500D;
        }
    }
}
