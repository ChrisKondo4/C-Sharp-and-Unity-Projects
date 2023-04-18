using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    static class Inting
    {
        public static int Methoding(int a)
        {
            return a / 2;
        }

        public static void Methoding(out int x, out int y)
        {
            Console.WriteLine("Enter another number:");
            x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter a THIRD number!:");
            y = Convert.ToInt32(Console.ReadLine());
        }
    }
}
