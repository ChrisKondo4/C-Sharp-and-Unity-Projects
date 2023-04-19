using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParsingEnums
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter which day of the week it is!");
            try
            {
                string Input = Console.ReadLine();
                DaysOfTheWeek Today = (DaysOfTheWeek)Enum.Parse(typeof(DaysOfTheWeek.Day), Input);
                Console.WriteLine("Today is: " + Today);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("That is not a day of the week.");
            }
            finally
            {
                Console.WriteLine("Please enter which day of the week it is!");
            }
        }
    }
}
