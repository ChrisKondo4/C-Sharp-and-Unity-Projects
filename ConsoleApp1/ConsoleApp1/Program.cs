using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, please give me a number!");
            int x = Convert.ToInt32(Console.ReadLine());
            New(x);
        }
        
        static void New(int x)
        {
            Console.WriteLine(x / 2);
        }

        static void New(string x)
        {
            Console.WriteLine(x + " is not an okay thing to say.");
        }
    }
}
