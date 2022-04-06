using System.Collections.Generic;

namespace StudentApp
{
    public class Disciple
    {
        private string Name;
        private string Surename;

        private List<double> grades = new List<double>();

        public Disciple(string name, string surename)
        {
            this.Name = name;
            this.Surename = surename;
        }

        public string FullName { get{
            return this.Name + " " + Surename;
        } set{} }
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