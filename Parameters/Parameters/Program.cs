using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parameters
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee<string> Chris = new Employee<string>()
            {
                Things = new List<string> { "computer", "clothes", "phone" }
            };
            Employee<int> ChrisQuantity = new Employee<int>()
            {
                Things = new List<int> { 1, 5, 3, 9, 4, 8 }
            };
            foreach (string list in Chris.Things)
            {
                Console.WriteLine(list);
            }
            foreach (int list in ChrisQuantity.Things)
            {
                Console.WriteLine(list);
            }
            Console.ReadLine();
        }
    }
}
