using System;

namespace MathAndComparisonOperatorsAssignment
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Anonymous Income Comparison Program\nPerson 1\nHourly Rate:");
            string HourlyRate1 = Console.ReadLine();
            Console.WriteLine("Hours worked per week:");
            string WeeklyHours1 = Console.ReadLine();
            Console.WriteLine("Person 2:\nHourly Rate:");
            string HourlyRate2 = Console.ReadLine();
            Convert.ToDouble(HourlyRate2);
            Console.WriteLine("Hours worked per week:");
            string WeeklyHours2 = Console.ReadLine();
            Convert.ToDouble(WeeklyHours2);
            decimal AnnSal1 = Convert.ToDecimal(HourlyRate1) * Convert.ToDecimal(WeeklyHours1) * 50.714m;
            Console.WriteLine("Annual salary of Person 1: " + AnnSal1);
            decimal AnnSal2 = Convert.ToDecimal(HourlyRate2) * Convert.ToDecimal(WeeklyHours2) * 50.714m;
            Console.WriteLine("Annual salary of Person 2: " + AnnSal2);
            Console.WriteLine("Does Person 1 make more money than Person 2?");
            bool comparison = AnnSal1 > AnnSal2;
            Console.WriteLine(comparison);
        }
    }
}
