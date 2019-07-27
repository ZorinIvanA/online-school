using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineSchool.ConsoleApp.Classes
{
    public class Automobile
    {
        private static decimal _cost;
        public static int SoldOut { get; private set; }
        public Automobile()
        {
            _cost = 100;
            SoldOut++;
        }

        public static decimal GetCost()
        {            
            return _cost;
        }
    }
}
