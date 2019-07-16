using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineSchool.ConsoleApp.Classes
{
    public class Customer
    {
        public decimal BoughtDuringTheYear { get; set; }
        public double Discount
        {
            get
            { return 0.01 * (double)BoughtDuringTheYear; }
        }       


        public decimal GetSumWithDiscount(decimal sum)
        {
            return sum * (decimal)(100 - Discount) / 100;
        }
    }
}
