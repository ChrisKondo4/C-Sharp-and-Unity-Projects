﻿using System;

namespace Student_Daily_Report
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("The Tech Academy.\nStudent Daily Report\nWhat is your name?");
            string yourName = Console.ReadLine();
            Console.WriteLine("What course are you on?");
            string course = Console.ReadLine();
            Console.WriteLine("What page number?");
            string page = Console.ReadLine();
            Convert.ToByte(page);
            Console.WriteLine("Do you need help with anything?");
            string help = Console.ReadLine();
            Convert.ToBoolean(help);
            Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics.");
            string experiences = Console.ReadLine();
            Console.WriteLine("Is there any other feedback you'd like to provide? Please be specific.");
            string feedback = Console.ReadLine();
            Console.WriteLine("How many hours did you study today?");
            string studyHours = Console.ReadLine();
            Convert.ToByte(studyHours);
            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");
        }
    }
}
