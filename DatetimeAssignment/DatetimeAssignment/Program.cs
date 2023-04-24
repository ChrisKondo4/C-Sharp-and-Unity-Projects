using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatetimeAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Current time: " + DateTime.Now);
            Console.WriteLine("Please enter a number!");
            double time = Convert.ToDouble(Console.ReadLine());
            DateTime converted = DateTime.Now;
            Console.WriteLine(converted.AddHours(time));
        }
    }
}