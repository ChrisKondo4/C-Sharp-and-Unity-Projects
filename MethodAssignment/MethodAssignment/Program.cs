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
            Class1 ten = new Class1();

            Console.WriteLine("Hello, please enter a number. Or two. We're adding here, by the way.");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Any second number?");
            bool second = Convert.ToBoolean(Console.ReadLine());
            if (second == true)
            {
                Console.WriteLine("Name your second number");
                int y = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(ten.Addition(x, y));
            }
            else
            {
                Console.WriteLine(ten.Addition(x));
            }
        }
    }
}
