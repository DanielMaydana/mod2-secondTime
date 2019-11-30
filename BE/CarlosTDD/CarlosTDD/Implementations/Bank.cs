using CarlosTDD.Interfaces;
using System.Collections.Generic;
using System;

namespace CarlosTDD.Implementations
{
    public class Bank
    {
        protected IAccount bankAccount;
        protected List<IAccount> allUsers;
        protected double tax;
        private delegate bool AmmountValidations(double ammount);

        public Bank()
        {
            this.allUsers = new List<IAccount>();
            this.bankAccount = new BankAccount();
        }

        public void AddAccount(IAccount accountToAdd)
        {
            this.allUsers.Add((UserAccount)accountToAdd);
        }

        public double GetAccountBalance(int id)
        {
            return this.GetAccount(id).GetBalance();
        }

        public bool CreditUser(int id, double ammount)
        {

            double taxedAmmount = ammount * (1 - this.tax);
            double bankFee = ammount * this.tax;

            return TryUpdateBalance(id, bankFee, taxedAmmount, ammount);
        }

        public bool DebitUser(int id, double ammount)
        {
            double bankFee = ammount * this.tax;
            double taxedAmmount = -(ammount + bankFee);

            return TryUpdateBalance(id, bankFee, taxedAmmount, ammount);
        }

        private IAccount GetAccount(int id)
        {
            var foundUser = this.allUsers.Find(account => ((UserAccount)account).Id == id);

            return foundUser != null ? foundUser : throw new ArgumentException("222");
        }

        private bool TryUpdateBalance(int id, double bankFee, double taxedAmmount, double ammount)
        {
            try
            {
                this.ValidateAmmount(ammount);
                this.UpdateBankBalance(bankFee);
                this.UpdateUserBalance(id, taxedAmmount);
            }
            catch (ArgumentException e)
            {
                switch (e.Message)
                {
                    case "111":
                        throw new ArgumentException($"The ammount to debit '{ammount}' is greater than the balance of the account '{id}'.");
                    case "222":
                        throw new ArgumentException($"The account with the id '{id}' was not found.");
                    case "333":
                        throw new ArgumentException($"The negative ammount '{ammount}' couldn't be processed for the account '{id}'.");
                }
            }

            return true;
        }


        private bool IsGreaterOrEqualThanZero(double ammount)
        {
            if (ammount < 0) throw new ArgumentException("333");

            return true;
        }

        private bool ValidateAmmount(double ammount)
        {
            AmmountValidations Validations = this.IsGreaterOrEqualThanZero;

            Validations(ammount);

            return true;
        }

        private void UpdateBankBalance(double bankFee)
        {
            this.bankAccount.UpdateBalance(bankFee);
        }

        private void UpdateUserBalance(int id, double taxedAmmount)
        {
            this.GetAccount(id).UpdateBalance(taxedAmmount);
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
