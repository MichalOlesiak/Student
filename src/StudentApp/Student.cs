using System.Collections.Generic;

namespace StudentApp
{
    public class Disciple
    {
        private string name;
        private string surename;

        private List<double> grades = new List<double>();

        public Disciple(string name, string surename)
        {
            this.name = name;
            this.surename = surename;
        }

        public string FullName 
        { 
            get
                {
                    return this.name + " "+ this.surename;
                } 
        }
        public void AddGrade(double grade)
        {
            this.grades.Add(grade);
        }

        public Statistics GetStatistics()
        {
            var result = new Statistics();
            result.Average = 0.0;
            result.High = double.MinValue;
            result.Low = double.MaxValue;

            foreach(var grade in this.grades)
            {
                result.Low = Math.Min(result.Low, grade);
                result.High = Math.Max(result.High, grade);
                result.Average += grade;
            }
            result.Average /= grades.Count;

            Console.WriteLine($"The lowest grade is {result.Low:N4}");
            Console.WriteLine($"The highest grade is {result.High:N4}");
            Console.WriteLine($"The Average is {result.Average:N4}");
            return result;
        }
    }
}