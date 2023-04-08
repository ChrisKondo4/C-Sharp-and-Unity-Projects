using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Additin:");
            Console.WriteLine(addition(5));
            Console.WriteLine(addition(5.4m));
            Console.WriteLine(addition("five"));
        }

        static int addition(int x)
        {
            return x + 10;
        }

        static int addition(decimal x)
        {
            return Convert.ToInt32(x * 7.5m);
        }

        static int addition(string x)
        {
            return Convert.ToInt32(x);
        }
    }
}
