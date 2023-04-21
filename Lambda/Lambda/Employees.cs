using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda
{
    public class Employees
    {
        public int Id;
        public string firstName;
        public string lastName;

        public Employees(int v1, string v2, string v3)
        {
            this.Id = v1;
            this.firstName = v2;
            this.lastName = v3;
        }
    }
}
