using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employees> currentEmployees = new List<Employees>();
            currentEmployees.Add(new Employees(0, "Joe", "Smith"));
            currentEmployees.Add(new Employees(1, "Harry", "Styles"));
            currentEmployees.Add(new Employees(2, "Richard", "Patten"));
            currentEmployees.Add(new Employees(3, "Mary", "Sother"));
            currentEmployees.Add(new Employees(4, "Bob", "Leamen"));
            currentEmployees.Add(new Employees(5, "Joe", "Marraro"));
            currentEmployees.Add(new Employees(6, "Pi'erre", "Bourne"));
            currentEmployees.Add(new Employees(7, "Sierra", "Mist"));
            currentEmployees.Add(new Employees(8, "Travis", "Scott"));
            currentEmployees.Add(new Employees(9, "Sarah", "Baker"));

            List<Employees> theJoes = new List<Employees>();

            foreach (Employees employee in currentEmployees)
            {
                if (employee.firstName == "Joe")
                {
                    theJoes.Add(employee);
                }
            }

            foreach (Employees employee in theJoes)
            {
                Console.WriteLine(employee.firstName + " " + employee.lastName + " ID " + employee.Id);
            }

            Console.WriteLine(". . .");

            List<Employees> joeLambda = currentEmployees.Where(x => x.firstName == "Joe").ToList();

            foreach (Employees employee in joeLambda)
            {
                Console.WriteLine(employee.firstName + " " + employee.lastName + " ID " + employee.Id);
            }

            Console.WriteLine(". . . ");

            List<Employees> numLambda = currentEmployees.Where(x => x.Id > 5).ToList();

            foreach (Employees employee in numLambda)
            {
                Console.WriteLine(employee.firstName + " " + employee.lastName + " ID " + employee.Id);
            }
        }
    }
}
