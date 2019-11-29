using CarlosTDD.Interfaces;
using System.Collections.Generic;

namespace CarlosTDD.Implementations
{
    public class Bank
    {
        protected IAccount bankAccount;
        protected List<IAccount> allUsers;
        protected double tax;

        public Bank()
        {
            this.bankAccount = new BankAccount();
            this.allUsers = new List<IAccount>();
        }

        public void AddAccount(IAccount accountToAdd)
        {
            this.allUsers.Add((UserAccount)accountToAdd);
        }

        public IAccount GetAccount(int id)
        {
            return this.allUsers.Find(account => ((UserAccount)account).Id == id);
        }

        public bool CreditUser(int id, double ammount)
        {
            double taxedAmmount = ammount * (1 - this.tax);
            double bankFee = ammount * this.tax;

            try
            {
                this.GetAccount(id).Credit(taxedAmmount);
                this.bankAccount.Credit(bankFee);
            }
            catch
            {
                return false;
            }

            return true;
        }

        public void SetTax(double tax)
        {
            this.tax = tax;
        }

        public double GetBalance()
        {
            return this.bankAccount.GetBalance();
        }
    }
}
