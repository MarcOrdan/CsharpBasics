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
            book.showStatistics();
        }
    }
}
