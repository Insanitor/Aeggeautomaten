using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Æggeautomaten.Model.Banks;

namespace Æggeautomaten.tests
{

    public class BankTests
    {
        private static List<BankAccount> accounts = new List<BankAccount>() { new BankAccount("01234", 1234), new BankAccount("12345", 2345) };

        public static List<BankAccount> Accounts { get => accounts; set => accounts = value; }

        [Theory]
        [InlineData("01234")]
        [InlineData("12345")]
        private static BankAccount GetAccount(string accountNumber)
        {
            for (int i = 0; i <= Accounts.Count; i++)
            {
                if (Accounts[i].AccountNumber == accountNumber)
                {
                    Assert.Equal(Accounts[i].AccountNumber, accountNumber);
                    return Accounts[i];
                }
            }
            return null;
        }

        [Theory]
        [InlineData("01234", 1234)]
        [InlineData("12345", 2345)]
        public static bool CanAccessAccount(string accountNumber, int pinCode)
        {
            if (pinCode == GetAccount(accountNumber).PinNumber)
            {
                Assert.True(true);
                return true;
            }
            return false;
        }

        [Theory]
        [InlineData("01234", 1234)]
        [InlineData("12345", 2345)]
        public static double GetBalance(string accountNumber, int pinCode)
        {
            if (Bank.CanAccessAccount(accountNumber, pinCode))
            {
                Assert.True(true);
                return GetAccount(accountNumber).Balance;
            }
            return 0;
        }

        [Theory]
        [InlineData("01234", 1234, 100)]
        [InlineData("01234", 1234, 1000)]
        [InlineData("12345", 2345, 100)]
        public static void AddBalance(string accountNumber, int pinCode, double amount)
        {
            if (CanAccessAccount(accountNumber, pinCode))
            {
                GetAccount(accountNumber).Balance += amount;
                Assert.True(true);
            }
        }

        [Fact]
        public static void GenerateAccountNumber()
        {
            string accountNumber = "";
            while (accountNumber.Length < 10)
            {
                while (accountNumber.Length < 10)
                {
                    accountNumber += new Random().Next(0, 9);
                }
            }
            Assert.True(accountNumber.Length == 10);
        }
    }
}
