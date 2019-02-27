using Æggeautomaten.Model.CreditCards.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Æggeautomaten.Model.CreditCards
{
    public class Maestro : Expireable
    {
        public static List<string> prefixes = new List<string>() { "5018", "5020", "5038", "5893", "6304", "6759", "6761", "6762", "6763" };

        public Maestro(string holderName) : base(holderName)
        {
        }
    }
}
