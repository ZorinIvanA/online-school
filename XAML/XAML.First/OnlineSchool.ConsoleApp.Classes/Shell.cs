using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineSchool.ConsoleApp.Classes
{
    public class Shell
    {
        public event EventHandler<PowerEventArgs> Blasted;

        public void Blast(int power)
        {
            Blasted?.Invoke(this, new PowerEventArgs(power));
        }
    }

    public class PowerEventArgs : EventArgs
    {
        public int Power { get; private set; }
        public PowerEventArgs(int power)
        {
            Power = power;
        }
    }
}
