using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineSchool.ConsoleApp.Classes
{
    public class Plane : Vechicle
    {
        public override void Move()
        {
            base.Move();
            Console.WriteLine("Plane move");
        }
    }
}
