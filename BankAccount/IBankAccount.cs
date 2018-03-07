using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    interface IBankAccount
    {
        void Deposit(decimal value);
        void Withdraw(decimal value);
        decimal GetBalance();
    }
}
