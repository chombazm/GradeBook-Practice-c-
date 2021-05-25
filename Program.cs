using System;

namespace GradeBook
{
    class GradeBook
    {
        static void Main(string[] args)
        {
            //Introduce the app
            Console.WriteLine("Hello Sudo!");

            Book book = new Book("Rich Dad");
            
            while (true)
            {
                Console.WriteLine("Enter number or press q to quit");
                var input = Console.ReadLine();
                if (input == "q")
                {
                    break;
                }
                try
                {
                    var grade = double.Parse(input);
                    book.AddGrade(grade);
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    throw;
                }
            }

            var stats = book.GetStatistics();
            Console.WriteLine($"The Lowest grade is {stats.Low}");
            Console.WriteLine($"The Highest grade is {stats.High}");
            Console.WriteLine($"The Average grade is {stats.Average}");


        }
    }
}
