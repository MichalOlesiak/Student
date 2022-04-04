using System;
using System.Collections.Generic;

namespace StudentApp

{
    class Program
    {
        static void Main(string[] args)
        {
            var student = new Disciple("Michal");
            student.AddGrade(15);
            student.AddGrade(20);
            student.AddGrade(30);

            var sat = student.GetStatistics();

        }
    }
}