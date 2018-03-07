using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            bool newAccount = true;
            Play(ref newAccount);
        }

        private static void Play(ref bool newCheckingAccount)
        {
            decimal accountStart = 10.00m;
            CheckingAccount checkingAccount = new CheckingAccount();

            if (newCheckingAccount)
            {
                checkingAccount.Balance = 0.00m;
            }
            else
            {
                checkingAccount.Balance = accountStart;
            }

            bool run = true;

            while (run)
            {
                ProgramHeader(ref checkingAccount);

                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.Q:
                        run = false;
                        break;

                    case ConsoleKey.W:
                        ShowWithdraw(ref checkingAccount);
                        break;

                    case ConsoleKey.D:
                        ShowDeposit(ref checkingAccount);
                        break;
                }                
            }
        }

        private static void ShowWithdraw(ref CheckingAccount checkingAccount)
        {
            Console.Clear();
            Console.WriteLine("WITHDRAW - CHECKING ACCOUNT");

            Console.WriteLine("\nBalance: {0}", checkingAccount.Balance);

            Console.Write("\n Enter the amount to withdraw ('X' to exit screen):");
            
            if(!decimal.TryParse(Console.ReadLine(),out decimal value))
            {
                Console.WriteLine("Please enter valid amoutn or 'X' to exit: ");
            }
            else
            {
                try
                {
                    checkingAccount.Withdraw(value);
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine();
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Press Enter to Continue");
                    Console.ReadKey();
                }
            }
        }

        private static void ShowDeposit(ref CheckingAccount checkingAccount)
        {
            Console.Clear();
            Console.WriteLine("DEPOSIT - CHECKING ACCOUNT");
            Console.WriteLine("\nBalance: {0}", checkingAccount.Balance);
            Console.Write("\nEnter the amount to deposit ('X' to exit screen):");

            if (!decimal.TryParse(Console.ReadLine(), out decimal value))
            {
               Console.WriteLine("Please enter valid amount or 'X' to exit: ");             
            }
            else
            {
                try
                {
                    checkingAccount.Deposit(value);
                }
                catch(ArgumentException ex)
                {
                    Console.WriteLine();
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Press Enter to Continue");
                    Console.ReadKey();
                }                
            }
        }
        private static void ProgramHeader(ref CheckingAccount checkingAccount)
        {
            Console.Clear();
            Console.WriteLine("CHECKING ACCOUNT");
            Console.WriteLine("Balance: {0}", checkingAccount.Balance);
            Console.Write("\n\nPress 'W' Withdraw, 'D' Deposit, 'Q' to exit: ");
        }
    }
}
