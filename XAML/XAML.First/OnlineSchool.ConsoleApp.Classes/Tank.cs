using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace OnlineSchool.ConsoleApp.Classes.Units
{
    public class Tank : Vechicle, IMovable, IDisposable
    {
        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public override void Move()
        {
            Console.WriteLine("Tank move");
        }

        public void OnShellBlasted(object sender, PowerEventArgs e)
        {
            Console.WriteLine($"Health is {100 - e.Power}");
        }
    }
}
