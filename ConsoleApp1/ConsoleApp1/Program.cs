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
            Console.WriteLine(Inting.Methoding(x));
            int a, b;
            Inting.Methoding(out a, out b);

            Console.WriteLine("Here's the second number you sent me: {0}", a);
            Console.WriteLine("And here's the third number you sent me!: {0}", b);
            Console.ReadLine();
        }
    }
}
