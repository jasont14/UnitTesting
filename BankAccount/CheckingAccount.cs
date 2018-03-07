using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    public class CheckingAccount : IBankAccount
    {
        decimal balance;

        public CheckingAccount()
        {
            Balance = 0.00m;
        }

        public CheckingAccount(decimal value)
        {
            Balance = value;
        }

        public decimal Balance
        {
            get
            {
                return balance;
            }

            set
            {
                if (value.CompareTo(0.00m) < 0)
                {
                    throw new ArgumentException("Balance cannot be set to less than $0.00");
                }
                else
                {
                    balance = value;
                }
            }
        }

        public void Withdraw(decimal value)
        {
            if (value.CompareTo(0.00m) < 0)
            {
                throw new ArgumentException("Cannot withdraw negative amount");
            }
            else
            {
                Balance = Balance - value;
            }
            
        }

        public void Deposit(decimal value)
        {
            if (value.CompareTo(0.00m) < 0)
            {
                throw new ArgumentException("Cannot deposit negative amount");
            }
            else
            {
                Balance = Balance + value;
            }
        }

        public decimal GetBalance()
        {
            return Balance;
        }
    }
}
