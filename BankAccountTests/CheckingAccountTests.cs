using Microsoft.VisualStudio.TestTools.UnitTesting;
using BankAccount;
using System;

namespace BankAccount.Tests
{
    [TestClass()]
    public class CheckingAccountTests
    {
        [TestMethod()]
        public void WithdrawTest()
        {
            //Arrange
            decimal currentBalance = 10.00m;
            decimal withdraw = 5.00m;
            decimal expected = 5.00m;
            var account = new CheckingAccount(currentBalance);
            //Act
            account.Withdraw(withdraw);
            decimal actual = account.Balance;
            //Assert
            Assert.AreEqual(expected,actual);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void WithdrawMoreThanBalance_Throws()
        {
            //Arrange
            decimal currentBalance = 10.00m;
            decimal withdraw = 20.00m;
            var account = new CheckingAccount(currentBalance);
            //Act
            account.Withdraw(withdraw);
            //Assert
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void Withdraw_NegativeAmount_Throws()
        {
            //Arrange
            decimal currentBalance = 10.00m;
            decimal withdraw = -4.00m;
            var account = new CheckingAccount(currentBalance);
            //Act
            account.Withdraw(withdraw);
            //Assert is handled by ExpectedException attribute above
        }

        [TestMethod()]
        public void DepositAdd()
        {
            //Arrange
            decimal balance = 10.00m;
            decimal deposit = 25.00m;
            decimal expected = 35.00m;
            var account = new CheckingAccount(balance);
            //Act
            account.Deposit(deposit);
            decimal result = account.Balance;
            //Assert
            Assert.AreEqual(result, expected);
        }
    }
}