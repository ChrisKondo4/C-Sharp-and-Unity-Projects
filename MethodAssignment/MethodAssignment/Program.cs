using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! I see you wish to multiply. Simply input one or two numbers.");
            int z = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Would you like to input a second number? True/false");
            bool optional = Convert.ToBoolean(Console.ReadLine());
            if (optional == false)
            {
                Console.WriteLine(Multiply(z));
            }
            else
            {
                Console.WriteLine("What is your second number?");
                int w = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(Multiply(z, w));
            }
        }

        static int Multiply(int x, int y = 5)
        {
            return x * y;
        }
    }
}
