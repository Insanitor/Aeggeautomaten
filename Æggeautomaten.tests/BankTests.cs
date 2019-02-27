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
        public static List<BankAccount> accounts = new List<BankAccount>() { new BankAccount("01234", 1234), new BankAccount("12345", 2345) };

        [Theory]
        [InlineData("01234")]
        [InlineData("12345")]
        [InlineData("23456")]
        private static void GetAccount(string accountNumber)
        {
            for (int i = 0; i <= Bank.Accounts.Count; i++)
            {
                if (accounts[i].AccountNumber == accountNumber)
                {
                    Assert.Equal(Bank.Accounts[i].AccountNumber, accountNumber);
                    break;
                }
            }
        }

        [Theory]
        [InlineData("01234", 1234)]
        [InlineData("12345", 2345)]
        [InlineData("23456", 3456)]
        public static void CanAccessAccount(string accountNumber, int pinCode)
        {
            Assert.True(pinCode == Bank.GetAccount(accountNumber).PinNumber);
        }

        [Theory]
        [InlineData("01234", 1234)]
        [InlineData("12345", 2345)]
        [InlineData("23456", 3456)]
        public static void GetBalance(string accountNumber, int pinCode)
        {
            if (Bank.CanAccessAccount(accountNumber, pinCode))
            {
                Assert.True(Bank.GetAccount(accountNumber).Balance >= 0);
            }
        }

        [Theory]
        [InlineData("01234", 1234, 100)]
        [InlineData("01234", 1234, 1000)]
        [InlineData("12345", 2345, 100)]
        [InlineData("23456", 3456, 1000)]
        public static void AddBalance(string accountNumber, int pinCode, double amount)
        {
            if (Bank.CanAccessAccount(accountNumber, pinCode))
            {
                Bank.GetAccount(accountNumber).Balance += amount;
            }
            Assert.Equal(Bank.GetAccount(accountNumber).Balance, amount);
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

        //public static void NewBankAccount(string cardHolder)
        //{
        //    for (int i = 0; i < accounts.Count; i++)
        //    {
        //        accounts.Add(new BankAccount(cardHolder))
        //        Assert.True(accounts[i].AccountOwner == cardHolder);
        //    }
        //}
    }
}
