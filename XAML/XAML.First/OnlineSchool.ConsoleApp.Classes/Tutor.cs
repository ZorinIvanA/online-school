using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineSchool.ConsoleApp.Classes
{
    public class Tutor : Person
    {
        public string Department;

        public Tutor(DateTime birthday)
        {
            SetBirthday(birthday);
        }
    }
}
