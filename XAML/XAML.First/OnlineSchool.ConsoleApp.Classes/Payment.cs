using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineSchool.ConsoleApp.Classes
{
    public class Payment
    {
        public void Pay(decimal sum) { }
        public void Pay(decimal sum, string cardNumber) { }
        public void Pay(string checkNumber, decimal sum ) { }
    }
}
