using CarlosTDD.Interfaces;
using System;

namespace CarlosTDD.Implementations
{
    public class UserAccount : IAccount
    {
        protected double balance;
        public int Id { get; private set; }

        public UserAccount(int id)
        {
            this.balance = 0;
            this.Id = id;
        }

        public double Credit(double ammount)
        {
            return this.balance += Math.Round(ammount, 2);
        }

        public double Debit(double ammount)
        {
            throw new System.NotImplementedException();
        }

        public double GetBalance()
        {
            return this.balance;
        }
    }
}
