using System;
using System.Collections.Generic;

namespace TryCatchAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<int> integers = new List<int>();
                integers.Add(400);
                integers.Add(150);
                integers.Add(200);
                integers.Add(500);

                Console.WriteLine("Please choose a whole number");
                int dividedBy = Convert.ToInt32(Console.ReadLine());
                foreach (int index in integers)
                {
                    Console.WriteLine(index / dividedBy);
                }
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Don't enter 0");
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Enter a number, silly!");
            }
            finally
            {
                Console.WriteLine("Let's try that again, shall we?");
            }
        }
    }
}
