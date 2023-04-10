using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndObjectsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee ChrisK = new Employee();
            ChrisK.FirstName = "Joshu";
            ChrisK.LastName = "Kondo";
            ChrisK.SayName();
        }
    }
}
