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
            this.FullName = name + " " + surename;
        }

        public string FullName { get; set;}
        public void AddGrade(string grade)
        {
            int result;
            if (int.TryParse(grade, out result))
            {
                this.grades.Add(result);
            }
            
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