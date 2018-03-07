# UnitTesting
Unit Testing C# Microsoft Visual Studio 2017

Bank Account with an Account interface that a Checking Account derives from to create simple app with the following:

# Methods and Properties

Withdraw - Remove from account.  Cannot be negative

Deposit - Add to account.  Cannot be negative.

ArgumentException - Would prefer custom class but used argument exception to test throw.

Balance - Property that cannot be negative.


# Testing

WithdrawTest - Tests to ensure debit balance as expected.

WithdrawNegativeAmountThrows - Tests to ensure an exception is thrown if a negative amount is withdrawn.

WithdrawMoreThanBalance_Throws - Tests to ensure an exception is thrown if more than the balance is withdrawn.

DepostAdd - Tests to ensure credit balance as expected.
