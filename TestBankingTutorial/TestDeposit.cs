using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankingTutorial;

namespace TestBankingTutorial
{
    public class TestDeposit
    {
        Account depositlib;

        public TestDeposit()
        {
            depositlib = new Account();
        }

        [Theory]
        [InlineData(100, 200, 300)]
        public void Test1(int Amount, int Balance, int expected)
        {
            Assert.Equal(expected, depositlib.Deposit(bool));
        }
    }
}
