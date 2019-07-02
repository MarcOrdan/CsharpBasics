using System;
using System.Collections.Generic;

namespace GradeBook
{
  class Book 
  {
    
    public Book(string name)
    {
      grades = new List<double>();
      this.name = name;
    }

    public void AddGrade(double grade)
    {
      grades.Add(grade);
    }

    public void showStatistics()
    {
            var result = 0.0;
            var highestGrade = double.MinValue;
            var lowestGrade = double.MaxValue;

            foreach(var number in grades)
            {
                highestGrade = Math.Max(number, highestGrade);
                lowestGrade = Math.Min(number, lowestGrade);
                result += number;
            }

            result /= grades.Count;
            Console.WriteLine($"The average grade is: {result:N1}");
            Console.WriteLine($"The highest grade is: {highestGrade:N1}");
            Console.WriteLine($"The lowest grade is: {lowestGrade:N1}");
    }

    private List<double> grades;
    private string name;
  }
    
}