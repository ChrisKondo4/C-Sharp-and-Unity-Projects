using System;
using System.Collections.Generic;

namespace ArraysAssignment
{
    class Program
    {
        static void Main()
        {
            string[] stringArray = { "Hello, ", "my name is ", "whatever", "you decide!" };
            int[] intArray = { 4, 8, 16, 32 };
            List<string> stringList = new List<string>();
            stringList.Add("Hello, ");
            stringList.Add("my name is ");
            stringList.Add("whatever ");
            stringList.Add("you decide!");

            Console.WriteLine("Hello! Please select an index of 0-3.");
            byte index = Convert.ToByte(Console.ReadLine());
            Console.WriteLine(stringArray[index]);

            Console.WriteLine("Fantastic! Now please select a new index of 0-3.");
            index = Convert.ToByte(Console.ReadLine());

            if (index >= 0 && index <= 3)
            {
                Console.WriteLine(intArray[index]);
            }
            else
            {
                Console.WriteLine("That index doesn't exist.");
            }
            Console.WriteLine("Okay, now one last time: please select an index of 0-3.");
            index = Convert.ToByte(Console.ReadLine());
            Console.WriteLine(stringList[index]);
        }
    }
}
