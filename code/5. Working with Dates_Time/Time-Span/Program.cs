﻿using System;

namespace Time_Span
{
    class Program
    {
        static void Main(string[] args)
        {

        //creating
        var timeSpan = new TimeSpan(1, 2, 3);

        var timeSpan1 = new TimeSpan(1, 0, 0);
        var timeSpan2 = TimeSpan.FromHours(1);   //point of parameter to be noted


        var start = DateTime.Now;
        var end = DateTime.Now.AddMinutes(2);
        var duration = end - start;
        Console.WriteLine("Duration: " + duration);

        //Properties

        //timeSpan.TotalHours

        Console.WriteLine("Minutes: " + timeSpan.Minutes);
        Console.WriteLine("Total Minutes: " + timeSpan.TotalMinutes);

        //Add

        Console.WriteLine("Add Example: " + timeSpan.Add(TimeSpan.FromMinutes(8)));
        Console.WriteLine("Subtract Example " + timeSpan.Subtract(TimeSpan.FromMinutes(2)));

        // To String

        Console.WriteLine("To String " + timeSpan.ToString());

        // Parse

        Console.WriteLine("parse " + TimeSpan.Parse("01:02:03"));

        

            
        }
    }
}

        
    

