using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodClassAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Methodology(9, 6);
            Methodology(y: 6, x: 9);
        }
        
        static void Methodology(int x, int y)
        {
            int l = x / 2;
            Console.WriteLine(y);
        }
    }
}
