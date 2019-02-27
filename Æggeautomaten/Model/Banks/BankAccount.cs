using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Æggeautomaten.Model.Banks
{
    public class BankAccount
    {
        private string accountOwner;

        public string AccountOwner
        {
            get { return accountOwner; }
            set { accountOwner = value; }
        }


        private string accountNumber;

        public string AccountNumber
        {
            get { return accountNumber; }
            set { accountNumber = value; }
        }

        private int pinNumber;

        //Make Internal after Tests
        public int PinNumber
        {
            get { return pinNumber; }
            set { pinNumber = value; }
        }

        private double balance;

        public double Balance
        {
            get { return balance; }
            set { balance = value; }
        }


        public BankAccount(string accountNumber, int pinNumber)
        {
            AccountNumber = accountNumber;
            PinNumber = pinNumber;
            balance = 0;
        }

        public BankAccount(string accountOwner)
        {
            AccountOwner = accountOwner;
            balance = 0;
        }
    }
}
