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

        public double UpdateBalance(double ammount)
        {
            this.ValidateAmmount(ammount);
            return this.balance += Math.Round(ammount, 2);
        }

        public double GetBalance()
        {
            return this.balance;
        }

        private bool ValidateAmmount(double ammount)
        {
            if (this.balance + ammount < 0) throw new ArgumentException("111");

            return true;
        }
    }
}
