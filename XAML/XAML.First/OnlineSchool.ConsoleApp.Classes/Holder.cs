using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineSchool.ConsoleApp.Classes
{
    public class Holder<T>
    {
        public T _holdee;

        public T1 GetHoldee<T1>(T1 arg)            
        {
            return arg;
        }
    }

    public interface IHoldee { }

    public class Smartphone : IHoldee
    {
        public Smartphone(int t)
        {

        }
        public Smartphone()
        {

        }
        public void Call() { }
    }

    public class TabletPC : IHoldee
    {
        public void Open() { }
    }


}
