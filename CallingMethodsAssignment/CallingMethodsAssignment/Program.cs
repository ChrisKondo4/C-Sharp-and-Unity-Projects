using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethodsAssignment
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Alright, now which number shall we start with?");
            int userInput1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What's the second number?");
            int userInput2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Which math operation would you like to perform: addition, subtraction, or multiplication?");
            string operation = Console.ReadLine();
            operation.ToLower();
            if (operation == "addition")
            {
                Console.WriteLine(Addition(userInput1, userInput2));
            }
            if (operation == "subtraction")
            {
                Console.WriteLine(Subtraction(userInput1, userInput2));
            }
            if (operation == "multiplication")
            {
                Console.WriteLine(Multiplication(userInput1, userInput2));
            }
        }

        static int Addition(int x, int y)
        {
            return x + y;
        }

        static int Subtraction(int x, int y)
        {
            return x - y;
        }

        static int Multiplication(int x, int y)
        {
            return x * y;
        }
    }
}
