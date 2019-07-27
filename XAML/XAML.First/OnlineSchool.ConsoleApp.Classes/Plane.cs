using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineSchool.ConsoleApp.Classes
{
    public class Plane : Vechicle, IMovable
    {
        public override void Move()
        {
            Console.WriteLine("Plane move");
        }

        void IMovable.Move()
        {
            Console.WriteLine("Plane IMovable move");
        }

        public void OnShellBlasted(object sender, PowerEventArgs e)
        {
            Console.WriteLine($"Plane is alive: {e.Power < 1000}!");
        }
    }
}
