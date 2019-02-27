using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Æggeautomaten.Model.Banks;

namespace Æggeautomaten.Model.CreditCards
{
    public abstract class CreditCard
    {
        private string cardHolder;

        public string CardHolder
        {
            get { return cardHolder; }
            set { cardHolder = value; }
        }

        private string accountNumber;

        protected CreditCard(string cardHolder)
        {
            CardHolder = cardHolder;
            
        }

        public string AccountNumber
        {
            get { return accountNumber; }
            set { accountNumber = value; }
        }

        private int pinCode;

        internal int PinCode
        {
            get { return pinCode; }
            set { pinCode = value; }
        }


        public bool AccessAccount(int pinCode)
        {
            if (Bank.CanAccessAccount(this.AccountNumber, pinCode))
            {
                return true;
            }
            else
                return false;
        }
    }
}
