using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineSchool.ConsoleApp.Classes
{
    public class Customer
    {        
        public double DiscountSize
        {
            get
            { return 0.01 * (double)HaveBought; }
        }
        public decimal HaveBought { get; set; }

        public decimal GetSum(decimal sum)
        {
            return sum - (decimal)DiscountSize;
        }
    }
}
