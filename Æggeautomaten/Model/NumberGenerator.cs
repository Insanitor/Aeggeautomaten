using Æggeautomaten.Model.CreditCards;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Æggeautomaten.Model
{
    public class NumberGenerator
    {
        public static string GenerateMaestroCardNumber(int digitCount)
        {
            string cardNumber = "";

            int whichPrefix = new Random().Next(0, Maestro.prefixes.Count);
            cardNumber += Maestro.prefixes[whichPrefix];

            while (cardNumber.Length < digitCount)
            {
                cardNumber += new Random().Next(0, 9);
            }

            return cardNumber;
        }

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
        }
    }
}
