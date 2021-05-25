using System;
using System.Collections.Generic;
using System.Text;

namespace GradeBook
{
    class Book
    {
        public Book(string name)
        {
            grades = new List<double>();

            this.name = name;
        }

        public void AddLetterGrade(char letter)
        {
            switch(letter)
            {
                case 'A':
                    AddGrade(90);
                    break;
                case 'B':
                    AddGrade(80);
                    break;
                case 'C':
                    break;

                default:
                    AddGrade(0);
                    break;
            }
        }

        public void AddGrade(double grade)
        {
            if (grade <= 100 && grade >=0)
            {
                grades.Add(grade);
            }
            else
            {
                Console.WriteLine("invalid charecter {0}", grade);
            }


        }


        public Statistics GetStatistics()
        {
            var results = new Statistics
            {
                Average = 0.0,
                High = double.MinValue,
                Low = double.MaxValue,
        };  

            for(var i = 0; i < grades.Count; i++)
            {
                results.High = Math.Max(grades[i], results.High);
                results.Low = Math.Min(grades[i], results.Low);
                results.Average += grades[i];
            }
            results.Average /= grades.Count;
            return results;
            //Console.WriteLine("The Average of {0} is {1}", name , results);
        }


        private string name;
        private List<double>grades;
    }
}
