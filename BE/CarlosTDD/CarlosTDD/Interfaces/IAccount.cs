using System;
using System.Collections.Generic;
using System.Text;

namespace CarlosTDD.Interfaces
{
    public interface IAccount
    {
        double GetBalance();

        double Credit(double ammount);

        double Debit(double ammount);
    }
}
