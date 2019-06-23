﻿using System;
using System.Collections.Generic;

namespace GradeBook
{    class Program
    {
        static void Main(string[] args)
        {
           var book = new Book("Jacob's Grade Book");
           book.AddGrade(89.1);
           book.AddGrade(90.5);
           book.AddGrade(77.5);
           book.GetStatistics();

           var stats = book.GetStatistics();
            Console.WriteLine($"The average grade is {stats.Average}. The highest grade is {stats.High}. The lowest grade is {stats.Low}.");   
        }
    }
}
