﻿using OnlineSchool.ConsoleApp.Classes.Units;
using System;
using System.Collections.Generic;
using System.Linq;

namespace OnlineSchool.ConsoleApp.Classes
{
    delegate int TwoArgsDelegate(int x, int y);
    delegate void VoidDelegate(int x, int y);

    class Program
    {
        const string MY_CONST = "tst";

        static void Main(string[] args)
        {
            #region Классы
            //var inputedString = Console.ReadLine();
            //int.TryParse(inputedString, out var result);
            //Console.WriteLine(result);

            //int age = 25;
            //Student s = new Student("Smith", ref age, "1111", 5);
            //Console.WriteLine(age);
            //int visitedOutput = 0;
            //s.VisitClass(3, out visitedOutput);
            //Console.WriteLine(visitedOutput);
            //var visitedClassesCount = s.GetClassesVisitedCount();
            //Console.WriteLine(visitedClassesCount._error);

            //Console.WriteLine($"Student {s._studentName} has visited class {visitedClassesCount._visited} times");
            #endregion

            #region ООП
            //            Tutor t = new Tutor(DateTime.Parse("2000-01-01"))
            //            {
            //                Department = "Любая кафедра",
            //                FIO = "Иванов И. И."
            //            };
            ////            t.SetBirthday(DateTime.Parse("2001-01-01"));
            //            Console.WriteLine(t.GetPersonAge());

            //Tank tank = new Tank();
            //tank.Move();
            //Plane p = new Plane();
            //p.Move();

            //Vechicle tank2 = new Tank();
            //tank2.Move();
            //Vechicle p2 = new Plane();
            //p2.Move();

            //Payment payment = new Payment();
            //payment.Pay((decimal)45.5, "401020200");

            #endregion

            #region Абстрактные классы и интерфейс

            //Vechicle vechicle1 = new Tank();
            //vechicle1.Move();
            //Vechicle vechicle = new Plane();
            //vechicle.Move();

            //IMovable movable = new Tank();
            //movable.Move();
            //IMovable movable1 = new Plane();
            //movable1.Move();
            //var checkResult = new Tutor(DateTime.Now) as IMovable;
            //checkResult?.Move();
            //Console.WriteLine(checkResult);

            #endregion

            #region Generic
            //Holder<Smartphone> holder = new Holder<Smartphone>();
            //holder._holdee = new Smartphone();
            //holder._holdee.Call();

            //Holder<TabletPC> holder1 = new Holder<TabletPC>();
            //holder1._holdee = new TabletPC();
            //holder1._holdee.Open();

            //Holder<int> holder2 = new Holder<int>();
            //holder2._holdee = 2;

            //List<int> intList = new List<int> { 1, 2, 5 };
            //List<Smartphone> smartphonesList = new List<Smartphone>
            //{
            //    new Smartphone(), new Smartphone(), new Smartphone()
            //};

            //Console.WriteLine(holder.GetHoldee<double>(2.34));
            #endregion

            #region Properties
            //Customer customer = new Customer();
            //customer.HaveBought = 100;
            //Console.WriteLine($"сумма: {customer.GetSum(100)}, скидка {customer.DiscountSize}");
            #endregion

            #region Delegate
            //TwoArgsDelegate del1 = GetSum;
            //TwoArgsDelegate del2 = GetDifference;
            //Console.WriteLine(del1(7, 5));
            //Console.WriteLine(del2(7, 5));

            //TwoArgsDelegate anonymousDelegate = delegate (int x, int y)
            //{
            //    return x / y;
            //};
            //Console.WriteLine(anonymousDelegate(8, 4));
            //TwoArgsDelegate lambda1 = (x, y) => x * y;
            //Console.WriteLine(lambda1(8, 4));
            //VoidDelegate delVoid = (x, y) =>
            //{
            //    var t = x * y;                
            //    Console.WriteLine(del1(t, 10));
            //};
            //delVoid(5, 7);
            #endregion

            #region Static class
            //Automobile automobile1 = new Automobile();
            //Automobile automobile2 = new Automobile();
            //Automobile automobile3 = new Automobile();
            //Console.WriteLine(Automobile.SoldOut);
            //Console.WriteLine(Automobile.GetCost());

            //EmailSender.Send("test@test.test", "test");            
            #endregion

            #region Events
            Shell shell = new Shell();
            Tank tank = new Tank();
            Plane plane = new Plane();
            shell.Blasted += tank.OnShellBlasted;
            shell.Blasted += plane.OnShellBlasted;
            shell.Blasted -= plane.OnShellBlasted;

            shell.Blast(1200);
            #endregion
        }

        #region Methods for Delegates
        static int GetSum(int x, int y) { return x + y; }
        static int GetDifference(int x, int y) { return x - y; }
        #endregion
    }
}
