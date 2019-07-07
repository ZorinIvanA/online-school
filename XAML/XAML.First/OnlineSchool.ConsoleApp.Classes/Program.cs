using System;

namespace OnlineSchool.ConsoleApp.Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Классы
            var inputedString = Console.ReadLine();
            int.TryParse(inputedString, out var result);
            Console.WriteLine(result);

            int age = 25;
            Student s = new Student("Smith", ref age, "1111", 5);
            Console.WriteLine(age);
            int visitedOutput = 0;
            s.VisitClass(3, out visitedOutput);
            Console.WriteLine(visitedOutput);
            var visitedClassesCount = s.GetClassesVisitedCount();
            Console.WriteLine(visitedClassesCount._error);

            Console.WriteLine($"Student {s._studentName} has visited class {visitedClassesCount._visited} times");
            #endregion

            #region ООП
            //            Tutor t = new Tutor(DateTime.Parse("2000-01-01"))
            //            {
            //                Department = "Любая кафедра",
            //                FIO = "Иванов И. И."
            //            };
            ////            t.SetBirthday(DateTime.Parse("2001-01-01"));
            //            Console.WriteLine(t.GetPersonAge());

            Vechicle v = new Vechicle();
            v.Move();
            Tank tank = new Tank();
            tank.Move();
            Plane p = new Plane();
            p.Move();

            Vechicle tank2 = new Tank();
            tank2.Move();
            Vechicle p2 = new Plane();
            p2.Move();

            Payment payment = new Payment();
            payment.Pay((decimal)45.5, "401020200");

            #endregion
        }
    }
}
