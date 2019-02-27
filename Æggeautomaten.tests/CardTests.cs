using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Æggeautomaten.Model.CreditCards;

namespace Æggeautomaten.tests
{
    public class CardTests
    {
        public enum CardType { Maestro, Visa, VisaElectron }

        [Theory]
        [InlineData(5)]
        [InlineData(10)]
        [InlineData(15)]
        [InlineData(20)]
        public void GenerateMaestroCardNumber(int digitCount)
        {
            string cardNumber = "";

            int whichPrefix = new Random().Next(0, Maestro.prefixes.Count);
            cardNumber += Maestro.prefixes[whichPrefix];

            while (cardNumber.Length < digitCount)
            {
                cardNumber += new Random().Next(0, 9);
            }

            Assert.Equal(cardNumber.Length, digitCount);
        }

    }
}
