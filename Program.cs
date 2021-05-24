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
            book.AddGrade(89.1);
            book.AddGrade(90.5);
            book.AddGrade(77.5);

            book.GetStatistics();


        }
    }
}
