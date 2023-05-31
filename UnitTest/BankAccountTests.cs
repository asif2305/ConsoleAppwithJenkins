using ConsoleAppwithJenkins;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest
{
    [TestClass]
    public class BankAccountTests
    {
        [TestMethod]
        public void Debit_WithValidAmount_UpdatesBalance()
        {
            ConsoleAppwithJenkins.Trigonometric.Main();
            double beginningBalance = 11.99;
            double debitAmount = 4.55;
            double expected = 7.54;
            BankAccount account = new BankAccount("Md Hasan Ali", beginningBalance);
            account.Debit(debitAmount);

            // assert
            double actual= account.Balance;
           
            Assert.AreEqual(expected, actual,0.001,"Account not debited correctly");
        }
    }
}
