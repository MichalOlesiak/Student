using System.Collections.Generic;

namespace StudentApp

{
    class Program
    {
        static void Main(string[] args)
        {
            var student = new Disciple("Michal", "Kowalski");
            var student1 = new Disciple("Tomek", "Kowalski");
            student.AddGrade(15);
            student.AddGrade(20);
            student.AddGrade(30);

            var sat = student.GetStatistics();

        }
    }
}