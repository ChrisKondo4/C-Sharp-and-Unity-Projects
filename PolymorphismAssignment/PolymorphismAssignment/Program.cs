using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee student = new Employee
            {
                firstName = "Sample",
                lastName = "Student"
            };
            student.SayName();
        }
    }
}
