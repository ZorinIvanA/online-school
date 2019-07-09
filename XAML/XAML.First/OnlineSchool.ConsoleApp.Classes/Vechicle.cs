using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineSchool.ConsoleApp.Classes
{
    public abstract class Vechicle : IMovable
    {
        public abstract void Move();

        public virtual void Wheel()
        {

        }
    }
}
