using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsAssignment
{
    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public static bool operator == (Employee Uno, Employee Dos)
        {
            return Uno == Dos;
        }

        public static bool operator != (Employee Uno, Employee Dos)
        {
            return Uno != Dos;
        }
    }
}
