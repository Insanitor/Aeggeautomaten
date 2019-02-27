using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Æggeautomaten.Model.CreditCards
{
    public abstract class Expireable : CreditCard
    {
        private string expireDate;
        public Expireable(string cardHolder) : base(cardHolder)
        {

        }

        public string ExpireDate
        {
            get { return expireDate; }
            set { expireDate = value; }
        }

        public string GenerateExpDate(int months, int years)
        {
            string expireDate = DateTime.Now.AddYears(years).AddMonths(months).ToString("MM/yy");

            return expireDate;
        }

        public string GenerateExpDate(int years)
        {
            string expireDate = DateTime.Now.AddYears(years).ToString("MM/yy");

            return expireDate;
        }

    }
}
