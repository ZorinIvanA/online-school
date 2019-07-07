using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineSchool.ConsoleApp.Classes
{
    public class Student : Person
    {
        public string Bookmark;
        public string _studentName;
        public int age;
        public int _visit;

        public Student(string studentName, ref int age, string markbook, int visit)
        {
            this._studentName = studentName;
            this.age = age;
            this.Bookmark = markbook;
            this._visit = visit;
        }

        public int VisitClass(int visit, out int visitedOutput)
        {
            visitedOutput = _visit;
            return _visit;
        }

        public VisitedCountResult GetClassesVisitedCount()
        {
            return new VisitedCountResult
            {
                _visited = _visit,
                _error = string.Empty
            };
        }
    }
}
