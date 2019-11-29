using System;

namespace TestMe
{
    public class Program
    {

        public static void Main()
        {
            BankAccs ba = new BankAccs();
            ba.clientname = "Jorge Fernandez";
            ba.balance = 11.99;

            ba.credit(5.77);
            ba.debit(11.22);

            Console.WriteLine("Current balance is ${0}", ba.balance);
        }
    }

    public class BankAccs
    {
        public string clientname;
        public double balance;
        public double bankBalance;
        public DateTime operationDateTime;

        public void debit(double amount)
        {
            balance -= amount;
            bankBalance -= amount;
            operationDateTime = DateTime.Now;
            applyTax(amount, "debit");
        }

        public void credit(double amount)
        {
            balance += amount;
            bankBalance += amount;
            operationDateTime = DateTime.Now;
            applyTax(amount, "credit");
        }

        public void applyTax(double amount, string operation)
        {
            if (operation == "debit")
            {
                balance -= generatetax() * amount / 100;
                bankBalance += generatetax() * amount / 100;
            }

            if (operation == "credit")
            {
                balance -= generatetax() * amount / 100;
                bankBalance += generatetax() * amount / 100;
            }
        }

        public static int generatetax()
        {
            return new Random().Next(1, 5);
        }

    }

}