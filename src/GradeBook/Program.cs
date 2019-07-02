using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {

            var book = new Book("Mac Book");
            book.AddGrade(1.5);

            var grades = new List<double>() {1.5, 3.5, 7.5, 4.5};
            grades.Add(2.5);

            var result = 0.0;
            foreach(var number in grades)
            {
                result += number;
            }

            result /= grades.Count;
            Console.WriteLine($"The average grade is: {result:N1}");


        }
    }
}
