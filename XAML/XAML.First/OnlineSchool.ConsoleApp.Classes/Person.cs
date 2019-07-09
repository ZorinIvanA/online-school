using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineSchool.ConsoleApp.Classes
{
    public abstract class Person
    {
        public string FIO;
        private DateTime Birthday;

        public void SetBirthday(DateTime newBirthday)
        {
            Birthday = newBirthday;
        }

        public int GetPersonAge()
        {
            return DateTime.Now.Year - Birthday.Year;
        }
    }
}
