using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Æggeautomaten.Model.Banks
{
    public class Bank
    {
        private static List<BankAccount> accounts = new List<BankAccount>() { new BankAccount("01234", 1234), new BankAccount("12345", 2345) };

        public static List<BankAccount> Accounts
        {
            get { return accounts; }
            private set { accounts = value; }
        }

        public static BankAccount GetAccount(string accountNumber)
        {
            for (int i = 0; i < Accounts.Count; i++)
            {
                if (Accounts[i].AccountNumber == accountNumber)
                    return Accounts[i];
            }
            return null;
        }

        public static bool CanAccessAccount(string accountNumber, int pincode)
        {
            if (pincode == GetAccount(accountNumber).PinNumber)
            {
                return true;
            }
            return false;
        }

        public static double GetBalance(string accountNumber, int pinCode)
        {
            if (CanAccessAccount(accountNumber, pinCode))
            {
                return GetAccount(accountNumber).Balance;
            }
            return 0;
        }
    }
}
