using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {

            var book = new Book("Mac Book");
            book.AddGrade(50.5);
            book.AddGrade(23.55);
            book.AddGrade(7.7);
            book.GetStatistics();

            var stats = book.GetStatistics();
            Console.WriteLine($"The Book name is: {book.name}");
            Console.WriteLine($"The average grade is: {stats.Average:N1}");
            Console.WriteLine($"The highest grade is: {stats.High:N1}");
            Console.WriteLine($"The lowest grade is: {stats.Low:N1}");
        }
    }
}
