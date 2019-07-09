using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineSchool.ConsoleApp.Classes
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
    }
}
