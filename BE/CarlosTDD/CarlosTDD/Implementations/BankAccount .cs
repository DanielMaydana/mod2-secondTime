using CarlosTDD.Interfaces;
using System.Collections.Generic;
using System;

namespace CarlosTDD.Implementations
{
    public class BankAccount : IAccount
    {
        private double balance;

        public BankAccount()
        {
            this.balance = 0;
        }

        public double UpdateBalance(double ammount)
        {
            return this.balance += Math.Round(ammount, 2);
        }

        public double GetBalance()
        {
            return this.balance;
        }
    }
}
