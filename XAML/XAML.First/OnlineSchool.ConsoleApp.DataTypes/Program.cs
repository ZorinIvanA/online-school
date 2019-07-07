using System;
using System.Text;

namespace OnlineSchool.ConsoleApp.DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = Console.ReadLine();

            var x = int.Parse(s);
            x *= 5;           

            Console.WriteLine(++x);
        }
    }
}
