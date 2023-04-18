using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee Uno = new Employee
            {
                Id = 0,
                Name = "Jerry"
            };
            Employee Dos = new Employee
            {
                Id = 1,
                Name = "Harry"
            };
            Console.WriteLine(Uno == Dos);
        }
    }
}
