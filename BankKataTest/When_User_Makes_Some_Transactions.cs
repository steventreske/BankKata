using BankKata;
using NSubstitute;
using Xunit;

namespace BankKataTest
{
    public class WhenUserMakesSomeTransactions
    {
        [Theory, AutoNSubstituteData]
        public void And_Statement_Is_Printed_The_Correct_Dates_Should_Be_Displayed(
            IConsole console,
            Account sut)
        {
            // Act
            sut.Deposit(1000);
            sut.Deposit(2000);
            sut.Withdrawal(500);
            sut.PrintStatement();

            // Assert
            Received.InOrder(() =>
            {
                console.PrintLine("date           || credit  || debit     || balance");
                console.PrintLine("14 / 01 / 2012 ||         ||    500.00 || 2500.00");
                console.PrintLine("13 / 01 / 2012 || 2000.00 ||           || 3000.00");
                console.PrintLine("10 / 01 / 2012 || 1000.00 ||           || 1000.00");
            });            
        }
    }
}